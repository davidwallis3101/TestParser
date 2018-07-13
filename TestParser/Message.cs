using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestParser
{
    public class Message
    {
        public int NodeId { get; set; }

        public int ChildSensorId { get; set; }

        public Command Command { get; set; }

        public string Ack { get; set; }

        public string Type { get; set; }

        public string Payload { get; set; }
    }
}
