
using CRUD.Entities;
using CRUD.Models.InputModels;
using CRUD.Models.ViewModels;
using CRUD.Persistence;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CRUD.Controllers
{
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly UserDbContext _dbContext;
        public UserController(UserDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        // api/users/5   método HTTP GET
      
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var user = _dbContext.Users.SingleOrDefault(u => u.Id == id);

            if (user == null)
                return NotFound();

            var viewUser = new ViewUser(user.Id, user.FullName, user.Tel, user.Email, user.BirthDate);
            return Ok(viewUser);
        }


        // api/users  método HTTP POST
       
        [HttpPost]
     
        public IActionResult Post([FromBody] CreateUser inputModel)
        {
            var user = new User(inputModel.FullName, inputModel.Email, inputModel.Tel, inputModel.BirthDate);

            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();

            return CreatedAtAction(nameof(Get), new { id = user.Id }, inputModel);
        }


        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateUser inputModel)
        {
            var user = _dbContext.Users.SingleOrDefault(u => u.Id == id);

            if (user == null)
                return NotFound();

            user.Update(inputModel.Email, inputModel.Tel);

            _dbContext.SaveChanges();

            return NoContent();
        }

        /*[HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var user = _dbContext.Users
                .SingleOrDefault(u => u.Id == id);

            if (user == null)
                return NotFound();

            user.Delete();

            _dbContext.SaveChanges();

            return NoContent();
        }*/
    }
}
