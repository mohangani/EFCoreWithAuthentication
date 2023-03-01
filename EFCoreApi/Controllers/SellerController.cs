using AutoMapper;
using EFCoreApi.Models.DbModels;
using Microsoft.AspNetCore.Mvc;

namespace EFCoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SellerController : CommonController<Seller, Seller>
    {
        private readonly ShopperStopDbContext _dbcontext;
        private readonly IMapper mapper;

        public SellerController(ShopperStopDbContext dbcontext, IMapper mapper) : base(dbcontext, mapper)
        {
            _dbcontext = dbcontext;
            this.mapper = mapper;
        }
    }
}
