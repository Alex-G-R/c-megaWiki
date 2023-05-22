using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11___More_If_statements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pierwszą liczbe: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Podaj drugą liczbe: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Higher(num1, num2);

            Console.ReadLine();
        }

        static void Higher(int num11, int num22)
        {
            if (num11 > num22)
            {
                Console.WriteLine($"{num11} Jest większą liczbą od {num22}");
            }
            else if (num11 < num22)
            {
                Console.WriteLine($"{num22} Jest większą liczbą od {num11}");
            }
            else if (num11 == num22)
            {
                Console.WriteLine($"{num22} == {num11}");
            }

        }
    }
}
