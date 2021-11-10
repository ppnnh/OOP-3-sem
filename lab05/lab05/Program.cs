/*Растение, Куст, Цветок, Роза, Гладиолус, Кактус, Бумага, Букет*/
using System;
using System.Collections.Generic;

namespace lab05
{
    class Program
    {
        static void Main(string[] args)
        {
            Bush bush1 = new Bush(1, "Forsythia", "1m", "April-May");
            Console.WriteLine(bush1.Name);
            Cactus cactus1 = new Cactus("Astrophytum", "15sm", "March");
            Console.WriteLine(cactus1.Name + ", " + cactus1.MounthOfFlowering);
            Cactus cactus2 = new Cactus();

            Flower flower1 = new Flower(30, 3);
            Rose rose1 = new Rose(30, 3, "Shrubby");
            flower1 = rose1 as Flower;
            if (rose1 is Flower)
            {
                Console.WriteLine("GetIn");
            }

            List<Plant> list = new List<Plant> { new Bush(2, ", Mahonia, ", "0.7m, ", "June"), new Cactus("Mammillaria Luti, ", "15sm, ", "July") };
            Printer printer = new Printer();
            foreach( Plant v in list)
            {
                Console.WriteLine(printer.IAmPrinting(v));
            }
        }
    }
}
