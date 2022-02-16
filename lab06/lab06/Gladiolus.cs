using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab06
{
    public class Gladiolus : Flower
    {
        public Gladiolus(int _cost, int _number, string _colour)
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
