using EFCoreApi.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreApi.Models.DbModels
{
    public class BookDetail :IDbModel
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public Book Book { get; set; }
    }
}
