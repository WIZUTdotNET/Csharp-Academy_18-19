using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulatorV1
{
    class Program
    {

        static void Main(string[] args)
        {
            int a;
            int b;
            int c;

            Console.WriteLine("Podaj dwie liczby");
            a = Int32.Parse(Console.ReadLine());
            b = Int32.Parse(Console.ReadLine());

            Console.WriteLine("1. Dodawanie");
            Console.WriteLine("2. Odejmowanie");
            Console.WriteLine("3. Mnożenie");
            Console.WriteLine("4. Dzielenie");
            Console.WriteLine("5. Modulo");

            c = Int32.Parse(Console.ReadLine());

            switch (c)
            {
                case 1:
                    Console.WriteLine($"{a} + {b} = {a + b}");
                    break;
                case 2:
                    Console.WriteLine($"{a} - {b} = {a - b}");
                    break;
                case 3:
                    Console.WriteLine($"{a} * {b} = {a * b}");
                    break;
                case 4:

                    if (b == 0)
                    {
                        Console.WriteLine("Nie można dzielić przez 0!");
                    }
                    else
                    {
                        Console.WriteLine($"{a} / {b} = {a / b}");
                    }
                    break;
                case 5:
                    if (b == 0)
                    {
                        Console.WriteLine("Nie można dzielić przez 0!");
                    }
                    else
                    {
                        Console.WriteLine($"{a} modulo {b} = {a % b}");
                    }
                    break;
                default:
                    Console.WriteLine("Nie ma takiej opcji");
                    break;
            }
            System.Console.ReadKey();
        }
    }
}