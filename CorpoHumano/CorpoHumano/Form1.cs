using CorpoHumano.Objetos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CorpoHumano
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Humano Humano;


        private void button1_Click(object sender, EventArgs e)
        {

            string Nome = text1.Text;
            string Sexo = text4.Text;
            Decimal Peso = Convert.ToDecimal(text3.Text);
            Decimal Altura = Convert.ToDecimal(text2.Text);
            int Idade = Convert.ToInt32(NUD1.Value);

            if  (Nome != "" || Sexo != "" || Peso == 0 || Altura == 0 || Idade == 0)
            {

                MessageBox.Show("Criado c/ Sucesso!");
                return;

            }

            Humano = new Humano(Nome);
            Humano.Sexo = Sexo;
            Humano.Peso = Peso;
            Humano.Altura = Altura;
            Humano.Idade = Idade;
        

       

        }
    }
}
