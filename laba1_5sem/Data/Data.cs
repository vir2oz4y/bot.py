using System.Data.SqlClient;



namespace laba1_5sem
{
    class Data
    {
        protected SqlConnection connection= new SqlConnection(Properties.Settings.Default.PostavkiConnectionString);
        protected SqlCommand command = new SqlCommand();
        protected SqlDataReader reader;


        public SqlDataReader readDataFromDB(string commandText)
        {
            connection.Open();
            command.CommandText = commandText;
            command.Connection = connection;
            reader = command.ExecuteReader();
            return reader;
        }


        public void close_reader()
        {
            connection.Close();
            try
            {
                reader.Close();
            }
            catch(System.NullReferenceException e)
            {
                
            }
            
        }
        
    }
}
