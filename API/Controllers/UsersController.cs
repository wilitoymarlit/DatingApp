using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        //Generando Constructor
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            _context = context;
        }

        //Anadimos el endpoint para anadir un usuario
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            return await _context.Users.ToListAsync();
            //var users = _context.Users.ToList();
            //return users;
        }

        //Otro Endpoint api/users/3
        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetUser(int id)
        {
            return await _context.Users.FindAsync(id);
            //var user = _context.Users.Find(id);
            //return user;
        }
    }
}