﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_application
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

       

        private void bt_go_back_Click(object sender, EventArgs e)
        {

           // this.Parent.Show();
            this.Close();
            //Form1.
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
