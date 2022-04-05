using EFCoreApi.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreApi.Models.DbModels
{
    public class Seller : IDbModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
        public bool IsActive { get; set; }
    }
}
