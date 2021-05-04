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
    public partial class Text1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Vishwas\Documents\TLPAS\data.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        public Text1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into LOGIN values('" + textBox1.Text + "','"+textBox2.Text+"')";
            cmd.ExecuteNonQuery();
            con.Close();
            this.Hide();
            MessageBox.Show("Password Set");
            ColorCombination clr = new ColorCombination();
            clr.Show();
            AcceptButton = button2;
            
        }

        private void Text1_Load(object sender, EventArgs e)
        {
            AcceptButton = button2;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.Focus();
        }

        private void Text1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
