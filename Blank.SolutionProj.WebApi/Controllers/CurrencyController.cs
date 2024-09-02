using Blank.solutionProj.DataBase.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        public async Task<IActionResult> GetAllCurrencys() {


            //var result= _appDbContext.Currencys.ToList();
            // var result = (from currency in _appDbContext.Currencys select currency).ToList();

            //var result= await _appDbContext.Currencys.ToListAsync();
            var result = await (from currency in _appDbContext.Currencys select currency).ToListAsync();


            return Ok(result);

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCurrencyByIdAsync([FromRoute] int id)
        {



            var result= await _appDbContext.Currencys.FindAsync(id);
          // var result = await (from currency in _appDbContext.Currencys where currency.Id==id  select currency).ToListAsync();


            return Ok(result);

        }

    }
}
