using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        class Soda
        {
            public void show_my_drink(string ing)
            {
                if( ing == null || ing == "" )
                {
                    Console.WriteLine("Обычная газировка");
                }
                else
                {
                    Console.WriteLine($"Газировка + {ing}");
                }
            }
        }
        static void Main(string[] args)
        {
            Soda drink1 = new Soda();
            Soda drink2 = new Soda();
            Soda drink3 = new Soda();
            drink1.show_my_drink("Малина");
            drink2.show_my_drink("");
            drink3.show_my_drink(null);
        }
    }
}
