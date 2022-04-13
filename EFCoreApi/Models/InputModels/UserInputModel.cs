using EFCoreApi.Controllers;
using EFCoreApi.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreApi.Models.InputModels
{
    public class UserInputModel : IDbModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Dob { get; set; }
        public GenderType Gender { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int AddressId { get; set; }
        public int RoleId { get; set; }
        public bool? IsActive { get; set; }
    }
}
