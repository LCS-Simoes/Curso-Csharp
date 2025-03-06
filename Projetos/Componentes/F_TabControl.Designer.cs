namespace Componentes
{
    partial class F_TabControl
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tb_nomePage = new System.Windows.Forms.TextBox();
            this.btn_novaPage = new System.Windows.Forms.Button();
            this.btn_removerTab = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btn_pos = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 69);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 369);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 343);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Componentes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 343);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tb_nomePage
            // 
            this.tb_nomePage.Location = new System.Drawing.Point(16, 13);
            this.tb_nomePage.Name = "tb_nomePage";
            this.tb_nomePage.Size = new System.Drawing.Size(156, 20);
            this.tb_nomePage.TabIndex = 1;
            // 
            // btn_novaPage
            // 
            this.btn_novaPage.Location = new System.Drawing.Point(16, 40);
            this.btn_novaPage.Name = "btn_novaPage";
            this.btn_novaPage.Size = new System.Drawing.Size(75, 23);
            this.btn_novaPage.TabIndex = 2;
            this.btn_novaPage.Text = "Adicionar";
            this.btn_novaPage.UseVisualStyleBackColor = true;
            this.btn_novaPage.Click += new System.EventHandler(this.btn_novaPage_Click);
            // 
            // btn_removerTab
            // 
            this.btn_removerTab.Location = new System.Drawing.Point(97, 40);
            this.btn_removerTab.Name = "btn_removerTab";
            this.btn_removerTab.Size = new System.Drawing.Size(75, 23);
            this.btn_removerTab.TabIndex = 3;
            this.btn_removerTab.Text = "Remover";
            this.btn_removerTab.UseVisualStyleBackColor = true;
            this.btn_removerTab.Click += new System.EventHandler(this.btn_removerTab_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(198, 13);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 4;
            // 
            // btn_pos
            // 
            this.btn_pos.Location = new System.Drawing.Point(198, 40);
            this.btn_pos.Name = "btn_pos";
            this.btn_pos.Size = new System.Drawing.Size(120, 23);
            this.btn_pos.TabIndex = 5;
            this.btn_pos.Text = "Posicionar";
            this.btn_pos.UseVisualStyleBackColor = true;
            this.btn_pos.Click += new System.EventHandler(this.btn_pos_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // F_TabControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_pos);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btn_removerTab);
            this.Controls.Add(this.btn_novaPage);
            this.Controls.Add(this.tb_nomePage);
            this.Controls.Add(this.tabControl1);
            this.Name = "F_TabControl";
            this.Text = "F_TabControl";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tb_nomePage;
        private System.Windows.Forms.Button btn_novaPage;
        private System.Windows.Forms.Button btn_removerTab;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btn_pos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}