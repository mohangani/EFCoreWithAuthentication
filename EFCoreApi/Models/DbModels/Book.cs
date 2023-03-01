using EFCoreApi.Controllers;

namespace EFCoreApi.Models.DbModels
{
    public class Book : IDbModel
    {
        [SwaggerIgnore]
        public int Id { get; set; }
        public string Name { get; set; }
        [SwaggerIgnore]
        public BookDetail BookDetails { get; set; }
        public int BookDetails_Id { get; set; }

    }
}
