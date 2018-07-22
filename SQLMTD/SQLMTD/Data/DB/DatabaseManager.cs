using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using SQLMTD.Data.Info;
using System.Data.SqlClient;
using System.Data;

namespace SQLMTD.Data.DB
{
    public static class DatabaseManager
    {
        private static readonly string _ConnectionString = ConfigurationManager.ConnectionStrings["SQLMTDConnectionString"].ToString();

        #region User

        private static void FillUserInfo(UserInfo info, SqlDataReader reader)
        {
            if (info == null)
            {
                throw new ArgumentNullException("info");
            }

            if (reader == null)
            {
                throw new ArgumentNullException("reader");
            }

            info.Id = (int)reader["Id"];
            info.Username = reader["Username"].ToString();
            info.Password = reader["Password"].ToString();
            info.FirstName = reader["FirstName"].ToString();
            info.LastName = reader["LastName"].ToString();
            info.Role = (UserRole)((int)reader["Role"]);
            info.Status = UserStatus.Active;
            info.CityId = (int)reader["CityId"];
        }

        public static UserInfo UserSelectByUsernameAndPassword(string username, string password)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            SqlTransaction transaction = null;

            UserInfo info = null;

            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "[dbo].[UserSelectByUsernameAndPassword]";
            command.Parameters.Add(new SqlParameter("@Username", username));
            command.Parameters.Add(new SqlParameter("@Password", password));

            try
            {
                connection.Open();

                transaction = connection.BeginTransaction();

                command.Transaction = transaction;

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    info = new UserInfo();
                    FillUserInfo(info, reader);
                }

                reader.Close();

                info.City = CitySelectById(info.CityId, transaction, connection);

                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }

            return info;
        }

        public static UserInfo UserSelectByUsername(string username)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();

            UserInfo info = null;

            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "[dbo].[UserSelectByUsername]";
            command.Parameters.Add(new SqlParameter("@Username", username));

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    info = new UserInfo();
                    FillUserInfo(info, reader);
                }
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }

            return info;
        }

        public static int UserInsert(UserInfo info)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();

            int result;

            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "[dbo].[UserInsert]";
            command.Parameters.Add(new SqlParameter("@Username", info.Username));
            command.Parameters.Add(new SqlParameter("@Password", info.Password));
            command.Parameters.Add(new SqlParameter("@FirstName", info.FirstName));
            command.Parameters.Add(new SqlParameter("@LastName", info.LastName));
            command.Parameters.Add(new SqlParameter("@Role", (int)info.Role));
            command.Parameters.Add(new SqlParameter("@Status", (int)info.Status));

            try
            {
                connection.Open();
                result = Convert.ToInt32(command.ExecuteScalar());
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }

            return result;
        }

        public static CityInfo CitySelectById(int cityId, SqlTransaction transaction, SqlConnection connection)
        {
            if (transaction == null)
            {
                throw new ArgumentNullException("transaction");
            }

            //SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();

            CityInfo result = null;

            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "[dbo].[CitySelect]";
            command.Parameters.Add(new SqlParameter("@CityId", cityId));
            command.Transaction = transaction;

            try
            {
                //connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    result = new CityInfo();
                    result.Id = (int)reader["Id"];
                    result.Name = reader["Name"].ToString();
                    result.RegistrationCode = reader["RegistrationCode"].ToString();
                }

                reader.Close();
            }
            finally
            {
                if (connection != null)
                {
                    //connection.Close();
                }
            }

            return result;
        }

        public static CityInfo CitySelectById(int cityId)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();

            CityInfo result = null;

            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "[dbo].[CitySelect]";
            command.Parameters.Add(new SqlParameter("@CityId", cityId));

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    result = new CityInfo();
                    result.Id = (int)reader["Id"];
                    result.Name = reader["Name"].ToString();
                    result.RegistrationCode = reader["RegistrationCode"].ToString();
                }
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }

            return result;
        }

        #endregion

        #region Owner

        private static void FillOwnerInfo(OwnerInfo info, SqlDataReader reader)
        {
            if (info == null)
            {
                throw new ArgumentNullException("info");
            }

            if (reader == null)
            {
                throw new ArgumentNullException("reader");
            }

            info.Id = (int)reader["OwnerId"];
            info.FirstName = reader["FirstName"].ToString();
            info.LastName = reader["LastName"].ToString();
            info.UniformCivilNumber = reader["UniformCivilNumber"].ToString();
            info.Address = reader["Address"].ToString();
            info.BirthDate = (DateTime)reader["BirthDate"];
        }

        private static void FillVehicleInfo(VehicleInfo info, SqlDataReader reader)
        {
            if (info == null)
            {
                throw new ArgumentNullException("info");
            }

            if (reader == null)
            {
                throw new ArgumentNullException("reader");
            }

            info.Id = (int)reader["Id"];
            info.Manifacture = reader["ManifactureName"].ToString();
            info.Model = reader["ModelName"].ToString();
            info.RegistrationNumber = reader["RegistrationNumber"].ToString();
            info.VinNumber = reader["VinNumber"].ToString();
            info.EngineNumber = reader["EngineNumber"].ToString();
            info.EnginePower = (int)reader["EnginePower"];
            info.EngineValume = (int)reader["EngineValume"];
            info.FirstRegistrationDate = (DateTime)reader["FirstRegistrationDate"];
            info.RegistrationDate = (DateTime)reader["RegistrationDate"];
            info.Type = (VehicleType)((int)reader["Type"]);
        }

        public static OwnerInfo OwnerSelectByUCN(string UCN)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();

            SqlDataReader reader = null;

            OwnerInfo info = null;
            VehicleInfo vInfo = null;
            List<VehicleInfo> infos = new List<VehicleInfo>();

            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "[dbo].[OwnerSelectByUCN]";
            command.Parameters.Add(new SqlParameter("@UCN", UCN));

            try
            {
                connection.Open();
                reader = command.ExecuteReader();
                bool isFirst = true;
                while (reader.Read())
                {
                    if (isFirst)
                    {
                        info = new OwnerInfo();
                        FillOwnerInfo(info, reader);
                        isFirst = false;
                    }

                    if (reader.IsDBNull(reader.GetOrdinal("Id")))
                    {
                        break;
                    }

                    vInfo = new VehicleInfo();
                    FillVehicleInfo(vInfo, reader);
                    vInfo.Owner = info;
                    infos.Add(vInfo);
                }

                if (info != null)
                {
                    info.Vehicles = infos;
                }
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }

            return info;
        }

        public static int OwnerInsert(OwnerInfo info)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();

            int result;

            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "[dbo].[OwnerInsert]";
            command.Parameters.Add(new SqlParameter("@FirstName", info.FirstName));
            command.Parameters.Add(new SqlParameter("@LastName", info.LastName));
            command.Parameters.Add(new SqlParameter("@UniformCivilNumber", info.UniformCivilNumber));
            command.Parameters.Add(new SqlParameter("@Address", info.Address));
            command.Parameters.Add(new SqlParameter("@BirthDate", info.BirthDate));

            try
            {
                connection.Open();
                result = Convert.ToInt32(command.ExecuteScalar());
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }

            return result;
        }

        public static void OwnerUpdateAddress(string address, int ownerId)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "[dbo].[OwnerUpdateAddress]";
            command.Parameters.Add(new SqlParameter("@Address", address));
            command.Parameters.Add(new SqlParameter("@OwnerId", ownerId));

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        public static bool OwnerCheckExists(string UCN)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();

            bool result = false;

            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "[dbo].[CheckUniformCivilNumberExists]";
            command.Parameters.Add(new SqlParameter("@UniformCivilNumber", UCN));

            try
            {
                connection.Open();
                int count = Convert.ToInt32(command.ExecuteScalar());

                if (count == 1)
                {
                    result = true;
                }
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }

            return result;
        }

        #endregion

        #region Vehicle

        public static VehicleInfo VehicleSelectByRegistrationNumber(string registrationNumber)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();

            VehicleInfo info = null;

            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "[dbo].[VehicleSelectByRegistrationNumber]";
            command.Parameters.Add(new SqlParameter("@RegistrationNumber", registrationNumber));

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    info = new VehicleInfo();
                    FillVehicleInfo(info, reader);

                    info.Owner = new OwnerInfo();
                    FillOwnerInfo(info.Owner, reader);
                }
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }

            return info;
        }

        public static VehicleInfo VehicleSelectByVinNumber(string vinNumber)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();

            VehicleInfo info = null;

            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "[dbo].[VehicleSelectByVinNumber]";
            command.Parameters.Add(new SqlParameter("@VinNumber", vinNumber));

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    info = new VehicleInfo();
                    FillVehicleInfo(info, reader);

                    info.Owner = new OwnerInfo();
                    FillOwnerInfo(info.Owner, reader);
                }
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }

            return info;
        }

        public static Dictionary<int, string> ManifacturesSelectAll()
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();

            Dictionary<int, string> result = new Dictionary<int,string>();

            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "[dbo].[ManifacturesSelectAll]";

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    result.Add((int)reader["Id"], reader["Name"].ToString());
                }
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }

            return result;
        }

        public static Dictionary<int, string> ModelsSelectByManifacture(string manifacture)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();

            Dictionary<int, string> result = new Dictionary<int, string>();

            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "[dbo].[ModelsSelectByManifacture]";
            command.Parameters.Add(new SqlParameter("@Manifacture", manifacture));

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    result.Add((int)reader["Id"], reader["Model"].ToString());
                }
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }

            return result;
        }

        public static int VehicleInsert(VehicleInfo info)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();

            int result;

            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "[dbo].[VehicleInsert]";
            command.Parameters.Add(new SqlParameter("@Manifacture", info.Manifacture));
            command.Parameters.Add(new SqlParameter("@Model", info.Model));
            command.Parameters.Add(new SqlParameter("@OwnerId", info.Owner.Id));
            command.Parameters.Add(new SqlParameter("@RegistrationNumber", info.RegistrationNumber));
            command.Parameters.Add(new SqlParameter("@VinNumber", info.VinNumber));
            if (!string.IsNullOrEmpty(info.EngineNumber))
            {
                command.Parameters.Add(new SqlParameter("@EngineNumber", info.EngineNumber));
            }
            else
            {
                command.Parameters.Add(new SqlParameter("@EngineNumber", DBNull.Value));
            }
            command.Parameters.Add(new SqlParameter("@EnginePower", info.EnginePower));
            command.Parameters.Add(new SqlParameter("@EngineValume", info.EngineValume));
            if (info.FirstRegistrationDate != DateTime.MinValue)
            {
                command.Parameters.Add(new SqlParameter("@FirstRegistrationDate", info.FirstRegistrationDate));
            }
            else
            {
                command.Parameters.Add(new SqlParameter("@FirstRegistrationDate", DBNull.Value));
            }
            command.Parameters.Add(new SqlParameter("@RegistrationDate", info.RegistrationDate));
            command.Parameters.Add(new SqlParameter("@Type", (int)info.Type));

            try
            {
                connection.Open();
                result = Convert.ToInt32(command.ExecuteScalar());
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }

            if (result == -1)
            {
                throw new SQLMTD.Data.Info.Exceptions.ManifactureNotFoundException();
            }

            if (result == -2)
            {
                throw new SQLMTD.Data.Info.Exceptions.ModelNotFoundException();
            }

            return result;
        }

        public static void VehicleDelete(int vehicleId)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "[dbo].[VehicleDelete]";

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        public static void VehicleUpdateOwner(int vehicleId, int newOwnerId)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "[dbo].[VehicleUpdateOwner]";
            command.Parameters.Add(new SqlParameter("@OwnerId", newOwnerId));
            command.Parameters.Add(new SqlParameter("@VehicleId", vehicleId));

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        public static string VehicleNumberSelectNew(string firstTwoCharacters)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();

            string result;

            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "[dbo].[SelectNewVehicleNumber]";
            command.Parameters.Add(new SqlParameter("@FirstTwoCharacters", firstTwoCharacters));

            try
            {
                connection.Open();
                result = (string)command.ExecuteScalar();
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }

            return result;
        }

        #endregion

        #region Statistics

        public static decimal AverageOwnerAgeSelect()
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();

            decimal result;

            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "[dbo].[OwnersAverageAgeSelect]";

            try
            {
                connection.Open();

                result = Convert.ToDecimal(command.ExecuteScalar());
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }

            return result;
        }

        public static int VehiclesCountSelect(VehicleType type)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();

            int result;

            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "[dbo].[VehiclesCountSelectByType]";
            command.Parameters.Add(new SqlParameter("@VehicleType", (int)type));

            try
            {
                connection.Open();
                result = Convert.ToInt32(command.ExecuteScalar());
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }

            return result;
        }

        public static DateTime VehiclesSelectAverageCreationDate(VehicleType type)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();

            DateTime result;

            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "[dbo].[VehicleSelectAverageYearOfCreationByType]";
            command.Parameters.Add(new SqlParameter("@VehicleType", (int)type));

            try
            {
                connection.Open();
                result = Convert.ToDateTime(command.ExecuteScalar());
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }

            return result;
        }

        public static decimal VehiclesSelectAverageAge(VehicleType type)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();

            decimal result;

            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "[dbo].[VehicleAverageAgeSelectByType]";
            command.Parameters.Add(new SqlParameter("@VehicleType", (int)type));

            try
            {
                connection.Open();
                result = Convert.ToDecimal(command.ExecuteScalar());
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }

            return result;
        }

        #endregion
    }
}
