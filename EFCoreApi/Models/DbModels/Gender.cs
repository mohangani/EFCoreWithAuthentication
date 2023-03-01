﻿using EFCoreApi.Data_Seed;

namespace EFCoreApi.Models.DbModels
{
    public class Gender : DataSeedEnumClass<GenderType>
    {
        //public GenderType GenderId { get; set; }
        //public string  GenderName { get; set; }
    }
    public enum GenderType : int
    {
        Male = 1,
        Female = 2,
        TransGenderMale = 3,
        TransGenderFemale = 4,
        Hizra = 5,
    }
}
