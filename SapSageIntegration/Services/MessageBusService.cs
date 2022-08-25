using System.Threading.Tasks;

namespace SapSageIntegration.Services
{
    public class MessageBusService
    {
        public Task AddMessageToQueueAsync(MessageType type, object data)
        {
            var messageToSend = new { type = type, data = data };
            return Task.CompletedTask;
        }
    }
}
