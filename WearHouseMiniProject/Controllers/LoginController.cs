using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WearHouseMiniProject.Data;
using WearHouseMiniProject.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WearHouseMiniProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly AppDbContext _context;

        public LoginController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/<LoginController>
        /*[HttpGet]
        public async Task<IActionResult> DisplayAllCategory()
        {
            return Ok(await _context.Category.ToListAsync());
        }*/

        // GET api/<LoginController>/5
        /*[HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }*/

        // POST api/<LoginController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] LoginValidate login)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var email = _context.UserData.Where(x => x.Email == login.Email).Count();
            var pass = _context.UserData.Where(x => x.Password == login.Password).Count();

            if (email < 1)
            {
                return NotFound();
            }
            else if (pass < 1)
            {
                return NotFound();
            }
            else
            {
                var name = _context.UserData
                    .Where(x => x.Email == login.Email)
                    .Select(y => y.Name).FirstOrDefault();
                return Ok(name);
            }
        }

        /*[HttpPost]
        [Route("{register:RegisterValidate}")]*/
        /*public async Task<IActionResult> RegisterValidation([FromRoute] RegisterValidate register)
        {
            //int ValidateAsync(string password) {
            //int counter = 0;
            //List<string> patterns = new List<string> {
            //@"[a-z]",
            // @"[A-Z]",
            //@"[0-9]",
            //@"[!@#$%^&*\(\)_\+\-\={}<>,\.\|""'~`:;\\?\/\[\]]"
            //};
            //foreach (string p in patterns)
            //{
            //if (Regex.IsMatch(register.Password, p))
            //{
            //    counter++;
            //}
            //}

            //return counter;
            // }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var email = _context.UserData.Where(x => x.Email == register.Email).Count();
            if (email == 1)
            {
                return NotFound("This email has been registered");
            }


            var user = new UserData
            {
                Name = register.Name,
                Email = register.Email,
                Password = register.Password,
            };

            _context.UserData.Add(user);
            await _context.SaveChangesAsync();

            *//*if (register.Name.Length == 0)
            {
                return NotFound("Name must be filled");
            } else if(!new EmailAddressAttribute().IsValid(register.Email) && register.Email.Length == 0)
            {
                return NotFound("Your email is not valid");
            } else if(ValidateAsync(register.Password) < 3 && register.Password.Length < 8)
            {
                return NotFound("Your password need at least 8 characters, one uppercase, one number, and one symbol");
            } else if()*//*


            return Ok();
        }*/

        /*[HttpPost]
        [Route("{addcategory:AddCategory}")]*/
        /*public async Task<IActionResult> AddingCategory([FromRoute] AddCategory addcategory)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var add = _context.Category.Where(x => x.CategoryName == addcategory.CategoryName).Count();

            if (add == 1)
            {
                return NotFound("This category existed");
            }

            var newcategory = new Category
            {
                CategoryName = addcategory.CategoryName,
            };

            _context.Category.Add(newcategory);
            await _context.SaveChangesAsync();

            return Ok();
        }*/

        // PUT api/<LoginController>/5
        //[HttpPut("{id}")]
        /*public async Task<IActionResult> Put(string id, [FromBody] EditCategory editcategory)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var edit = await _context.Category.FirstOrDefaultAsync(x => x.CategoryName == id);

            edit.CategoryName = editcategory.CategoryName;
            await _context.SaveChangesAsync();

            return Ok();
        }*/

        // DELETE api/<LoginController>/5
        //[HttpDelete("{id}")]
        /*public async Task<IActionResult> Delete(string id)
        {
            var delete = await _context.Category.FirstOrDefaultAsync(x => x.CategoryName == id);

            _context.Category.Remove(delete);
            await _context.SaveChangesAsync();

            return Ok();
        }*/
    }
}
