using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        class Drink
        {
            public string Name;
            public double litr;

            public void Print()
            {
                Console.WriteLine("Название: " + Name);
                Console.WriteLine("Объём в литрах: " +  litr);
            }
            public void WriteToFile(StreamWriter sw)
            {
                sw.WriteLine("Название: " + Name);
                sw.WriteLine("Объём в литрах: " + litr);
                sw.WriteLine();
            }
        }

        class DrinkComparer : IComparer<Drink> //  сортировка по алфавиту
        {
            public int Compare(Drink x, Drink y)
            {
                return string.Compare(x.Name, y.Name, StringComparison.Ordinal);
            }
        }
        static void Main(string[] args)
        {
            w1:
            Console.Write("Введите количество напитков, которые хотите записать: ");
            int size = int.Parse(Console.ReadLine());
            if(size <= 0)
            {
                Console.WriteLine("Вы ввели некорректное число, попробуйте ещё раз");
                goto w1;
            }

            Drink[] drinks = new Drink[size];
            for (int i = 0; i < size;  i++)
            {
                drinks[i] = new Drink();
                Console.Write("Введите название " + (i+1) + " напитка: ");
                drinks[i].Name = Console.ReadLine();
                Console.Write("Введите объём в литрах: ");
                drinks[i].litr = double.Parse(Console.ReadLine());
                Console.WriteLine();

            }

            // Сортировка списка напитков по алфавиту
            Array.Sort(drinks, new DrinkComparer());

            // Вывод отсортированных напитков
            foreach (var drink in drinks)
            {
                drink.Print();
            }

            using (StreamWriter sw = new StreamWriter("drinks.txt")) // запись в файл
            {
                foreach (var drink in drinks)
                {
                    drink.WriteToFile(sw);
                }
            }

        }
    }
}
