 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_13___Switch_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj Index Dnia tygodnia 0-Niedziela: ");
            int dayNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(GetDay(dayNum));

            Console.ReadLine();
        }

        static string GetDay(int dayNum)
        {
            string dayName;

            switch (dayNum)
            {
                case 0:
                    dayName = "Niedziela";
                    break;

                case 1:
                    dayName = "Poniedziałek";
                    break;

                case 2:
                    dayName = "Wtorek";
                    break;

                case 3:
                    dayName = "Środa";
                    break;

                case 4:
                    dayName = "Czwartek";
                    break;

                case 5:
                    dayName = "Piątek";
                    break;

                case 6:
                    dayName = "Sobota";
                    break;

                default:
                    dayName = "Błędna liczba dnia";
                    break;

            }

            return dayName;
        }
    }
}
