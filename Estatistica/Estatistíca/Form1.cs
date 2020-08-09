using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estatistíca
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
            List<int> number = new List<int>();
            int valor0 = 0;
            int valor1 = 1000;
            int valor2 = 0;

            for (int i = 0; i < 99; i++)
            {

                number.Add(r.Next(0, 101));

                listBox1.Items.Add(number[i]);


            }
            foreach (int item in number)
            {
                if (item < valor1)
                {
                    valor1 = item;


                }
                label6.Text = "Menor:" + valor1;



                if (item > valor0)
                {
                    valor0 = item;

                }
                label4.Text = "Maior:" + valor0;



            }
            foreach (int item in number)
            {
                valor2 = valor2 + item;


            }

            int valor3 = valor2 / 100;
           label5.Text = "Média:" + valor3;



        }
    }
}
