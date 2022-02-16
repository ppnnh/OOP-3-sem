using System;
using System.Collections.Generic;
using System.Text;

namespace lab07
{
    class BException : Exception
    {
        public new string Message;

        public BException(string message, string cost) : base(message)
        {
            Message = $"BouquetException({cost}): " + message;
        }
    }
    class FException : Exception
    {
        public new string Message;

        public FException(string message, string f) : base(message)
        {
            Message = $"FlowerException({f}): " + message;
        }
    }

}
