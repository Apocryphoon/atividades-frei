using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int res;
            int soma;
            int jog;
            Random r = new Random();
        
            int numberboot = r.Next(0, 10);

            label5.Text = numberboot.ToString();
   
            jog = Convert.ToInt32(textBox1.Text);

            soma = jog + numberboot;
            res = soma % 2;

            if (res==0 && radioButton1.Checked==true) 
            {

                MessageBox.Show("Jogador ganhou!");




           }

        else if (res==1 && radioButton2.Checked==true)

            {

                MessageBox.Show("Jogador ganhou!");



            }

            else

            {

                MessageBox.Show ("BOT ganhou!");


            }

        }
    }
}
