using Microsoft.Data.SqlClient;
using StudentAccomodation.Models;

namespace StudentAccomodation.Services.ADOServices.ADODormitoryServices
{
    public class ADODormitory
    {
        private string _connectionString;
        private IConfiguration _configuration;

        public ADODormitory(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("IamConnector");
        }



        public List<Dormitoty> DisplayAllDormitories()
        {
            List<Dormitoty> returner = new List<Dormitoty>();
            string query = "select *  from Dormitory";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Dormitoty dormitories = new Dormitoty();
                        dormitories.Dormitory_No = Convert.ToInt32(reader[0]);
                        dormitories.Name = Convert.ToString(reader[1]);
                        dormitories.Address = Convert.ToString(reader[2]);
                        returner.Add(dormitories);
                    }
                }
                return returner;
            }
        }
    }
}
