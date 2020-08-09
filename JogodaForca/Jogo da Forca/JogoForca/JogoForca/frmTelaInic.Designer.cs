namespace JogoForca
{
    partial class frmTelaInic
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbJogo = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnInic = new System.Windows.Forms.Button();
            this.lblInic = new System.Windows.Forms.Label();
            this.gbJogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbJogo
            // 
            this.gbJogo.Controls.Add(this.btnAdd);
            this.gbJogo.Controls.Add(this.btnInic);
            this.gbJogo.Controls.Add(this.lblInic);
            this.gbJogo.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbJogo.Location = new System.Drawing.Point(0, 0);
            this.gbJogo.Name = "gbJogo";
            this.gbJogo.Size = new System.Drawing.Size(724, 469);
            this.gbJogo.TabIndex = 0;
            this.gbJogo.TabStop = false;
            this.gbJogo.Text = "Jogo Da Forca";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Silver;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Goudy Stout", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(528, 407);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(184, 56);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Adicionar Palavras";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnInic
            // 
            this.btnInic.BackColor = System.Drawing.Color.Silver;
            this.btnInic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInic.Font = new System.Drawing.Font("Goudy Stout", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInic.Location = new System.Drawing.Point(196, 246);
            this.btnInic.Name = "btnInic";
            this.btnInic.Size = new System.Drawing.Size(296, 62);
            this.btnInic.TabIndex = 2;
            this.btnInic.Text = "Iniciar";
            this.btnInic.UseVisualStyleBackColor = false;
            this.btnInic.Click += new System.EventHandler(this.btnInic_Click);
            // 
            // lblInic
            // 
            this.lblInic.AutoSize = true;
            this.lblInic.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInic.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblInic.Location = new System.Drawing.Point(157, 111);
            this.lblInic.Name = "lblInic";
            this.lblInic.Size = new System.Drawing.Size(387, 29);
            this.lblInic.TabIndex = 1;
            this.lblInic.Text = "Jogo Da Forca Com x Palavras";
            // 
            // frmTelaInic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(724, 469);
            this.Controls.Add(this.gbJogo);
            this.MaximizeBox = false;
            this.Name = "frmTelaInic";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmTelaInic_Load);
            this.gbJogo.ResumeLayout(false);
            this.gbJogo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbJogo;
        private System.Windows.Forms.Button btnInic;
        private System.Windows.Forms.Label lblInic;
        private System.Windows.Forms.Button btnAdd;
    }
}

