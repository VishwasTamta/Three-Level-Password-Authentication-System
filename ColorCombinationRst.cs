using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
namespace TLPAS
{
    public partial class ColorCombinationRst : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Vishwas\Documents\Mydb.mdf; Integrated Security = True; Connect Timeout = 30");

        public ColorCombinationRst()
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
            AcceptButton = button4;
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update COLOR set val='"+textBox1.Text+"'";
            cmd.ExecuteNonQuery();
            con.Close();
            this.Hide();
            MessageBox.Show("Combination Successfully Upadeted");
            pictureRst pic = new pictureRst();
            pic.Show();
        }
       
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void ColorCombinationRst_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void ColorCombinationRst_Load(object sender, EventArgs e)
        {

        }
    }
}
