namespace Componentes
{
    partial class F_CheckedListBox
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
            this.clb_transportes = new System.Windows.Forms.CheckedListBox();
            this.btn_mostrarselecionados = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.tb_add = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clb_transportes
            // 
            this.clb_transportes.FormattingEnabled = true;
            this.clb_transportes.Items.AddRange(new object[] {
            "Carro",
            "Avião",
            "Navio",
            "Ônibus",
            "Trem"});
            this.clb_transportes.Location = new System.Drawing.Point(13, 13);
            this.clb_transportes.Name = "clb_transportes";
            this.clb_transportes.Size = new System.Drawing.Size(121, 184);
            this.clb_transportes.TabIndex = 0;
            // 
            // btn_mostrarselecionados
            // 
            this.btn_mostrarselecionados.Location = new System.Drawing.Point(139, 13);
            this.btn_mostrarselecionados.Name = "btn_mostrarselecionados";
            this.btn_mostrarselecionados.Size = new System.Drawing.Size(173, 23);
            this.btn_mostrarselecionados.TabIndex = 1;
            this.btn_mostrarselecionados.Text = "Mostrar Selecionados";
            this.btn_mostrarselecionados.UseVisualStyleBackColor = true;
            this.btn_mostrarselecionados.Click += new System.EventHandler(this.btn_mostrarselecionados_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(139, 72);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(172, 23);
            this.btn_limpar.TabIndex = 2;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(140, 43);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(172, 23);
            this.btn_reset.TabIndex = 3;
            this.btn_reset.Text = "Resetar Lista";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(139, 171);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(171, 23);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "Adicionar novo transporte";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // tb_add
            // 
            this.tb_add.Location = new System.Drawing.Point(139, 145);
            this.tb_add.Name = "tb_add";
            this.tb_add.Size = new System.Drawing.Size(172, 20);
            this.tb_add.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Digite um novo TRANSPORTE";
            // 
            // F_CheckedListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 387);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_add);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_mostrarselecionados);
            this.Controls.Add(this.clb_transportes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_CheckedListBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckedListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clb_transportes;
        private System.Windows.Forms.Button btn_mostrarselecionados;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox tb_add;
        private System.Windows.Forms.Label label1;
    }
}