﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes
{
    public partial class F_Principal : Form
    {
        public int num;
        public F_Principal()
        {
            InitializeComponent();
            this.num = 0;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(tb_veiculo.TextLength == 0)
            {
                MessageBox.Show("Digite um veiculo para poder adicionar");
                tb_veiculo.Focus(); //Focus leva o cursor até o local
                return; //para a execução do evento
            }

            //Passando os valores do tb veiculo para lista
            tb_listav.Text += tb_veiculo.Text + ", ";

            //Limpa após adicionar e retorna o cursor ao label
            tb_veiculo.Clear();
            tb_veiculo.Focus();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            tb_listav.Clear();
            tb_veiculo.Clear();
            tb_veiculo.Focus();
        }

        private void F_Principal_Load(object sender, EventArgs e)
        {

        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            //Iniciando proximo form

            //Declaração da objeto da classe F_Veiculos
            F_Veiculos f_Veiculos = new F_Veiculos(tb_listav.Text, this);
            f_Veiculos.ShowDialog(); 
            // Exibe o formulario mas poderia ser show / Dialog prende o usuario a tela
        }

        private void btn_valor_Click(object sender, EventArgs e)
        {
            MessageBox.Show(num.ToString());
        }

        private void checkBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_CheckBox f_checkbox = new F_CheckBox();
            f_checkbox.ShowDialog();
        }

        private void checkedListBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_CheckedListBox f_checklistbox = new F_CheckedListBox();
            f_checklistbox.ShowDialog();
        }

        private void comboBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ComboBox f_comboBox = new F_ComboBox();
            f_comboBox.ShowDialog();
        }

        private void dateTimePickerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_DateTimePicker f_date = new F_DateTimePicker();  
            f_date.ShowDialog();    
        }

        private void linkLabelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_LinkLabel f_link = new F_LinkLabel();
            f_link.ShowDialog();
        }

        private void listBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ListBox f_ListBox = new F_ListBox(); 
            f_ListBox.ShowDialog();
        }

        private void listViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ListView f_listView = new F_ListView();
            f_listView.ShowDialog();
        }
    }
}
