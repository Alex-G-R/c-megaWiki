using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_17___Exponent_Function___Method
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(GetPow(3,3));

            Console.ReadLine();
        }

        static int GetPow(int baseNum, int powNum)
        {
            int result = 1;
            // result = Math.Pow(baseNum,powNum)
            for (int i = 0; i < powNum; i++)
            {
                result = result * baseNum;
            }

            return result;
        }
    }
}
