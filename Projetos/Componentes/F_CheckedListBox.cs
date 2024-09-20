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
    public partial class F_CheckedListBox : Form
    {
        public F_CheckedListBox()
        {
            InitializeComponent();
        }

        private void btn_mostrarselecionados_Click(object sender, EventArgs e)
        {
            string txt = "";
            foreach (string t  in clb_transportes.CheckedItems)
            {
                txt += t + ", ";
            }
            
            MessageBox.Show(txt);
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            clb_transportes.Items.Clear();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            //Chamo pelo nome do objeto e passo pra false assim ele limpa todos
            clb_transportes.Items.Clear();
            clb_transportes.Items.Add("Carro", false);
            clb_transportes.Items.Add("Avião", false);
            clb_transportes.Items.Add("Navio", false);
            clb_transportes.Items.Add("Ônibus", false);
            clb_transportes.Items.Add("Trem", false);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(tb_add.Text != "")
            {
                clb_transportes.Items.Add(tb_add.Text);
                tb_add.Clear();
                tb_add.Focus();
            }
            else
            {
                MessageBox.Show("Adicione um texto");
            }
            
        }
    }
}
