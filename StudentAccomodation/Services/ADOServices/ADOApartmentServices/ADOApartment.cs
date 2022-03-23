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
            _connectionString = configuration.GetConnectionString("IamConnector");      
        }
        Apartment apartment1 = new Apartment();


        public List<Apartment> DisplayAllapartments()
        {
            List<Apartment> apartments = new List<Apartment>();
            string query = "select *  from Apartment";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Apartment apartment = new Apartment();
                        apartment.Appart_No = Convert.ToInt32(reader[0]);
                        apartment.Address = Convert.ToString(reader[1]);
                        apartment.Types = Convert.ToChar(reader[1]);
                        apartments.Add(apartment);
                    }
                }
                return apartments;
            }
        }
    }
}
