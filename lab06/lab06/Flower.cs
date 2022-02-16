using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab06
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
            set { number = value; }
        }
        public Flower(int _cost, int _number, string _colour)
        {
            Cost = _cost;
            Number = _number;
            Colour = _colour;

        }
        public Flower()
        {
        }
    }
}
