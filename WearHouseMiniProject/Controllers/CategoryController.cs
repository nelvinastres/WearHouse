using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WearHouseMiniProject.Data;
using WearHouseMiniProject.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WearHouseMiniProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CategoryController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/<CategoryController>
        /*[HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<CategoryController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }*/

        // POST api/<CategoryController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] AddCategory addcategory)
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
                UserID = addcategory.UserID,
                CategoryName = addcategory.CategoryName
            };

            _context.Category.Add(newcategory);
            await _context.SaveChangesAsync();

            return Ok();
        }


        // PUT api/<CategoryController>/5
        [HttpPut("{id, categoryname}")]
        public async Task<IActionResult> Put(string id, string categoryname, [FromBody] EditCategory editcategory)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var edit = await _context.Category.FirstOrDefaultAsync(x => x.UserID == id);
            if (edit == null)
            {
                return NotFound("Category Not Found");
            }

            while (true)
            {
                if (edit.CategoryName == categoryname)
                {
                    edit.CategoryName = editcategory.CategoryName;
                    await _context.SaveChangesAsync();
                    break;
                }
            }

            /*edit.CategoryName = editcategory.CategoryName;
            await _context.SaveChangesAsync();*/

            return Ok();
        }

        // DELETE api/<CategoryController>/5
        [HttpDelete("{id, categoryname}")]
        public async Task<IActionResult> Delete(string id, string categoryname)
        {
            var delete = await _context.Category.FirstOrDefaultAsync(x => x.UserID == id);

            if (delete == null)
            {
                return NotFound("Category Not Found");
            }

            while (true)
            {
                if (delete.CategoryName == categoryname)
                {
                    _context.Category.Remove(delete);
                    await _context.SaveChangesAsync();
                    break;
                }
            }

            if (delete == null)
            {
                return NotFound("Category not found");
            }

            /*_context.Category.Remove(delete);
            await _context.SaveChangesAsync();*/

            return Ok();
        }
    }
}
