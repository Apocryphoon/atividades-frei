using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransferindoArquivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] arquivos = System.IO.Directory.GetFiles("C:\\Users\\infoc43\\Desktop\\arquivos");

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < arquivos.Length; i++)
            {

                System.IO.File.Move(arquivos[i], "C:\\Users\\infoc43\\Desktop\\pasta2");

            }

        }
    }
}
