﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalModels.Models.BaseModels
{
    public record ItemsDeleteReq
    {
        public IEnumerable<int> Ids { get; set; }
    }
}
