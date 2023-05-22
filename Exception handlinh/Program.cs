using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_19___Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter a number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Bomba");
            }
            catch (Exception a)
            { 
                Console.WriteLine(a.Message);
            }

            Console.ReadLine();
        }
    }   
    
}
