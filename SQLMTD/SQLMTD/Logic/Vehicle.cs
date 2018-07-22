using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLMTD.Data.Info;
using SQLMTD.Data.DB;

namespace SQLMTD.Logic
{
    public class Vehicle
    {
        private VehicleInfo _VehicleInfo;
        private Owner _Owner;

        public Vehicle()
        {
            this._VehicleInfo = new VehicleInfo();
        }

        public Vehicle(string registrationOrVinNumber, VehicleSelectionType type)
        {
            if (type == VehicleSelectionType.RegistrationNumber)
            {
                this._VehicleInfo = DatabaseManager.VehicleSelectByRegistrationNumber(registrationOrVinNumber);
            }
            else
            {
                this._VehicleInfo = DatabaseManager.VehicleSelectByVinNumber(registrationOrVinNumber);
            }
        }

        public Vehicle(VehicleInfo info)
        {
            if (info == null)
            {
                throw new ArgumentNullException("info");
            }

            this._VehicleInfo = info;
        }

        public Nullable<int> Id
        {
            get
            {
                return this._VehicleInfo.Id;
            }
            set
            {
                this._VehicleInfo.Id = value;
            }
        }

        public string Manifacture
        {
            get
            {
                return this._VehicleInfo.Manifacture;
            }
            set
            {
                this._VehicleInfo.Manifacture = value;
            }
        }

        public string Model
        {
            get
            {
                return this._VehicleInfo.Model;
            }
            set
            {
                this._VehicleInfo.Model = value;
            }
        }

        public string RegistrationNumber
        {
            get
            {
                return this._VehicleInfo.RegistrationNumber;
            }
            set
            {
                this._VehicleInfo.RegistrationNumber = value;
            }
        }

        public string VinNumber
        {
            get
            {
                return this._VehicleInfo.VinNumber;
            }
            set
            {
                this._VehicleInfo.VinNumber = value;
            }
        }

        public string EngineNumber
        {
            get
            {
                return this._VehicleInfo.EngineNumber;
            }
            set
            {
                this._VehicleInfo.EngineNumber = value;
            }
        }

        public int EnginePower
        {
            get
            {
                return this._VehicleInfo.EnginePower;
            }
            set
            {
                this._VehicleInfo.EnginePower = value;
            }
        }

        public int EngineValume
        {
            get
            {
                return this._VehicleInfo.EngineValume;
            }
            set
            {
                this._VehicleInfo.EngineValume = value;
            }
        }

        public DateTime FirstRegistrationDate
        {
            get
            {
                return this._VehicleInfo.FirstRegistrationDate;
            }
            set
            {
                this._VehicleInfo.FirstRegistrationDate = value;
            }
        }

        public DateTime RegistrationDate
        {
            get
            {
                return this._VehicleInfo.RegistrationDate;
            }
            set
            {
                this._VehicleInfo.RegistrationDate = value;
            }
        }

        public VehicleType Type
        {
            get
            {
                return this._VehicleInfo.Type;
            }
            set
            {
                this._VehicleInfo.Type = value;
            }
        }

        public Owner Owner
        {
            get
            {
                if (this._Owner == null)
                {
                    this._Owner = new Owner(this._VehicleInfo.Owner);
                }

                return this._Owner;
            }
            set
            {
                if (value != null)
                {
                    this._Owner = value;
                    this._VehicleInfo.Owner = value.GetInfoObject();
                }
                else
                {
                    throw new ArgumentNullException("Owner");
                }
            }
        }

        public bool VehicleExists
        {
            get
            {
                return this._VehicleInfo != null;
            }
        }

        public void Create()
        {
            this._VehicleInfo.Id = DatabaseManager.VehicleInsert(this._VehicleInfo);
        }

        public void UpdateOwner(int ownerId)
        {
            DatabaseManager.VehicleUpdateOwner(this.Id.Value, ownerId);
        }

        public void Delete()
        {
            DatabaseManager.VehicleDelete(this.Id.Value);
        }

        public static string GenerateNewRegistrationNumber(string firstTwoCharacters)
        {
            return DatabaseManager.VehicleNumberSelectNew(firstTwoCharacters);
        }
    }
}
