using Azure.Messaging.ServiceBus;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace SapSageIntegration.Services.Message
{
    public class MessageBusService: IAsyncDisposable
    {
        private ILogger logger;

        // connection string to your Service Bus namespace
        private string connectionString = "<NAMESPACE CONNECTION STRING>";

        // name of your Service Bus queue
        private string queueName = "<QUEUE NAME>";

        // the client that owns the connection and can be used to create senders and receivers
        private ServiceBusClient client;

        // the sender used to publish messages to the queue
        private ServiceBusSender sender;

        public MessageBusService(string connectionString, string queueName)
        {
            this.connectionString = connectionString;
            this.queueName = queueName;

            // The Service Bus client types are safe to cache and use as a singleton for the lifetime
            // of the application, which is best practice when messages are being published or read
            // regularly.
            //
            // set the transport type to AmqpWebSockets so that the ServiceBusClient uses the port 443. 
            // If you use the default AmqpTcp, you will need to make sure that the ports 5671 and 5672 are open
            var clientOptions = new ServiceBusClientOptions() { TransportType = ServiceBusTransportType.AmqpWebSockets };
            this.client = new ServiceBusClient(connectionString, clientOptions);
            this.sender = client.CreateSender(queueName);
        }

        public async Task SendMessageToQueueAsync(MessageDto message, CancellationToken cancellationToken = default)
        {
            var messageText = SerializeMessage(message);
            var serviceBusMessage = new ServiceBusMessage(messageText);

            // Use the producer client to send the batch of messages to the Service Bus queue
            await sender.SendMessageAsync(serviceBusMessage, cancellationToken);
            // logger.LogInformation($"A {message.Type} message has been published to the queue.");
        }

        public async Task SendMulptipleMessageToQueueAsync(List<MessageDto> messages, CancellationToken cancellationToken = default)
        {
            // create a batch 
            using ServiceBusMessageBatch messageBatch = await sender.CreateMessageBatchAsync();

            foreach (var message in messages)
            {
                var messageText = SerializeMessage(message);

                // try adding a message to the batch
                if (!messageBatch.TryAddMessage(new ServiceBusMessage(messageText)))
                {
                    // if it is too large for the batch
                    throw new Exception($"The message {message.Type} is too large to fit in the batch.");
                }
            }
            // Use the producer client to send the batch of messages to the Service Bus queue
            await sender.SendMessagesAsync(messageBatch, cancellationToken);
            //   logger.LogInformation($"A batch of {messages.Count} messages has been published to the queue.");

        }

        public string SerializeMessage(MessageDto message)
        {
            var messageToSend = JsonSerializer.Serialize(message);
            return messageToSend;
        }

        public MessageDto DeserializeMessage(string message)
        {
            var messageDto = JsonSerializer.Deserialize<MessageDto>(message);
            return messageDto;
        }

        async ValueTask IAsyncDisposable.DisposeAsync()
        {
            // Calling DisposeAsync on client types is required to ensure that network
            // resources and other unmanaged objects are properly cleaned up.
            await sender.DisposeAsync();
            await client.DisposeAsync();
        }
    }
}
