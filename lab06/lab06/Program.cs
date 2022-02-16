/*Растение, Куст, Цветок, Роза, Гладиолус, Кактус, Бумага, Букет*/
using System;
using System.Collections.Generic;

namespace lab06
{
    class Program
    {
        static void Main(string[] args)
        {
            Rose rose1 = new Rose(45, 3, "red");
            Gladiolus glad1 = new Gladiolus(35, 2, "yellow");
            Gladiolus glad2 = new Gladiolus(325, 2, "yellow");
            List<object> bouquet1 = new List<object> { glad2, rose1, glad1 };
            Container container = new Container();
            container.mainList = bouquet1;

            container.PrintElems();
            Rose rose2 = new Rose(56, 2, "pink");
            container.Add(rose2);
            container.Remove(2);
            Console.WriteLine("------------------------------------");
            container.PrintElems();

            Console.WriteLine("------------------------------------");
            Controller cntrl = new Controller();
            cntrl.Sort(container);
            container.PrintElems();
            Console.WriteLine("------------------------------------");
            cntrl.Search(container, "red");
            cntrl.Sum(container);
            cntrl.TotalCost(container);
        }
    }
}

