using Microsoft.Data.SqlClient;
using StudentAccomodation.Models;

namespace StudentAccomodation.Services.ADOServices.ADOApartmentServices
{
    public class ADOApartment
    {
        private string _connectionString;
        private IConfiguration _configuration;

        public ADOApartment(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("IamConnector");      
        }
        


        public List<Apartment> DisplayAllapartments()
        {
            List<Apartment> apartmentsz = new List<Apartment>();
            string query = "select *  from Appartment";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Apartment apartments = new Apartment();
                        apartments.Appart_No = Convert.ToInt32(reader[0]);
                        apartments.Address = Convert.ToString(reader[1]);
                        apartments.Types = Convert.ToChar(reader[2]);
                        apartmentsz.Add(apartments);
                    }
                }
                return apartmentsz;
            }
        }
    }
}
