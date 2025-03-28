﻿using System;
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
    public partial class F_MonthCalendar : Form
    {
        public F_MonthCalendar()
        {
            InitializeComponent();
        }

        private void btn_data_Click(object sender, EventArgs e)
        {
              //Capturando a data inicial
              textBox1.Text = monthCalendar1.SelectionStart.ToShortDateString();
              
              //Capturando a data final
              textBox2.Text = monthCalendar1.SelectionEnd.ToShortDateString();

              //Capturando data e hora
              textBox3.Text = monthCalendar1.TodayDate.ToString();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox1.Text = monthCalendar1.SelectionStart.ToShortDateString();
            textBox2.Text = monthCalendar1.SelectionEnd.ToShortDateString();
            textBox3.Text = monthCalendar1.TodayDate.ToString();
        }
    }
}
