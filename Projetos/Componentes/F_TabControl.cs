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
    public partial class F_TabControl : Form
    {
        public F_TabControl()
        {
            InitializeComponent();
        }

        private void btn_novaPage_Click(object sender, EventArgs e)
        {
            if(tb_nomePage.Text != null)
            {
                TabPage pagina = new TabPage();
                pagina.Text = tb_nomePage.Text;
                pagina.Name = tb_nomePage.Text;
                pagina.TabIndex = tabControl1.TabPages.Count; //Count ~~> contador de paginas

                tabControl1.TabPages.Add(pagina);
                tb_nomePage.Clear();
                definirMaximo();
            }else
            {
                MessageBox.Show("TextBox vazio, impossivel criar nova TAB");
            }
        }

        private void btn_removerTab_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabControl1.SelectedTab);
        }

        private void btn_pos_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value < tabControl1.TabPages.Count)
            {
                tabControl1.SelectedIndex = Int32.Parse(numericUpDown1.Value.ToString());
                definirMaximo();
            }
            else
            {
                MessageBox.Show("Ultrassou o limite");
            }

        }

        private void definirMaximo()
        {
            numericUpDown1.Maximum = tabControl1.TabPages.Count;   
        }
    }
}
