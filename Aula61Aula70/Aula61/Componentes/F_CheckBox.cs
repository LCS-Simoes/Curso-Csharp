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
    public partial class F_CheckBox : Form
    {
        List<CheckBox> Transporte = new List<CheckBox>();
        public F_CheckBox()
        {
            InitializeComponent();
            //Adicionando na lista os checkbox
            Transporte.Add(cb_carro);
            Transporte.Add(cb_aviao);
            Transporte.Add(cb_navio);
            Transporte.Add(cb_onibus);

        }

        private void btn_transportesMarcados_Click(object sender, EventArgs e)
        {
            //Imprimindo os checkbox marcados através da lista
            string txt = "";
            foreach(CheckBox t in Transporte)
            {
                if (t.Checked)
                {
                    txt += t.Text + ", ";
                }
            }
            MessageBox.Show(txt); //Exibe a variavel txt
        }

        private void cb_patinete_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_patinete.Checked)
            {
                MessageBox.Show("Patinete marcado");
            }
        }

        private void btn_filho_Click(object sender, EventArgs e)
        {
            F_FilhoCheckBox f_filho = new F_FilhoCheckBox();
            f_filho.ShowDialog();
        }
    }
}
