using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoForca.Database
{
    public class PalavrasDatabase
    {
        public string GerarPalavra(int palavra)
        {
            string query = "select * from tb_palavras where id_palavras='{0}';";

            query = string.Format(query, palavra);

            SistemaDatabase sist = new SistemaDatabase();
            MySqlDataReader reader = sist.ExecuteSelect(query);

            string palavraGerada = "";

            while (reader.Read())
            {
                palavraGerada = reader.GetString("ds_palavra");
            }

            return palavraGerada;

        }

        public int QtdPalavras()
        {
            string query = "select count(*) from tb_palavras;";

            SistemaDatabase sist = new SistemaDatabase();
            MySqlDataReader reader = sist.ExecuteSelect(query);

            int alo = 0;

            while (reader.Read())
            {
               alo = reader.GetInt32("count(*)");
            }

            return alo;
        }

        public void InserirPalavra(string palavra)
        {
            string query = "insert into tb_palavras (ds_palavra) values ('{0}');";

            query = string.Format(query, palavra);

            SistemaDatabase sist = new SistemaDatabase();
            sist.ExecuteInsert(query);
        }
    }
}
