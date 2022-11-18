using EFCoreApi.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EFCoreApi.Models.DbModels
{
    public class Book : IDbModel
    {
        [JsonIgnore]
        public int Id { get; set; }
        public string Name { get; set; }
        [JsonIgnore]
        public BookDetail BookDetails { get; set; }
        public int BookDetails_Id { get; set; }

    }
}
