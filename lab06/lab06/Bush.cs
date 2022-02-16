using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab06
{
    public class Bush : Plant
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public virtual string height
        {
            get { return ("Height of the bush: " + Height); }
            set { Height = value; }
        }
        public virtual string mounthOfFlowering
        {
            get { return ("Mounth of flowering of the bush" + MounthOfFlowering); }
            set { mounthOfFlowering = value; }
        }
        public override bool DoClone()
        {
            return false;
        }
        public Bush(int _id, string _name, string _height, string _mounthOfFlowering)
        {
            Id = _id;
            Name = _name;
            Height = _height;
            MounthOfFlowering = _mounthOfFlowering;
        }
        public Bush()
        { }
        public override string ToString()
        {
            {
                string rez = this.Id + this.Name + this.Height + this.MounthOfFlowering;
                return rez;
            }
        }
    }
}
