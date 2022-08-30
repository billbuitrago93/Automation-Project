using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapSageIntegration.Services.Message
{
    public class MessageDto
    {
        public MessageDto()
        {
        }

        public MessageDto(MessageType type, dynamic value)
        {
            this.Type = type;
            this.Value = value;
        }

        public MessageType Type { get; set; }

        public dynamic Value { get; set; }

        public int ResendCount { get; set; } = 0;
    }
}
