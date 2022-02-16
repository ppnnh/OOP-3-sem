using System;
using System.Collections.Generic;
using System.Text;

namespace Лаба_12
{
    class Test : IShow
    {
        public string name;

        public Test() { }

        public Test(string name)
        {
            this.name = name;
        }

        public void Show()
        {
            Console.WriteLine(name);
        }

        public void Toconsole(List<string> vs)
        {
            foreach (string str in vs)
            {
                Console.WriteLine(str);
            }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public override string ToString()
        {
            return "My name - " + name;
        }
    }
}
