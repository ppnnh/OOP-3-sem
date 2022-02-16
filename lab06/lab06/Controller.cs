using System;
using System.Collections.Generic;
using System.Text;

namespace lab06
{
    class Controller
    {
        public void Sort(Container ct) //Провести сортировку цветов в букете на основе любого параметра
        {
            ct.list.Sort();
        }

        public void Search(Container ct, string color) //Найти цветок в букете, соответствующий заданному цвету.
        {
            foreach (Flower item in ct.list)
            {
                if (item.Colour == color) Console.WriteLine(item.ToString());
            }
        }
        public void Sum(Container ct)
        {
            int sum = 0;

            foreach (object item in ct.list)
            {
                if (item.GetType().BaseType.Name == "Flower" )
                {
                    sum++;
                }
            }

            Console.WriteLine($"Количество элементов в букете = {sum}");
        }

        public void TotalCost(Container ct)
        {
            double sum = 0;

            foreach (object item in ct.list)
            {
                if (item.GetType().BaseType.Name == "Flower")
                {
                    sum += ((Flower)item).Cost;
                }
            }

            Console.WriteLine($"Стоимость букета: = {sum}");
        }
    }
}
