using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_24___Static_Class_Attributes
{
    class Movie
    {
        public string title;
        public string author;
        private string pegi;
        public static int number = 0;

        public Movie(string aTitle, string aAuthor, string aPegi)
        {
            title = aTitle;
            author = aAuthor;
            Pegi = aPegi;
            number++;
        }

        public string Pegi
        {
            get
            {
                return pegi;
            }

            set
            {
                if (value == "Pegi-21" || value == "Pegi-18" || value == "Pegi-16" || value == "Pegi-13" || value == "Pegi-12" || value == "Pegi-8" || value == "Pegi-3" || value == "Pegi-X")
                {
                    pegi = value;
                }
                else
                {
                    pegi = "Pegi-X";
                }
            }
        }
    }
}
