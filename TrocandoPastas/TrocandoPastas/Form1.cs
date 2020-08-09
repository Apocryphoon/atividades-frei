using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrocandoPastas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string de = "a";
        string para = "a";
        
        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog pasta = new FolderBrowserDialog();
            if (pasta.ShowDialog() == DialogResult.OK)
            {
                de = pasta.SelectedPath;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog pasta = new FolderBrowserDialog();
            if (pasta.ShowDialog() == DialogResult.OK)
            {
                para = pasta.SelectedPath;
            }
            MessageBox.Show(para);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (de == "a" || para == "a")
            {
                MessageBox.Show("Selecione as pastas");
            }
            else
            {
                string[] arq = System.IO.Directory.GetFiles(de);

                int i = 0;

                foreach (string item in arq)
                {
                    System.IO.FileInfo fi = null;

                    fi = new System.IO.FileInfo(item);
                    System.IO.File.Move(arq[i], "C:\\Users\\"+SystemInformation.UserName+"\\Desktop\\backup\\"+fi.Name);
                    i++;


                }
            }
        }
    }
}
