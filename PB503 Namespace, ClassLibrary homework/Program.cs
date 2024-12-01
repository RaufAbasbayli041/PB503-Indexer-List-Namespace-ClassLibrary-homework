using PB503Helper;

namespace PB503_Namespace__ClassLibrary_homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("first book");
            book1.AuthorName = "book1 Author";
            book1.PageCount = 22;

            Book book2 = new Book("second book");
            book2.AuthorName = "book2 Author";
            book2.PageCount = 22;

            Book book3 = new Book("third book");
            book3.AuthorName = "book3 Author";
            book3.PageCount = 33;


            Library library1 = new Library();

            library1.AddBook(book1);
            library1.AddBook(book2);
            library1.AddBook(book3);

            //foreach(var item in library1._books)
            //{
            //    Console.WriteLine(item.ID);
            //}

            //foreach (var book in library1.FindAllBooksByName("sec"))
            //{
            //    Console.WriteLine(book.ID);
            //}

            //Book wantedBook = library1.FindBookByCode("02");

            //Console.WriteLine(wantedBook.Name);

            

            //foreach (var book in library1.RemoveAllBooksByName("first"))
            //{
            //    Console.WriteLine(book.Name);
            //}

            //foreach (var books in library1.SearchBooks("25"))
            //{
            //    Console.WriteLine(books.AuthorName);
            //}


            foreach(var books in library1.FindAllBooksByPageCountRange(28, 45))
            {
                Console.WriteLine(books.Name);
            }

        }
    }
}
