using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreApi.Models.DbModels
{
    public class Size
    {
        public int Id { get; set; }
        public float? Width { get; set; }
        public float? Height { get; set; }
        public int ProductSize { get; set; }
    }


}
