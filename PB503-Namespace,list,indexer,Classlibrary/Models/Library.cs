using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace PB503_Namespace_list_indexer_Classlibrary.Models
{
    public class Library
    {
        private List<Book> _books = new List<Book>();

        public List<Book> Books => _books;
        public Book this[int index]
        {
            get => _books[index];

        }

        public void AddBook(Book book)
        {
            _books.Add(book);
        }

        public List<Book> FindAllBooksName(string value)
        {
            return _books.FindAll(books => books.Name.Contains(value));
        }

        public void RemoveAllBooksByName(string value)
        {
            _books.RemoveAll(book => book.Name.Contains(value));
        }

        public List<Book> SearchBooks(string value)
        {
            return _books.FindAll(books => books.Name.Contains(value) || books.AuthorName.Contains(value));
        }

        public List<Book> FindAllBooksByPageCountRange(int min, int max)
        {
            return _books.FindAll(book => book.PageCount >= min && book.PageCount <= max);
        }


        public Book FindBookByCode(string code)
        {
            return _books.Find(book => book.Code == code);
        }

        public void RemoveBookByCode(string value)
        {
            _books.Remove(FindBookByCode(value));
        }







    }
}
