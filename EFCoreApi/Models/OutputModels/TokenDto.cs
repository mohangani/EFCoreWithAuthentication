using System;

namespace EFCoreApi.Models.OutputModels
{
    public class TokenDto
    {
        public string Name { get; set; }
        public string Role { get; set; }
        public string Token { get; set; }
        public DateTime ExpirationDate { get; set; }
        public double ExpirationInMs { get; set; }
    }
}
