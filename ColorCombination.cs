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
    public partial class ColorCombination : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Vishwas\Documents\TLPAS\data.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");

        public ColorCombination()
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
            cmd.CommandText = "insert into COLOR values('" + textBox1.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            this.Hide();
            MessageBox.Show("Record Inserted Successfully");
            picture pic = new picture();
            pic.Show();
        }
       
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void ColorCombination_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
