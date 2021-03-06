﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLMTD.Data.Info
{
    public class OwnerInfo
    {
        public Nullable<int> Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UniformCivilNumber { get; set; }
        public string Address { get; set; }
        public DateTime BirthDate { get; set; }

        public IEnumerable<VehicleInfo> Vehicles { get; set; }
    }
}
