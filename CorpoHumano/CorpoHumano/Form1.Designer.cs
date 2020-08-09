namespace CorpoHumano
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.text1 = new System.Windows.Forms.TextBox();
            this.text2 = new System.Windows.Forms.TextBox();
            this.text3 = new System.Windows.Forms.TextBox();
            this.nome = new System.Windows.Forms.Label();
            this.altura = new System.Windows.Forms.Label();
            this.peso = new System.Windows.Forms.Label();
            this.idade = new System.Windows.Forms.Label();
            this.NUD1 = new System.Windows.Forms.NumericUpDown();
            this.sexo = new System.Windows.Forms.Label();
            this.text4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CorpoHumano.Properties.Resources.cmc;
            this.pictureBox1.Location = new System.Drawing.Point(38, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(370, 242);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.sexo);
            this.groupBox1.Controls.Add(this.text4);
            this.groupBox1.Controls.Add(this.NUD1);
            this.groupBox1.Controls.Add(this.idade);
            this.groupBox1.Controls.Add(this.peso);
            this.groupBox1.Controls.Add(this.altura);
            this.groupBox1.Controls.Add(this.nome);
            this.groupBox1.Controls.Add(this.text3);
            this.groupBox1.Controls.Add(this.text2);
            this.groupBox1.Controls.Add(this.text1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(-5, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 829);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Maquina De Homem";
            // 
            // text1
            // 
            this.text1.Location = new System.Drawing.Point(140, 377);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(268, 35);
            this.text1.TabIndex = 1;
            // 
            // text2
            // 
            this.text2.Location = new System.Drawing.Point(140, 448);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(268, 35);
            this.text2.TabIndex = 2;
            // 
            // text3
            // 
            this.text3.Location = new System.Drawing.Point(140, 519);
            this.text3.Name = "text3";
            this.text3.Size = new System.Drawing.Size(268, 35);
            this.text3.TabIndex = 3;
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Location = new System.Drawing.Point(33, 377);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(82, 27);
            this.nome.TabIndex = 4;
            this.nome.Text = "Nome:";
            // 
            // altura
            // 
            this.altura.AutoSize = true;
            this.altura.Location = new System.Drawing.Point(33, 448);
            this.altura.Name = "altura";
            this.altura.Size = new System.Drawing.Size(82, 27);
            this.altura.TabIndex = 5;
            this.altura.Text = "Altura:";
            // 
            // peso
            // 
            this.peso.AutoSize = true;
            this.peso.Location = new System.Drawing.Point(33, 519);
            this.peso.Name = "peso";
            this.peso.Size = new System.Drawing.Size(73, 27);
            this.peso.TabIndex = 6;
            this.peso.Text = "Peso:";
            // 
            // idade
            // 
            this.idade.AutoSize = true;
            this.idade.Location = new System.Drawing.Point(33, 652);
            this.idade.Name = "idade";
            this.idade.Size = new System.Drawing.Size(79, 27);
            this.idade.TabIndex = 7;
            this.idade.Text = "Idade:";
            // 
            // NUD1
            // 
            this.NUD1.Location = new System.Drawing.Point(140, 652);
            this.NUD1.Name = "NUD1";
            this.NUD1.Size = new System.Drawing.Size(201, 35);
            this.NUD1.TabIndex = 8;
            // 
            // sexo
            // 
            this.sexo.AutoSize = true;
            this.sexo.Location = new System.Drawing.Point(33, 593);
            this.sexo.Name = "sexo";
            this.sexo.Size = new System.Drawing.Size(72, 27);
            this.sexo.TabIndex = 10;
            this.sexo.Text = "Sexo:";
            // 
            // text4
            // 
            this.text4.Location = new System.Drawing.Point(140, 593);
            this.text4.Name = "text4";
            this.text4.Size = new System.Drawing.Size(268, 35);
            this.text4.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 720);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(377, 68);
            this.button1.TabIndex = 2;
            this.button1.Text = "Gerar Humano";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 812);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label sexo;
        private System.Windows.Forms.TextBox text4;
        private System.Windows.Forms.NumericUpDown NUD1;
        private System.Windows.Forms.Label idade;
        private System.Windows.Forms.Label peso;
        private System.Windows.Forms.Label altura;
        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.TextBox text3;
        private System.Windows.Forms.TextBox text2;
        private System.Windows.Forms.TextBox text1;
    }
}

