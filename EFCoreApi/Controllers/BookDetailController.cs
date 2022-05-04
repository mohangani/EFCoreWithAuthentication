using AutoMapper;
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
        private readonly IMapper mapper;

        public BookDetailController(ShopperStopDbContext dbcontext,IMapper mapper) : base(dbcontext, mapper)
        {
            _dbcontext = dbcontext;
            this.mapper = mapper;
        }
    }
}
