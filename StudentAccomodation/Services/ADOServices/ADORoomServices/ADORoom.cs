using Microsoft.Data.SqlClient;
using StudentAccomodation.Models;

namespace StudentAccomodation.Services.ADOServices.ADORoomServices
{
    public class ADORoom
    {
        private string _connectionString;
        private IConfiguration _configuration;

        public ADORoom(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("IamConnector");
        }



        public List<Room> DisplayAllRoooms()
        {
            List<Room> returner = new List<Room>();
            string query = "select *  from Room";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Room room = new Room();
                        room.Place_No = Convert.ToInt32(reader[0]);
                        room.Rent_Per_Semester = Convert.ToInt32(reader[1]);
                        room.Occupied = Convert.ToBoolean(reader[2]);
                        room.Room_No = Convert.ToInt32(reader[3]);
                        if (reader[4] is DBNull) { room.Dormitory_No = -1; } else { room.Dormitory_No = Convert.ToInt32(reader[4]); }
                        if (reader[5]  is DBNull) { room.Appart_No = -1; } else {  room.Appart_No = Convert.ToInt32(reader[5]); }
                        
                       
                        returner.Add(room);
                    }
                }
                return returner;
            }
        }
        public List<Room> DisplayVacantRooms(int id, string type )
        {
            List<Room> returner = new List<Room>();
            string query;

            if (type == "Apartment")
            { 
                 query = $"select * from Room where Appart_No = {id} and Occupied = 0";
            }
            else
            {
                 query = $"select * from Room where Dormitory_No = {id} and Occupied = 0";
            }

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Room room = new Room();
                        room.Place_No = Convert.ToInt32(reader[0]);
                        room.Rent_Per_Semester = Convert.ToInt32(reader[1]);
                        room.Occupied = Convert.ToBoolean(reader[2]);
                        room.Room_No = Convert.ToInt32(reader[3]);
                        if (reader[4] is DBNull) { room.Dormitory_No = -1; } else { room.Dormitory_No = Convert.ToInt32(reader[4]); }
                        if (reader[5] is DBNull) { room.Appart_No = -1; } else { room.Appart_No = Convert.ToInt32(reader[5]); }


                        returner.Add(room);
                    }
                }
                return returner;
            }
        }
    }
}
