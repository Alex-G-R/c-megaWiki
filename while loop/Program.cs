using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_14___While_Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            int index = 1;

            while( index <= 5)
            {
                Console.WriteLine(index);
                index++;
            }



            int index2 = 7;
            // najpierw robi potem sprawdza czy sie zgadza z warunkiem w while
            do
            {
                Console.WriteLine(index2);
                index2++;
            } while (index2 <= 5);


            Console.ReadLine();
        }


    }
}
