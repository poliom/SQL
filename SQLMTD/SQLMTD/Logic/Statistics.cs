using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLMTD.Data.DB;
using SQLMTD.Data.Info;

namespace SQLMTD.Logic
{
    public static class Statistics
    {
        public static decimal GetAverageOwnersAge()
        {
            return DatabaseManager.AverageOwnerAgeSelect();
        }

        public static int GetVehiclesCountByType(VehicleType type)
        {
            return DatabaseManager.VehiclesCountSelect(type);
        }

        public static DateTime GetAverageVehiclesCreationDate(VehicleType type)
        {
            return DatabaseManager.VehiclesSelectAverageCreationDate(type);
        }

        public static decimal GetAverageVehiclesAge(VehicleType type)
        {
            return DatabaseManager.VehiclesSelectAverageAge(type);
        }
    }
}
