using EFCoreApi.Controllers;

namespace EFCoreApi.Models.DbModels
{
    public class Cart : IDbModel
    {
        [SwaggerIgnore]
        public int Id { get; set; }

        public int UserId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        [SwaggerIgnore]
        public User User { get; set; }
        [SwaggerIgnore]
        public Product Product { get; set; }

    }
}
