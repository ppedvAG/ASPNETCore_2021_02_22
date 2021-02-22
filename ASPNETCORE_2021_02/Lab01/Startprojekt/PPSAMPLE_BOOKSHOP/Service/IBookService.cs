using PPSAMPLE_BOOKSHOP.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PPSAMPLE_BOOKSHOP.Service
{
    public interface IBookService
    {
        Book InserBook(Book book);

        IList<Book> GetBooks(string query, bool onlyAudioBooks);

        int GetCount();

        Book GetById(int id);
    }
}