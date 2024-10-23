namespace Componentes
{
    partial class F_LinkLabel
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.lk_canal = new System.Windows.Forms.LinkLabel();
            this.lk_calculadora = new System.Windows.Forms.LinkLabel();
            this.lk_multiplos = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite seu Nome";
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(25, 38);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(157, 20);
            this.tb_nome.TabIndex = 1;
            // 
            // lk_canal
            // 
            this.lk_canal.AutoSize = true;
            this.lk_canal.Location = new System.Drawing.Point(22, 79);
            this.lk_canal.Name = "lk_canal";
            this.lk_canal.Size = new System.Drawing.Size(34, 13);
            this.lk_canal.TabIndex = 2;
            this.lk_canal.TabStop = true;
            this.lk_canal.Text = "Canal";
            this.lk_canal.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lk_calculadora
            // 
            this.lk_calculadora.AutoSize = true;
            this.lk_calculadora.Location = new System.Drawing.Point(83, 79);
            this.lk_calculadora.Name = "lk_calculadora";
            this.lk_calculadora.Size = new System.Drawing.Size(63, 13);
            this.lk_calculadora.TabIndex = 4;
            this.lk_calculadora.TabStop = true;
            this.lk_calculadora.Text = "Calculadora";
            this.lk_calculadora.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lk_calculadora_LinkClicked);
            // 
            // lk_multiplos
            // 
            this.lk_multiplos.AutoSize = true;
            this.lk_multiplos.Location = new System.Drawing.Point(22, 122);
            this.lk_multiplos.Name = "lk_multiplos";
            this.lk_multiplos.Size = new System.Drawing.Size(126, 13);
            this.lk_multiplos.TabIndex = 5;
            this.lk_multiplos.TabStop = true;
            this.lk_multiplos.Text = "Google - Canal - Youtube";
            this.lk_multiplos.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lk_multiplos_LinkClicked);
            // 
            // F_LinkLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 404);
            this.Controls.Add(this.lk_multiplos);
            this.Controls.Add(this.lk_calculadora);
            this.Controls.Add(this.lk_canal);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "F_LinkLabel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_LinkLabel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.LinkLabel lk_canal;
        private System.Windows.Forms.LinkLabel lk_calculadora;
        private System.Windows.Forms.LinkLabel lk_multiplos;
    }
}