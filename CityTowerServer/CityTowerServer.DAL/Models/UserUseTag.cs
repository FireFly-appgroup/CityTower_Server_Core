﻿using System;
using System.Collections.Generic;

namespace CityTowerServer.DAL.Models
{
    public partial class UserUseTag
    {
        public int TagId { get; set; }
        public int Uid { get; set; }

        public TagList Tag { get; set; }
    }
}
