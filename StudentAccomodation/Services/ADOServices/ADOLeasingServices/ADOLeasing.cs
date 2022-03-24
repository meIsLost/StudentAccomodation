using Microsoft.Data.SqlClient;
using StudentAccomodation.Models;

namespace StudentAccomodation.Services.ADOServices.ADOLeasingServices
{
    public class ADOLeasing
    {
        private string _connectionString;
        private IConfiguration _configuration;

        public ADOLeasing(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("IamConnector");
        }



        public List<Leasing> DisplayAllLeasings()
        {
            List<Leasing> returner = new List<Leasing>();
            string query = $"select *  from Leasing";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Leasing leasing= new Leasing();
                        leasing.Leasing_No = Convert.ToInt32(reader[0]);
                        leasing.Student_No = Convert.ToInt32(reader[1]);
                        leasing.Place_No = Convert.ToInt32(reader[2]);
                        leasing.Date_From = Convert.ToDateTime(reader[3]);
                        leasing.Date_To= Convert.ToDateTime(reader[4]);
                        returner.Add(leasing);
                    }
                }
                return returner;
            }
        }
    }
}
