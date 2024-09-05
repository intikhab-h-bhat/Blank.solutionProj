using Blank.solutionProj.DataBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blank.solutionProj.DataBase.Interface
{
    public interface  IBookDal
    {

        Task<IEnumerable<Book>> GetBooksAsync();
        //Task<Book> GetBookByIdAsync(int id);

        Task<Book> AddBookAsync(Book book);
        //Task UpdateBookAsync(Book book);
        //Task DeleteBookAsync(int id);

    }
}
