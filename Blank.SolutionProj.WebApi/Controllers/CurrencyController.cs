using Blank.solutionProj.DataBase.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Blank.SolutionProj.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurrencyController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;
        public CurrencyController(AppDbContext appDbContext)
        {

            _appDbContext = appDbContext;
            
        }

        [HttpGet]
        public IActionResult GetAllCurrencys() {
        
            
            //var result= _appDbContext.Currencys.ToList();
            var result = (from currency in _appDbContext.Currencys select currency).ToList();
            return Ok(result);
        
        }

    }
}
