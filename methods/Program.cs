using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHi("Majkel Dragon III the big chungus", 131);
            SayHi("Alex", 144);
            SayHi("Adrianos sixNine Cszarpowiec", 87);
            // to mowi zeby wykonac tego voida SayHi

            Console.ReadLine();
        }
        // zawsze musisz wpisac static a potem to co chcesz zeby zwrocilo void - bez zoobowiazan 
        static void SayHi(string name, int age)
        {
            Console.WriteLine("Hello "+name+ " masz "+ age+" lat");
        }

    }
}
