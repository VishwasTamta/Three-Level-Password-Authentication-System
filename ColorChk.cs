using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Web;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace TLPAS
{
    public partial class ColorChk : Form
    {
        int chk;
        public ColorChk()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "RED";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "GREEN";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "BLUE";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            if (chk < 3)
            {
                SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Vishwas\Documents\TLPAS\data.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
                SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From COLOR where val='" + textBox1.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    this.Hide();
                    MessageBox.Show("Login Successfull");
                    picChk pchk = new picChk();
                    pchk.Show();
                }
                else
                {
                    MessageBox.Show("Please Check Your Username and Password");
                    chk += 1;
                }
            }
            else
            {
                MessageBox.Show("Sorry you have entered wrong password three times");
                this.Hide();
                TextChk tc = new TextChk();
                tc.Show();
                chk = 0;
            }
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void ColorChk_Load(object sender, EventArgs e)
        {
            AcceptButton = button4;
           

        }
    }

}