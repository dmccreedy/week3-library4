using System;
using System.Collections.Generic;
using System.Text;

namespace week3_library4
{
    public class Book
    {
        //Private fields
        private string _title;
        private string _author;
        private int _isbn;
        //Public properties

        public string Title
        {
            get { return _title; }
            set
            {
                if (!value.Any(char.IsDigit))
                {
                    _title = value;
                }
                else
                {
                    Console.WriteLine("Title cannot contain numbers.");
                }
            }
        }

        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }

        public int ISBN
        {
            get { return _isbn; }
            set
            { _isbn = value; 
            }
        }

        //Constructor
        public Book(string bookTitle, string bookAuthor, int bookISBN)
        {
            Title = bookTitle;
            Author = bookAuthor;
            ISBN = bookISBN;
        }
        //Methods
        public void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"ISBN: {ISBN}");
        }



        // Parameterless constructor





    }
}
