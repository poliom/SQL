using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLMTD.Data.DB;
using SQLMTD.Data.Info;

namespace SQLMTD.Logic
{
    public class Owner
    {
        private OwnerInfo _OwnerInfo;
        private List<Vehicle> _Vehicles;

        public Owner()
        {
            this._OwnerInfo = new OwnerInfo();
        }

        public Owner(string ucn)
        {
            this._OwnerInfo = DatabaseManager.OwnerSelectByUCN(ucn);
        }

        public Owner(OwnerInfo info)
        {
            if (info == null)
            {
                throw new ArgumentNullException("info");
            }

            this._OwnerInfo = info;
        }

        public Nullable<int> Id
        {
            get
            {
                return this._OwnerInfo.Id;
            }
            set
            {
                this._OwnerInfo.Id = value;
            }
        }

        public string FirstName
        {
            get
            {
                return this._OwnerInfo.FirstName;
            }
            set
            {
                this._OwnerInfo.FirstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this._OwnerInfo.LastName;
            }
            set
            {
                this._OwnerInfo.LastName = value;
            }
        }

        public string UniformCivilNumber
        {
            get
            {
                return this._OwnerInfo.UniformCivilNumber;
            }
            set
            {
                this._OwnerInfo.UniformCivilNumber = value;
            }
        }

        public string Address
        {
            get
            {
                return this._OwnerInfo.Address;
            }
            set
            {
                this._OwnerInfo.Address = value;
            }
        }

        public DateTime BirthDate
        {
            get
            {
                return this._OwnerInfo.BirthDate;
            }
            set
            {
                this._OwnerInfo.BirthDate = value;
            }
        }

        public List<Vehicle> Vehicles
        {
            get
            {
                if (this._Vehicles == null)
                {
                    List<VehicleInfo> infos = new List<VehicleInfo>(this._OwnerInfo.Vehicles);
                    this._Vehicles = infos.ConvertAll<Vehicle>(v => new Vehicle(v));
                }

                return this._Vehicles;
            }
            set
            {
                this._Vehicles = value;
            }
        }

        public OwnerInfo GetInfoObject()
        {
            return this._OwnerInfo;
        }

        public void Create()
        {
            this.Id = DatabaseManager.OwnerInsert(this._OwnerInfo);
        }

        public void AddVehicle(Vehicle item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }

            item.Owner = this;
            item.Create();
            List<Vehicle> list = this.Vehicles;
            list.Add(item);
            this.Vehicles = list;
        }

        public void UpdateAddress(string address)
        {
            DatabaseManager.OwnerUpdateAddress(address, this.Id.Value);
        }

        public static bool CheckUcnExists(string ucn)
        {
            return DatabaseManager.OwnerCheckExists(ucn);
        }
    }
}
