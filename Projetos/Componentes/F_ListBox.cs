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
    public partial class F_ListBox : Form
    {
        List<string> carros = new List<string>();
        public F_ListBox()
        {
            InitializeComponent();
            carros.Add("Celta");
            carros.Add("Golf");
            carros.Add("Onix");

            //Adicionando no listbox através do data source
            lb_carros.DataSource = carros;
        }

        private void atualizar()
        {
            lb_carros.DataSource = null; //Reseta a Lista
            lb_carros.DataSource = carros; // Adiciona na lista
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (tb_carro.Text == null)
            {
                MessageBox.Show("Digite um carro");
                tb_carro.Focus();
            }
            else
            {
                //Pegando o texto do text box e adicionando na lista carro
                carros.Add(tb_carro.Text);
                tb_carro.Clear();
                atualizar();
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            carros.RemoveAt(lb_carros.SelectedIndex);
            atualizar();
        }

        private void btn_obter_Click(object sender, EventArgs e)
        {
            tb_carro.Text = carros[lb_carros.SelectedIndex];
        }

        private void lb_clear_Click(object sender, EventArgs e)
        {
            carros.Clear();
            atualizar();
        }
    }
}
