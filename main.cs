using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using Microsoft.Win32;
using System.Configuration;


namespace TLPAS
{
    public partial class main : Form
    {
        //public static string t;
       // public static string txt;
        public main()
        {
            
            InitializeComponent();
            
            /*  System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1000;//one second
            timer1.Tick += new System.EventHandler(timer1_Tick);
            timer1.Start();
            int count = 30;*/
        }

        /*
         private void timer1_Tick(object sender, EventArgs e)
         {
         if(count!=0)
         {
         button1.Enabled=false;
         label1.Text =  count.ToString() +" seconds more to Enable Refresh Button";
         count--;
         }
         else
         {
         button1.Enabled=true;
         timer1.Stop();
         }

 }*/
        
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Vishwas\Documents\myDatabaseMain.mdf;Integrated Security = True; Connect Timeout = 30");
        
        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM [LOGIN]";
            cmd.Connection = con;
            SqlDataReader rd = cmd.ExecuteReader();
               if (rd.HasRows)
                {
                    MessageBox.Show("You have already registered");
                   
                }
                else
                {
                    RegistryKey key;
            key = Registry.ClassesRoot.CreateSubKey(@"Folder\shell\Three Level Password Authentication System");
            key = Registry.ClassesRoot.CreateSubKey(@"Folder\shell\Three Level Password Authentication System\command");
            key.SetValue("", Application.ExecutablePath);
           
                    this.Hide();
                    Text1 t1 = new Text1(con);
                    t1.Show();
                    
                }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            TextChk tc = new TextChk(con);
            tc.Show();
        }


        private void main_Load(object sender, EventArgs e)
        {
            
        }

        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        public static void Save()
        {
            
        }
       
    }
}
