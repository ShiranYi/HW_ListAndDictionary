using System;
using System.Collections.Generic;

namespace HW_ListAndDictionary
{
    internal class Program


    {
        static void Main(string[] args)
        {

            Book book1 = new Book("Book1", "abcd", "Dana", "Adventure");
            Book book2 = new Book("Book2", "abcd", "Yossi", "Thriller");
            Book book3 = new Book("Book3", "abcd", "Moshe", "Science Fiction");
            Book book4 = new Book("Book4", "abcd", "Shira", "Novel");

            Dictionary<string, Book> books = new Dictionary<string, Book>();
            books.Add("Book1", book1);
            books.Add("Book2", book2);
            books.Add("Book3", book3);
            books.Add("Book4", book4);

    
            
            




        }
    }
}
