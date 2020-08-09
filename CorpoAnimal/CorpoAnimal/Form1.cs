using CorpoAnimal.Objetos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CorpoAnimal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        PC PC;


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string Modelo = text1.Text;
            string Processador = text2.Text;
            string Memoria = text3.Text;
            string HD = text6.Text;
            string LeitorCD = text7.Text;
            Decimal Peso = Convert.ToDecimal(text5.Text);
            Decimal Altura = Convert.ToDecimal(text4.Text);

            if (Processador != "" ||Modelo != "" || Memoria != "" || HD != "" || LeitorCD != "" || Peso == 0 || Altura == 0 || Tamanho == 0)
            {

                MessageBox.Show("Descrição realizada c/ sucesso!");
                return;

            }

            PC = new PC();
            PC.Modelo = Modelo;
            PC.Processador = Processador;
            PC.Memoria = Memoria;
            PC.HD = HD;
            PC.LeitorCD = LeitorCD;
            PC.Peso = Peso;
            PC.Altura = Altura;



            
            


        }
    }
}
