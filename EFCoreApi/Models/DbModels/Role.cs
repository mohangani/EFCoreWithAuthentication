namespace EFCoreApi.Models.DbModels
{
    public class Role
    {
        [SwaggerIgnore]
        public int Id { get; set; }
        public string RoleName { get; set; }

        [SwaggerIgnore]
        public User User { get; set; }
    }
}
