﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace final_project
{
    class Program
    {
          public static bool loginflag=false;
          public static bool adminlogin=false;
          public const int minimumamount = 5000;
          public static String password, number;
        static void Main(string[] args)
        {
            // showdata();
            retry:
            Console.WriteLine("please login");
             login();
            if(adminlogin == true)
            {
                loginflag = true;
            }
            if(loginflag == true)
            {
                    Console.WriteLine("enter your choice \n1)logout \n2)check balance\n3)payment");
                //all the data can be enterd
                if (adminlogin == true) { Console.WriteLine("admin can have this ragister functionality press 10) for it "); }
                    int ch = Convert.ToInt32(Console.ReadLine());
                    switch (ch)
                    {
                        case 1:
                            logout();
                            break;
                        case 2:
                            checkbalance();
                            break;
                        case 3:
                            payto();
                            break;

                    case 10:
                            if(adminlogin == true)
                               {
                                   ragister(); 
                               }
                        else { Console.WriteLine("you are not authorised"); }
                            break;
                    }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("try again");
                goto retry;
            }
            goto retry;
        }
        public  static void payto()
        {
            Console.WriteLine("entwr the number to make payment");

        }
        public static void checkbalance()
        {
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\Users\admin\source\repos\final project\final project\Database1.mdf'; Integrated Security = True");
            SqlDataAdapter adp = new SqlDataAdapter("select * from login", con);  ///fech all the entryes in the table login
            DataSet ds = new DataSet();
           // adp.FillSchema(ds,SchemaType.Source,"login"); //////initializing schema of the ds
            adp.Fill(ds);
            Console.WriteLine("data feched with balance");
            Console.WriteLine("balance is " + ds.Tables[0].Rows[0]["ballance"]);
                    ////////////////////////////////////////////////////////////////remaining to print balance///////////////////////////////////////
            }
            public static void ragister()
        {
            /////////////////////////////////////////user data entry ////////////////////////////////////////
            Console.WriteLine("enter new user number");
            number = Console.ReadLine();
            Console.WriteLine("password");
            password = Console.ReadLine();
            rebalance:
            Console.WriteLine("balance pleas");
            int balance = Convert.ToInt32(Console.ReadLine());
            if (balance < minimumamount)
            {
                Console.WriteLine("pleas re-enter balance above 5000");
                goto rebalance;
            }
            ////////////////////////////user data enterd by admin to ragister////////////////////////////////
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\Users\admin\source\repos\final project\final project\Database1.mdf'; Integrated Security = True");
            SqlDataAdapter adp = new SqlDataAdapter( "select * from login",con);  ///fech all the entryes in the table login
            DataSet ds = new DataSet();
            adp.FillSchema(ds, SchemaType.Source, "login"); //////initializing schema of the ds
            adp.Fill(ds); ///set entryes in data adapter
            DataRow dr = ds.Tables["login"].NewRow(); //entering new row to ds//////
            dr["number"] = number;
            dr["password"] = password;
            dr["ballance"] = balance;
            ds.Tables["login"].Rows.Add(dr);
            SqlCommandBuilder scmb = new SqlCommandBuilder(adp); //////built the update query
            adp = scmb.DataAdapter; /////set the data adapter for updation
            adp.Update(ds,"login"); ////  update adp use data in login table from dataset
        }
        public static void login()
        {
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\Users\admin\source\repos\final project\final project\Database1.mdf'; Integrated Security = True");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            ///////////////////////////////////////////////////connected to database/////////////////////////////////////////////////////////////////
            Console.WriteLine("connected");
            Console.WriteLine("Enter user number");
            String number = Console.ReadLine();
            Console.WriteLine("enter the password");
            String password = Console.ReadLine();
            if(number.Equals("Admin") && password.Equals("admin"))
            {
                adminlogin = true;
                goto end;                         //goto end of login function
            }
            /////////////user input complite////////////
            cmd.CommandText = "select * from login where number =" + number + "";   /// find number in database and fatch data 
            SqlDataReader reader = cmd.ExecuteReader(); //execute the query to read
            if (reader.HasRows) 
            {
               // Console.WriteLine("has rows");
                reader.Read(); //read data from sql command 
                               // Console.WriteLine("{0}\t{1}\t{2}", reader.GetString(0), reader.GetString(1),reader.GetInt32(2)); //print the data on screen untill it is not empty.
                if (reader.GetString(1).Equals(password))  //check for password correction
                {
                    Console.WriteLine("login");
                    loginflag = true;
                }
                else { Console.WriteLine("incorrect password"); }
            }
            else { Console.WriteLine("enter correct usernumber"); }
        //cmd.CommandText = "insert into S ('id','name') values ('1','test')";
        //cmd.ExecuteNonQuery();
        // Console.WriteLine("write done");
        end:                                         // jump for admin login
            con.Close();
            Console.ReadKey();
        }
        public static void logout() {loginflag = false;adminlogin = false;}//just a logout function
        public static void showdata()
        {
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\Users\admin\source\repos\final project\final project\Database1.mdf'; Integrated Security = True");
            SqlDataAdapter adp = new SqlDataAdapter("select * from S ", con);
            DataSet ds = new DataSet();
            adp.Fill(ds, "S");
            ds.Tables["S"].Rows[0]["Id"] = "10";
            SqlCommandBuilder scmd = new SqlCommandBuilder(adp);
            adp = scmd.DataAdapter;
            adp.Update(ds,"S");
            Console.WriteLine("Record updated");
            Console.ReadKey();
        }


    }
}
