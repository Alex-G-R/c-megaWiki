using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10___If_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isMale = true;
            bool isTall = false;
            //         and
            if (isMale && isTall)
            {
                Console.WriteLine("Tak jesteś mężczyzną i jesteś wysoki");
            }//     ! robi że nie - jest mężczyna i NIE jest wysoki
            else if (isMale && !isTall)
            {
                Console.WriteLine("Jesteś mężczyną i nie jesteś wysoki");
            }
            else if (!isMale && isTall)
            {
                Console.WriteLine("Jesteś wysoką kobietą");
            }
            else
            {
                Console.WriteLine("Albo nie jesteś mężczyzną albo nie jesteś wysoki albo oba");
            }//        or
            if (isMale || isTall)
            {
                Console.WriteLine("Jesteś albo mężczyzną albo wysoki(a) lub oba");
            }

            Console.ReadLine();
        }
    }
}
