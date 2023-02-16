using PE_PRN211_LeHaDuy_RePo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_PRN211_LeHaDuy_RePo.Repositories
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetBooks();
        Book GetBookByID(string bookId);
        void InsertBook(Book book);
        void DeleteBook(string bookId);
        void UpdateBook(Book book);

    }
}
