using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4___Getting_input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj imie: ");
            string name = Console.ReadLine();

            Console.WriteLine("Imie ktore wprowadziłeś to: "+name);

            Console.ReadLine();
        }
    }
}
