using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_18___2d_Array
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] numberGrid =
            {
                {1, 2, 3 },
                {4, 5, 6 },
                {7, 8, 9 }
            };
            // row 0 column 2
            Console.WriteLine(numberGrid[0,2]);

            Console.ReadLine();
        }
    }
}
