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
    public partial class F_MaskedBox : Form
    {
        public F_MaskedBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                //Se estiver marcado ele exibe somente o texto digitado
                maskedTextBox1.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            }
            else
            {
                //Se o checkbox não estiver marcado eu irei incluir no formato da masked qualquer caracter definido na mascara
                maskedTextBox1.TextMaskFormat = MaskFormat.IncludeLiterals;
            }

            String msg = maskedTextBox1.Text;
            MessageBox.Show(msg);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                String msg = mb_senha.Text;
                mb_senha.PasswordChar = msg[0];
            }else
            {
                mb_senha.PasswordChar = '*';
            }
        }
    }
}
