using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
    static void checkVvod(double num)
        {
            string input;
            Console.WriteLine("Введите число:");
            input = Console.ReadLine();
            while (!double.TryParse(input, out num))
            {
                Console.WriteLine("Вы ввели что-то неправильное. Пожалуйста, введите число:");
                input = Console.ReadLine();
            }
        }

    static void Main(string[] args)
        {
            int num = 0;
            Console.WriteLine("Введите номер операции: ");
            Console.WriteLine("1 - Сложение\n2 - Вычитание\n3 - Произведение\n4 - Деление\n5 - Завершить программу");
            w1:
            num = int.Parse(Console.ReadLine());
            if(num < 1 || num > 5)
            {
                Console.WriteLine("Вы ввели некорректное число, попробуйте ещё раз: ");
                goto w1;
            }
            switch (num)
            {
                case 1:

                    return;
                case 2:

                    return;
                case 3:

                    return;
                case 4:

                    return;
                case 5:
                    Console.WriteLine("Вы завершили программу");
                    return;
            }

        }
    }
}
