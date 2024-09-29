using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WearHouseMiniProject.Data;
using WearHouseMiniProject.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WearHouseMiniProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private readonly AppDbContext _context;

        public RegisterController(AppDbContext context)
        {
            _context = context;
        }
        // GET: api/<RegisterController>
        /*[HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }*/

        // GET api/<RegisterController>/5
        /*[HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }*/

        // POST api/<RegisterController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] RegisterValidate register)
        {
            var rand = new Random();
            int ID = rand.Next(100, 1000);
            var UserIDlocal = "UU" + ID;

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var email = _context.UserData.Where(x => x.Email == register.Email).Count();
            if (email == 1)
            {
                return NotFound();
            }

            var user = new UserData
            {
                UserID = UserIDlocal,
                Name = register.Name,
                Email = register.Email,
                Password = register.Password,
            };

            _context.UserData.Add(user);
            await _context.SaveChangesAsync();

            return Ok();
        }

        // PUT api/<RegisterController>/5
        /*[HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }*/

        // DELETE api/<RegisterController>/5
        /*[HttpDelete("{id}")]
        public void Delete(int id)
        {
        }*/
    }
}
