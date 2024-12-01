using PB503_Namespace_list_indexer_Classlibrary.Models;

namespace PB503_Namespace_list_indexer_Classlibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book0 = new Book("Test");
            book0.AuthorName = "Testler";
            book0.PageCount = 156;

            Book book1 = new Book("jest");
            book1.AuthorName = "eler";
            book1.PageCount = 1156;

            Book book2 = new Book("mest");
            book2.AuthorName = "elii";
            book2.PageCount = 547;

            Book book3 = new Book("Test");
            book3.AuthorName = "salam";
            book3.PageCount = 78;

            Book book4 = new Book("Test");
            book4.AuthorName = "Test";
            book4.PageCount = 598;

            Book book5 = new Book("mest");
            book5.AuthorName = "salam";
            book5.PageCount = 365;

            Book book6 = new Book("salam");
            book6.AuthorName = "sagol";
            book6.PageCount = 521;

            Library library = new Library();
            library.AddBook(book0);
            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);
            library.AddBook(book4);
            library.AddBook(book5);
            library.AddBook(book6);

            Console.WriteLine("Indexer:");
            for (int i = 0; i < library.Books.Count; i++)
            {
                Console.WriteLine(library[i].Name);
            }
            Console.WriteLine("===========================================================================");
            Console.WriteLine("Book code");
            Console.WriteLine(library[2].Code);
            Console.WriteLine("===========================================================================");
            Console.WriteLine("Find by name");
            List<Book> wantedBookByName = library.FindAllBooksName("Test");
            foreach (var book in wantedBookByName)
            {
                Console.WriteLine(book.Name);
            }
            Console.WriteLine("==========================================================================");
            Console.WriteLine("Remove by name");
            library.RemoveAllBooksByName("Test");
            foreach (var book in library.Books)
            {
                Console.WriteLine(book.Name);
            }
            Console.WriteLine("===========================================================================");
            Console.WriteLine("Search");
            List<Book> wantedByValue = library.SearchBooks("salam");
            foreach (var books in wantedByValue)
            {
                Console.WriteLine($"{books.Name} {books.AuthorName}");
            }
            Console.WriteLine("===========================================================================");
            Console.WriteLine("Page count");
            List<Book> wantedByPage = library.FindAllBooksByPageCountRange(500, 1000);
            foreach (var books in wantedByPage)
            {
                books.ShowBookInfo();
            }
            Console.WriteLine("===========================================================================");
            Console.WriteLine("Find By code");
            Console.WriteLine(library.FindBookByCode("ME3").Name);
            Console.WriteLine("===========================================================================");
            Console.WriteLine("Remove with code");
            library.RemoveBookByCode("ME3");
            foreach (var book in library.Books)
            {
                book.ShowBookInfo();
            }
         
        }
    }
}
            

           

            

            




            


