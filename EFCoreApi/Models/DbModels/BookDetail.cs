using EFCoreApi.Controllers;

namespace EFCoreApi.Models.DbModels
{
    public class BookDetail : IDbModel
    {
        [SwaggerIgnore]
        public int Id { get; set; }
        public string Description { get; set; }
        [SwaggerIgnore]
        public Book Book { get; set; }
    }
}
