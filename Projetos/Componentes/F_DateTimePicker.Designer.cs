namespace Componentes
{
    partial class F_DateTimePicker
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
            this.btn_obterData = new System.Windows.Forms.Button();
            this.dtp_data = new System.Windows.Forms.DateTimePicker();
            this.tb_dia = new System.Windows.Forms.TextBox();
            this.tb_mes = new System.Windows.Forms.TextBox();
            this.tb_ano = new System.Windows.Forms.TextBox();
            this.tb_data = new System.Windows.Forms.TextBox();
            this.btn_setData = new System.Windows.Forms.Button();
            this.btn_hoje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_obterData
            // 
            this.btn_obterData.Location = new System.Drawing.Point(329, 23);
            this.btn_obterData.Name = "btn_obterData";
            this.btn_obterData.Size = new System.Drawing.Size(182, 23);
            this.btn_obterData.TabIndex = 0;
            this.btn_obterData.Text = "Obter Data";
            this.btn_obterData.UseVisualStyleBackColor = true;
            this.btn_obterData.Click += new System.EventHandler(this.btn_obterData_Click);
            // 
            // dtp_data
            // 
            this.dtp_data.Location = new System.Drawing.Point(12, 23);
            this.dtp_data.Name = "dtp_data";
            this.dtp_data.Size = new System.Drawing.Size(311, 20);
            this.dtp_data.TabIndex = 1;
            // 
            // tb_dia
            // 
            this.tb_dia.Location = new System.Drawing.Point(12, 75);
            this.tb_dia.Name = "tb_dia";
            this.tb_dia.Size = new System.Drawing.Size(100, 20);
            this.tb_dia.TabIndex = 2;
            // 
            // tb_mes
            // 
            this.tb_mes.Location = new System.Drawing.Point(118, 75);
            this.tb_mes.Name = "tb_mes";
            this.tb_mes.Size = new System.Drawing.Size(100, 20);
            this.tb_mes.TabIndex = 3;
            // 
            // tb_ano
            // 
            this.tb_ano.Location = new System.Drawing.Point(224, 75);
            this.tb_ano.Name = "tb_ano";
            this.tb_ano.Size = new System.Drawing.Size(100, 20);
            this.tb_ano.TabIndex = 4;
            // 
            // tb_data
            // 
            this.tb_data.Location = new System.Drawing.Point(12, 49);
            this.tb_data.Name = "tb_data";
            this.tb_data.Size = new System.Drawing.Size(312, 20);
            this.tb_data.TabIndex = 5;
            // 
            // btn_setData
            // 
            this.btn_setData.Location = new System.Drawing.Point(328, 72);
            this.btn_setData.Name = "btn_setData";
            this.btn_setData.Size = new System.Drawing.Size(182, 23);
            this.btn_setData.TabIndex = 9;
            this.btn_setData.Text = "Setar Data";
            this.btn_setData.UseVisualStyleBackColor = true;
            this.btn_setData.Click += new System.EventHandler(this.btn_setData_Click);
            // 
            // btn_hoje
            // 
            this.btn_hoje.Location = new System.Drawing.Point(329, 101);
            this.btn_hoje.Name = "btn_hoje";
            this.btn_hoje.Size = new System.Drawing.Size(182, 23);
            this.btn_hoje.TabIndex = 10;
            this.btn_hoje.Text = "Hoje";
            this.btn_hoje.UseVisualStyleBackColor = true;
            this.btn_hoje.Click += new System.EventHandler(this.btn_hoje_Click);
            // 
            // F_DateTimePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 234);
            this.Controls.Add(this.btn_hoje);
            this.Controls.Add(this.btn_setData);
            this.Controls.Add(this.tb_data);
            this.Controls.Add(this.tb_ano);
            this.Controls.Add(this.tb_mes);
            this.Controls.Add(this.tb_dia);
            this.Controls.Add(this.dtp_data);
            this.Controls.Add(this.btn_obterData);
            this.Name = "F_DateTimePicker";
            this.Text = "F_DateTimePicker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_obterData;
        private System.Windows.Forms.DateTimePicker dtp_data;
        private System.Windows.Forms.TextBox tb_dia;
        private System.Windows.Forms.TextBox tb_mes;
        private System.Windows.Forms.TextBox tb_ano;
        private System.Windows.Forms.TextBox tb_data;
        private System.Windows.Forms.Button btn_setData;
        private System.Windows.Forms.Button btn_hoje;
    }
}