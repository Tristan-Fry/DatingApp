
using API.Data;
using API.Entitites;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")] //how a user would access this controller: /api/users

    //when a user sends a request to this controller then this class will be created
    //The liftime of this is scoped to the request
    public class UsersController : ControllerBase
    {
        // '_' is the typical convention for private variables instead of using 'this'
        private readonly DataContext _context;

        public UsersController(DataContext context)
        {
            _context = context;
        }

        //creating api endpoint
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            //gives list of users
            var users = await _context.Users.ToListAsync();
            return users;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetUser(int id)
        {
            //finding single user by their id
            return await _context.Users.FindAsync(id);
        }

    }
}