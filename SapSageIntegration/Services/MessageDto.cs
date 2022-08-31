using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapSageIntegration.Services
{
    public class MessageDto
    {
        public MessageDto()
        {
        }

        public MessageDto(MessageType type, string value)
        {
            Type = type;
            Value = value;
        }

        public MessageType Type { get; set; }

        public string Value { get; set; }

        public int ResendCount { get; set; } = 0;

        public string ResendDesc { get; set; }
    }
}
