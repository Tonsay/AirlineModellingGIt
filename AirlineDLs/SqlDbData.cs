using AirlineModelling;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineDLs
{
    public class SqlDbData
    {
        static string connectionString
             // = "Data Source = PEARL-LAPTOP\\SQLEXPRESS;  Initial Catalog = AirlineModelling; Integrated Security = True;"; 
             = "Server = tcp: 20.198.228.121; Database=AirlineModelling; User Id = sa; Password=Tonsay123!;";
       
        static SqlConnection sqlConnection = new SqlConnection(connectionString);

        public static void Connect()
        {
            sqlConnection.Open();
        }

        public List<Booking> GetDetails()
        {
            string selectStatement = "SELECT ticketnum,usernames,status FROM Details";

            SqlCommand selectCommand = new SqlCommand(selectStatement, sqlConnection);

            sqlConnection.Open();
            List<Booking> users = new List<Booking>();

            SqlDataReader reader = selectCommand.ExecuteReader();

            while (reader.Read())
            {
            
                string ticketnum = reader["ticketnum"].ToString();
                string user = reader["usernames"].ToString();
                
                Booking readUser = new Booking();
                readUser.ticketnum = ticketnum;
                readUser.user = user;
                readUser.status = Convert.ToInt32(reader["status"]);

                users.Add(readUser);
            }

            sqlConnection.Close();

            return users;
        }
        public int AddUser(string ticketnum, string user)
        {
            int success;

            string insertStatement = "INSERT INTO Details VALUES (@ticketnum,@usernames)";

            SqlCommand insertCommand = new SqlCommand(insertStatement, sqlConnection);

            insertCommand.Parameters.AddWithValue("@usernames", user);
            insertCommand.Parameters.AddWithValue("@ticketnum", ticketnum);
            insertCommand.Parameters.AddWithValue("@status", 1);
            sqlConnection.Open();

            success = insertCommand.ExecuteNonQuery();

            sqlConnection.Close();

            return success;

        }

        public int UpdateUser(string ticketnum, string user)
        {
            int success;

            string updateStatement = $"UPDATE Details SET usernames = @usernames WHERE ticketnum = @ticketnum";

            SqlCommand updateCommand = new SqlCommand(updateStatement, sqlConnection);

            sqlConnection.Open();

            updateCommand.Parameters.AddWithValue("@usernames", user);
            updateCommand.Parameters.AddWithValue("@ticketnum", ticketnum);

            success = updateCommand.ExecuteNonQuery();

            sqlConnection.Close();

            return success;

        }

        public int DeleteUser(string ticketnum)
        {
            int success;
            string deleteStatement = $"DELETE FROM Details WHERE ticketnum = @ticketnum";
            SqlCommand deleteCommand = new SqlCommand(deleteStatement, sqlConnection);
            sqlConnection.Open();

            deleteCommand.Parameters.AddWithValue("@ticketnum", ticketnum);

            success = deleteCommand.ExecuteNonQuery();

            sqlConnection.Close();
            return success; 
        }

    }
}
