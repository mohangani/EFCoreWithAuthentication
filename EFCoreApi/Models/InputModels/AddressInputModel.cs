﻿namespace EFCoreApi.Models.InputModels
{
    public class AddressInputModel
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Pincode { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

    }
}
