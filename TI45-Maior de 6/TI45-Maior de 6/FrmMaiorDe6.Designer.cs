namespace TI45_Maior_de_6
{
    partial class FrmMaiorDe6
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
            this.lblN1 = new System.Windows.Forms.Label();
            this.lblN2 = new System.Windows.Forms.Label();
            this.lblN3 = new System.Windows.Forms.Label();
            this.lblN4 = new System.Windows.Forms.Label();
            this.lblN5 = new System.Windows.Forms.Label();
            this.lblN6 = new System.Windows.Forms.Label();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.txtN3 = new System.Windows.Forms.TextBox();
            this.txtN4 = new System.Windows.Forms.TextBox();
            this.txtN5 = new System.Windows.Forms.TextBox();
            this.txtN6 = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.gpbBotoes = new System.Windows.Forms.GroupBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpa = new System.Windows.Forms.Button();
            this.btnVerifica = new System.Windows.Forms.Button();
            this.gpbBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblN1
            // 
            this.lblN1.AutoSize = true;
            this.lblN1.Location = new System.Drawing.Point(35, 30);
            this.lblN1.Name = "lblN1";
            this.lblN1.Size = new System.Drawing.Size(77, 13);
            this.lblN1.TabIndex = 0;
            this.lblN1.Text = "1º Número";
            // 
            // lblN2
            // 
            this.lblN2.AutoSize = true;
            this.lblN2.Location = new System.Drawing.Point(35, 80);
            this.lblN2.Name = "lblN2";
            this.lblN2.Size = new System.Drawing.Size(77, 13);
            this.lblN2.TabIndex = 1;
            this.lblN2.Text = "2º Número";
            // 
            // lblN3
            // 
            this.lblN3.AutoSize = true;
            this.lblN3.Location = new System.Drawing.Point(35, 130);
            this.lblN3.Name = "lblN3";
            this.lblN3.Size = new System.Drawing.Size(77, 13);
            this.lblN3.TabIndex = 2;
            this.lblN3.Text = "3º Número";
            // 
            // lblN4
            // 
            this.lblN4.AutoSize = true;
            this.lblN4.Location = new System.Drawing.Point(259, 30);
            this.lblN4.Name = "lblN4";
            this.lblN4.Size = new System.Drawing.Size(77, 13);
            this.lblN4.TabIndex = 3;
            this.lblN4.Text = "4º Número";
            // 
            // lblN5
            // 
            this.lblN5.AutoSize = true;
            this.lblN5.Location = new System.Drawing.Point(259, 80);
            this.lblN5.Name = "lblN5";
            this.lblN5.Size = new System.Drawing.Size(77, 13);
            this.lblN5.TabIndex = 4;
            this.lblN5.Text = "5º Número";
            // 
            // lblN6
            // 
            this.lblN6.AutoSize = true;
            this.lblN6.Location = new System.Drawing.Point(259, 130);
            this.lblN6.Name = "lblN6";
            this.lblN6.Size = new System.Drawing.Size(77, 13);
            this.lblN6.TabIndex = 5;
            this.lblN6.Text = "6º Número";
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(141, 30);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(100, 21);
            this.txtN1.TabIndex = 6;
            this.txtN1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtN1_KeyDown);
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(141, 80);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(100, 21);
            this.txtN2.TabIndex = 7;
            this.txtN2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtN2_KeyDown);
            // 
            // txtN3
            // 
            this.txtN3.Location = new System.Drawing.Point(141, 130);
            this.txtN3.Name = "txtN3";
            this.txtN3.Size = new System.Drawing.Size(100, 21);
            this.txtN3.TabIndex = 8;
            this.txtN3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtN3_KeyDown);
            // 
            // txtN4
            // 
            this.txtN4.Location = new System.Drawing.Point(368, 30);
            this.txtN4.Name = "txtN4";
            this.txtN4.Size = new System.Drawing.Size(100, 21);
            this.txtN4.TabIndex = 9;
            this.txtN4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtN4_KeyDown);
            // 
            // txtN5
            // 
            this.txtN5.Location = new System.Drawing.Point(368, 80);
            this.txtN5.Name = "txtN5";
            this.txtN5.Size = new System.Drawing.Size(100, 21);
            this.txtN5.TabIndex = 10;
            this.txtN5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtN5_KeyDown);
            // 
            // txtN6
            // 
            this.txtN6.Location = new System.Drawing.Point(368, 130);
            this.txtN6.Name = "txtN6";
            this.txtN6.Size = new System.Drawing.Size(100, 21);
            this.txtN6.TabIndex = 11;
            this.txtN6.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtN6_KeyDown);
            // 
            // lblResultado
            // 
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultado.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(38, 197);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(430, 33);
            this.lblResultado.TabIndex = 12;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gpbBotoes
            // 
            this.gpbBotoes.Controls.Add(this.btnSair);
            this.gpbBotoes.Controls.Add(this.btnLimpa);
            this.gpbBotoes.Controls.Add(this.btnVerifica);
            this.gpbBotoes.Location = new System.Drawing.Point(18, 238);
            this.gpbBotoes.Name = "gpbBotoes";
            this.gpbBotoes.Size = new System.Drawing.Size(471, 75);
            this.gpbBotoes.TabIndex = 13;
            this.gpbBotoes.TabStop = false;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.DarkGray;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSair.Location = new System.Drawing.Point(336, 30);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(106, 29);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpa
            // 
            this.btnLimpa.BackColor = System.Drawing.Color.DarkGray;
            this.btnLimpa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLimpa.Location = new System.Drawing.Point(183, 30);
            this.btnLimpa.Name = "btnLimpa";
            this.btnLimpa.Size = new System.Drawing.Size(106, 29);
            this.btnLimpa.TabIndex = 1;
            this.btnLimpa.Text = "&Limpar";
            this.btnLimpa.UseVisualStyleBackColor = false;
            this.btnLimpa.Click += new System.EventHandler(this.btnLimpa_Click);
            // 
            // btnVerifica
            // 
            this.btnVerifica.BackColor = System.Drawing.Color.DarkGray;
            this.btnVerifica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerifica.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVerifica.Location = new System.Drawing.Point(30, 30);
            this.btnVerifica.Name = "btnVerifica";
            this.btnVerifica.Size = new System.Drawing.Size(106, 29);
            this.btnVerifica.TabIndex = 0;
            this.btnVerifica.Text = "&Verificar";
            this.btnVerifica.UseVisualStyleBackColor = false;
            this.btnVerifica.Click += new System.EventHandler(this.btnVerifica_Click);
            // 
            // FrmMaiorDe6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(496, 319);
            this.Controls.Add(this.gpbBotoes);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtN6);
            this.Controls.Add(this.txtN5);
            this.Controls.Add(this.txtN4);
            this.Controls.Add(this.txtN3);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.lblN6);
            this.Controls.Add(this.lblN5);
            this.Controls.Add(this.lblN4);
            this.Controls.Add(this.lblN3);
            this.Controls.Add(this.lblN2);
            this.Controls.Add(this.lblN1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMaiorDe6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maior Número de 6";
            this.gpbBotoes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblN1;
        private System.Windows.Forms.Label lblN2;
        private System.Windows.Forms.Label lblN3;
        private System.Windows.Forms.Label lblN4;
        private System.Windows.Forms.Label lblN5;
        private System.Windows.Forms.Label lblN6;
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.TextBox txtN3;
        private System.Windows.Forms.TextBox txtN4;
        private System.Windows.Forms.TextBox txtN5;
        private System.Windows.Forms.TextBox txtN6;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.GroupBox gpbBotoes;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpa;
        private System.Windows.Forms.Button btnVerifica;
    }
}

