using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soma_Aleatoria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            Random r = new Random();
            int Q = r.Next(0, 20);

            int[] numeros = new int[20];

            for (int i = 0; i <=19; i++)
            {
                numeros[i] = r.Next(0, 20);
                listBox1.Items.Add(numeros[i]);
            }

            label1.Text = Q.ToString();




        }
    }
}
