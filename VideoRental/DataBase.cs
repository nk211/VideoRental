using System;
using System.Data;
using System.Data.SqlClient;


namespace VideoRental
{
    public class DataBase
    {
        //global declaration of the variable 
        public SqlConnection connection;
        public String connection_String = System.Configuration.ConfigurationManager.ConnectionStrings["Conn_String"].ConnectionString;
        public SqlCommand command;
        public SqlDataReader Datareader;
    }

    class CustomerRecord : DataBase
    {
        public void Ins(String qry)
        {
            connection = new SqlConnection(connection_String);
            connection.Open();
            command = new SqlCommand(qry, connection);
            command.ExecuteNonQuery();
            connection.Close();

        }

        // user define method that is used to get the record from the table
        public DataTable Srch(String qry)
        {
            DataTable tbl = new DataTable();


            connection = new SqlConnection(connection_String);

            connection.Open();
            command = new SqlCommand(qry, connection);

            Datareader = command.ExecuteReader();

            tbl.Load(Datareader);

            connection.Close();

            return tbl;
        }
        public int CountSrch(String qry)
        {
            connection = new SqlConnection(connection_String);

            connection.Open();
            command = new SqlCommand(qry, connection);

            return Convert.ToInt32(command.ExecuteScalar().ToString());
        }
    }
    class video : DataBase
    {

        public void Ins(String qry)
        {
            connection = new SqlConnection(connection_String);
            connection.Open();
            command = new SqlCommand(qry, connection);
            command.ExecuteNonQuery();
            connection.Close();

        }

        // user define method that is used to get the record from the table
        public DataTable Srch(String qry)
        {
            DataTable tbl = new DataTable();


            connection = new SqlConnection(connection_String);

            connection.Open();
            command = new SqlCommand(qry, connection);

            Datareader = command.ExecuteReader();

            tbl.Load(Datareader);

            connection.Close();

            return tbl;
        }

        public int CountSrch(String qry)
        {
            connection = new SqlConnection(connection_String);

            connection.Open();
            command = new SqlCommand(qry, connection);

            return Convert.ToInt32(command.ExecuteScalar().ToString());
        }

    }
    public class Rental : DataBase
    {
        public void Ins(String qry)
        {
            connection = new SqlConnection(connection_String);
            connection.Open();
            command = new SqlCommand(qry, connection);
            command.ExecuteNonQuery();
            connection.Close();

        }

        // user define method that is used to get the record from the table
        public DataTable Srch(String qry)
        {
            DataTable tbl = new DataTable();


            connection = new SqlConnection(connection_String);

            connection.Open();
            command = new SqlCommand(qry, connection);

            Datareader = command.ExecuteReader();

            tbl.Load(Datareader);

            connection.Close();

            return tbl;
        }

    }
}
