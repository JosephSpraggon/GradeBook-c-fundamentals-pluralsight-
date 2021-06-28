using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Joe's GradeBook");
            book.AddGrade(89.1);
            book.AddGrade(37.8);
            book.AddGrade(92.4);

            book.showStats();
        }
    }
}
