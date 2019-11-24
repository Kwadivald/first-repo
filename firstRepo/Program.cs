using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstRepo
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Dodaj liczby");
                Console.WriteLine("2. Odejmij liczby");
                Console.WriteLine("3. Pomnóż liczby");
                Console.WriteLine("4. Dziel liczby");
                Console.WriteLine("5. Wyjście");
                int menuOption = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
