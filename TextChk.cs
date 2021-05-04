using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace TLPAS
{
    public partial class TextChk : Form
    {
        int chk;
        SqlConnection con;

        public TextChk(SqlConnection con)
        {
            this.con = con;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (chk < 3)
            {
                //SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Vishwas\Documents\Mydb.mdf; Integrated Security = True; Connect Timeout = 30");
                SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From LOGIN where USERNAME='" + textBox1.Text + "' and PASSWORD='" + textBox2.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Login Successfull");
                    this.Hide();
                    ColorChk cc = new ColorChk(con);
                    cc.Show();
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
                main mn = new main();
                mn.Show();
            }
            }

        private void TextChk_Load(object sender, EventArgs e)
        {
            AcceptButton = button2;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           this.Focus();
        }
        }
}
