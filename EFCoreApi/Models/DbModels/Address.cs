namespace EFCoreApi.Models.DbModels
{
    public class Address
    {
        [SwaggerIgnore]
        public int Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Pincode { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        [SwaggerIgnore]
        public User User { get; set; }
        [SwaggerIgnore]
        public Seller Seller { get; set; }
    }
}
