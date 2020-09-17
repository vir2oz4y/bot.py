
using System.Data.SqlClient;

namespace laba1_5sem
{
    class Procedure: Data
    {
        public void ProcedureRun(string commandText)
        {
            connection.Open();
            command.CommandText = commandText;
            command.Connection = connection;
            reader = command.ExecuteReader();
            close_reader();
        }

        public SqlDataReader Procedure_2(string nameP)
        {
            connection.Open();
            command.Parameters.Clear();
            command.CommandText = "procedure_2 @nameP";
            command.Connection = connection;
            command.Parameters.AddWithValue("@nameP", nameP);
            reader = command.ExecuteReader();
            return reader;
        }

        public SqlDataReader Procedure_3(string nameT,string dpr,string sr)
        {
            connection.Open();
            command.Parameters.Clear();
            command.CommandText = "procedure_3 @nameT,@dpr,@sr";
            command.Connection = connection;
            command.Parameters.AddWithValue("@nameT", nameT);
            command.Parameters.AddWithValue("@dpr", dpr);
            command.Parameters.AddWithValue("@sr", sr);
            reader = command.ExecuteReader();
            return reader;
        }

        public SqlDataReader Procedure_5(string nameP)
        {
            connection.Open();
            command.Parameters.Clear();
            command.CommandText = "procedure_5 @nameP";
            command.Connection = connection;
            command.Parameters.AddWithValue("@nameP", nameP);
            reader = command.ExecuteReader();
            return reader;
        }

        public SqlDataReader Procedure_6(string nameP)
        {
            connection.Open();
            command.Parameters.Clear();
            command.CommandText = "procedure_6 @nameP";
            command.Connection = connection;
            command.Parameters.AddWithValue("@nameP", nameP);
            reader = command.ExecuteReader();
            return reader;
        }

        public SqlDataReader Procedure_7(string date)
        {
            string year = date.Split('.')[2].Split(' ')[0];
            string month = int.Parse(date.Split('.')[1]).ToString();
            connection.Open();
            command.Parameters.Clear();
            command.CommandText = "procedure_pivot_1 @year, @month";
            command.Connection = connection;
            command.Parameters.AddWithValue("@year", year);
            command.Parameters.AddWithValue("@month", month);
            reader = command.ExecuteReader();
            return reader;
        }

        public SqlDataReader Procedure_8(string date)
        {
            string year = date.Split('.')[2].Split(' ')[0];
            string month = int.Parse(date.Split('.')[1]).ToString();
            connection.Open();
            command.Parameters.Clear();
            command.CommandText = "procedure_pivot_2 @year, @month";
            command.Connection = connection;
            command.Parameters.AddWithValue("@year", year);
            command.Parameters.AddWithValue("@month", month);
            reader = command.ExecuteReader();
            return reader;
        }
    }
}
