using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace ClubRegistration {
    internal class ClubRegistrationQuery {
        private SqlConnection sqlConnect;
        private SqlCommand sqlCommand;
        private SqlDataAdapter sqlAdapter;
        private SqlDataReader sqlReader;
        public DataTable dataTable;
        public BindingSource bindingSource;
        private string connectionString;
        public string _FirstName, _MiddleName, _LastName, _Gender, _Program;
        public int _Age;

        public ClubRegistrationQuery() {
            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\ClubDB.mdf;Integrated Security=True;";
            sqlConnect = new SqlConnection(connectionString);
            dataTable = new DataTable();
            bindingSource = new BindingSource();
        }

        public bool DisplayList() {
            string ViewClubMembers = "SELECT StudentId, FirstName, MiddleName, LastName, Age, Gender, Program FROM ClubMembers";
            sqlAdapter = new SqlDataAdapter(ViewClubMembers, sqlConnect);
            dataTable.Clear();
            sqlAdapter.Fill(dataTable);
            bindingSource.DataSource  = dataTable;
            return true;
        }
        
        public string[] GetStudentIDs() {
            List<string> studentIDs = new List<string>();

            string query = "SELECT StudentId FROM ClubMembers";
            sqlCommand = new SqlCommand(query, sqlConnect);

            if (sqlConnect.State == ConnectionState.Closed) {
                sqlConnect.Open();
            }

            sqlReader = sqlCommand.ExecuteReader(); 

            while (sqlReader.Read()) {
                studentIDs.Add(sqlReader["StudentId"].ToString()); 
            }

            sqlReader.Close();
            sqlConnect.Close();

            return studentIDs.ToArray();
        }

        public DataRow GetStudentDataByID(long studentId) {
            string query = "SELECT StudentId, FirstName, MiddleName, LastName, Age, Gender, Program FROM ClubMembers WHERE StudentId = @StudentId";
            sqlCommand = new SqlCommand(query, sqlConnect);
            sqlCommand.Parameters.Add("@StudentId", SqlDbType.BigInt).Value = studentId;
            sqlAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            sqlAdapter.Fill(dt);
            if (dt.Rows.Count > 0) {
                return dt.Rows[0];
            }
            return null;
        }

        public bool UpdateStudent(long studentId, string firstName, string middleName, string lastName, int age, string gender, string program) {
            if (sqlConnect.State == System.Data.ConnectionState.Open) {
                sqlConnect.Close();
            }
            string query = "UPDATE ClubMembers SET FirstName = @FirstName, MiddleName = @MiddleName, LastName = @LastName, Age = @Age, Gender = @Gender, Program = @Program WHERE StudentId = @StudentId";
            sqlCommand = new SqlCommand(query, sqlConnect);
            sqlCommand.Parameters.Add("@StudentId", SqlDbType.BigInt).Value = studentId;
            sqlCommand.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = firstName;
            sqlCommand.Parameters.Add("@MiddleName", SqlDbType.VarChar).Value = middleName;
            sqlCommand.Parameters.Add("@LastName", SqlDbType.VarChar).Value = lastName;
            sqlCommand.Parameters.Add("@Age", SqlDbType.Int).Value = age;
            sqlCommand.Parameters.Add("@Gender", SqlDbType.VarChar).Value = gender;
            sqlCommand.Parameters.Add("@Program", SqlDbType.VarChar).Value = program;
            sqlConnect.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
            return true;
        }

        public bool RegisterStudent(long StudentID, string FirstName, string MiddleName, string LastName, int Age, string Gender, string Program) {
            if (sqlConnect.State == System.Data.ConnectionState.Open) {
                sqlConnect.Close();
            }
            sqlCommand = new SqlCommand("INSERT INTO ClubMembers VALUES(@StudentID, @FirstName, @MiddleName, @LastName, @Age, @Gender, @Program)", sqlConnect);
            sqlCommand.Parameters.Add("@StudentID", SqlDbType.BigInt).Value = StudentID;
            sqlCommand.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = FirstName;
            sqlCommand.Parameters.Add("@MiddleName", SqlDbType.VarChar).Value = MiddleName;
            sqlCommand.Parameters.Add("@LastName", SqlDbType.VarChar).Value = LastName;
            sqlCommand.Parameters.Add("@Age", SqlDbType.Int).Value = Age;
            sqlCommand.Parameters.Add("@Gender", SqlDbType.VarChar).Value = Gender;
            sqlCommand.Parameters.Add("@Program", SqlDbType.VarChar).Value = Program;
            sqlConnect.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
            return true;
        }
    }
}
