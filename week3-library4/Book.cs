using System;
using System.Collections.Generic;
using System.Text;

namespace week3_library4
{
    public class Book
    {
        public string Title;
        public string Author;

        public int ISBN;

        public void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"ISBN: {ISBN}");
        }

    }
}
