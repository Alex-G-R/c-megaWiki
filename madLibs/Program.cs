using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLibs_game
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("My car is {color}");
            Console.WriteLine("My t-shirt is {color2}");
            Console.WriteLine("My dad is {color3}");

            Console.WriteLine("Enter the value for color: ");
            string color = Console.ReadLine();

            Console.WriteLine("Enter the value for color2: ");
            string color2 = Console.ReadLine();

            Console.WriteLine("Enter the value for color3: ");
            string color3 = Console.ReadLine();


            Console.WriteLine("Very cool your final story sounds like this: ");


            Console.WriteLine($"My car is {color}");
            Console.WriteLine($"My t-shirt is {color2}");
            Console.WriteLine($"My dad is {color3}");

            Console.ReadLine();
        }
    }
}
