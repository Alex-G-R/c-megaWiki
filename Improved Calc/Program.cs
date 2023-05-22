using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_12___Improved_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Podaj liczbę: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Podak operator: ");
            string op = Console.ReadLine();

            Console.WriteLine("Podaj liczbę: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (op == "+")
            {
                Console.WriteLine(num1 + num2);
            }

            else if (op == "-")
            {
                Console.WriteLine(num1 - num2);
            }

            else if (op == "/")
            {
                Console.WriteLine(num1 / num2);
            }

            else if (op == "*")
            {
                Console.WriteLine(num1 * num2);
            }
            
            else
            {
                Console.WriteLine("Taki operator nie istnieje, pozdrawiam z rodzinką");
            }


            Console.ReadLine();
        }
    }
}
