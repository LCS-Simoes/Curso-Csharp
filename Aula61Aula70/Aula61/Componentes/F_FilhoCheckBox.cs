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
    public partial class F_FilhoCheckBox : Form
    {
        public F_CheckBox fcb;
        public F_FilhoCheckBox()
        {
            InitializeComponent();
            try
            {
                //Aponto para o formulario F_CheckBox o AS serve para "modificar" o tipo
                fcb = Application.OpenForms["F_CheckBox"] as F_CheckBox;
                //Relacionando componentes do form pai pro filho
                cb_carro.Checked = fcb.cb_carro.Checked;
                cb_aviao.Checked = fcb.cb_aviao.Checked;
                cb_navio.Checked = fcb.cb_navio.Checked;
                cb_onibus.Checked = fcb.cb_onibus.Checked;
            }catch
            {
                MessageBox.Show("Formulário não encontrado ou não aberto");
            }  
        }

        private void cb_carro_CheckedChanged(object sender, EventArgs e)
        {
            fcb.cb_carro.Checked = cb_carro.Checked;
        }

        private void cb_aviao_CheckedChanged(object sender, EventArgs e)
        {
            fcb.cb_aviao.Checked = cb_aviao.Checked;
        }

        private void cb_navio_CheckedChanged(object sender, EventArgs e)
        {
            fcb.cb_navio.Checked = cb_navio.Checked;
        }

        private void cb_onibus_CheckedChanged(object sender, EventArgs e)
        {   
            fcb.cb_onibus.Checked= cb_onibus.Checked;  
        }

        private void cb_patinete_CheckedChanged(object sender, EventArgs e)
        {
            fcb.cb_patinete.Checked = cb_patinete.Checked;  
        }
    }
}
