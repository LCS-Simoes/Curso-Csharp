namespace Componentes
{
    partial class F_Veiculos
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
            this.tb_listav = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_listav
            // 
            this.tb_listav.Location = new System.Drawing.Point(11, 12);
            this.tb_listav.Multiline = true;
            this.tb_listav.Name = "tb_listav";
            this.tb_listav.Size = new System.Drawing.Size(307, 377);
            this.tb_listav.TabIndex = 0;
            this.tb_listav.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // F_Veiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 401);
            this.Controls.Add(this.tb_listav);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_Veiculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Veiculos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.F_Veiculos_FormClosed);
            this.Load += new System.EventHandler(this.textBox1_TextChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_listav;
    }
}