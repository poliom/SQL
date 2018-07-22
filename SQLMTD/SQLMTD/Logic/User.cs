using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLMTD.Data.Info;
using SQLMTD.Data.DB;

namespace SQLMTD.Logic
{
    public class User
    {
        private UserInfo _UserInfo;

        public User()
        {
            this._UserInfo = new UserInfo();
        }

        public User(string username)
        {
            this._UserInfo = DatabaseManager.UserSelectByUsername(username);

            if (this._UserInfo == null)
            {
                this._UserInfo = new UserInfo();
            }
        }

        public Nullable<int> Id
        {
            get
            {
                return this._UserInfo.Id;
            }
            set
            {
                this._UserInfo.Id = value;
            }
        }

        public string Username
        {
            get
            {
                return this._UserInfo.Username;
            }
            set
            {
                this._UserInfo.Username = value;
            }
        }

        public string Password
        {
            get
            {
                return this._UserInfo.Password;
            }
            set
            {
                this._UserInfo.Password = Login.LoginManager.GetHash(value);
            }
        }

        public string FirstName
        {
            get
            {
                return this._UserInfo.FirstName;
            }
            set
            {
                this._UserInfo.FirstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this._UserInfo.LastName;
            }
            set
            {
                this._UserInfo.LastName = value;
            }
        }

        public UserRole Role
        {
            get
            {
                return this._UserInfo.Role;
            }
            set
            {
                this._UserInfo.Role = value;
            }
        }

        public UserStatus Status
        {
            get
            {
                return this._UserInfo.Status;
            }
            set
            {
                this._UserInfo.Status = value;
            }
        }

        public CityInfo City
        {
            get
            {
                if (string.IsNullOrEmpty(this._UserInfo.City.RegistrationCode))
                {
                    return DatabaseManager.CitySelectById(this._UserInfo.CityId);
                }

                return this._UserInfo.City;
            }
        }

        public void Create()
        {
            this._UserInfo.Id = DatabaseManager.UserInsert(this._UserInfo);
        }
    }
}
