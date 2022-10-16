using GitFresh.Clean.Application;
using GitFresh.Clean.Domain;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GitFresh.Clean.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DietsController : ControllerBase
    {
        private readonly IDietService _dietService;
        public DietsController(IDietService dietService)
        {
            _dietService = dietService;
        }
        // GET: api/<DietsController>
        [HttpGet]
        public ActionResult<List<Diet>> Get()
        {
            var dietsFromService = _dietService.GetAllDiets();
            return Ok(dietsFromService);
        }

    }
}
