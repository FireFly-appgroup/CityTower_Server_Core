﻿using System;
using System.Collections.Generic;

namespace CityTowerServer.DAL.Models
{
    public partial class AspNetRoles
    {
        public AspNetRoles()
        {
            AspNetUserRoles = new HashSet<AspNetUserRoles>();
        }

        public string Id { get; set; }
        public string Name { get; set; }

        public ICollection<AspNetUserRoles> AspNetUserRoles { get; set; }
    }
}
