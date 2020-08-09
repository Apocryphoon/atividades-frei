using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizSeriado
{
    public partial class frmQuiz : Form
    {
        public int resultado;
        public int resultado2;
        public frmQuiz()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            
            lblINI.Visible = false;
            btnIniciar.Visible = false;
            lblQ1.Visible = true;
            rbtQ1O1.Visible = true;
            rbtQ1O2.Visible = true;
            rbtQ1O3.Visible = true;
            btnNext1.Visible = true;
        }


        private void btnNext1_Click(object sender, EventArgs e)
        {
            lblQ1.Visible = false;
            rbtQ1O1.Visible = false;
            rbtQ1O2.Visible = false;
            rbtQ1O3.Visible = false;
            btnNext1.Visible = false;

            lblQ2.Visible = true;
            rbtQ2O1.Visible = true;
            rbtQ2O2.Visible = true;
            rbtQ2O3.Visible = true;
            btnNext2.Visible = true;
            if (rbtQ1O1.Checked == true)
            {
                resultado++;
                resultado2 = resultado2 + 20;
            }

        }


        private void btnNext2_Click(object sender, EventArgs e)
        {
            lblQ2.Visible = false;
            rbtQ2O1.Visible = false;
            rbtQ2O2.Visible = false;
            rbtQ2O3.Visible = false;
            btnNext2.Visible = false;

            lblQ3.Visible = true;
            rbtQ3O1.Visible = true;
            rbtQ3O2.Visible = true;
            rbtQ3O3.Visible = true;
            btnNext3.Visible = true;
            if (rbtQ2O2.Checked ==true)
            {
                resultado++;
                resultado2 = resultado2 + 20;
            }
        }

        private void btnNext3_Click(object sender, EventArgs e)
        {
            lblQ3.Visible = false;
            rbtQ3O1.Visible = false;
            rbtQ3O2.Visible = false;
            rbtQ3O3.Visible = false;
            btnNext3.Visible = false;

            lblQ4.Visible = true;
            rbtQ4O1.Visible = true;
            rbtQ4O2.Visible = true;
            rbtQ4O3.Visible = true;
            btnNext4.Visible = true;
            if (rbtQ3O3.Checked == true)
            {
                resultado++;
                resultado2 = resultado2 + 20;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblQ4.Visible = false;
            rbtQ4O1.Visible = false;
            rbtQ4O2.Visible = false;
            rbtQ4O3.Visible = false;
            btnNext4.Visible = false;

            lblQ5.Visible = true;
            rbtQ5O1.Visible = true;
            rbtQ5O2.Visible = true;
            rbtQ5O3.Visible = true;
            btnNext5.Visible = true;
            if (rbtQ4O1.Checked ==true)
            {
                resultado++;
                resultado2 = resultado2 + 20;
            }
        }

        private void btnNext5_Click(object sender, EventArgs e)
        {
            if (rbtQ5O2.Checked==true)
            {
                resultado2 = resultado2 + 20;
                resultado++;
            }
            lblQ5.Visible = false;
            rbtQ5O1.Visible = false;
            rbtQ5O2.Visible = false;
            rbtQ5O3.Visible = false;
            btnNext5.Visible = false;

            progressBar1.Value = resultado2;
            progressBar1.Visible = true;
            lblResu1.Visible = true;
            lblResu2.Text = resultado + "/5";
            lblResu2.Visible = true;
            btnSair.Visible = true;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
