using AutoMapper;
using EFCoreApi.Models.DbModels;
using Microsoft.AspNetCore.Mvc;

namespace EFCoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : CommonController<Cart, Cart>
    {
        private readonly ShopperStopDbContext _dbcontext;
        private readonly IMapper mapper;

        public CartController(ShopperStopDbContext dbcontext, IMapper mapper) : base(dbcontext, mapper)
        {
            _dbcontext = dbcontext;
            this.mapper = mapper;
        }
    }
}
