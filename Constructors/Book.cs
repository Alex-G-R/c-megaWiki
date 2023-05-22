using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_21___Constructors
{
    class Book
    {
        public string title;
        public string author;
        public int pages;
        public double price;

        public Book(string aTitle, string aAuthor, int aPages, double aPrice)
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;
            price = aPrice;
        }

    }
}
