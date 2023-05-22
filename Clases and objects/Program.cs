using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_20___Classes_and_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.title = "Harry Potter";
            book1.author = "JK Rowling";
            book1.pages = 400;
            book1.price = 39.99;

            Book book2 = new Book();
            book2.title = "Bible";
            book2.author = "Jesus Christ";
            book2.pages = 1400;
            book2.price = 79.99;



            Console.WriteLine($"Title: {book1.title}, author: {book1.author}, number of pages: {book1.pages}, price {book1.price}");
            Console.WriteLine($"Title: {book2.title}, author: {book2.author}, number of pages: {book2.pages}, price {book1.price}");

            Console.ReadLine();
        }


    }
}
