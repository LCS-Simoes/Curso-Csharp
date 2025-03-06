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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Principal));
            this.btn_add = new System.Windows.Forms.Button();
            this.tb_veiculo = new System.Windows.Forms.TextBox();
            this.lb_init = new System.Windows.Forms.Label();
            this.tb_listav = new System.Windows.Forms.TextBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_mostrar = new System.Windows.Forms.Button();
            this.btn_valor = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.componentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkedListBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimePickerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkLabelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maskedBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthCalendarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numericUpDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trackBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.MenuNotificacoes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tspmi_restaurar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmpi_mensagem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmpi_fechar = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.MenuNotificacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(188, 44);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Adicionar";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // tb_veiculo
            // 
            this.tb_veiculo.Location = new System.Drawing.Point(12, 44);
            this.tb_veiculo.Name = "tb_veiculo";
            this.tb_veiculo.Size = new System.Drawing.Size(170, 20);
            this.tb_veiculo.TabIndex = 1;
            // 
            // lb_init
            // 
            this.lb_init.AutoSize = true;
            this.lb_init.Location = new System.Drawing.Point(12, 28);
            this.lb_init.Name = "lb_init";
            this.lb_init.Size = new System.Drawing.Size(90, 13);
            this.lb_init.TabIndex = 2;
            this.lb_init.Text = "Digite um veículo";
            // 
            // tb_listav
            // 
            this.tb_listav.Location = new System.Drawing.Point(12, 70);
            this.tb_listav.Multiline = true;
            this.tb_listav.Name = "tb_listav";
            this.tb_listav.Size = new System.Drawing.Size(251, 235);
            this.tb_listav.TabIndex = 3;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(12, 312);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(251, 23);
            this.btn_Clear.TabIndex = 4;
            this.btn_Clear.Text = "Limpar";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_mostrar
            // 
            this.btn_mostrar.Location = new System.Drawing.Point(12, 341);
            this.btn_mostrar.Name = "btn_mostrar";
            this.btn_mostrar.Size = new System.Drawing.Size(251, 23);
            this.btn_mostrar.TabIndex = 5;
            this.btn_mostrar.Text = "Mostrar Veiculos";
            this.btn_mostrar.UseVisualStyleBackColor = true;
            this.btn_mostrar.Click += new System.EventHandler(this.btn_mostrar_Click);
            // 
            // btn_valor
            // 
            this.btn_valor.Location = new System.Drawing.Point(12, 371);
            this.btn_valor.Name = "btn_valor";
            this.btn_valor.Size = new System.Drawing.Size(251, 23);
            this.btn_valor.TabIndex = 7;
            this.btn_valor.Text = "Valor da Variavel NUM";
            this.btn_valor.UseVisualStyleBackColor = true;
            this.btn_valor.Click += new System.EventHandler(this.btn_valor_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.componentesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(269, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // componentesToolStripMenuItem
            // 
            this.componentesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkBoxToolStripMenuItem,
            this.checkedListBoxToolStripMenuItem,
            this.comboBoxToolStripMenuItem,
            this.dateTimePickerToolStripMenuItem,
            this.linkLabelToolStripMenuItem,
            this.listBoxToolStripMenuItem,
            this.listViewToolStripMenuItem,
            this.maskedBoxToolStripMenuItem,
            this.monthCalendarToolStripMenuItem,
            this.numericUpDownToolStripMenuItem,
            this.trackBarToolStripMenuItem,
            this.treeViewToolStripMenuItem,
            this.splitContainerToolStripMenuItem,
            this.tabControlToolStripMenuItem});
            this.componentesToolStripMenuItem.Name = "componentesToolStripMenuItem";
            this.componentesToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.componentesToolStripMenuItem.Text = "Componentes";
            // 
            // checkBoxToolStripMenuItem
            // 
            this.checkBoxToolStripMenuItem.Name = "checkBoxToolStripMenuItem";
            this.checkBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.checkBoxToolStripMenuItem.Text = "CheckBox";
            this.checkBoxToolStripMenuItem.Click += new System.EventHandler(this.checkBoxToolStripMenuItem_Click);
            // 
            // checkedListBoxToolStripMenuItem
            // 
            this.checkedListBoxToolStripMenuItem.Name = "checkedListBoxToolStripMenuItem";
            this.checkedListBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.checkedListBoxToolStripMenuItem.Text = "CheckedListBox";
            this.checkedListBoxToolStripMenuItem.Click += new System.EventHandler(this.checkedListBoxToolStripMenuItem_Click);
            // 
            // comboBoxToolStripMenuItem
            // 
            this.comboBoxToolStripMenuItem.Name = "comboBoxToolStripMenuItem";
            this.comboBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.comboBoxToolStripMenuItem.Text = "ComboBox";
            this.comboBoxToolStripMenuItem.Click += new System.EventHandler(this.comboBoxToolStripMenuItem_Click);
            // 
            // dateTimePickerToolStripMenuItem
            // 
            this.dateTimePickerToolStripMenuItem.Name = "dateTimePickerToolStripMenuItem";
            this.dateTimePickerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dateTimePickerToolStripMenuItem.Text = "DateTimePicker";
            this.dateTimePickerToolStripMenuItem.Click += new System.EventHandler(this.dateTimePickerToolStripMenuItem_Click);
            // 
            // linkLabelToolStripMenuItem
            // 
            this.linkLabelToolStripMenuItem.Name = "linkLabelToolStripMenuItem";
            this.linkLabelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.linkLabelToolStripMenuItem.Text = "LinkLabel";
            this.linkLabelToolStripMenuItem.Click += new System.EventHandler(this.linkLabelToolStripMenuItem_Click);
            // 
            // listBoxToolStripMenuItem
            // 
            this.listBoxToolStripMenuItem.Name = "listBoxToolStripMenuItem";
            this.listBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listBoxToolStripMenuItem.Text = "ListBox";
            this.listBoxToolStripMenuItem.Click += new System.EventHandler(this.listBoxToolStripMenuItem_Click);
            // 
            // listViewToolStripMenuItem
            // 
            this.listViewToolStripMenuItem.Name = "listViewToolStripMenuItem";
            this.listViewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listViewToolStripMenuItem.Text = "ListView";
            this.listViewToolStripMenuItem.Click += new System.EventHandler(this.listViewToolStripMenuItem_Click);
            // 
            // maskedBoxToolStripMenuItem
            // 
            this.maskedBoxToolStripMenuItem.Name = "maskedBoxToolStripMenuItem";
            this.maskedBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.maskedBoxToolStripMenuItem.Text = "MaskedBox";
            this.maskedBoxToolStripMenuItem.Click += new System.EventHandler(this.maskedBoxToolStripMenuItem_Click);
            // 
            // monthCalendarToolStripMenuItem
            // 
            this.monthCalendarToolStripMenuItem.Name = "monthCalendarToolStripMenuItem";
            this.monthCalendarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.monthCalendarToolStripMenuItem.Text = "MonthCalendar";
            this.monthCalendarToolStripMenuItem.Click += new System.EventHandler(this.monthCalendarToolStripMenuItem_Click);
            // 
            // numericUpDownToolStripMenuItem
            // 
            this.numericUpDownToolStripMenuItem.Name = "numericUpDownToolStripMenuItem";
            this.numericUpDownToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.numericUpDownToolStripMenuItem.Text = "NumericUpDown";
            this.numericUpDownToolStripMenuItem.Click += new System.EventHandler(this.numericUpDownToolStripMenuItem_Click);
            // 
            // trackBarToolStripMenuItem
            // 
            this.trackBarToolStripMenuItem.Name = "trackBarToolStripMenuItem";
            this.trackBarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.trackBarToolStripMenuItem.Text = "TrackBar";
            this.trackBarToolStripMenuItem.Click += new System.EventHandler(this.trackBarToolStripMenuItem_Click);
            // 
            // treeViewToolStripMenuItem
            // 
            this.treeViewToolStripMenuItem.Name = "treeViewToolStripMenuItem";
            this.treeViewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.treeViewToolStripMenuItem.Text = "TreeView";
            this.treeViewToolStripMenuItem.Click += new System.EventHandler(this.treeViewToolStripMenuItem_Click);
            // 
            // splitContainerToolStripMenuItem
            // 
            this.splitContainerToolStripMenuItem.Name = "splitContainerToolStripMenuItem";
            this.splitContainerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.splitContainerToolStripMenuItem.Text = "SplitContainer";
            this.splitContainerToolStripMenuItem.Click += new System.EventHandler(this.splitContainerToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.MenuNotificacoes;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // MenuNotificacoes
            // 
            this.MenuNotificacoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspmi_restaurar,
            this.tsmpi_mensagem,
            this.tsmpi_fechar});
            this.MenuNotificacoes.Name = "contextMenuStrip1";
            this.MenuNotificacoes.Size = new System.Drawing.Size(134, 70);
            this.MenuNotificacoes.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuNotificacoes_ItemClicked);
            // 
            // tspmi_restaurar
            // 
            this.tspmi_restaurar.Name = "tspmi_restaurar";
            this.tspmi_restaurar.Size = new System.Drawing.Size(133, 22);
            this.tspmi_restaurar.Text = "Restaurar";
            // 
            // tsmpi_mensagem
            // 
            this.tsmpi_mensagem.Name = "tsmpi_mensagem";
            this.tsmpi_mensagem.Size = new System.Drawing.Size(133, 22);
            this.tsmpi_mensagem.Text = "Mensagem";
            // 
            // tsmpi_fechar
            // 
            this.tsmpi_fechar.Name = "tsmpi_fechar";
            this.tsmpi_fechar.Size = new System.Drawing.Size(133, 22);
            this.tsmpi_fechar.Text = "Fechar";
            // 
            // tabControlToolStripMenuItem
            // 
            this.tabControlToolStripMenuItem.Name = "tabControlToolStripMenuItem";
            this.tabControlToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tabControlToolStripMenuItem.Text = "TabControl";
            this.tabControlToolStripMenuItem.Click += new System.EventHandler(this.tabControlToolStripMenuItem_Click);
            // 
            // F_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 408);
            this.Controls.Add(this.btn_valor);
            this.Controls.Add(this.btn_mostrar);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.tb_listav);
            this.Controls.Add(this.lb_init);
            this.Controls.Add(this.tb_veiculo);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "F_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Componentes";
            this.Load += new System.EventHandler(this.F_Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.MenuNotificacoes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox tb_veiculo;
        private System.Windows.Forms.Label lb_init;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_mostrar;
        private System.Windows.Forms.Button btn_valor;
        public System.Windows.Forms.TextBox tb_listav;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem componentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkedListBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comboBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateTimePickerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linkLabelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maskedBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monthCalendarToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip MenuNotificacoes;
        private System.Windows.Forms.ToolStripMenuItem tspmi_restaurar;
        private System.Windows.Forms.ToolStripMenuItem tsmpi_mensagem;
        private System.Windows.Forms.ToolStripMenuItem tsmpi_fechar;
        private System.Windows.Forms.ToolStripMenuItem numericUpDownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trackBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem treeViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem splitContainerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabControlToolStripMenuItem;
    }
}

