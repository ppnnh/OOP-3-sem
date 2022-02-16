﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Reflection;
using System.IO;
using System.Threading;

namespace Lab_OOP_15
{
    class Program
    {
        public static void ToWriteNum()
        {
            try
            {
                Console.WriteLine("Input n: ");
                int n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    using (StreamWriter sw = new StreamWriter("nums.txt", true))
                    {
                        sw.WriteLine(i);
                        Console.Write(i);
                        Thread.Sleep(100);
                    }
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void Main(string[] args)
        {
            try
            {
                // 1 
                using (StreamWriter sw = new StreamWriter("processes.txt"))
                {
                    Process[] allProcesses = Process.GetProcesses();    //получение всех процессов
                    foreach (Process p in allProcesses)          //при запуске приложения ОС создает для него процесс,
                    {                                           //которому выделяется определенное адр пр-во в памяти
                        sw.WriteLine("ID: " + p.Id);
                        sw.WriteLine("Process name: " + p.ProcessName);
                        sw.WriteLine("Priority: " + p.BasePriority);
                        sw.WriteLine("Responding: " + p.Responding);        //отвечает ли пользовательский интерфейс
                        sw.WriteLine("WorkingSet64: " + p.WorkingSet64);    //объем памяти
                        //sw.WriteLine("Start at: " + p.StartTime);             //отсутствие доступа
                        //sw.WriteLine("Total processor time: " + p.TotalProcessorTime);
                        sw.WriteLine();
                    }
                }

                // 2
                AppDomain domain = AppDomain.CurrentDomain;               //домен приложения - отдельный логический раздел внутри процесса
                Console.WriteLine("Current domain");
                Console.WriteLine("Name: " + domain.FriendlyName);
                Console.WriteLine("Configuration: " + domain.SetupInformation);
                Console.WriteLine("Directory: " + domain.BaseDirectory);
                Console.WriteLine("Assemblies of current domain:");
                Assembly[] assemblies = domain.GetAssemblies();
                foreach (Assembly a in assemblies)
                {
                    Console.WriteLine(a.GetName().Name);
                }
                //Создать новый домен
                AppDomain newDomain = AppDomain.CreateDomain("New domain");
                //Загрузить туда сборку
                newDomain.Load(new AssemblyName("Lab_OOP_15"));
                Console.WriteLine("Name of the new domain: " + newDomain.FriendlyName + "\nAssamblies of new domain:");
                foreach (Assembly a in newDomain.GetAssemblies())
                {
                    Console.WriteLine(a.GetName().Name);
                }
                //Выгрузить домен
                AppDomain.Unload(newDomain);
                Console.WriteLine("\nPress any key\n");
                Console.ReadKey();

                //3 
                Console.WriteLine("\nThreads");                         //поток - используемый внутри процесса путь выполнения
                Thread thread = new Thread(ToWriteNum);                 //процесс содержит мин один поток - главный
                thread.Start();                                         //из главного - вторичные
                thread.Name = "MyThread01";
                Thread.Sleep(1000);
                thread.Suspend();
                Console.WriteLine("Thread name: " + thread.Name);
                Thread.Sleep(100);
                Console.WriteLine("State: " + thread.ThreadState);
                Thread.Sleep(100);
                Console.WriteLine("Priority: " + thread.Priority);
                Thread.Sleep(1000);
                thread.Resume();
                Thread.Sleep(3000);

                Console.WriteLine("\n\nPress any key\n");
                Console.ReadKey();

                //4. 
                //i. выводились сначала четные, потом нечетные числа
                Console.WriteLine("Chet/Nechet");
                Console.WriteLine("Consistently:");
                TwoThreads.Consistently();
                Thread.Sleep(4000);
                Console.WriteLine("\nPress any key\n");
                Console.ReadKey();
                //ii. последовательно выводились одно четное, другое нечетное.
                Console.WriteLine("One by one:");
                TwoThreads.OneByOne();

                Thread.Sleep(7000);
                Console.WriteLine("\nPress any key\n");
                Console.ReadKey();

                //5

                TimerCallback tm = new TimerCallback(Count);    //метод обратного вызова
                //таймер - запускает опред действия по истечению некоторого периода времени
                Timer timer = new Timer(tm, null, 500, 1000); //метод, объект для передачи в метод, мс через кот таймер запускается, интервал между вызовами метода
                Thread.Sleep(5000);
                Console.WriteLine("Time is over...");
                timer.Dispose();
                Process music = Process.Start("song.mp3");
                Console.ReadKey();
                void Count(object obj)
                {
                    Console.WriteLine($"It's {DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
