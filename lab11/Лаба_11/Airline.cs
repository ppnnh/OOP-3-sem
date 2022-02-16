using System;
using System.Collections.Generic;
using System.Text;

namespace Лаба_11
{
    class Airline
    {
        public string destination { get; set; }                         // пункт назначения
        public int flightNum { get; set; }
        public string planeType { get; set; }
        public int time;
        public int Time
        {
            set
            {
                if (value >= 2400)
                {
                    Console.WriteLine("Время введено некорректно");
                }
                else
                {
                    time = value;
                }
            }

            get { return time; }
        }
        public string[] days { get; set; }
        private readonly int hashCode;
        public const int someValue = 10;
        private static int NumberOfObjects = 0;

        public Airline()
        {
            destination = "Москва";
            flightNum = 1;
            days = new string[] { "Понедельник" };
            planeType = "Airbus";
            time = 1200;
            NumberOfObjects++;
            hashCode = NumberOfObjects * 183012 / 1039;
        }

        public Airline(string dest, int fliNum, string plTp)
        {
            destination = dest;
            flightNum = fliNum;
            planeType = plTp;
            NumberOfObjects++;
            hashCode = NumberOfObjects * 183012 / 1039;
        }

        public Airline(string dest, int fliNum, string plTp, string[] d, int tm = 1300)
        {
            destination = dest;
            flightNum = fliNum;
            planeType = plTp;
            time = tm;
            days = d;
            NumberOfObjects++;
            hashCode = NumberOfObjects * 183012 / 1039;
        }

        static Airline()  //статический конструктор
        {
            Console.WriteLine("Создан первый объект класса");
        }

        /*  private Airline()
          {

          }*/

        public void ChangeVariable(ref int a, out int b)
        {
            b = a;
            a = 111;
        }

        public static void Info()
        {
            Console.WriteLine($"Создано {NumberOfObjects} объектов класса");
        }

        public void printHashCode()
        {
            Console.WriteLine($"Hashcode: {hashCode}");
        }

        public override string ToString()
        {
            string result = $"Место следования: {destination}, номер рейса: {flightNum}, модель: {planeType}, время: {time}, дни следования: "; ;
            foreach (var item in days)
            {
                result += item + " ";
            }
            return result;
        }
    }
}
