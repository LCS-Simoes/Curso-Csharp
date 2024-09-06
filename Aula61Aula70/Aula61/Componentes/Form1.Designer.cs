namespace Componentes
{
    partial class F_Principal
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
            this.btn_add = new System.Windows.Forms.Button();
            this.tb_veiculo = new System.Windows.Forms.TextBox();
            this.lb_init = new System.Windows.Forms.Label();
            this.tb_listav = new System.Windows.Forms.TextBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(188, 25);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Adicionar";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // tb_veiculo
            // 
            this.tb_veiculo.Location = new System.Drawing.Point(12, 25);
            this.tb_veiculo.Name = "tb_veiculo";
            this.tb_veiculo.Size = new System.Drawing.Size(170, 20);
            this.tb_veiculo.TabIndex = 1;
            // 
            // lb_init
            // 
            this.lb_init.AutoSize = true;
            this.lb_init.Location = new System.Drawing.Point(12, 9);
            this.lb_init.Name = "lb_init";
            this.lb_init.Size = new System.Drawing.Size(90, 13);
            this.lb_init.TabIndex = 2;
            this.lb_init.Text = "Digite um veículo";
            // 
            // tb_listav
            // 
            this.tb_listav.Location = new System.Drawing.Point(12, 51);
            this.tb_listav.Multiline = true;
            this.tb_listav.Name = "tb_listav";
            this.tb_listav.Size = new System.Drawing.Size(251, 235);
            this.tb_listav.TabIndex = 3;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(12, 293);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(251, 23);
            this.btn_Clear.TabIndex = 4;
            this.btn_Clear.Text = "Limpar";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // F_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 334);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.tb_listav);
            this.Controls.Add(this.lb_init);
            this.Controls.Add(this.tb_veiculo);
            this.Controls.Add(this.btn_add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Componentes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox tb_veiculo;
        private System.Windows.Forms.Label lb_init;
        private System.Windows.Forms.TextBox tb_listav;
        private System.Windows.Forms.Button btn_Clear;
    }
}

