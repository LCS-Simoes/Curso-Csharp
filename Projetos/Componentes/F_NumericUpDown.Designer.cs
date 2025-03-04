namespace Componentes
{
    partial class F_NumericUpDown
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.tb_valor = new System.Windows.Forms.TextBox();
            this.btn_definir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(24, 13);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 0;
            // 
            // tb_valor
            // 
            this.tb_valor.Location = new System.Drawing.Point(164, 12);
            this.tb_valor.Name = "tb_valor";
            this.tb_valor.Size = new System.Drawing.Size(100, 20);
            this.tb_valor.TabIndex = 1;
            this.tb_valor.Text = "0";
            // 
            // btn_definir
            // 
            this.btn_definir.Location = new System.Drawing.Point(115, 55);
            this.btn_definir.Name = "btn_definir";
            this.btn_definir.Size = new System.Drawing.Size(75, 23);
            this.btn_definir.TabIndex = 2;
            this.btn_definir.Text = "Definir Valor";
            this.btn_definir.UseVisualStyleBackColor = true;
            this.btn_definir.Click += new System.EventHandler(this.btn_definir_Click);
            // 
            // F_NumericUpDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 370);
            this.Controls.Add(this.btn_definir);
            this.Controls.Add(this.tb_valor);
            this.Controls.Add(this.numericUpDown1);
            this.Name = "F_NumericUpDown";
            this.Text = "F_NumericUpDown";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox tb_valor;
        private System.Windows.Forms.Button btn_definir;
    }
}