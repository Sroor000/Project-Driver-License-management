using Project_Driver_License_management;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Acess_Data_Layer
{



    public class ClsPeopleAccessData
    {
        private static void AddParameters(SqlCommand cmd, PeopleDTO dto)
        {
            cmd.Parameters.AddWithValue("@FirstName", dto.FirstName);
            cmd.Parameters.AddWithValue("@SecondName", dto.SecondName);
            cmd.Parameters.AddWithValue("@ThirdName", dto.ThirdName);
            cmd.Parameters.AddWithValue("@LastName", dto.LastName);
            cmd.Parameters.AddWithValue("@NationalNo", dto.NationalNo);
            cmd.Parameters.AddWithValue("@DateOfBirth", dto.DateOfBirth);
            cmd.Parameters.AddWithValue("@Gender", dto.Gender);
            cmd.Parameters.AddWithValue("@Phone", dto.Phone);
            cmd.Parameters.AddWithValue("@Country", dto.Country);
            cmd.Parameters.AddWithValue("@Address", dto.Address);
            cmd.Parameters.AddWithValue("@Email", dto.Email);
            cmd.Parameters.AddWithValue("@ImagePath", dto.ImagePath);
        }

        private static PeopleDTO MapReaderToPeopleDTO(SqlDataReader reader)
        {
            return new PeopleDTO()
            {
                PersonID = (int)reader["PersonID"],
                FirstName = reader["FirstName"].ToString(),
                SecondName = reader["SecondName"].ToString(),
                ThirdName = reader["ThirdName"].ToString(),
                LastName = reader["LastName"].ToString(),
                NationalNo = reader["NationalNo"].ToString(),
                DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]),
                Gender = reader["Gender"].ToString(),
                Phone = reader["Phone"].ToString(),
                Country = reader["NationalityCountryID"].ToString(),
                Address = reader["Address"].ToString(),
                Email = reader["Email"].ToString(),
                ImagePath = reader["ImagePath"].ToString()
            };
        }
        public static PeopleDTO GetPersonById(int personId)
        {
            PeopleDTO dto = null;

            string query = "SELECT * FROM People WHERE PersonID = @PersonID";

            using (SqlConnection con = DatabaseConnection.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@PersonID", personId);

                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        dto = MapReaderToPeopleDTO(reader);
                    }
                }
            }

            return dto;
        }
        public static bool UpdatePerson(PeopleDTO dto)
        {
            string query = @"
        UPDATE People SET
            FirstName = @FirstName,
            SecondName = @SecondName,
            ThirdName = @ThirdName,
            LastName = @LastName,
            NationalNo = @NationalNo,
            DateOfBirth = @DateOfBirth,
            Gender = @Gender,
            Phone = @Phone,
            NationalityCountryID = @Country,
            Address = @Address,
            Email = @Email,
            ImagePath = @ImagePath
        WHERE PersonID = @PersonID
    ";

            using (SqlConnection con = DatabaseConnection.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                AddParameters(cmd, dto);
                cmd.Parameters.AddWithValue("@PersonID", dto.PersonID);

                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
        public static bool InsertPerson(PeopleDTO dto)
        {


            string query = @"
        INSERT INTO People 
        (FirstName, SecondName, ThirdName, LastName, NationalNo,
         DateOfBirth, Gender, Phone, NationalityCountryID, Address, Email, ImagePath)
        VALUES 
        (@FirstName, @SecondName, @ThirdName, @LastName, @NationalNo,
         @DateOfBirth, @Gender, @Phone, @Country, @Address, @Email, @ImagePath)
    ";

            using (SqlConnection con = DatabaseConnection.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                AddParameters(cmd, dto);

                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
        public static PeopleDTO GetPersonByNationalNo(string nationalNo)
        {
            PeopleDTO dto = null;

            string query = "SELECT * FROM People WHERE NationalNo = @NationalNo";

            using (SqlConnection con = DatabaseConnection.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@NationalNo", nationalNo);

                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        dto = MapReaderToPeopleDTO(reader);
                    }
                }
            }

            return dto;
        }

        public static bool DeletePersonData(int PersonID)
        {
            
            
                string query = "delete from People where PersonID=@PersonID";
            using (SqlConnection con = DatabaseConnection.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                try
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@PersonID", PersonID);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception e) {   throw new Exception(e.Message); }
                finally { con.Close(); }
            }
            
            
           
        }

    }
}
