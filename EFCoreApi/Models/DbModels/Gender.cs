using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreApi.Models.DbModels
{
    public class Gender
    {
        public GenderType GenderId { get; set; }
        public string  GenderName { get; set; }
    }
    public enum GenderType : int
    {
        Male = 1,
        Female = 2,
        TransGenderMale=3,
        TransGenderFemale=4,
        Hizra = 5,
    }
}
