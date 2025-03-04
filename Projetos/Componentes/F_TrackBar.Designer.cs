namespace Componentes
{
    partial class F_TrackBar
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
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.tb_valor = new System.Windows.Forms.TextBox();
            this.lb_valor = new System.Windows.Forms.Label();
            this.btn_definir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(13, 13);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(775, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // tb_valor
            // 
            this.tb_valor.Location = new System.Drawing.Point(13, 65);
            this.tb_valor.Name = "tb_valor";
            this.tb_valor.Size = new System.Drawing.Size(273, 20);
            this.tb_valor.TabIndex = 1;
            // 
            // lb_valor
            // 
            this.lb_valor.AutoSize = true;
            this.lb_valor.Location = new System.Drawing.Point(13, 92);
            this.lb_valor.Name = "lb_valor";
            this.lb_valor.Size = new System.Drawing.Size(35, 13);
            this.lb_valor.TabIndex = 2;
            this.lb_valor.Text = "label1";
            // 
            // btn_definir
            // 
            this.btn_definir.Location = new System.Drawing.Point(304, 65);
            this.btn_definir.Name = "btn_definir";
            this.btn_definir.Size = new System.Drawing.Size(75, 23);
            this.btn_definir.TabIndex = 3;
            this.btn_definir.Text = "Definir";
            this.btn_definir.UseVisualStyleBackColor = true;
            this.btn_definir.Click += new System.EventHandler(this.btn_definir_Click);
            // 
            // F_TrackBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_definir);
            this.Controls.Add(this.lb_valor);
            this.Controls.Add(this.tb_valor);
            this.Controls.Add(this.trackBar1);
            this.Name = "F_TrackBar";
            this.Text = "F_TrackBar";
            this.Load += new System.EventHandler(this.F_TrackBar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TextBox tb_valor;
        private System.Windows.Forms.Label lb_valor;
        private System.Windows.Forms.Button btn_definir;
    }
}