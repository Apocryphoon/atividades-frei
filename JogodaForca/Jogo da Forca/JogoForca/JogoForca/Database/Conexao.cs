using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoForca
{
    public class Conexao
    {

        public MySqlConnection Create()
        {
            string connectionString = "server=localhost;database=Forcadb;uid=root;pwd=1234";

            MySqlConnection conect = new MySqlConnection(connectionString);
            conect.Open();

            return conect;
        }

    }
}
