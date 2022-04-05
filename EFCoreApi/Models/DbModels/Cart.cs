using EFCoreApi.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreApi.Models.DbModels
{
    public class Cart :IDbModel
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public int ProductId { get; set; }

        public User User { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }

    }
}
