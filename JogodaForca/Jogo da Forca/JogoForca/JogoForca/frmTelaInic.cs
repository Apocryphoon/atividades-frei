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
    public partial class frmTelaInic : Form
    {
        public frmTelaInic()
        {
            InitializeComponent();
        }

        private void btnInic_Click(object sender, EventArgs e)
        {
            frmJogo tela = new frmJogo();
            tela.Show();
        }

        private void frmTelaInic_Load(object sender, EventArgs e)
        {
            PalavrasDatabase data = new PalavrasDatabase();
            int qtd = data.QtdPalavras();
            lblInic.Text = "Jogo da forca com " + qtd + " palavras";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddPalavra tela = new frmAddPalavra();
            tela.Show();
        }
    }
}
