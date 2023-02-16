using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PE_PRN211_LeHaDuy_RePo.Models;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace PE_PRN211_LeHaDuy_RePo.Repositories
{
    public class BookRepository : IBookRepository
    {
        private BookPubLisherContext _db;
        public BookRepository()
        {
            var cs = GetConnectionString();
            _db = new BookPubLisherContext(cs);
        }
        private string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();
            var strConn = config["ConnectionStrings:PeDB"];
            return strConn;
        }
        public IEnumerable<Book> GetBooks()
        {
            return this._db.Books;
        }
        public Book GetBookByID(string bookId)
        {
            var book = _db.Books.Where(x => x.BookId == bookId).FirstOrDefault();
            return book;
        }
        public void DeleteBook(string bookId)
        {
            var book = _db.Books.Where(x => x.BookId == bookId).FirstOrDefault();
            _db.Books.Remove(book);
            _db.SaveChanges();
        }
        public void InsertBook(Book book)
        {
            try
            {
                Book b = GetBookByID(book.BookId);
                if(b == null)
                {
                    _db.Add(book);
                    _db.SaveChanges();
                }
                else
                {
                    throw new Exception("The book's id already exist");
                }
            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateBook(Book book)
        {
            _db.Books.Where(a => a.BookId == book.BookId).ToList()
                .ForEach((a) =>
                {
                    a.BookName = book.BookName;
                    a.AuthorName = book.AuthorName;
                    a.Quantity = book.Quantity;
                    a.PublisherId = book.PublisherId;
                }
                );
            _db.SaveChanges();
        }
    }
}
