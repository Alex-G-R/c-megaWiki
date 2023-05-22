using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luckynumbers = { 7, 13, 19, 69, 2115 };
            // index index index   0  1   2   3   4       index index 

            Console.WriteLine(luckynumbers[0]+" "+luckynumbers[4]);

            Console.WriteLine(luckynumbers[1]);

            luckynumbers[1] = 8000;
            Console.WriteLine(luckynumbers[1]);

            string[] friends = new string[10];
            // This numer in new string[X] is telling us how many elements this array will be able to hold 

            friends[0] = "Alex";
            friends[1] = "Jim";

            Console.WriteLine(friends[0] + " " + friends[1] + " " + friends[3]);
            // Index numer 3 nic nie wyświetli bo index 3 jest pusty tak jak index 2, 4, 5, 6 itd.


            Console.ReadLine();
        }
    }
}
