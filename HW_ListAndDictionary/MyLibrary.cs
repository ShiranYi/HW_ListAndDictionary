using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_ListAndDictionary
{
    internal class MyLibrary
    {
        private Dictionary<string, Book> books;
        public int Count { get { return books.Count; } }

        public MyLibrary()
        {
            books = new Dictionary<string, Book>();
        }
        public bool AddBook(Book book)
        {
            if (book == null)
                return books.TryAdd(book.Title, book);
            return false;

        }
        public bool RemoveBook(string book)
        {
            if (book == null)
                return false;
            return books.Remove(book);

        }
        public bool HaveThisBook(string book)
        {
            return books.ContainsKey(book);
        }
        public Book GetBook(string book)
        {
            return books[book];
        }
   
        public void Clear()
        {
            books = new Dictionary<string, Book>();

        }
        public List<string> GetAuthors()
        {
            List<string> authors = new List<string>();
            foreach (Book book in books.Values)
            {
                authors.Add(book.Author);
            }

            return authors;

        }
        public List<Book> GetBooksSortedByAuthorName()
        {
            return books.Values.OrderBy(book => book.Author).ToList();
        }
    
        public override string ToString()
        {
            string bookList = "";
            foreach (KeyValuePair<string, Book> book in books)
            {
                bookList += book.Key + ": " + book.Value + "\n";
            }
            return bookList;
        }




    }
}
