using JogoForca.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoForca
{
    public partial class frmAddPalavra : Form
    {
        public frmAddPalavra()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PalavrasDatabase data = new PalavrasDatabase();
            data.InserirPalavra(txtAdd.Text);
        }
    }
}
