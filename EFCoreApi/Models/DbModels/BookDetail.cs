using EFCoreApi.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EFCoreApi.Models.DbModels
{
    public class BookDetail :IDbModel
    {
        [JsonIgnore]
        public int Id { get; set; }
        public string Description { get; set; }
        [JsonIgnore]
        public Book Book { get; set; }
    }
}
