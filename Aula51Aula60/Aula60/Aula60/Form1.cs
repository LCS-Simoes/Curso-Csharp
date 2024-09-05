using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula60
{
    public partial class F_Principal : Form
    {
        public F_Principal()  
        {
            InitializeComponent();
        }
        private void btn_ok_Click(object sender, EventArgs e)
        {
            //Versão resumida

            lb_link.Text = tb_texto.Text;

            /*
            Versão compelxa

                string txt_Modify
                Modify = tb_texto.Text; //.Text é para eu pegar o texto dentro do textbox
                ink.Text = txt_Modify; //.Text recebe a variavel txt que havia pegado o texto do text box
            */
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
