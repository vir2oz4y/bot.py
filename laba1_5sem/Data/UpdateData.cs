using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace laba1_5sem
{
    class UpdateData:Data
    {
        public void updateTovar(string lastName, string newName)
        {
            string sql = "update tovar set nameT=@newName where nameT=@lastName";
            command.Parameters.Clear();
            command.CommandText = sql;
            command.Connection = connection;
            command.Parameters.AddWithValue("@newName", newName);
            command.Parameters.AddWithValue("@lastName", lastName);
            try
            {
                connection.Open();
                int n = command.ExecuteNonQuery();
                MessageBox.Show("Изменение выполенено!!!");
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

        public void updatePostavshik(string Name, string City, string idp)
        {
            string sql = "update postavshik set namep=@Name,gorod=@City where idp=@idp ";
            command.Parameters.Clear();
            command.CommandText = sql;
            command.Connection = connection;
            command.Parameters.AddWithValue("@name", Name);
            command.Parameters.AddWithValue("@city", City);
            command.Parameters.AddWithValue("@idp", idp);
            try
            {
                connection.Open();
                int n = command.ExecuteNonQuery();
                MessageBox.Show("Изменение выполенено!!!");
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

        public void updatePost(string idt, string idp, string dpr, string sr, string v, string st, string dp, string np)

        {
            string sql = "update post set idt=@idt,idp=@idp,dpr=@dpr,sr=@sr,v=@v,st=@st,dp=@dp where np=@np";
            command.Parameters.Clear();
            command.CommandText = sql;
            command.Connection = connection;
            command.Parameters.AddWithValue("@idt", idt);
            command.Parameters.AddWithValue("@idp", idp);

            if (dpr != "null") command.Parameters.AddWithValue("@dpr", dpr);
            else command.Parameters.Add(new SqlParameter("@dpr", DBNull.Value));

            if (sr != "null") command.Parameters.AddWithValue("@sr", Convert.ToInt32(sr));
            else command.Parameters.Add(new SqlParameter("@sr", DBNull.Value));

            if (v != "null") command.Parameters.AddWithValue("@v", Convert.ToDecimal(v));
            else command.Parameters.Add(new SqlParameter("@v", DBNull.Value));

            if (st != "null") command.Parameters.AddWithValue("@st", Convert.ToDecimal(st));
            else command.Parameters.Add(new SqlParameter("@st", DBNull.Value));

            command.Parameters.AddWithValue("@dp", dp);
            command.Parameters.AddWithValue("@np", np);
            try
            {
                connection.Open();
                int n = command.ExecuteNonQuery();
                MessageBox.Show($"Изменение выполнено!!!");
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
