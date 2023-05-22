using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_24___Static_Class_Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie avengers = new Movie("Avengers", "Johs Whedon", "Pegi-13");
            Console.WriteLine(Movie.number);
            Movie shrek = new Movie("Shrek", "Osioł", "Pegi-21");
            Console.WriteLine(Movie.number);

            Console.ReadLine();
        }
    }
}
