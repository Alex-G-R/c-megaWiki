using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3___Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("No elo elo 420 zabawa");
            //                      hehe jaranie

            Console.WriteLine("No elo elo \nmam na imie Alex");
            // \n to taki <br> z html, tworzy nowa linijke i pisze tam dlasza czesc writeline

            string fraza = "Alex" + " jest super cool";
            Console.WriteLine(fraza);

            fraza = fraza + " i on lubi pociągi";
            Console.WriteLine(fraza);



            string fraza2 = "Kocham C#";
            Console.WriteLine(fraza2.Length);
            // funkcja .Lenght wyświetli długość frazy 2

            Console.WriteLine(fraza2.ToUpper());
            // to zrobi wszytko na duze litery

            Console.WriteLine(fraza2.ToLower());
            // a to robi na małe


            Console.WriteLine(fraza2.Contains("C#"));
            // to sprawdza czy zawiera X i wypisuje true albo false

            Console.WriteLine(fraza2[0]);
            // wpisujesz index litery i ja wypisuje 
            // index idzie od zera czyli tak
            // Alex
            // 0123
            Console.WriteLine(fraza2[2]);


            Console.ReadLine();
        }
    }
}
