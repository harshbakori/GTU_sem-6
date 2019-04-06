using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Desctop_aplication
{
   
    public partial class login : Form
    {
        public const int minimumamount = 5000;
        public static string password, number;
        public static bool adminlogin = false;
        public static bool loginflag = false;
        public static int f = 1;

        public login()
        {
            InitializeComponent();
        }

        private void tb_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_submit_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C: \Users\admin\source\repos\Desctop aplication\Desctop aplication\Database1.mdf';Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from login where number =" + tb_name.Text + "";

            SqlDataReader reader = cmd.ExecuteReader(); //execute the query to read
            if (reader.HasRows)
            {
                reader.Read(); //read data from sql command 
                if (reader.GetString(1).Equals(password))  //check for password correction
                {
                    Console.WriteLine("login");
                    loginflag = true;
                }
                else { Console.Clear(); Console.WriteLine("incorrect password"); }
            }
            else { Console.Clear(); Console.WriteLine("enter correct usernumber"); }


            if (tb_name.Text == "Admin" && tb_password.Text == "Admin")
            {
                adminop a2 = new adminop();
                this.Hide(); ///hide the main form....
                //this.Close();///close the aplication...all
                // f2.BackColor = Color.Aqua;
                // f2.WindowState = MaximizeBox;
                a2.Show();
            }
            else
            {
                MessageBox.Show("Invalid Information");
            }
        }
    }
}
