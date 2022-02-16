using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab06
{
    public class Cactus : Plant
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public virtual string height
        {
            get { return ("Height of the cactus: " + Height); }
            set { Height = value; }
        }
        public virtual string mounthOfFlowering
        {
            get { return ("Mounth of flowering of the cactus" + MounthOfFlowering); }
            set { mounthOfFlowering = value; }
        }
        public override bool DoClone()
        {
            return false;
        }
        public Cactus(string _name, string _height, string _mounthOfFlowering)
        {
            Name = _name;
            Height = _height;
            MounthOfFlowering = _mounthOfFlowering;
        }
        public Cactus()
        { }
        public override string ToString()
        {
            {
                string rez = this.Name + this.Height + this.MounthOfFlowering;
                return rez;
            }
        }
    }
}
