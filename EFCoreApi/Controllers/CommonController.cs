using AutoMapper;
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
    public abstract class CommonController<Source,Dest> : ControllerBase where Source: class, IDbModel
        where Dest: class, IDbModel
    {
        private readonly ShopperStopDbContext _dbcontext;
        private readonly IMapper _mapper;

        public CommonController(ShopperStopDbContext dbcontext,IMapper mapper)
        {
            _dbcontext = dbcontext;
            _mapper = mapper;
        }

        [HttpPost("Add")]
        public virtual async Task<IActionResult> Add(Source model)
        {
            await _dbcontext.Set<Dest>().AddAsync(_mapper.Map<Dest>(model));
            var insertedId = _dbcontext.SaveChanges();
            return Ok(insertedId);

        }

        [HttpPost("AddRange")]
        public virtual async Task<IActionResult> AddRange(List<Source> modelList)
        {
            //_mapper.Map<List<Dest>>(modelList)
            
            await _dbcontext.Set<Dest>().AddRangeAsync(modelList as List<Dest>);
            _dbcontext.SaveChanges();
            return Ok();
        }

        [HttpPut("Update")]
        public virtual IActionResult Update(Source user)
        {
            if (user.Id == default) return BadRequest("User Id Required.");
            _dbcontext.Set<Dest>().Update(user as Dest);
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
            var result1 = await _dbcontext.Set<Dest>().FirstOrDefaultAsync(x => x.Id == Id);
            return Ok(result1);
        }

        //[HttpGet("GetUsersList")]
        //public IActionResult GetUsersList(string username)
        //{
        //    return Ok(_dbcontext.Set<T>().Where(x => x.FirstName.Contains(username) || x.LastName.Contains(username)));
        //}

        // GET: api/Generic
        [HttpGet("list/{pageNo}-{pageSize}")]
        public virtual IEnumerable<Dest> Get(int pageNo, int pageSize)
        {
            var query = _dbcontext.Set<Dest>();

            var totalRecords = query.Count();
            var items = query.OrderBy(x => x.Id)
                .Skip((pageNo - 1) * pageSize)
                .Take(pageSize)
                .AsEnumerable();

            return items;
        }
    }
}
