using Blank.solutionProj.DataBase.Data;
using Blank.solutionProj.DataBase.Models;
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
            var result = await (from currency in _appDbContext.Currencys 
             select new Currency()
            {
                Id = currency.Id,
                Title = currency.Title,
            }).ToListAsync();


            return Ok(result);

        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetCurrencyByIdAsync([FromRoute] int id)
        {



            var result= await _appDbContext.Currencys.FindAsync(id);
          // var result = await (from currency in _appDbContext.Currencys where currency.Id==id  select currency).ToListAsync();


            return Ok(result);

        }


        [HttpGet("{title}")]
        public async Task<IActionResult> GetCurrencyByTitleAsync([FromRoute] string title,[FromQuery] string? desc)
        {
            //var result = await _appDbContext.Currencys.FirstOrDefaultAsync(x=>x.Title == title
            //&&  (string.IsNullOrEmpty(desc) || x.Description == desc));    

            var result = await _appDbContext.Currencys.Where(x => x.Title == title
            && (string.IsNullOrEmpty(desc) || x.Description == desc)).ToListAsync();


            return Ok(result);

        }

        [HttpPost("all")]
        public async Task<IActionResult> GetCurrencyByIdsAsync([FromBody] List<int> ids)
        {
            //var ids=new List<int> { 1,2,3};

            var result = await _appDbContext.Currencys.Where(x=> ids.Contains(x.Id))
                .Select(x => new Currency()
                {
                    Id=x.Id, Title=x.Title,
                 })
                .ToListAsync();
          


            return Ok(result);
        }

    }
}
