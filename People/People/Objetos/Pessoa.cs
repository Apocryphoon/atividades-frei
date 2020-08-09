using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace People.Objetos
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Sexo { get; set; }
        public string Nacionalidade { get; set; }
        public string Etnia { get; set; }
        public int QI { get; set; }
        public string Olho { get; set; }

        public bool Vivo { get; set; }

        public Pessoa(string Nome, int Idade, string Sexo)
        {
            this.Nome = Nome;
            this.Idade = Idade;
            this.Sexo = Sexo;
        }

        public void Criar()
        {
            if (Vivo == true)
            {
                MessageBox.Show("Você já tem uma pessoa viva");
                return;
            }

            this.Vivo = true;

            MessageBox.Show("Pessoa criada");
        }

        public void Matar()
        {
            this.Vivo = false;

            MessageBox.Show("Pessoa Morta");
        }

        public void Correr(int Velocidade)
        {
            if (this.Vivo == false)
            {
                MessageBox.Show("Não existe uma pessoa");
                return;
            }

            MessageBox.Show("Correndo...");
        }

        public string Informacoes()
        {
            string dados = string.Format("Nome: {0} \n Idade: {1} \n Sexo: {2} \n Nacionalidade: {3} \n Etnia: {4} \n Cor do olho: {5} \n QI: {6} ", Nome, Idade, Sexo, Nacionalidade, Etnia, Olho, QI);

            return dados;
        }

        public void Pensar(string pensamento)
        {
            if (Vivo == false)
            {
                MessageBox.Show("Não existe uma pessoa");
                return;
            }

            MessageBox.Show("Pensando em " + pensamento);
        }

        public void Descansar()
        {
            if (Vivo == false)
            {
                MessageBox.Show("Não existe uma pessoa");
                return;
            }

            MessageBox.Show("Descansando");
        }
    }
}
