using Azure.Messaging.ServiceBus;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace SapSageIntegration.Services.Message
{
    public static class MessageBusHelper  
    {  
        public static string SerializeMessage(MessageDto message)
        {
            var messageToSend = JsonSerializer.Serialize(message);
            return messageToSend;
        }

        public static MessageDto DeserializeMessage(string message)
        {
            var messageDto = JsonSerializer.Deserialize<MessageDto>(message);
            return messageDto;
        } 
    }
}
