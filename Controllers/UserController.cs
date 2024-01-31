using eCommerceSamotNet8.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eCommerceSamotNet8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<Users>>> GetAllUsers()
        {
            var users = new List<Users> { new Users { Id = 1, Name = "John", Email = "" } };

            return Ok(users);
        }
    }
}
