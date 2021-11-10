/*Класс  множество Set. Дополнительно перегрузить 
следующие операции: -  удалить элемент из множества 
(типа set-item); *  пересечение множеств; <  сравнение 
множеств; >  проверка на подмножество; & придумайте 
использование.
Методы расширения:
1) Добавление точки в конце строки
2) Удаление нулевых элементов из множества*/
using System;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            MySet set1 = new MySet(1, "First Set");
            set1.AddItem("Lera");
            set1.AddItem("Kris");

            MySet set2 = new MySet(2, "Second Set");
            set2.AddItem("Lera");
            set2.AddItem(" ");
            set2.AddItem("Max");
            set2.AddItem("Kris");
            set2.AddItem("Pavel");

            MySet set3 = new MySet(3, "Third Set");
            set3.AddItem("Andrey");
            set3.AddItem("Egor");
            set3.AddItem("Max");
            set3.AddItem("Kris");


            MySet set4 = new MySet(4, "Fourth Set");
            set4.AddItem("Nika");
            set4.AddItem("");
            set4.AddItem("Egor");

            Console.WriteLine("--------- Перегрузка оператора - ---------"); //удалить элемент из множества
            string name = "Egor";
            set3 = set3 - name;
            set3.Show();
            Console.WriteLine("--------- Перегрузка оператора * ------------"); //пересечение множеств
            set2 = set2 * set1;
            set2.Show();

            Console.WriteLine("--------- Перегрузка оператора & ----------------"); //разница множеств
            set3 = set3 & set1;
            set3.Show();

            Console.WriteLine("--------- Перегрузка оператора > ----------------"); //проверка на подмножество
            Console.WriteLine(set1 > set2);

            Console.WriteLine("--------- Перегрузка оператора < ----------------"); //сравнение множеств
            Console.WriteLine(set1 < set2);

            Console.WriteLine("------------- Расширение Dif ----------------"); //разница меэжу макс и мин
            set3.Show();
            int e = set3.Max();
            Console.WriteLine(e);
            int y = set3.Min();
            Console.WriteLine(y);
            int r = set3.Dif();
            Console.WriteLine(r);

            Console.WriteLine("---------------------------------------------");

            string abc = "awdg fseol  ajes";
            Console.WriteLine($"{abc}\tКоличество слов: {abc.CountOfWords()}");
            Console.WriteLine("---------------------------------------------");

            int r2 = set3.Sum();
            set3.Show();
            Console.WriteLine($"Количество букв слов: {r2}");
            Console.WriteLine("---------------------------------------------");
            set4.Show();
            Console.WriteLine("------------------ Удаление нулевых элементов из множества---------------------------");
            set4.RemoveSpace();
            set4.Show();
            Console.WriteLine("--------------------Добавление точки в конце строки-------------------------");
            set4.DotAtTheEnd();
            set4.Show();
        }
    }
}
