using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.DAL;
using Library.Models;

namespace Library.Services
{
    class BookService
    {
        private readonly LibraryContext _libraryContext;
        public BookService()
        {
            _libraryContext = new LibraryContext();
        }

        public void Add(Book book)
        {
            _libraryContext.Books.Add(book);
            _libraryContext.SaveChanges();
        }
        public void Delete(Book book)
        {
            _libraryContext.Books.Remove(book);
            _libraryContext.SaveChanges();
        }
        public void Update(Book book)
        {
            if (!_libraryContext.Books.Contains(book))
            {
                throw new NullReferenceException();
            }
            _libraryContext.Entry(book).State = System.Data.Entity.EntityState.Modified;
            _libraryContext.SaveChanges();
        }
        public List<Book> All()
        {
            return _libraryContext.Books.ToList();
        }
        public Book Find(int id)
        {
            Book book =  _libraryContext.Books.Find(id);
            return book;
        }
    }
}
