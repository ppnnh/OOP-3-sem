using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace lab10
{
    class Woker
    {
        public string name;

        public Woker(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return base.ToString() + $", имя: {name}.";
        }
    }
}
