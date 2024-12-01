using PB503Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PB503_Namespace__ClassLibrary_homework
{
    public class Library
    {
        // private Book[] _books = Array.Empty<Book>();

        public List<Book> _books = new List<Book>();

        public Book this[int index]
        {
            get => _books[index];
        }

        public void AddBook(Book book)
        {
            _books.Insert(_books.Count, book);
            _books[^1] = book;
        }

        public List<Book> FindAllBooksByName(string name)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
            {
                return null;
            }
            List<Book> wantedBooks = new List<Book>();
            foreach (Book book in _books)
            {
                if (book.Name.ToLower().Contains(name.ToLower()))
                {
                    wantedBooks.Insert(wantedBooks.Count, book);
                    wantedBooks[^1] = book;
                }
            }
            return wantedBooks;
        }

        public Book FindBookByCode(string code)
        {
            if (string.IsNullOrEmpty(code) || string.IsNullOrWhiteSpace(code))
            {
                return null;
            }
            foreach (var book in _books)
            {
                if (book.Code.ToLower().Contains(code.ToLower()))
                {
                    return book;
                }
            }
            return null;
        }

        public List<Book> RemoveAllBooksByName(string value)
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
            {
                return null;
            }
            _books.RemoveAll(x => x.Name.ToLower().Contains(value.ToLower()));
            return _books;
        }

        public List<Book> RemoveBookByCode(string code)
        {
            if (string.IsNullOrEmpty(code) || string.IsNullOrWhiteSpace(code))
            {
                return null;
            }
            _books.RemoveAll(x => x.Code.ToLower().Contains(code.ToLower()));
            return _books;
        }

        public List<Book> SearchBooks(string value)
        {
            List<Book> searchBooks = new List<Book>();
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
            {
                return null;
            }


            foreach (var book in _books)
            {
                if (value.Length != book.PageCount)
                {
                    Console.WriteLine("error");
                }
                else if (book.Name.ToLower().Contains(value.ToLower()) || book.AuthorName.ToLower().Contains(value.ToLower())
                    || book.PageCount.ToString().ToLower().Contains(value.ToLower()))
                {
                    searchBooks.Add(book);
                }

            }
            return searchBooks;
        }

        public List<Book> FindAllBooksByPageCountRange (int minPage, int maxPage)
        {
            List<Book> wantedBooks = new List<Book>();
            
            foreach (var book in _books)
            {
                if (book.PageCount > minPage && book.PageCount < maxPage)
                {
                    wantedBooks.Add(book);
                }
            }
            return wantedBooks;
        }



    }
}
