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
    public class BookDetailController : CommonController<BookDetail, BookDetail>
    {
        private readonly ShopperStopDbContext _dbcontext;
        public BookDetailController(ShopperStopDbContext dbcontext) : base(dbcontext)
        {
            _dbcontext = dbcontext;
        }
    }
}
