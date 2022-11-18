using System.Text.Json.Serialization;

namespace EFCoreApi.Models.DbModels
{
    public class Image
    {

        [JsonIgnore]
        public int Id { get; set; }
        public string Url { get; set; }
        public string Type { get; set; }
        [JsonIgnore]
        public Product Product { get; set; }


    }
}
