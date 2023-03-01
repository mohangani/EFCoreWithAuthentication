using EFCoreApi.Controllers;
using System;

namespace EFCoreApi.Models.DbModels
{
    public class User : IDbModel
    {

        [SwaggerIgnore]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return $"{LastName} {FirstName}";
            }
        }
        public DateTime Dob { get; set; }
        public GenderType Gender { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        [SwaggerIgnore]
        public int AddressId { get; set; }
        public Address Address { get; set; }
        public int RoleId { get; set; }

        [SwaggerIgnore]
        public Role Role { get; set; }

        [SwaggerIgnore]
        public bool? IsActive { get; set; } = true;

        [SwaggerIgnore]
        public Cart Cart { get; set; }
    }


}
