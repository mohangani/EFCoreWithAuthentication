using EFCoreApi.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreApi.Models.DbModels
{
    public class Book : IDbModel
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public BookDetail BookDetails { get; set; }
        public int BookDetails_Id { get; set; }

    }
}
