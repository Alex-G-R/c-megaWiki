using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_9___Return_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbe ktora przemnozemy do szescianu: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Cube(num));


            Console.ReadLine();
        }

        static int Cube(int num)
        {
            int result = num * num * num;

            return result;
        }
    }
}
