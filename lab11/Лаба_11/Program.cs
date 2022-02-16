using System;
using System.Collections.Generic;
using System.Linq;

namespace Лаба_11
{
    class Program
    {
        static void Main(string[] args)
        {
            { // 1
                string[] months = {"January", "February", "March", "April", "May", "June",
                "July", "August", "September", "October", "November", "December", };

                int n = 4;
                var SelectedMonths1 = from t in months
                                      where t.Length == n
                                      select t;

                var SelectedMonths2 = from t in months
                                      where Equals(t, "December") || Equals(t, "January") || Equals(t, "February")
                                            || Equals(t, "June") || Equals(t, "July") || Equals(t, "August")
                                      select t;

                var SelectedMonths3 = from t in months
                                      orderby t
                                      select t;

                var SelectedMonths4 = from t in months
                                      where t.Contains("u")
                                      where t.Length >= 4
                                      select t;

                foreach (var item in SelectedMonths1)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("-------------------------------------");
                foreach (var item in SelectedMonths2)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("-------------------------------------");
                foreach (var item in SelectedMonths3)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("-------------------------------------");
                foreach (var item in SelectedMonths4)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("-------------------------------------");
            }

            { // 2, 3
                string[] arr1 = new string[] { "Понедельник", "Среда", "Четверг" };
                string[] arr2 = new string[] { "Вторник", "Среда", "Четверг" };
                string[] arr3 = new string[] { "Суббота", "Воскресенье" };
                string[] arr4 = new string[] { "Пятница", "Воскресенье", "Понедельник"};
                Airline a1 = new Airline("Гродно", 666, "Boieng", arr1, 1200);
                Airline a2 = new Airline("Минск", 999, "Airbus", arr2, 1130);
                Airline a3 = new Airline("Москва", 333, "Су-25", arr3, 1800);
                Airline a4 = new Airline("Лондон", 111, "Ил-38", arr4, 1900);
                Airline a5 = new Airline("Нью-Йорк", 777, "Boieng", arr1, 2300);
                Airline a6 = new Airline("Пекин", 222, "Су-25", arr2, 1000);
                Airline a7 = new Airline("Гродно", 444, "Ил-38", arr3, 1250);
                Airline a8 = new Airline("Минск", 555, "Airbus", arr4, 0940);
                Airline a9 = new Airline("Лондон", 888, "Boieng", arr3, 2135);
                Airline a10 = new Airline("Пекин", 101, "Су-25", arr2, 2000);
                List<Airline> clA = new List<Airline>();
                clA.Add(a1);
                clA.Add(a2);
                clA.Add(a3);
                clA.Add(a4);
                clA.Add(a5);
                clA.Add(a6);
                clA.Add(a7);
                clA.Add(a8);
                clA.Add(a9);
                clA.Add(a10);

                string destination = "Гродно";
                var SelectedAirline1 = clA
                    .Where(n => Equals(n.destination, destination))
                    .Select(n => n);

                string mon = "Понедельник";
                var SelectedAirline2 = clA
                    .Where(n => n.days.Contains(mon))
                    .Select(n => n)
                    .Count();

                var SelectedAirline3 = clA
                   .Where(n => n.days.Contains(mon))
                   .OrderBy(n => n.time)
                   .First();

                string wed = "Среда";
                string fri = "Пятница";
                var SelectedAirline4 = clA
                   .Where(n => n.days.Contains(wed) || n.days.Contains(fri))
                   .OrderBy(n => n.time)
                   .Last();

                var SelectedAirline5 = clA
                   .OrderBy(n => n.time)
                   .Select(n => n);

                foreach (var item in SelectedAirline1)
                {
                    Console.WriteLine(item.ToString());
                }
                Console.WriteLine("-------------------------------------");
                Console.WriteLine($"Кол-во рейсов для {mon}: {SelectedAirline2}");
                Console.WriteLine($"Рейс в {mon} раньше всех: {SelectedAirline3}");
                Console.WriteLine($"Рейс в {wed} или {fri} позже всех: {SelectedAirline4}");
                Console.WriteLine("-------------------------------------");
                foreach (var item in SelectedAirline5)
                {
                    Console.WriteLine(item.ToString());
                }
                Console.WriteLine("-------------------------------------");

                { //4
                    var SelectedAirline = clA
                        .GroupBy(n => n.planeType)
                        .Select(
                        n => new 
                        { 
                            Name = n.Key, 
                            Count = n.Count() 
                        })
                        .Where(n => n.Count < 5)
                        .OrderBy(n => n.Name)
                        .Take(3);

                    foreach (var item in SelectedAirline)
                    {
                        Console.WriteLine(item.ToString());
                    }
                    Console.WriteLine("-------------------------------------");
                }

                { //5
                    int[] key = { 1, 5, 6, 8 };
                    var SelectedAirline = clA
                    .Join(
                    key,
                    n => n.planeType.Length,
                    t => t,
                    (n, t) => new
                    {
                        PlaneType = n.planeType,
                        key = string.Format($"{t}")
                    });

                    foreach (var item in SelectedAirline)
                    {
                        Console.WriteLine(item.ToString());
                    }
                }
            }

        }
    }
}
