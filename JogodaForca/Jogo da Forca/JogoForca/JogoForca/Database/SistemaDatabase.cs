using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoForca.Database
{
    public class SistemaDatabase
    {
        public MySqlDataReader ExecuteSelect (string script)
        {
            Conexao conect = new Conexao();
            MySqlConnection conexao = conect.Create();

            MySqlCommand command = conexao.CreateCommand();
            command.CommandText = script;

            MySqlDataReader reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            return reader;
        }

        public void ExecuteInsert(string script)
        {
            Conexao conect = new Conexao();
            MySqlConnection conexao = conect.Create();

            MySqlCommand command = conexao.CreateCommand();
            command.CommandText = script;

            command.ExecuteNonQuery();
            conexao.Close();

        }
    }
}
