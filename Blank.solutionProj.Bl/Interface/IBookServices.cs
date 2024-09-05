using Blank.solutionProj.DataBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blank.solutionProj.Bl.Interface
{
    public interface  IBookServices
    {

        Task<IEnumerable<Book>> GetBooksAsync();
        Task<Book> AddBookAsync(Book book);
    }
}
