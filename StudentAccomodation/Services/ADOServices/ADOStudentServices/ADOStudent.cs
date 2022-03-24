using Microsoft.Data.SqlClient;
using StudentAccomodation.Models;

namespace StudentAccomodation.Services.ADOServices.ADOStudentServices
{
    public class ADOStudent
    {
        private string _connectionString;
        private IConfiguration _configuration;

        public ADOStudent(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("IamConnector");
        }



        public List<Student> DisplayAllStudents()
        {
            List<Student> returner = new List<Student>();
            string query = "select *  from Student";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Student student= new Student();
                        student.Student_No = Convert.ToInt32(reader[0]);
                        student.SName = Convert.ToString(reader[1]);
                        student.SAddress = Convert.ToString(reader[2]);
                        student.Has_Room = Convert.ToBoolean(reader[3]);
                        student.Registration_Date = Convert.ToDateTime(reader[4]);
                        

                        returner.Add(student);
                    }
                }
                return returner;
            }
        }
    }
}
