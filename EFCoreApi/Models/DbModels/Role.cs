using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EFCoreApi.Models.DbModels
{
    public class Role
    {
        [JsonIgnore]
        public int Id { get; set; }
        public string RoleName { get; set; }

        [JsonIgnore]
        public User User { get; set; }
    }
}
