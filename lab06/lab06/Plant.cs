/*Растение, Куст, Цветок, Роза, Гладиолус, Кактус, Бумага, Букет*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//растение: куст, кактус
//plant: bush, cactus
namespace lab06
{
    public  abstract partial class Plant
    {

        private string height;
        public virtual string Height
        {
            get { return height; }
            set { height = value; }
        }

        private string mounthOfFlowering;
        public virtual string MounthOfFlowering
        {
            get { return mounthOfFlowering; }
            set { mounthOfFlowering = value; }
        }
        public abstract bool DoClone();
        public Plant(string _height, string _mounthOfFlowering)
        {
            height = _height;
            mounthOfFlowering = _mounthOfFlowering;
        }

        public Plant(string _height)
        {
            height = _height;
            mounthOfFlowering = null;
        }
        public Plant()
        {
            height = null;
            mounthOfFlowering = null;
        }
    }
}