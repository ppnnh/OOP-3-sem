using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab06
{
    //букет: бумага, цветок: роза, гладиолус 
    //bouquet: paper, flower: rose, gladiolus
    public class Bouqeut : IComparable
    {
        private int cost;
        public int Cost
        {
            get { return cost; }
            set { cost = value; }
        }
        public Bouqeut(int _cost)
        {
            cost = _cost;
        }
        public Bouqeut()
        { }
        public enum Flowers
        {
            rose,
            chamomile,
            chrysanthemum
        }
        public Flowers flowers;
        struct bouqeut
        {
            public string name;
            public int cost;

            public void Print()
            {
                Console.WriteLine($"Цветы: {name}   Стоимость: {cost}");
            }
        }

        public int CompareTo(object obj)
        {
            Bouqeut bk2 = (Bouqeut)obj;
            if (cost > bk2.cost) return 1;
            if (cost < bk2.cost) return -1;
            return 0;
        }
    }
}
