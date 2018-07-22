using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLMTD.Data.Info
{
    public class VehicleInfo
    {
        public Nullable<int> Id { get; set; }
        public string Manifacture { get; set; }
        public string Model { get; set; }
        public string RegistrationNumber { get; set; }
        public string VinNumber { get; set; }
        public string EngineNumber { get; set; }
        public int EnginePower { get; set; }
        public int EngineValume { get; set; }
        public DateTime FirstRegistrationDate { get; set; }
        public DateTime RegistrationDate { get; set; }
        public VehicleType Type { get; set; }

        public OwnerInfo Owner { get; set; }

        public VehicleInfo()
        {
            //this.Owner = new OwnerInfo();
        }
    }
}
