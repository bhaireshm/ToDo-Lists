﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBConnection
{
    public partial class passingForm : Form
    {

        public static string value = "";

        public passingForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            value = textBox1.Text;
            recivedForm rfrm = new recivedForm();
            rfrm.Show();

        }
    }
}
