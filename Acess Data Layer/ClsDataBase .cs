
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
 
using static System.Net.Mime.MediaTypeNames;


namespace Project_Driver_License_management
{
    public class ClsDataBase
    {
        public static string Str_Connection = "Server=.;DataBase=DVLD;User ID=sa;Password=123456;";
        public static SqlConnection con = new SqlConnection(Str_Connection);
        public static bool Get_PeopleData_ByID(
        int PersonID, ref string FristName, ref string SecondName, ref string ThirdName,
       ref string LastName, ref string National_No, ref DateTime BirthofDate, ref string Gender,
       ref string Phone, ref string country, ref string Adress, ref string Email,
       ref string ImagePath)
        {
            bool isFound = false;
            string query = "SELECT * FROM People WHERE PersonID = @PersonID";


            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@PersonID", PersonID);

                try
                {
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            isFound = true;
                            FristName = reader["FirstName"].ToString();
                            SecondName = reader["SecondName"].ToString();
                            ThirdName = reader["ThirdName"].ToString();
                            LastName = reader["LastName"].ToString();
                            National_No = reader["NationalNo"].ToString();
                            BirthofDate = Convert.ToDateTime(reader["DateOfBirth"]);
                            Gender = reader["Gender"].ToString();
                            Phone = reader["Phone"].ToString();
                            country = reader["NationalityCountryID"].ToString();
                            Adress = reader["Address"].ToString();
                            Email = reader["Email"].ToString();
                            ImagePath = reader["ImagePath"].ToString();
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                finally
                {

                    con.Close();
                }
            }

            return isFound;
        }
        public static bool Get_PeopleData_ByNationalNo(
     ref int PersonID, ref string FristName, ref string SecondName, ref string ThirdName,
     ref string LastName, ref string National_No, ref DateTime BirthofDate, ref string Gender,
     ref string Phone, ref string country, ref string Adress, ref string Email,
     ref string ImagePath)
        {
            bool isFound = false;
            string query = "SELECT * FROM People WHERE NationalNo = @NationalNO";


            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@NationalNo", National_No);

                try
                {
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            isFound = true;
                            PersonID = int.Parse(reader["PersonID"].ToString());
                            FristName = reader["FirstName"].ToString();
                            SecondName = reader["SecondName"].ToString();
                            ThirdName = reader["ThirdName"].ToString();
                            LastName = reader["LastName"].ToString();
                            National_No = reader["NationalNo"].ToString();
                            BirthofDate = Convert.ToDateTime(reader["DateOfBirth"]);
                            Gender = reader["Gender"].ToString();
                            Phone = reader["Phone"].ToString();
                            country = reader["NationalityCountryID"].ToString();
                            Adress = reader["Address"].ToString();
                            Email = reader["Email"].ToString();
                            ImagePath = reader["ImagePath"].ToString();
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                finally
                {

                    con.Close();
                }
            }

            return isFound;
        }
        public static bool Insert_PeopleData(
    string FirstName, string SecondName, string ThirdName,
    string LastName, string National_No, DateTime BirthofDate, string Gender,
    string Phone, string country, string Address, string Email, string ImagePath)
        {
            int NationalityID = int.Parse(country);
            bool isSuccess = false;
            string query = @"
        INSERT INTO People 
        ( FirstName, SecondName, ThirdName, LastName, NationalNo, 
         DateOfBirth, Gender, Phone, NationalitycountryID, Address, Email, ImagePath)
        VALUES 
        ( @FirstName, @SecondName, @ThirdName, @LastName, @National_No, 
         @BirthofDate, @Gender, @Phone, @country, @Address, @Email, @ImagePath)";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {

                cmd.Parameters.AddWithValue("@FirstName", FirstName);
                cmd.Parameters.AddWithValue("@SecondName", SecondName);
                cmd.Parameters.AddWithValue("@ThirdName", ThirdName);
                cmd.Parameters.AddWithValue("@LastName", LastName);
                cmd.Parameters.AddWithValue("@National_No", National_No);
                cmd.Parameters.AddWithValue("@BirthofDate", BirthofDate);
                cmd.Parameters.AddWithValue("@Gender", Gender);
                cmd.Parameters.AddWithValue("@Phone", Phone);
                cmd.Parameters.AddWithValue("@country", NationalityID);
                cmd.Parameters.AddWithValue("@Address", Address);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@ImagePath", ImagePath);

                try
                {
                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    isSuccess = rowsAffected > 0;
                }

                catch (Exception e)
                {
                    MessageBox.Show("Error: " + e.Message);
                }
                finally
                {

                    con.Close();
                }
            }

            return isSuccess;
        }
        public static bool NationalNO_isExist(string Nationalno)
        {
            bool isExist = false;
            string query = "select *from People where NationalNO = @NationalNo";
            try
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@NationalNo", Nationalno);
                    con.Open();




                    isExist = cmd.ExecuteReader().HasRows;



                }
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
            finally { con.Close(); }
            return isExist;
        }
        public static bool PersonID_isExist(int PersonID)
        {
            bool isExist = false;
            string query = "select  top 1 PersonID from People where PersonID = @PersonID";
            try
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@PersonID", PersonID);
                    con.Open();




                    isExist = cmd.ExecuteReader().HasRows;



                }
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
            finally { con.Close(); }
            return isExist;
        }
        public static DataTable Get_Countries_Name()
        {
            return GenralQuery("SELECT * FROM countries ");
        }


        public static DataTable Get_All_People_Info()
        {
            return GenralQuery("SELECT * FROM People ");
        }
        public static bool Update_PeopleData(
    int PersonID,
    string FirstName, string SecondName, string ThirdName,
    string LastName, string National_No, DateTime BirthofDate, string Gender,
    string Phone, string country, string Address, string Email, string ImagePath)
        {
            int NationalityID = int.Parse(country);
            bool isSuccess = false;
            string query = @"
    UPDATE People 
    SET 
        FirstName = @FirstName,
        SecondName = @SecondName,
        ThirdName = @ThirdName,
        LastName = @LastName,
        NationalNo = @National_No,
        DateOfBirth = @BirthofDate,
        Gender = @Gender,
        Phone = @Phone,
        NationalityCountryID = @country,
        Address = @Address,
        Email = @Email,
        ImagePath = @ImagePath
    WHERE 
        PersonID = @PersonID";


            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@PersonID", PersonID);
            cmd.Parameters.AddWithValue("@FirstName", FirstName);
            cmd.Parameters.AddWithValue("@SecondName", SecondName);
            cmd.Parameters.AddWithValue("@ThirdName", ThirdName);
            cmd.Parameters.AddWithValue("@LastName", LastName);
            cmd.Parameters.AddWithValue("@National_No", National_No);
            cmd.Parameters.AddWithValue("@BirthofDate", BirthofDate);
            cmd.Parameters.AddWithValue("@Gender", Gender);
            cmd.Parameters.AddWithValue("@Phone", Phone);
            cmd.Parameters.AddWithValue("@country", NationalityID);
            cmd.Parameters.AddWithValue("@Address", Address);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@ImagePath", ImagePath);

            try
            {
                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                isSuccess = rowsAffected > 0;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error updating record: " + e.Message);
            }
            finally
            {
                con.Close();
            }


            return isSuccess;
        }
        public static bool DeletePersonData(int PersonID)
        {
            if (PersonID_isExist(PersonID))
            {
                string query = "delete from People where PersonID=@PersonID";
                SqlCommand cmd = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@PersonID", PersonID);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception e) { MessageBox.Show(e.Message); }
                finally { con.Close(); }

            }
            else {
                MessageBox.Show("NOT EXIST Person Data with this id");
            }
            return false;
        }
        public static DataTable ISExist_User(string UserID, string Password) {
            return GenralQuery("select top 1 * from Users where UserID=@UserID");

        }
        public static bool ISExist_User(int UserID)
        {
            bool isExist = false;

            string query = "select top 1 * from Users where UserID=@UserID";
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                cmd.Parameters.AddWithValue("@UserID", UserID);
                isExist = cmd.ExecuteReader().HasRows;

            }
            catch (Exception e) { MessageBox.Show(e.Message); }
            finally { con.Close(); }
            return isExist;

        }
        public static bool Get_UserData_UserandPassword(
    ref int UserID,
   ref string UserName,
    ref string Password,
    ref int PersonID,
    ref string FullName, ref bool Active)
        {
            bool isFound = false;
            string query = "SELECT   Users.*,fullname = People.FirstName + ' ' + People.SecondName + ' ' +   People.ThirdName + ' ' + People.LastName " +
                  "FROM   Users INNER JOIN  " +
                  " People ON Users.PersonID = People.PersonID WHERE    Users.UserName = @UserName And Users.Password=@Password";


            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@UserName", UserName);
            cmd.Parameters.AddWithValue("@Password", Password);

            try
            {
                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        isFound = true;
                        UserID = Convert.ToInt32(reader["UserID"]);
                        PersonID = Convert.ToInt32(reader["PersonID"]);
                        FullName = reader["FullName"].ToString();
                        Active = reader["isActive"].ToString() == "True" ? true : false;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Login error: " + e.Message);
            }
            finally { con.Close(); }

            return isFound;
        }
        public static bool Get_UserData_ByID(
  ref int UserID,
    ref string UserName,
    ref string Password,
    ref int PersonID,
    ref string FullName, ref bool Active)
        {
            bool isFound = false;
            string query = "SELECT   Users.*,fullname = People.FirstName + ' ' + People.SecondName + ' ' +   People.ThirdName + ' ' + People.LastName " +
                "FROM   Users INNER JOIN  " +
                " People ON Users.PersonID = People.PersonID WHERE    Users.UserID = @UserID";


            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        isFound = true;
                        UserName = reader["UserName"].ToString();
                        Password = reader["Password"].ToString();
                        PersonID = Convert.ToInt32(reader["PersonID"]);
                        FullName = reader["FullName"].ToString();
                        Active = reader["IsActive"].ToString() == "True" ? true : false;

                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Database error: " + e.Message);
            }
            finally { con.Close(); }


            return isFound;
        }
        public static string Get_Name_Country(int CountryID)
        {
            string NameCountry = "", query = "Select CountryName from countries where CountryID=@CountryID";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@CountryID", CountryID);
            try
            { con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    NameCountry = reader[0].ToString();
                }
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
            finally { con.Close(); }
            return NameCountry;
        }
        public static bool IsPerson_Link_WithUser(int PersonID)
        {
            string qury = "select  top 1 PersonID from Users where PersonID=@PersonID ";

            SqlCommand cmd = new SqlCommand(qury, con);
            cmd.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return true;
                }
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
            finally { con.Close(); }
            return false;
        }
        public static bool Insert_UserData(int PersonID, string UserName, string Password, bool isActive)
        {
            bool isSuccess = false;


            string query = @"
        INSERT INTO Users 
        (PersonID, UserName, Password, isActive)
        VALUES 
        (@PersonID, @UserName, @Password, @isActive)";

            SqlCommand cmd = new SqlCommand(query, con);


            cmd.Parameters.AddWithValue("@PersonID", PersonID);
            cmd.Parameters.AddWithValue("@UserName", UserName);
            cmd.Parameters.AddWithValue("@Password", Password);
            cmd.Parameters.AddWithValue("@isActive", isActive);

            try
            {
                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                isSuccess = rowsAffected > 0;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error inserting user data: " + e.Message);
            }
            finally
            {

                con.Close();

            }


            return isSuccess;
        }
        public static int GetUserIDBy_PersonID(int PersonID)
        {
            int UserID = -1;

            string query = @"
        select UserID from Users 
       
    
        Where PersonID=@PersonID";

            SqlCommand cmd = new SqlCommand(query, con);


            cmd.Parameters.AddWithValue("@PersonID", PersonID);


            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    UserID = int.Parse(reader["UserID"].ToString());
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Error  data: " + e.Message);
            }
            finally
            {

                con.Close();

            }
            return UserID;
        }
        public static bool Update_UserData(int UserID, int PersonID, string UserName, string Password, bool isActive)
        {
            bool isSuccess = false;


            string query = @"
        UPDATE Users 
        SET 
            PersonID = @PersonID,
            UserName = @UserName,
            Password = @Password,
            isActive = @isActive
        WHERE 
            UserID = @UserID";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@UserID", UserID);
            cmd.Parameters.AddWithValue("@PersonID", PersonID);
            cmd.Parameters.AddWithValue("@UserName", UserName);
            cmd.Parameters.AddWithValue("@Password", Password);
            cmd.Parameters.AddWithValue("@isActive", isActive);

            try
            {
                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                isSuccess = rowsAffected > 0;


            }
            catch (Exception e)
            {
                MessageBox.Show("Error updating user data: " + e.Message);
            }
            finally
            {


                con.Close();

            }


            return isSuccess;
        }
        public static DataTable Get_AllUserData()
        {
            return GenralQuery(@"SELECT   Users.*,fullname = People.FirstName + ' ' + People.SecondName + ' ' +   People.ThirdName + ' ' + People.LastName 
                FROM   Users INNER JOIN   
                 People ON Users.PersonID = People.PersonID ");
        }
        public static bool DeleteUserData(int UserID)
        {
            bool isSuccess = false;
            if (ISExist_User(UserID))
            {
                string query = "delete from People where UserID=@UserID";
                SqlCommand cmd = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@UserID", UserID);
                    isSuccess = cmd.ExecuteNonQuery() > 0;

                }
                catch (Exception e) { MessageBox.Show(e.Message); }
                finally { con.Close(); }

            }
            else
            {
                MessageBox.Show($"NOT EXIST User Data with this {UserID}");
            }
            return isSuccess;
        }
        public static bool Get_ApplicationType_Info(ref int ApplicationID, ref string ApplicationName, ref double ApplicationFees)
        {

            bool isFound = false;
            string query = "SELECT *from ApplicationTypes  where ApplicationTypeID=@ApplicationID";
            ;


            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {
                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        ApplicationID = int.Parse(reader["ApplicationTypeID"].ToString());
                        ApplicationName = reader["ApplicationTypeTitle"].ToString();
                        ApplicationFees = double.Parse(reader["ApplicationFees"].ToString());
                        isFound = true;


                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Database error: " + e.Message);
            }
            finally { con.Close(); }


            return isFound;
        }
        public static DataTable Get_AllApplicationType_Info()
        {
            return GenralQuery("SELECT *from ApplicationTypes  ");
        }
        public static double GetFeesForApplicationType(int ApptypeID)
        {
            return Convert.ToDouble(GenralQuery($"Select ApplicationFees from APplicationTypes where ApplicationTypeID ={ApptypeID}").Rows[0][0].ToString());
        }
        public static bool Update_ApptypeInfo(int ApplicationID, string ApplicationName, double ApplicationFees)
        {
            bool isSuccess = false;


            string query = @"
        UPDATE ApplicationTypes 
        SET 
          
            ApplicationTypeTitle = @ApplicationTypeTitle,
            ApplicationFees = @ApplicationFees
          
        WHERE 
           ApplicationTypeID = @ApplicationTyoeID";

            SqlCommand cmd = new SqlCommand(query, con);


            cmd.Parameters.AddWithValue("@ApplicationTypeTitle", ApplicationName);
            cmd.Parameters.AddWithValue("@ApplicationFees", ApplicationFees);
            cmd.Parameters.AddWithValue("@ApplicationTyoeID", ApplicationID);



            try
            {
                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                isSuccess = rowsAffected > 0;


            }
            catch (Exception e)
            {
                MessageBox.Show("Error updating user data: " + e.Message);
            }
            finally
            {


                con.Close();

            }


            return isSuccess;
        }
        public static bool Get_TestType_Info(ref int TestID, ref string TestName, ref double TestFees, ref string TestDescription)
        {
            bool isFound = false;
            string query = "SELECT * FROM TestTypes WHERE TestTypeID = @TestID";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@TestID", TestID);

            try
            {
                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        TestID = int.Parse(reader["TestTypeID"].ToString());
                        TestName = reader["TestTypeTitle"].ToString();
                        TestFees = double.Parse(reader["TesttypeFees"].ToString());
                        TestDescription = reader["TestTypeDescription"].ToString();
                        isFound = true;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Database error: " + e.Message);
            }
            finally
            {
                con.Close();
            }

            return isFound;
        }
        public static DataTable Get_AllTestType_Info()
        {
            return GenralQuery("SELECT * FROM TestTypes");
        }
        public static bool Update_TestTypeInfo(int TestID, string TestName, double TestFees, string TestDescription)
        {
            bool isSuccess = false;

            string query = @"
        UPDATE TestTypes 
        SET 
            TestTypeTitle = @TestTypeTitle,
            TesttypeFees = @TesttypeFees,
            TestTypeDescription = @TestTypeDescription
        WHERE 
            TestTypeID = @TestTypeID";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@TestTypeTitle", TestName);
            cmd.Parameters.AddWithValue("@TesttypeFees", TestFees);
            cmd.Parameters.AddWithValue("@TestTypeDescription", TestDescription);
            cmd.Parameters.AddWithValue("@TestTypeID", TestID);

            try
            {
                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                isSuccess = rowsAffected > 0;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error updating test type data: " + e.Message);
            }
            finally
            {
                con.Close();
            }

            return isSuccess;
        }
        public static DataTable GenralQuery(string query)
        {
            DataTable dt = new DataTable();
            using (SqlCommand cmd = new SqlCommand(query, con))
            {


                try
                {
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                finally
                {

                    con.Close();
                }

            }
            return dt;
        }

        public static DataTable Get_ClassLicense_NameandFees()
        {
            return GenralQuery("SELECT ClassName,ClassFees FROM LicenseClasses ");
        }
        public static string Get_ClassLicense_NameBYClassLicenseID(int ClassLicenseID)
        {
            return GenralQuery($"SELECT ClassName FROM LicenseClasses Where LicenseClassID={ClassLicenseID}").Rows[0]["ClassName"].ToString();
        }
        public static string Get_ClassLicense_NameBYD_APPID(int D_L_AppID)
        {
            return GenralQuery($"\r\nSELECT ClassName FROM LicenseClasses Where LicenseClassID=(select LicenseClassID from LocalDrivingLicenseApplications where LocalDrivingLicenseApplicationID={D_L_AppID})").Rows[0]["ClassName"].ToString();
        }
        public static int Get_ClassLicense_IDBYD_APPID(int D_L_AppID)
        {
            return Convert.ToInt32(GenralQuery($"SELECT LicenseClassID FROM LicenseClasses Where LicenseClassID=(select LicenseClassID from LocalDrivingLicenseApplications where ApplicationID={D_L_AppID})").Rows[0]["LicenseClassID"].ToString());
        }
        public static int Get_PassedTestbyLocalApplicationID(int LocalApplicationID)
        {
            return int.Parse(GenralQuery($@"SELECT COUNT(dbo.TestAppointments.TestTypeID) AS PassedTestCount
                       FROM      dbo.Tests INNER JOIN
                                         dbo.TestAppointments ON dbo.Tests.TestAppointmentID = dbo.TestAppointments.TestAppointmentID
                       WHERE   dbo.TestAppointments.LocalDrivingLicenseApplicationID = {LocalApplicationID} AND dbo.Tests.TestResult = 1").Rows[0]["PassedTestCount"].ToString());
        }
        public static DataTable Get_LocalLicenseApplicationInfoView()
        {
            return GenralQuery("select *from LocalDrivingLicenseApplications_View ");
        }
        public static DataTable Get_LocalLicenseApplicationInfo()
        {
            return GenralQuery("select *from LocalDrivingLicenseApplications ");
        }
        public static bool Get_LocalLicenseApplication_Info(
    ref int LocalDrivingLicenseapplicationID,
            ref int applicationID,
             ref int licenseClass)
        {
            bool isFound = false;

            string query = @"SELECT * FROM LocalDrivingLicenseApplications
                     WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseapplicationID);

            try
            {
                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        applicationID = Convert.ToInt32(reader["ApplicationID"]);
                        licenseClass = Convert.ToInt32(reader["LicenseClassID"]);

                        isFound = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

            return isFound;
        }
        public static bool Get_Application_Info(ref int applicationID,
            ref int applicantPersonID,
            ref DateTime applicationDate,
            ref int applicationTypeID,
            ref int applicationStatus,
            ref DateTime lastStatusDate,
            ref double paidFees,
            ref int createdByUserID)
        {
            bool isFound = false;
            string query = @"SELECT * FROM Applications WHERE ApplicationID = @ApplicationID";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ApplicationID", applicationID);

            try
            {
                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        applicationID = Convert.ToInt32(reader["ApplicationID"]);
                        applicantPersonID = Convert.ToInt32(reader["ApplicantPersonID"]);
                        applicationDate = Convert.ToDateTime(reader["ApplicationDate"]);
                        applicationTypeID = Convert.ToInt32(reader["ApplicationTypeID"]);
                        applicationStatus = Convert.ToInt32(reader["ApplicationStatus"]);
                        lastStatusDate = Convert.ToDateTime(reader["LastStatusDate"]);
                        paidFees = Convert.ToDouble(reader["PaidFees"]);
                        createdByUserID = Convert.ToInt32(reader["CreatedByUserID"]);

                        isFound = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

            return isFound;
        }
        public static bool Update_Application_Info(int applicationID,
    int applicantPersonID,
    DateTime applicationDate,
    int applicationTypeID,
    int applicationStatus,
    DateTime lastStatusDate,
    double paidFees,
    int createdByUserID)
        {
            bool isSuccess = false;

            string query = @"
    UPDATE Applications SET
        ApplicantPersonID = @ApplicantPersonID,
        ApplicationDate = @ApplicationDate,
        ApplicationTypeID = @ApplicationTypeID,
        ApplicationStatus = @ApplicationStatus,
        LastStatusDate = @LastStatusDate,
        PaidFees = @PaidFees,
        CreatedByUserID = @CreatedByUserID
    WHERE ApplicationID = @ApplicationID";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ApplicantPersonID", applicantPersonID);
            cmd.Parameters.AddWithValue("@ApplicationDate", applicationDate);
            cmd.Parameters.AddWithValue("@ApplicationTypeID", applicationTypeID);
            cmd.Parameters.AddWithValue("@ApplicationStatus", applicationStatus);
            cmd.Parameters.AddWithValue("@LastStatusDate", lastStatusDate);
            cmd.Parameters.AddWithValue("@PaidFees", paidFees);
            cmd.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);
            cmd.Parameters.AddWithValue("@ApplicationID", applicationID);

            try
            {
                con.Open();
                int rows = cmd.ExecuteNonQuery();
                isSuccess = rows > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating application: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

            return isSuccess;
        }
        public static int Insert_Application_Info(

    int applicantPersonID,
    DateTime applicationDate,
    int applicationTypeID,
    int applicationStatus,
    DateTime lastStatusDate,
    double paidFees,
    int createdByUserID)
        {
            bool isSuccess = false;

            string query = @"
    INSERT INTO Applications
    (
        ApplicantPersonID,
        ApplicationDate,
        ApplicationTypeID,
        ApplicationStatus,
        LastStatusDate,
        PaidFees,
        CreatedByUserID
    )
         OUTPUT INSERTED.ApplicationID
    VALUES
    (
        @ApplicantPersonID,
        @ApplicationDate,
        @ApplicationTypeID,
        @ApplicationStatus,
        @LastStatusDate,
        @PaidFees,
        @CreatedByUserID
    )";
            int applicationID = -1;

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ApplicantPersonID", applicantPersonID);
            cmd.Parameters.AddWithValue("@ApplicationDate", applicationDate);
            cmd.Parameters.AddWithValue("@ApplicationTypeID", applicationTypeID);
            cmd.Parameters.AddWithValue("@ApplicationStatus", applicationStatus);
            cmd.Parameters.AddWithValue("@LastStatusDate", lastStatusDate);
            cmd.Parameters.AddWithValue("@PaidFees", paidFees);
            cmd.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);

            try
            {
                con.Open();
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    applicationID = Convert.ToInt32(result);
                    isSuccess = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting application: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

            return applicationID;
        }
        //Local application license 
        public static bool Get_LocalDrivingLicenseApp_Info(ref int id, ref int applicationID, ref int licenseClassID)
        {
            bool isFound = false;
            string query = @"SELECT * FROM LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID = @ID";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ID", id);

            try
            {
                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        id = Convert.ToInt32(reader["LocalDrivingLicenseApplicationID"]);
                        applicationID = Convert.ToInt32(reader["ApplicationID"]);
                        licenseClassID = Convert.ToInt32(reader["LicenseClassID"]);
                        isFound = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

            return isFound;
        }
        public static int Insert_LocalDrivingLicenseApp_Info(int applicationID, int licenseClassID)
        {

            int id = -1;
            string query = @"
        INSERT INTO LocalDrivingLicenseApplications (ApplicationID, LicenseClassID)
        OUTPUT INSERTED.LocalDrivingLicenseApplicationID
        VALUES (@ApplicationID, @LicenseClassID)";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ApplicationID", applicationID);
            cmd.Parameters.AddWithValue("@LicenseClassID", licenseClassID);

            try
            {
                con.Open();
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    id = Convert.ToInt32(result);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Insert error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

            return id;
        }
        public static bool Update_LocalDrivingLicenseApp_Info(int id, int applicationID, int licenseClassID)
        {
            bool isSuccess = false;
            string query = @"
        UPDATE LocalDrivingLicenseApplications
        SET ApplicationID = @ApplicationID,
            LicenseClassID = @LicenseClassID
        WHERE LocalDrivingLicenseApplicationID = @ID";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ID", id);
            cmd.Parameters.AddWithValue("@ApplicationID", applicationID);
            cmd.Parameters.AddWithValue("@LicenseClassID", licenseClassID);

            try
            {
                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                isSuccess = rowsAffected > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

            return isSuccess;
        }
        public static bool Is_NewApplication(int PersonID, int LicenseClass)
        {
            bool isSuccess = false;
            string query = "";
            DataTable dt = GenralQuery($" select  ApplicationID from Applications where ApplicantPersonID={PersonID}and ApplicationStatus=1and ApplicationTypeID=1");
            DataTable DT = GenralQuery("select *from LocalDrivingLicenseApplications");
            int i = 0;
            foreach (DataRow dr in dt.Rows) {
                for (; i < DT.Rows.Count; i++)
                {
                    if (int.Parse(DT.Rows[i]["ApplicationID"].ToString()) >= int.Parse(dr["ApplicationID"].ToString()))
                    {
                        if (int.Parse(DT.Rows[i]["LicenseClassID"].ToString()) == LicenseClass)
                        {
                            return false;
                        }
                        break;
                    }
                }

            }


            return true;


        }
        public static bool Delete_Application_Info(int applicationID)
        {
            bool isDeleted = false;

            string query = "DELETE FROM Applications WHERE ApplicationID = @ApplicationID";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ApplicationID", applicationID);

            try
            {
                con.Open();
                int rows = cmd.ExecuteNonQuery();
                isDeleted = rows > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting application: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

            return isDeleted;
        }
        public static bool Delete_LocalDrivingLicenseApp_Info(int localID)
        {
            bool isDeleted = false;

            string query = "DELETE FROM LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID = @ID";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ID", localID);

            try
            {
                con.Open();
                int rows = cmd.ExecuteNonQuery();
                isDeleted = rows > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting local driving license application: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

            return isDeleted;
        }


        //Local application license 
        // testAppointments
        public static DataTable Get_TestAppointmentsInfoBYLocalAppID(int Local, int TestTypeID)
        {
            DataTable dt = GenralQuery($"select *from TestAppointments where LocalDrivingLicenseApplicationID ={Local} and testTypeID={TestTypeID} ");
            if (dt == null) return new DataTable();
            return dt;
        }

        public static bool Get_TestAppointment_Info(ref int appointmentID, ref int testTypeID, ref int ldlaID,
                                            ref DateTime appDate, ref double paidFees,
                                            ref int createdByUserID, ref bool isLocked)
        {
            string query = @"SELECT * FROM TestAppointments WHERE TestAppointmentID = @id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", appointmentID);

            try
            {
                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        testTypeID = Convert.ToInt32(reader["TestTypeID"]);
                        ldlaID = Convert.ToInt32(reader["LocalDrivingLicenseApplicationID"]);
                        appDate = Convert.ToDateTime(reader["AppointmentDate"]);
                        paidFees = Convert.ToDouble(reader["PaidFees"]);
                        createdByUserID = Convert.ToInt32(reader["CreatedByUserID"]);
                        isLocked = Convert.ToBoolean(reader["IsLocked"]);
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching TestAppointment: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

            return false;

        }
        public static bool Update_TestAppointment(
      int testAppointmentID,
      int testTypeID,
      int localDrivingLicenseApplicationID,
      DateTime appointmentDate,
      double paidFees,
      int createdByUserID,
      bool isLocked)
        {
            
            
                string query = @"
            UPDATE TestAppointments
            SET TestTypeID = @TestTypeID,
                LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID,
                AppointmentDate = @AppointmentDate,
                PaidFees = @PaidFees,
                CreatedByUserID = @CreatedByUserID,
                IsLocked = @IsLocked
            WHERE TestAppointmentID = @TestAppointmentID";

                SqlCommand cmd = new SqlCommand(query, con);
                
                    cmd.Parameters.AddWithValue("@TestAppointmentID", testAppointmentID);
                    cmd.Parameters.AddWithValue("@TestTypeID", testTypeID);
                    cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", localDrivingLicenseApplicationID);
                    cmd.Parameters.AddWithValue("@AppointmentDate", appointmentDate);
                    cmd.Parameters.AddWithValue("@PaidFees", paidFees);
                    cmd.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);
                    cmd.Parameters.AddWithValue("@IsLocked", isLocked);

                try
                {
                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
                return false;
            }
        public static bool Insert_TestAppointment(
            ref int testAppointmentID,
    int testTypeID,
    int localDrivingLicenseApplicationID,
    DateTime appointmentDate,
    double paidFees,
    int createdByUserID,
    bool isLocked)
        {


            string query = @"
            INSERT INTO TestAppointments
            (TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked)
            VALUES (@TestTypeID, @LocalDrivingLicenseApplicationID, @AppointmentDate, @PaidFees, @CreatedByUserID, @IsLocked);
            SELECT SCOPE_IDENTITY();";


            SqlCommand cmd = new SqlCommand(query, con);
                
                    cmd.Parameters.AddWithValue("@TestTypeID", testTypeID);
                    cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", localDrivingLicenseApplicationID);
                    cmd.Parameters.AddWithValue("@AppointmentDate", appointmentDate);
                    cmd.Parameters.AddWithValue("@PaidFees", paidFees);
                    cmd.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);
                    cmd.Parameters.AddWithValue("@IsLocked", isLocked);

                    try
                    {
                        con.Open();
                       object result= cmd.ExecuteScalar();
                        if(result != null)
                {
                    testAppointmentID = Convert.ToInt32( result);
                    return true;
                }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        con.Close();
                    }
                    return false;
                
            }
        public static bool IsLockedTestAppointment(int D_L_AppID, int testTypeID)
        {
            return GenralQuery($"select Islocked from TestAppointments where TestTypeID={testTypeID}and LocalDrivingLicenseApplicationID={D_L_AppID} and IsLocked=0").Rows.Count!=0;
        }



        //testAppointments
        //tests
        public static bool Get_TestByTestAppointmentID(ref int testID, ref int testAppointmentID, ref bool testResult, ref string notes, ref int createdByUserID)
        {
            string query = @"
        SELECT TestID, TestAppointmentID, TestResult, Notes, CreatedByUserID
        FROM Tests
        WHERE TestAppointmentID = @TestAppointmentID";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@TestAppointmentID", testAppointmentID);

            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    testID = Convert.ToInt32(reader["TestID"]);
                    testAppointmentID = Convert.ToInt32(reader["TestAppointmentID"]);
                    testResult = Convert.ToBoolean(reader["TestResult"]);
                    notes = reader["Notes"] != DBNull.Value ? reader["Notes"].ToString() : null;
                    createdByUserID = Convert.ToInt32(reader["CreatedByUserID"]);
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return false;
        }
        public static bool Insert_Test(ref int testID, int testAppointmentID, bool testResult, string notes, int createdByUserID)
        {
            string query = @"
        INSERT INTO Tests (TestAppointmentID, TestResult, Notes, CreatedByUserID)
        VALUES (@TestAppointmentID, @TestResult, @Notes, @CreatedByUserID);
        SELECT SCOPE_IDENTITY();";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@TestAppointmentID", testAppointmentID);
            cmd.Parameters.AddWithValue("@TestResult", testResult);
            cmd.Parameters.AddWithValue("@Notes", (object)notes ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);

            try
            {
                con.Open();
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    testID = Convert.ToInt32(result);
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return false;
        }

        public static bool Update_Test(int testID, int testAppointmentID, bool testResult, string notes, int createdByUserID)
        {
            string query = @"
        UPDATE Tests
        SET TestAppointmentID = @TestAppointmentID,
            TestResult = @TestResult,
            Notes = @Notes,
            CreatedByUserID = @CreatedByUserID
        WHERE TestID = @TestID";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@TestID", testID);
            cmd.Parameters.AddWithValue("@TestAppointmentID", testAppointmentID);
            cmd.Parameters.AddWithValue("@TestResult", testResult);
            cmd.Parameters.AddWithValue("@Notes", (object)notes ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);

            try
            {
                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return false;
        }

        public static bool Delete_Test(int testID)
        {
            string query = "DELETE FROM Tests WHERE TestID = @TestID";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@TestID", testID);

            try
            {
                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return false;
        }
        public static DataTable Get_AllTests()

        { return null; }
        public static bool IsPassVisiontest (int testAppinmnetID){ return GenralQuery($"select top 1  tests.TestResult from Tests inner join TestAppointments on Tests.TestAppointmentID={testAppinmnetID} \r\nand TestTypeID=1 where TestResult =1") != null; }
        public static bool IsPassWrittentest(int testAppinmnetID) { return GenralQuery($"select top 1  tests.TestResult from Tests inner join TestAppointments on Tests.TestAppointmentID={testAppinmnetID} \r\nand TestTypeID=1 where TestResult =2") != null; }
        public static bool IsPassStreettest(int testAppinmnetID) { return GenralQuery($"select top 1  tests.TestResult from Tests inner join TestAppointments on Tests.TestAppointmentID={testAppinmnetID} \r\nand TestTypeID=1 where TestResult =3") != null; }

        //test
        //Drivers
        public static bool GetDriverByID(
    int driverID,
    ref int personID,
    ref int createdByUserID,
    ref DateTime createdDate)
        {
            bool isFound = false;

      
                string query = @"SELECT PersonID, CreatedByUserID, CreatedDate 
                         FROM Drivers 
                         WHERE DriverID = @DriverID";

            SqlCommand command = new SqlCommand(query, con);
                
                    command.Parameters.AddWithValue("@DriverID", driverID);
            try
            {
                con.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        isFound = true;
                        personID = (int)reader["PersonID"];
                        createdByUserID = (int)reader["CreatedByUserID"];
                        createdDate = (DateTime)reader["CreatedDate"];
                    }
                }
            }
            catch (Exception ex)
            
                { MessageBox.Show(ex.Message); }

            finally { con.Close(); }

            return isFound;
        }

        public static bool Insert_Driver(ref int newDriverID, int personID, int createdByUserID, DateTime dateCreated)
        {
            string query = @"INSERT INTO Drivers (PersonID, CreatedByUserID, CreatedDate)
                     VALUES (@PersonID, @CreatedByUserID, @CreatedDate);
                     SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, con);

            command.Parameters.AddWithValue("@PersonID", personID);
            command.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);
            command.Parameters.AddWithValue("@CreatedDate", dateCreated);

            try
            {
                con.Open();
                newDriverID = Convert.ToInt32(command.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

            return newDriverID != -1;
        }

        public static bool Update_Driver(int driverID, int personID, int createdByUserID, DateTime dateCreated)
        {
            int rowsAffected = 0;

            string query = @"UPDATE Drivers
                     SET PersonID = @PersonID,
                         CreatedByUserID = @CreatedByUserID,
                         CreatedDate = @CreatedDate
                     WHERE DriverID = @DriverID";

            SqlCommand command = new SqlCommand(query, con);

            command.Parameters.AddWithValue("@DriverID", driverID);
            command.Parameters.AddWithValue("@PersonID", personID);
            command.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);
            command.Parameters.AddWithValue("@CreatedDate", dateCreated);

            try
            {
                con.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

            return rowsAffected > 0;
        }

        public static DataTable GetAllDriversInfo_View()
        {
            return GenralQuery("select *from Drivers_View");
        }
        public static DataTable GetAllLicenseByDriverID(int driverID)
        {
            return GenralQuery($"Select * from DriverLicense_View where DriverID={driverID}");
        }
   public static DataTable     GetAllInternationalLicensesInfoByDriverID(int DriverID)
        {
            return GenralQuery($"SELECT InternationalLicenseID, IssuedUsingLocalLicenseID AS LocalLicenseID, ApplicationID, IssueDate, ExpirationDate, IsActive\r\nFROM     InternationalLicenses where DriverID={DriverID}");
        }
     public static int   GetDirverIDBYPersonID(int personID)
        {
            DataTable dt = GenralQuery($"select DriverID from Drivers where PersonID={personID}");
            if (dt.Rows.Count>0) {
                return Convert.ToInt32(dt.Rows[0][0].ToString()); }
            return -1;
        }
       public static int GetPersonIDBYDriverID(int DriverID)
        {
            DataTable dt = GenralQuery($"select PersonID from Drivers where DriverID={DriverID}");
            if (dt.Rows.Count > 0)
            {
                return Convert.ToInt32(dt.Rows[0][0].ToString());
            }
            return -1;
        }
        //Drivers
        //Licneses
        public static bool GetLicenseInfo_ByLicenseID(int licenseID,
      ref int applicationID,
      ref int driverID,
      ref int licenseClass,
      ref DateTime issueDate,
      ref DateTime expirationDate,
      ref string notes,
      ref double paidFees,
      ref bool isActive,
      ref int issueReason,
      ref int createdByUserID)
        {
            bool isFound = false;

           
            
                string query = @"SELECT * FROM Licenses WHERE LicenseID = @LicenseID";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@LicenseID", licenseID);
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    applicationID = (int)reader["ApplicationID"];
                    driverID = (int)reader["DriverID"];
                    licenseClass = (int)reader["LicenseClass"];
                    issueDate = (DateTime)reader["IssueDate"];
                    expirationDate = (DateTime)reader["ExpirationDate"];
                    notes = reader["Notes"] != DBNull.Value ? (string)reader["Notes"] : "";
                    paidFees = reader["PaidFees"] != DBNull.Value ? Convert.ToDouble(reader["PaidFees"]) : 0.0;
                    isActive = Convert.ToBoolean(reader["IsActive"]);
                    issueReason = Convert.ToInt32(reader["IssueReason"]);
                    createdByUserID = (int)reader["CreatedByUserID"];
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }

            return isFound;
        }
        public static bool GetLicenseInfo_ByApplicationID(ref int licenseID,
     ref int applicationID,
     ref int driverID,
     ref int licenseClass,
     ref DateTime issueDate,
     ref DateTime expirationDate,
     ref string notes,
     ref double paidFees,
     ref bool isActive,
     ref int issueReason,
     ref int createdByUserID)
        {
            bool isFound = false;



            string query = @"SELECT * FROM Licenses WHERE APPlicationID = @ApplicationID";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ApplicationID", applicationID);
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;


                    licenseID = (int)reader["LicenseID"];
                    driverID = (int)reader["DriverID"];
                    licenseClass = (int)reader["LicenseClass"];
                    issueDate = (DateTime)reader["IssueDate"];
                    expirationDate = (DateTime)reader["ExpirationDate"];
                    notes = reader["Notes"] != DBNull.Value ? (string)reader["Notes"] : "";
                    paidFees = reader["PaidFees"] != DBNull.Value ? Convert.ToDouble(reader["PaidFees"]) : 0.0;
                    isActive = Convert.ToBoolean(reader["IsActive"]);
                    issueReason = Convert.ToInt32 (reader["IssueReason"]);
                    createdByUserID = (int)reader["CreatedByUserID"];
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }

            return isFound;
        }

        public static bool InsertLicenseInfo(
                    ref int LicenseID,
            int applicationID,
            int driverID,
            int licenseClass,
            DateTime issueDate,
            DateTime expirationDate,
            string notes,
            double paidFees,
            bool isActive,
            int issueReason,
            int createdByUserID)
        {
           

        
            
                string query = @"
                INSERT INTO Licenses 
                (ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID)
                VALUES
                (@ApplicationID, @DriverID, @LicenseClass, @IssueDate, @ExpirationDate, @Notes, @PaidFees, @IsActive, @IssueReason, @CreatedByUserID);
                SELECT SCOPE_IDENTITY();";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ApplicationID", applicationID);
                cmd.Parameters.AddWithValue("@DriverID", driverID);
                cmd.Parameters.AddWithValue("@LicenseClass", licenseClass);
                cmd.Parameters.AddWithValue("@IssueDate", issueDate);
                cmd.Parameters.AddWithValue("@ExpirationDate", expirationDate);
                cmd.Parameters.AddWithValue("@Notes", string.IsNullOrEmpty(notes) ? (object)DBNull.Value : notes);
                cmd.Parameters.AddWithValue("@PaidFees", paidFees);
                cmd.Parameters.AddWithValue("@IsActive", isActive);
                cmd.Parameters.AddWithValue("@IssueReason", issueReason);
                cmd.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);

            try
            {
                con.Open();
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    LicenseID = Convert.ToInt32(result);
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }

            finally { con.Close(); }
            return LicenseID!=-1;
        }

        public static bool UpdateLicenseInfo(int licenseID,
            int applicationID,
            int driverID,
            int licenseClass,
            DateTime issueDate,
            DateTime expirationDate,
            string notes,
            double paidFees,
            bool isActive,
            int issueReason,
            int createdByUserID)
        {
            int rowsAffected = 0;

           
                string query = @"
                UPDATE Licenses
                SET ApplicationID = @ApplicationID,
                    DriverID = @DriverID,
                    LicenseClass = @LicenseClass,
                    IssueDate = @IssueDate,
                    ExpirationDate = @ExpirationDate,
                    Notes = @Notes,
                    PaidFees = @PaidFees,
                    IsActive = @IsActive,
                    IssueReason = @IssueReason,
                    CreatedByUserID = @CreatedByUserID
                WHERE LicenseID = @LicenseID";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@LicenseID", licenseID);
                cmd.Parameters.AddWithValue("@ApplicationID", applicationID);
                cmd.Parameters.AddWithValue("@DriverID", driverID);
                cmd.Parameters.AddWithValue("@LicenseClass", licenseClass);
                cmd.Parameters.AddWithValue("@IssueDate", issueDate);
                cmd.Parameters.AddWithValue("@ExpirationDate", expirationDate);
                cmd.Parameters.AddWithValue("@Notes", string.IsNullOrEmpty(notes) ? (object)DBNull.Value : notes);
                cmd.Parameters.AddWithValue("@PaidFees", paidFees);
                cmd.Parameters.AddWithValue("@IsActive", isActive);
                cmd.Parameters.AddWithValue("@IssueReason", issueReason);
                cmd.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);
            try
            {
                con.Open();
                rowsAffected = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }

            return rowsAffected > 0;
        }
        public static bool Get_InternationalLicenseInfo(
        ref int InternationalLicenseID,
        ref int ApplicationID,
        ref int DriverID,
        ref int IssuedUsingLocalLicenseID,
        ref DateTime IssueDate,
        ref DateTime ExpirationDate,
        ref bool IsActive,
        ref int CreatedByUserID)
        {
            bool IsFound = false;

            try
            {

                
                    string query = @"SELECT * FROM InternationalLicenses WHERE InternationalLicenseID = @InternationalLicenseID";

                SqlCommand command = new SqlCommand(query, con);
                    
                        command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);

                        con.Open();

             SqlDataReader reader = command.ExecuteReader();
                        
                            if (reader.Read())
                            {
                                IsFound = true;

                                ApplicationID = (int)reader["ApplicationID"];
                                DriverID = (int)reader["DriverID"];
                                IssuedUsingLocalLicenseID = (int)reader["IssuedUsingLocalLicenseID"];
                                IssueDate = (DateTime)reader["IssueDate"];
                                ExpirationDate = (DateTime)reader["ExpirationDate"];
                                IsActive = (bool)reader["IsActive"];
                                CreatedByUserID = (int)reader["CreatedByUserID"];
                            }
            }
            catch (Exception ex)
            {
               
                throw new Exception("Error in Get_InternationalLicenseInfo: " + ex.Message);
            }
            finally { 
                con.Close();
            }

            return IsFound;
        }
        public static int Insert_InternationalLicenseInfo(
 
    int ApplicationID,
    int DriverID,
    int IssuedUsingLocalLicenseID,
    DateTime IssueDate,
    DateTime ExpirationDate,
    bool IsActive,
    int CreatedByUserID)
        {
            int InternationalLicenseID = -1;

            try
            {


                string query = @"
                INSERT INTO InternationalLicenses
                (ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID)
                VALUES (@ApplicationID, @DriverID, @IssuedUsingLocalLicenseID, @IssueDate, @ExpirationDate, @IsActive, @CreatedByUserID);
                
                SELECT SCOPE_IDENTITY();";  // get last inserted ID

                SqlCommand command = new SqlCommand(query, con);

                command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
                command.Parameters.AddWithValue("@DriverID", DriverID);
                command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID);
                command.Parameters.AddWithValue("@IssueDate", IssueDate);
                command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
                command.Parameters.AddWithValue("@IsActive", IsActive);
                command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

                con.Open();
                object result = command.ExecuteScalar();

                if (result != null)
                {
                    InternationalLicenseID = Convert.ToInt32(result);
                }


            }
            catch (Exception ex)
            {
                throw new Exception("Error in Insert_InternationalLicenseInfo: " + ex.Message);
            }
            finally { con.Close(); }

            return InternationalLicenseID;
        }
        public static bool IsDetainedLicense(int LicenseID)
        {
            return GenralQuery($"select DetainID from DetainedLicenses where LicenseID={LicenseID} and IsReleased=0").Rows.Count > 0;
        }
        public static bool IsHave_InterNationalLicense(int localLIcenseID) 
        {
            return GenralQuery($"select FOUNDED=1 FROM InternationalLicenses where IssuedUsingLocalLicenseID={localLIcenseID} ").Rows.Count > 0;
        }
        public static DataTable Get_AllInternationalLicenses()
        {
            return GenralQuery("SELECT InternationalLicenseID, IssuedUsingLocalLicenseID AS LocalLicenseID, ApplicationID, IssueDate, ExpirationDate, IsActive\r\nFROM     InternationalLicenses");
        }
        public static double GetFeesLicense(int licenseClassID)
        {
            return Convert.ToInt32(GenralQuery($"select ClassFees from LicenseClasses where LicenseClassID={licenseClassID}").Rows[0][0].ToString());
        }

       

        public static int DetainLicense(int licenseID, DateTime detainDate, double fineFees, int createdByUserID, bool iSRelease)
        {
            string Query = @"INSERT INTO DetainedLicenses (LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased)
                     VALUES (@LicenseID, @DetainDate, @FineFees, @CreatedByUserID, @IsReleased);
                     SELECT SCOPE_IDENTITY();";
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.Parameters.AddWithValue("@LicenseID", licenseID);
            cmd.Parameters.AddWithValue("@DetainDate", detainDate);
            cmd.Parameters.AddWithValue("@FineFees", fineFees);
            cmd.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);
            cmd.Parameters.AddWithValue("@IsReleased", iSRelease);
            int newDetainID = -1;
            try
            {
                con.Open();
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    newDetainID = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }
         return newDetainID;
        }
        public static bool ReleaseDetainedLicense(int detainID,int ApplicationID, DateTime releaseDate,  int RealsedByUserID,bool ISRealse)
        {
            string Query = @"UPDATE DetainedLicenses
                     SET ReleaseDate = @ReleaseDate,
                         ReleasedByUserID = @RealsedByUserID,
                         IsReleased = @IsReleased,
                           ReleaseApplicationID=@ApplicationID
                     WHERE DetainID = @DetainID";
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.Parameters.AddWithValue("@DetainID", detainID);
            cmd.Parameters.AddWithValue("@ReleaseDate", releaseDate);
            cmd.Parameters.AddWithValue("@RealsedByUserID", RealsedByUserID);
            cmd.Parameters.AddWithValue("@IsReleased", ISRealse);
              cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            int rowsAffected = 0;
            try
            {
                con.Open();
                rowsAffected = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }
            return rowsAffected > 0;
       
        }

        public  static int GetDetainIDBYLicenseID(int licenseID)
        {
            DataTable dt = GenralQuery($"select DetainID from DetainedLicenses where LicenseID={licenseID} and IsReleased=0"); 
            if (dt.Rows.Count > 0)
            {
                return Convert.ToInt32(dt.Rows[0][0].ToString());
            }
              return -1;
        }

        public static double GetFineFeesBYLicenseID(int licenseID)
        {
            DataTable dt = GenralQuery($"select FineFees from DetainedLicenses where LicenseID={licenseID} and IsReleased=0");
            if (dt.Rows.Count > 0)
            {
                return Convert.ToDouble(dt.Rows[0][0].ToString());
            }
            return -1;
            
        }

        public static DataTable GetAllDetainedLicenses()
        {
            return GenralQuery("select *from DetainLicenses_View");
        }
        //Licneses
    }
}
