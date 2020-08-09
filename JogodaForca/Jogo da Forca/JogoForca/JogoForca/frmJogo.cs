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
    public partial class frmJogo : Form
    {
        public frmJogo()
        {
            InitializeComponent();
        }

        public List<string> letra = new List<string>();
        public string palavra;
        public string novasLetras = " ";
        public int erro;
        public string termino = "";


        private void frmJogo_Load(object sender, EventArgs e)
        {
            PalavrasDatabase data = new PalavrasDatabase();
            int qtd = data.QtdPalavras();

            Random bot = new Random();
            int numeroPalavra = bot.Next(1, qtd + 1);

            palavra = data.GerarPalavra(numeroPalavra);

            int tamanhoPalavra = palavra.Length;

            for (int i = 0; i < tamanhoPalavra; i++)
            {
                letra.Add(palavra.Substring(i,1));
            }


            int tamanho = palavra.Length;
            lblLetrasX.Text = "A palavra tem " + tamanho + " letras";

            MessageBox.Show(palavra);



        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void txt1_MouseCaptureChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            string letraEscolhida = maskedTextBox1.Text;

            string letrasUsadas = "Letras Usadas"; ;

            int pos = palavra.IndexOf(letraEscolhida);


            if (pos == -1)
            {
                
                if (novasLetras.IndexOf(letraEscolhida) == -1)
                {
                    novasLetras = novasLetras + letraEscolhida;
                    erro++;
                    lblErros.Text = "Erros " + erro + "/7";
                }
                else
                {
                    MessageBox.Show("Letra já escolhida");
                }

            }
            else
            {
                if (novasLetras.IndexOf(letraEscolhida) == -1)
                {
                    termino = termino + letraEscolhida;
                    novasLetras = novasLetras + letraEscolhida;
                }
                else
                {
                    MessageBox.Show("Letra já escolhida");
                }

            }
            if (erro == 7)
            {
                MessageBox.Show("Você Perdeu :(");
                this.Close();
            }

            

            lblLetras.Text = letrasUsadas + " " + novasLetras;

            if (termino == palavra)
            {
                MessageBox.Show("Você ganhou, a palavra era " + palavra);
                this.Close();
            }



            if (letra.Count >= 1 && letra[0] == letraEscolhida && txt1.Text == "")
            {
                txt1.Text = letra[0];
                txt1.Enabled = true;
            }
            else
            {
                if (txt1.Text == letra[0])
                {
                    txt1.Enabled = true;

                }
                else
                {
                    txt1.Enabled = false;
                }
                
            }
            if (letra.Count >= 2 && letra[1] == letraEscolhida && txt2.Text == "")
            {
                txt2.Text = letra[1];
                txt2.Enabled = true;
            }
            else
            {
                if (txt2.Text == letra[1])
                {
                    txt2.Enabled = true;
                }
                else
                {
                    txt2.Enabled = false;
                }

            }
            if (letra.Count >= 3 && letra[2] == letraEscolhida && txt3.Text == "")
            {
                txt3.Text = letra[2];
                txt3.Enabled = true;
            }
            else
            {
                if (txt3.Text == letra[2])
                {
                    txt3.Enabled = true;
                }
                else
                {
                    txt3.Enabled = false;
                }

            }
            if (letra.Count >= 4 && letra[3] == letraEscolhida && txt4.Text=="")
            {
                txt4.Text = letra[3];
                txt4.Enabled = true;
            }
            else
            {
                if (letra.Count >= 4 && txt4.Text==letra[3])
                {
                    txt4.Enabled = true;
                }
                else
                {
                    txt4.Enabled = false;
                }

            }
            if (letra.Count >= 5 && letra[4] == letraEscolhida && txt5.Text=="")
            {
                txt5.Text = letra[4];
                txt5.Enabled = true;
            }
            else
            {
                if (letra.Count >= 5 && txt5.Text == letra[4])
                {
                    txt5.Enabled = true;
                }
                else
                {
                    txt5.Enabled = false;
                }

            }
            if (letra.Count >= 6 && letra[5] == letraEscolhida && txt6.Text=="")
            {
                txt6.Text = letra[5];
                txt6.Enabled = true;
            }
            else
            {
                if (letra.Count >= 6 && txt6.Text == letra[5])
                {
                    txt6.Enabled = true;
                }
                else
                {
                    txt6.Enabled = false;
                }

            }
            if (letra.Count >= 7 && letra[6] == letraEscolhida && txt7.Text =="")
            {
                txt7.Text = letra[6];
                txt7.Enabled = true;
            }
            else
            {
                if (letra.Count >= 7 && txt7.Text == letra[6])
                {
                    txt7.Enabled = true;
                }
                else
                {
                    txt7.Enabled = false;
                }
                
            }
            if (letra.Count >= 8 && letra[7] == letraEscolhida && txt8.Text == "")
            {
                txt8.Text = letra[7];
                txt8.Enabled = true;
            }
            else
            {
                if (letra.Count >= 8 && txt8.Text == letra[7])
                {
                    txt8.Enabled = true;
                }
                else
                {
                    txt8.Enabled = false;
                }

            }
            if (letra.Count >= 9 && letra[8] == letraEscolhida && txt9.Text=="")
            {
                txt9.Text = letra[8];
                txt9.Enabled = true;
            }
            else
            {
                if (letra.Count >= 9 && txt9.Text == letra[8])
                {
                    txt9.Enabled = true;
                }
                else
                {
                    txt9.Enabled = false;
                }

            }
            if (letra.Count >= 10 && letra[9] == letraEscolhida && txt10.Text=="")
            {
                txt10.Text = letra[9];
                txt10.Enabled = true;
            }
            else
            {
                if (letra.Count >= 10 && txt10.Text == letra[9])
                {
                    txt10.Enabled = true;
                }
                else
                {
                    txt10.Enabled = false;
                }

            }
            if (txt1.Text + txt2.Text + txt3.Text == palavra)
            {
                MessageBox.Show("Você ganhou, a palavra era " + palavra);
                this.Close();
            }
            else
            {
                if (txt1.Text + txt2.Text + txt3.Text + txt4.Text == palavra)
                {
                    MessageBox.Show("Você ganhou, a palavra era " + palavra);
                    this.Close();
                }
                else
                {
                    if (txt1.Text + txt2.Text + txt3.Text + txt4.Text + txt5.Text == palavra)
                    {
                        MessageBox.Show("Você ganhou, a palavra era " + palavra);
                        this.Close();
                    }
                    else
                    {
                        if (txt1.Text + txt2.Text + txt3.Text + txt4.Text + txt5.Text + txt6.Text == palavra)
                        {
                            MessageBox.Show("Você ganhou, a palavra era " + palavra);
                            this.Close();
                        }
                        else
                        {
                            if (txt1.Text + txt2.Text + txt3.Text + txt4.Text + txt5.Text + txt6.Text + txt7.Text == palavra)
                            {
                                MessageBox.Show("Você ganhou, a palavra era " + palavra);
                                this.Close();
                            }
                            else
                            {
                                if (txt1.Text + txt2.Text + txt3.Text + txt4.Text + txt5.Text + txt6.Text + txt7.Text + txt8.Text == palavra)
                                {
                                    MessageBox.Show("Você ganhou, a palavra era " + palavra);
                                    this.Close();
                                }
                                else
                                {
                                    if (txt1.Text + txt2.Text + txt3.Text + txt4.Text + txt5.Text + txt6.Text + txt7.Text + txt8.Text + txt9.Text == palavra)
                                    {
                                        MessageBox.Show("Você ganhou, a palavra era " + palavra);
                                        this.Close();
                                    }
                                    else
                                    {
                                        if (txt1.Text + txt2.Text + txt3.Text + txt4.Text + txt5.Text + txt6.Text + txt7.Text + txt8.Text + txt9.Text + txt10.Text == palavra)
                                        {
                                            MessageBox.Show("Você ganhou, a palavra era " + palavra);
                                            this.Close();
                                        }
                                        else
                                        {

                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }


        }
    }
}
