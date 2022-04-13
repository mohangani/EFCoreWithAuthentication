using EFCoreApi.Models.DbModels;
using EFCoreApi.Models.InputModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Policy = "admin")]
    public class UserController : CommonController<UserInputModel, User>
    {
        private readonly ShopperStopDbContext _dbcontext;

        public UserController(ShopperStopDbContext dbcontext) : base(dbcontext)
        {
            _dbcontext = dbcontext;
        }

        //[HttpPost("Add")]
        //public async Task<IActionResult> Add(User user)
        //{
        //    await _dbcontext.Users.AddAsync(user);
        //    var userid = _dbcontext.SaveChanges();
        //    return Ok(userid);

        //}

        //[HttpPost("AddRange")]
        //public async Task<IActionResult> AddRange(List<User> user)
        //{
        //    await _dbcontext.Users.AddRangeAsync(user);
        //    _dbcontext.SaveChanges();
        //    return Ok();
        //}

        //[HttpPut("Update")]
        //public IActionResult Update(User user)
        //{
        //    if (user?.Id is null) return BadRequest("User Id Required.");
        //    _dbcontext.Users.Update(user);
        //    return Ok(_dbcontext.SaveChanges());
        //}

        //[HttpDelete("Delete")]
        //public IActionResult Delete(int userId)
        //{
        //    var user = _dbcontext.Users.Find(userId);
        //    if (user is null) return BadRequest("User id not Exists.");

        //    user.IsActive = false;
        //    _dbcontext.Users.Update(user);

        //    //_dbcontext.Users.Remove(user);
        //    return Ok(_dbcontext.SaveChanges());
        //}

        //[HttpGet("GetUser")]
        //public async Task<IActionResult> GetUser(int userid)
        //{
        //   // var result =  await _dbcontext.Users.Include(x=>x.Address).FirstOrDefaultAsync(x=>x.UserId == userid);
        //    var result1 =  await _dbcontext.Users.FirstOrDefaultAsync(x=>x.Id == userid);
        //    return Ok(result1);
        //}

        //[HttpGet("GetUsersList")]
        //public IActionResult GetUsersList(string username)
        //{
        //    return Ok(_dbcontext.Users.Where(x=>x.FirstName.Contains(username) || x.LastName.Contains(username)));
        //}
    }
}
