using Blank.solutionProj.Bl.Interface;
using Blank.solutionProj.DataBase.Data;
using Blank.solutionProj.DataBase.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Blank.SolutionProj.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController: ControllerBase
    {
        private readonly IBookServices _bookServices;

        public BooksController(IBookServices bookServices)
        {
            _bookServices = bookServices;
        }


        [HttpGet]
        public async Task<IActionResult> GetBooks()
        {
           var books= await _bookServices.GetBooksAsync();
            return Ok(books);
        }

        [HttpPost]
        public async Task<IActionResult> AddBook([FromBody] Book book)
        {
            await _bookServices.AddBookAsync(book);
            return Ok(book);            

        }
        


    }
}
