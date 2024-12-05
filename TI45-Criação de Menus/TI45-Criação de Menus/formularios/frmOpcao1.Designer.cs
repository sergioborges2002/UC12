namespace TI45_Criação_de_Menus.formularios
{
    partial class frmOpcao1
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnSaudacao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Calisto MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(175, 5);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(351, 36);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Formulário da Opção 1";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(123, 77);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(520, 22);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Este formulário captura um nome e retorna uma saudação";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(137, 163);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(60, 20);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(203, 160);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(361, 30);
            this.txtNome.TabIndex = 3;
            // 
            // btnSaudacao
            // 
            this.btnSaudacao.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaudacao.Location = new System.Drawing.Point(277, 236);
            this.btnSaudacao.Name = "btnSaudacao";
            this.btnSaudacao.Size = new System.Drawing.Size(159, 41);
            this.btnSaudacao.TabIndex = 4;
            this.btnSaudacao.Text = "Saudações";
            this.btnSaudacao.UseVisualStyleBackColor = true;
            this.btnSaudacao.Click += new System.EventHandler(this.btnSaudacao_Click);
            // 
            // frmOpcao1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(710, 330);
            this.Controls.Add(this.btnSaudacao);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Name = "frmOpcao1";
            this.Text = "frmOpcao1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnSaudacao;
    }
}