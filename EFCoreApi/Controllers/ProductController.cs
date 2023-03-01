using AutoMapper;
using EFCoreApi.Models.DbModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : CommonController<Product, Product>
    {
        private readonly ShopperStopDbContext _dbcontext;
        private readonly IMapper mapper;

        public ProductController(ShopperStopDbContext dbcontext, IMapper mapper) : base(dbcontext, mapper)
        {
            _dbcontext = dbcontext;
            this.mapper = mapper;
        }

        [HttpGet("list1")]
        public async Task<IActionResult> Get1(int pageNo = 1, int pageSize = 50)
        {
            var count = _dbcontext.Products.Count();
            var result = await _dbcontext.Products.Include(x => x.Size).OrderBy(x => x.Id).Skip((pageNo - 1) * pageSize).Take(pageSize).ToListAsync();
            return Ok(result);
        }
    }
}
