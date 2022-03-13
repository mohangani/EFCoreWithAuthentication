using EFCoreApi.Models.DbModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ShopperStopDbContext _dbcontext;

        public UserController(ShopperStopDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add(User user)
        {
            await _dbcontext.Users.AddAsync(user);
            var userid = _dbcontext.SaveChanges();
            return Ok(userid);

        }

        [HttpPost("AddRange")]
        public async Task<IActionResult> AddRange(List<User> user)
        {
            await _dbcontext.Users.AddRangeAsync(user);
            _dbcontext.SaveChanges();
            return Ok();
        }

        [HttpPut("Update")]
        public IActionResult Update(User user)
        {
            if (user?.UserId is null) return BadRequest("User Id Required.");
            _dbcontext.Users.Update(user);
            return Ok(_dbcontext.SaveChanges());
        }

        [HttpDelete("Delete")]
        public IActionResult Delete(int userId)
        {
            var user = _dbcontext.Users.Find(userId);
            if (user is null) return BadRequest("User id not Exists.");
            _dbcontext.Users.Remove(user);
            return Ok(_dbcontext.SaveChanges());
        }

        [HttpGet("GetUser")]
        public async Task<IActionResult> GetUser(int userid)
        {
            return Ok(await _dbcontext.Users.FindAsync(userid));
        }

        [HttpGet("GetUsersList")]
        public IActionResult GetUsersList(string username)
        {
            return Ok(_dbcontext.Users.Where(x=>x.FirstName.Contains(username) || x.LastName.Contains(username)));
        }
    }
}
