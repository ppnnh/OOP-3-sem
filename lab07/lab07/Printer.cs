using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab07
{
    public class Printer
    {
        public string IAmPrinting(Plant someobj)
        {
            return someobj.ToString();
        }
        public string IAmPrinting(Bush someobj)
        {
            return someobj.ToString();
        }
        public string IAmPrinting(Cactus someobj)
        {
            return someobj.ToString();
        }
    }
}
