using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1_5sem
{
    class InputData:Data
    {
        public List<Tovar> Input_tovar()
        {
            List<Tovar> tovars = new List<Tovar>();
            string com = "SELECT * from tovar";
            SqlDataReader reader = readDataFromDB(com);
            int idt;
            string name;
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    idt = int.Parse(reader[0].ToString());
                    name = reader[1].ToString();
                    tovars.Add(new Tovar {Idt=idt ,Name=name});
                }

            }
            reader.Close();
            close_reader();
            return tovars;
        }

        public List<Postavshik> Input_postavshik()
        {
            List<Postavshik> postavshiks = new List<Postavshik>();
            string com = "SELECT * from postavshik";
            SqlDataReader reader = readDataFromDB(com);

            int idp;
            string name;
            string city;
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    idp =int.Parse(reader[0].ToString());
                    name = reader[1].ToString();
                    city = reader[2].ToString();
                    postavshiks.Add(new Postavshik {idp=idp,name= name, city=city });
                }

            }
            reader.Close();
            close_reader();

            return postavshiks;
        }

        public List<Post> Input_post()
        {
            List<Post> posts = new List<Post>();
            string com = "SELECT * from post";
            SqlDataReader reader = readDataFromDB(com);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    posts.Add(new Post { np=reader[0].ToString(), idt=reader[1].ToString(), idp=reader[2].ToString(), dpr=reader[3].ToString(), sr=reader[4].ToString(), v=reader[5].ToString(), st=reader[6].ToString(), dp=reader[7].ToString() });
                }

            }
            reader.Close();
            close_reader();
            return posts;
        }

        public List<Itog> Input_itog()
        {
            List<Itog> itogs = new List<Itog>();
            string com = "SELECT * from itog";
            SqlDataReader reader = readDataFromDB(com);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    itogs.Add(new Itog { idt = reader[0].ToString(), idp = reader[1].ToString(), v2018 = reader[2].ToString(), st2018 = reader[3].ToString(), v2019 = reader[4].ToString(), st2019 = reader[5].ToString(), v2020 = reader[6].ToString(), st2020 = reader[7].ToString() });
                }

            }
            reader.Close();
            close_reader();
            return itogs;
        }

    }
}
