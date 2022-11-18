using EFCoreApi.Controllers;
using EFCoreApi.Models.InputModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EFCoreApi.Models.DbModels
{
    public class User : IDbModel
    {

        [JsonIgnore]
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

        [JsonIgnore]
        public int AddressId { get; set; }
        public Address Address { get; set; }
        public int RoleId { get; set; }

        [JsonIgnore]
        public Role Role { get; set; }

        [JsonIgnore]
        public bool? IsActive { get; set; } = true;

        [JsonIgnore]
        public Cart Cart { get; set; }
    }


}
