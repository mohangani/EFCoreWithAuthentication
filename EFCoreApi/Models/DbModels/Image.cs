﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreApi.Models.DbModels
{
    public class Image
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Type { get; set; }
    }
}
