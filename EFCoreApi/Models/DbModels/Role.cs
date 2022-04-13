﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreApi.Models.DbModels
{
    public class Role
    {
        public int Id { get; set; }
        public string RoleName { get; set; }

        public User User { get; set; }
    }
}
