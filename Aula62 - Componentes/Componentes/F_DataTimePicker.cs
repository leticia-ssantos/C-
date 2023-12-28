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
    public partial class F_DataTimePicker : Form
    {
        public F_DataTimePicker()
        {
            InitializeComponent();
        }

        private void btn_obterData_Click(object sender, EventArgs e)
        {
            tb_data.Text=dtp_data.Text;

            tb_dia.Text=dtp_data.Value.Day.ToString();
            tb_mes.Text = dtp_data.Value.Month.ToString();
            tb_ano.Text = dtp_data.Value.Year.ToString();
        }

        private void btn_setarData_Click(object sender, EventArgs e)
        {
            int d, m, a;
            d = Int32.Parse(tb_dia.Text);
            m = Int32.Parse(tb_mes.Text);
            a = Int32.Parse(tb_ano.Text);

            DateTime dt = new DateTime(a, m, d);


            dtp_data.Value = dt;
        }

        private void btn_hoje_Click(object sender, EventArgs e)
        {
            
            dtp_data.Value= DateTime.Today;

        }
    }
}
