using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab07
{
    public class Flower : Bouqeut
    {
        private string colour;
        public string Colour
        {
            get { return colour; }
            set { colour = value; }
        }
        private int number;
        public virtual int Number
        {
            get { return number; }
            set
            {
                if (value <= 0) throw new FException("неверное количество цветов в букете", GetType().FullName);
                number = value;
            }
        }
        public Flower(int _cost, int _number, string _colour)
        {
            Cost = _cost;
            Number = _number;
            Colour = _colour;
            if (Colour.Length == 0) throw new FException("цвет не может состоять из 0 символов", GetType().Name);
            this.Colour = Colour;

        }
        public Flower()
        {
        }
    }
}
