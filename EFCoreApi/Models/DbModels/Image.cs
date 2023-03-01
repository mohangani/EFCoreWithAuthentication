namespace EFCoreApi.Models.DbModels
{
    public class Image
    {

        [SwaggerIgnore]
        public int Id { get; set; }
        public string Url { get; set; }
        public string Type { get; set; }
        [SwaggerIgnore]
        public Product Product { get; set; }


    }
}
