using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace laba1_5sem
{
    class DeleteData:Data
    {
        public void deleteTovar(string idt)
        {
            string sql = "delete from tovar where idt=@idt";
            command.Parameters.Clear();
            command.CommandText = sql;
            command.Connection = connection;
            command.Parameters.AddWithValue("@idt", idt);
            try
            {
                connection.Open();
                int n = command.ExecuteNonQuery();
                MessageBox.Show("Удаление выполенено!!!");
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

        public void deletePostavshik(string idp)
        {
            string sql = "delete from postavshik where idp=@idp ";
            command.Parameters.Clear();
            command.CommandText = sql;
            command.Connection = connection;
            command.Parameters.AddWithValue("@idp", idp);

            try
            {
                connection.Open();
                int n = command.ExecuteNonQuery();
                MessageBox.Show("Удаление выполенено!!!");
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

        public void deletePost(string np)
        {
            string sql = "delete from post where np=@np";
            command.Parameters.Clear();
            command.CommandText = sql;
            command.Connection = connection;


            command.Parameters.AddWithValue("@np", np);
            try
            {
                connection.Open();
                int n = command.ExecuteNonQuery();
                MessageBox.Show("Запись удалена!!!");
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
