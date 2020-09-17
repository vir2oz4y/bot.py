using System.Collections.Generic;
using System.Data.SqlClient;

namespace laba1_5sem
{
    class InputName:Data
    {
        public List<string> NameP()
        {
            List<string> namesP = new List<string>();
            string com = "SELECT namep from Postavshik";
            SqlDataReader reader = readDataFromDB(com);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    namesP.Add(reader[0].ToString());
                }

            }
            reader.Close();
            close_reader();
            return namesP;
        }

        public List<string> NameT()
        {
            List<string> namesP = new List<string>();
            string com = "SELECT namet from tovar";
            SqlDataReader reader = readDataFromDB(com);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    namesP.Add(reader[0].ToString());
                }

            }
            reader.Close();
            close_reader();
            return namesP;
        }

    }
}
