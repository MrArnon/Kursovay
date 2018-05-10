using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrodcastAlgorithm
{
    public class MessageArgs: EventArgs
    {
        public String Message { get; }

        public MessageArgs(String message)
        {
            Message = message;
        }
    }
}
