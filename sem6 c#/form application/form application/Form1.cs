using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hi bro how are you?");

            TextBox t = new TextBox();
            t.Location=new Point(100, 100);
            this.components.Add(t);
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            if(txt_name.Text=="Admin" && txt_pass.Text=="Admin")
            {
                Form2 f2 = new Form2();
                this.Hide(); ///hide the main form....
                //this.Close();///close the aplication...all
                f2.BackColor = Color.Aqua;
                // f2.WindowState = MaximizeBox;
                f2.Show();
            }
            else
            {
                MessageBox.Show("Invalid Information");
            }
        }



        private void bt_cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
