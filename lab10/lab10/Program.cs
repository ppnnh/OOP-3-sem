using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            { // 1
                ControlClass<Woker> collection = new ControlClass<Woker>();
                Woker w1 = new Woker("Vasya");
                Woker w2 = new Woker("Kolya");
                Woker w3 = new Woker("Petya");

                collection.Add(0, w1);
                collection.Add(0, w2);
                collection.Add(0, w3);
                collection.Print();
                Console.WriteLine("-----------------------------");
                collection.Remove(w2);
                collection.Print();
                Console.WriteLine($"Элемент {w1.name} содержится в collection: {collection.Contains(w1)}");
                Console.WriteLine($"Элемент {w2.name} содержится в collection: {collection.Contains(w2)}");
            }

            { // 2
                ControlClass<int> collection2 = new ControlClass<int>();
                collection2.Add(0, 2);
                collection2.Add(0, 6);
                collection2.Add(0, 11);
                collection2.Add(0, 1);
                collection2.Add(0, 121);
                collection2.Print();

                Console.Write("Введите n: ");
                string str;
                str = Console.ReadLine();
                int n = Convert.ToInt32(str);
                while (n > 0)
                {
                    collection2.RemoveAt(--n);
                }
                Console.WriteLine("------------------------------------");
                collection2.Print();

                int[] arr = { 1, 2, 3 };

                Console.WriteLine("------------------------------------");
                collection2.Print();

                LinkedList<int> link = new LinkedList<int>();

                for (int i = 0; i < collection2.Count; i++)
                {
                    link.AddLast(collection2.Value(i));
                }

                int a = 121;

                foreach (int item in link)
                {
                    if (item == a)
                    {
                        Console.WriteLine("Элемент найден");
                    }
                }

                var collection3 = new ObservableCollection<Woker>();
                Woker w1 = new Woker("Буратино");

                collection3.CollectionChanged += CollectionChanged;
                collection3.Add(w1);
                collection3.Remove(w1);
            }
        }

        private static void CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    Console.WriteLine($"Добавлен новый объект");
                    break;

                case NotifyCollectionChangedAction.Remove:
                    Console.WriteLine($"Удален объект");
                    break;
            }
        }
    }
}
