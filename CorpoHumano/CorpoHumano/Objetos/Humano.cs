using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorpoHumano.Objetos
{
   public class Humano
    {

        public string Nome { set; get; }
        public string Sexo { set; get; }
        public Decimal Peso { set; get; }
        public Decimal Altura { set; get; }
        public int Idade { get; set; }

        public Humano(string Nome)
        {

            this.Nome = Nome;
        }






    }
}
