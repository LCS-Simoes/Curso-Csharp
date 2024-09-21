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
    public partial class F_ComboBox : Form
    {
        public F_ComboBox()
        {
            InitializeComponent();
        }

        private void btn_selecionados_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cb_transporte.Text);
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            cb_transporte.Items.Clear();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            cb_transporte.Items.Clear();
            cb_transporte.Items.Add("Carro");
            cb_transporte.Items.Add("Avião");
            cb_transporte.Items.Add("Navio");
            cb_transporte.Items.Add("Ônibus");
            cb_transporte.Items.Add("Trem");
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            if(tb_add.Text != "")
            {   
                //FindString = Encontrar string se ele for < 0 é que ele não achou um elemento ja criado
                if(cb_transporte.FindString(tb_add.Text) < 0)
                {
                    cb_transporte.Items.Add(tb_add.Text);
                }
                else
                {
                    MessageBox.Show("Item já existe");
                }
                
            }
        }

        private void cb_transporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_add.Text = cb_transporte.Text;
        }
    }
}
