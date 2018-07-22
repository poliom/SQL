using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLMTD.Data.Info
{
    public class UserInfo
    {
        public Nullable<int> Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public UserRole Role { get; set; }
        public UserStatus Status { get; set; }
        public int CityId { get; set; }

        public CityInfo City { get; set; }

        public UserInfo()
        {
            this.City = new CityInfo();
        }
    }
}
