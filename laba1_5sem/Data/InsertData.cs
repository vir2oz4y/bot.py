using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace laba1_5sem
{
    class InsertData:Data
    {
        public void insertTovar(string name)
        {
            string sql = "insert into tovar values (@name)";
            command.Parameters.Clear();
            command.CommandText = sql;
            command.Connection = connection;
            command.Parameters.AddWithValue("@name", name);
            try
            {
                connection.Open();
                int n = command.ExecuteNonQuery();
                MessageBox.Show($"Запись добавлена!!!");
            }
            catch (SqlException e)
            {

                MessageBox.Show(e.Message);
            }
            finally
            {
                close_reader();
            }

        }

        public void insertPostavshik(string name, string city)
        {
            string sql = "insert into postavshik values (@name,@city)";
            command.Parameters.Clear();
            command.CommandText = sql;
            command.Connection = connection;
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@city", city);
            try
            {
                connection.Open();
                int n = command.ExecuteNonQuery();
                MessageBox.Show($"Добавлено {n} записей");
            }
            catch (SqlException e)
            {

                MessageBox.Show(e.Message);
            }
            finally
            {
                close_reader();
            }
        }

        public void insertPost(string idt, string idp, string dpr, string sr, string v, string st, string dp)
        {
            string sql = "insert into post values (@idt,@idp,@dpr,@sr,@v,@st,@dp)";
            command.Parameters.Clear();
            command.CommandText = sql;
            command.Connection = connection;
            command.Parameters.AddWithValue("@idt", idt);
            command.Parameters.AddWithValue("@idp", idp);

            if (dpr != "null") command.Parameters.AddWithValue("@dpr", dpr);
            else command.Parameters.Add(new SqlParameter("@dpr", DBNull.Value));

            if (sr != "null") command.Parameters.AddWithValue("@sr", Convert.ToInt32(sr));
            else command.Parameters.Add(new SqlParameter("@sr", DBNull.Value));

            if (v != "null") command.Parameters.AddWithValue("@v", Convert.ToDouble(v));
            else command.Parameters.Add(new SqlParameter("@v", DBNull.Value));

            if (st != "null") command.Parameters.AddWithValue("@st", Convert.ToDouble(st));
            else command.Parameters.Add(new SqlParameter("@st", DBNull.Value));

            command.Parameters.AddWithValue("@dp", dp);
            try
            {
                connection.Open();
                int n = command.ExecuteNonQuery();
                MessageBox.Show($"Запись добавлена!!!");
            }
            catch (SqlException e)
            {

                MessageBox.Show(e.Message);
            }
            finally
            {
                close_reader();
            }
        }


    }
}
