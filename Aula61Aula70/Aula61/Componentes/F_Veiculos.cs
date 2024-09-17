using System;
using System.Windows.Forms;

namespace Componentes
{
    public partial class F_Veiculos : Form
    {

        F_Principal fp;
        public F_Veiculos(String v, F_Principal f)
        {
            InitializeComponent();
            tb_listav.Text = v;
            fp = f;
            f.num = 10;
        }


        private void F_Veiculos_FormClosed(object sender, FormClosedEventArgs e)
        {
            fp.tb_listav.Text = tb_listav.Text;
        }



        //Descarte
        private void F_Veiculos_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
