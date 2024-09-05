using Blank.solutionProj.DataBase.Interface;
using Blank.solutionProj.DataBase.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blank.solutionProj.DataBase.Data.BookData
{
    public class AddBookDal:IBookDal
    {
        private readonly AppDbContext _appDbContext;
        public AddBookDal(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

       
        public async Task<IEnumerable<Book>> GetBooksAsync(){
        
            
            return await _appDbContext.Books.ToListAsync();
        }


        public async Task<Book> AddBookAsync(Book model)
        {
            _appDbContext.Books.AddAsync(model);

            await _appDbContext.SaveChangesAsync();
            return model;
            
        }


    }
}
