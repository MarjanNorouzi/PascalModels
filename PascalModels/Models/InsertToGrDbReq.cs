using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalModels.Models
{
    public class InsertToGrDbReq
    {
        public string GrCode { get; set; }
        public string GrName { get; set; }
        public int Grkind { get; set; }

    }
}
