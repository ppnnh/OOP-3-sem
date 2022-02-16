using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab06
{
    public class Rose : Flower
    {
        public Rose(int _cost, int _number, string _colour)
        {
            Cost = _cost;
            Number = _number;
            Colour = _colour;
        }
        public override string ToString()
        {
            return $"Тип объекта: {base.ToString()}, стоимость: {Cost}, количество: {Number}, цвет: {Colour}";
        }
    }
}
