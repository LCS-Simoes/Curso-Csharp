namespace Aula60
{
    partial class Form1
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
            this.btn_teste = new System.Windows.Forms.Button();
            this.lb_link = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_teste
            // 
            this.btn_teste.BackColor = System.Drawing.Color.Black;
            this.btn_teste.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_teste.ForeColor = System.Drawing.Color.Red;
            this.btn_teste.Location = new System.Drawing.Point(24, 60);
            this.btn_teste.Name = "btn_teste";
            this.btn_teste.Size = new System.Drawing.Size(213, 80);
            this.btn_teste.TabIndex = 0;
            this.btn_teste.Text = "Botão";
            this.btn_teste.UseVisualStyleBackColor = false;
            this.btn_teste.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_link
            // 
            this.lb_link.AutoSize = true;
            this.lb_link.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_link.Location = new System.Drawing.Point(20, 28);
            this.lb_link.Name = "lb_link";
            this.lb_link.Size = new System.Drawing.Size(130, 20);
            this.lb_link.TabIndex = 1;
            this.lb_link.Text = "lucassimoes.com";
            this.lb_link.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(24, 158);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(213, 20);
            this.tb_nome.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 752);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.lb_link);
            this.Controls.Add(this.btn_teste);
            this.Name = "Form1";
            this.Text = "Curso C#";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_teste;
        private System.Windows.Forms.Label lb_link;
        private System.Windows.Forms.TextBox tb_nome;
    }
}

