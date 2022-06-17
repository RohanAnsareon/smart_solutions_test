using Microsoft.AspNetCore.Mvc;
using personality_test_api.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace personality_test_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionaryController : ControllerBase
    {
        private readonly AppDbContext _dbContext;

        public QuestionaryController(AppDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        // GET: api/<QuestionaryController>
        [HttpGet]
        public ActionResult<IEnumerable<Question>> Get()
        {
            return Ok(_dbContext.Questions.ToList());
        }

        //// GET api/<QuestionaryController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<QuestionaryController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<QuestionaryController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<QuestionaryController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
