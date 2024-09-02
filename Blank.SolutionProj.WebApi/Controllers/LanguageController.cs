using Blank.solutionProj.DataBase.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace Blank.SolutionProj.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguageController : ControllerBase
    {
        private readonly AppDbContext _appdDbContext;
        public LanguageController(AppDbContext appDbContext)
        {
            _appdDbContext = appDbContext;
        }

        [HttpGet]

       public IActionResult GetAllLanguages()
        {

            //var result= _appdDbContext.Languages.ToList();
            var result= (from language in _appdDbContext.Languages select language).ToList();

            return Ok(result);
        }
    }
}
