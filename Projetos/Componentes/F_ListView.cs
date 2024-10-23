using System;
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
    public partial class F_ListView : Form
    {
        public F_ListView()
        {
            InitializeComponent();
        }

        private void Clear()
        {
            tb_id.Clear();
            tb_preco.Clear();
            tb_qtd.Clear();
            tb_produto.Clear();
            tb_id.Focus();
        }

        private void Obter()
        {
            tb_id.Text = lv_produtos.SelectedItems[0].SubItems[0].Text;
            tb_produto.Text = lv_produtos.SelectedItems[0].SubItems[1].Text;
            tb_qtd.Text = lv_produtos.SelectedItems[0].SubItems[2].Text;
            tb_preco.Text = lv_produtos.SelectedItems[0].SubItems[3].Text;
        }


        private void btn_add_Click(object sender, EventArgs e)
        {
            if (tb_id.Text == "")
            {
                MessageBox.Show("ID Não pode ser vazio");
                tb_id.Focus();
            }if (tb_produto.Text == "")
            {
                MessageBox.Show("Produto Não pode ser vazio");
                tb_produto.Focus();
            }
            if (tb_qtd.Text == "")
            {
                MessageBox.Show("Quantidade Não pode ser vazio");
                tb_qtd.Focus();
            }
            if (tb_preco.Text == "")
            {
                MessageBox.Show("Preço Não pode ser vazio");
                tb_preco.Focus();
            }
            //Item Colunas  / SubItems Linhas
            string[] produtos = new string[4];
            produtos[0] = tb_id.Text;
            produtos[1] = tb_produto.Text;
            produtos[2] = tb_qtd.Text;
            produtos[3] = tb_preco.Text;

            ListViewItem l = new ListViewItem(produtos);
            lv_produtos.Items.Add(l);
            Clear();
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            lv_produtos.Items.RemoveAt(lv_produtos.SelectedIndices[0]);
        }

        private void btn_obter_Click(object sender, EventArgs e)
        {
            Obter();
        }

        private void lv_produtos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_produtos.SelectedItems.Count > 0)
            {
                Obter();
            }
        }
    }
}
