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
    public partial class F_Principal : Form
    {
        public F_Principal()
        {
            InitializeComponent();
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
    }
}
