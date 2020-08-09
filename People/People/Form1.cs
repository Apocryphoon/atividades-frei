using People.Objetos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace People
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Pessoa a;

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string nacionalidade = txtNac.Text;
            string etnia = txtEtnia.Text;
            string olho = txtOlho.Text;
            int idade = Convert.ToInt32(nudIdade.Value);
            int qi = Convert.ToInt32(nudQI.Value);
            string sexo = cboSexo.Text;

            if (nome == string.Empty || nacionalidade == string.Empty || etnia == string.Empty || olho == string.Empty || sexo == string.Empty || idade == 0 || qi == 0)
            {
                MessageBox.Show("Preencha todos os campos");
                return;
            }

            a = new Pessoa(nome, idade, sexo);
            a.Etnia = etnia;
            a.Idade = idade;
            a.Nacionalidade = nacionalidade;
            a.Olho = olho;
            a.QI = qi;

            a.Criar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                a.Matar();
            }
            catch ( Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a.Correr(10);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(a.Informacoes());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {

                if (textBox1.Text == string.Empty)
                {
                    MessageBox.Show("Digite alguma coisa");
                    return;
                }

                a.Pensar(textBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                a.Descansar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
