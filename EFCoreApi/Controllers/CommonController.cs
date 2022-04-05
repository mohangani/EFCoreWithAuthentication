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
    public abstract class CommonController<T> : ControllerBase where T: class, IDbModel
    {
        private readonly ShopperStopDbContext _dbcontext;

        public CommonController(ShopperStopDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        [HttpPost("Add")]
        public virtual async Task<IActionResult> Add(T model)
        {
            await _dbcontext.Set<T>().AddAsync(model);
            var insertedId = _dbcontext.SaveChanges();
            return Ok(insertedId);

        }

        [HttpPost("AddRange")]
        public virtual async Task<IActionResult> AddRange(List<T> modelList)
        {
            await _dbcontext.Set<T>().AddRangeAsync(modelList);
            _dbcontext.SaveChanges();
            return Ok();
        }

        [HttpPut("Update")]
        public virtual IActionResult Update(T user)
        {
            if (user.Id == default) return BadRequest("User Id Required.");
            _dbcontext.Set<T>().Update(user);
            return Ok(_dbcontext.SaveChanges());
        }

        [HttpDelete("Delete")]
        public virtual IActionResult Delete(int userId)
        {
            var user = _dbcontext.Users.Find(userId);
            if (user is null) return BadRequest("User id not Exists.");

            user.IsActive = false;
            _dbcontext.Users.Update(user);

            //_dbcontext.Users.Remove(user);
            return Ok(_dbcontext.SaveChanges());
        }

        [HttpGet("Find")]
        public virtual async Task<IActionResult> GetUser(int Id)
        {
            // var result =  await _dbcontext.Users.Include(x=>x.Address).FirstOrDefaultAsync(x=>x.UserId == userid);
            var result1 = await _dbcontext.Set<T>().FirstOrDefaultAsync(x => x.Id == Id);
            return Ok(result1);
        }

        //[HttpGet("GetUsersList")]
        //public IActionResult GetUsersList(string username)
        //{
        //    return Ok(_dbcontext.Set<T>().Where(x => x.FirstName.Contains(username) || x.LastName.Contains(username)));
        //}

        // GET: api/Generic
        [HttpGet("list/{pageNo}-{pageSize}")]
        public virtual (IEnumerable<T>, int) Get(int pageNo, int pageSize)
        {
            var query = _dbcontext.Set<T>();

            var totalRecords = query.Count();
            var items = query.OrderBy(x => x.Id)
                .Skip((pageNo - 1) * pageSize)
                .Take(pageSize)
                .AsEnumerable();

            return (items, totalRecords);
        }
    }
}
