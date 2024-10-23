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
    public partial class F_LinkLabel : Form
    {
        public F_LinkLabel()
        {
            InitializeComponent();
            lk_multiplos.Links.Add(0,6,"www.google.com");
            lk_multiplos.Links.Add(9, 5, "http://youtube.com/prizza");
            lk_multiplos.Links.Add(17, 7, "http://youtube.com");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel ll = (LinkLabel)sender;

            //Inicia um processo que automaticamente abre o browse e a URL
            System.Diagnostics.Process.Start("http://youtube.com/" + tb_nome.Text); //Link da Web
            ll.LinkVisited = true; //Passa a cor para roxo que significa como visitado
        }

        private void lk_calculadora_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");  //Calculadora Windows
            
        }

        private void lk_multiplos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Inicio o parametro E do próprio processo 
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());

            //Versão de link visited no E
            e.Link.Visited = true;
        }
    }
}
