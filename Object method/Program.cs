using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_22___Object_Method
{
    class Program
    {
        static void Main(string[] args)
        {

            Student student1 = new Student("John", "Buisness", 2.9);
            Student student2 = new Student("Alex", "Programming", 3.9);

            Console.WriteLine(student1.HasHonors());
            Console.WriteLine(student2.HasHonors());

            Console.ReadLine();
        }


    }
}
