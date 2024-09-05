using Blank.solutionProj.Bl.Interface;
using Blank.solutionProj.DataBase.Data;
using Blank.solutionProj.DataBase.Data.BookData;
using Blank.solutionProj.DataBase.Interface;
using Blank.solutionProj.DataBase.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blank.solutionProj.Bl.Services.BookServices
{
    public class BookServices:IBookServices
    {
        private readonly IBookDal _bookDal;
        public BookServices(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }



        public async Task<IEnumerable<Book>> GetBooksAsync()
        {
            return await _bookDal.GetBooksAsync();
        }

       
        public async Task<Book> AddBookAsync(Book book)
        {
            return await _bookDal.AddBookAsync(book);
        }


    }
}
