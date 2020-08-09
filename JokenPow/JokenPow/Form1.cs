using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JokenPow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            int jogar = comboBox1.SelectedIndex;

            Random r = new Random();
            int joke = r.Next(0, 3);



            comboBox2.SelectedIndex = joke;

            if (jogar == joke)
            {

                label2.Text = "EMPATE!";

            }

            else

            {

                switch (jogar)

                {
                    case 0:

                        if (joke == 1)
                        {
                            label2.Text = " Perdeu!";
                        }
                        if (joke == 2)
                        {
                            label2.Text = "Ganhou!";
                        }
                        break;





                    case 1:

                        if (joke == 0)
                        {
                            label2.Text = "Ganhou!";
                        }
                        if (joke == 2)
                        {
                            label2.Text = "Perdeu!";
                        }
                        break;

                    case 2:

                        if (joke == 0)
                        {
                            label2.Text = "Perdeu!";
                        }
                        if (joke == 2)
                        {
                            label2.Text = "Ganhou!";
                        }
                        break;
                }
            }



            }
    }
}
