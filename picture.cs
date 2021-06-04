using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Data.SqlClient;

namespace TLPAS
{
    public partial class picture : Form
    {
        SqlConnection con;// = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Vishwas\Documents\Mydb.mdf; Integrated Security = True; Connect Timeout = 30");
        
        public picture(SqlConnection con)
        {
            this.con = con;
            InitializeComponent();      
        }

        Image img;
        public static Image ScaleImage(Image image, int maxWidth, int maxHeight)
        {
            var ratioX = (double)maxWidth / image.Width;
            var ratioY = (double)maxHeight / image.Height;
            var ratio = Math.Min(ratioX, ratioY);

            var newWidth = (int)(image.Width * ratio);
            var newHeight = (int)(image.Height * ratio);

            var newImage = new Bitmap(newWidth, newHeight);

            using (var graphics = Graphics.FromImage(newImage)) graphics.DrawImage(image, 0, 0, newWidth, newHeight);
            return newImage;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "1";
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string imgLocation = "";
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                pictureBox1.ImageLocation = imgLocation;

                imgLocation = dialog.FileName;
                img = Image.FromFile(dialog.FileName);
            }
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
                
                int w = Convert.ToInt32(500), h = Convert.ToInt32(295);
                img = Resize(img, w, h);
                //((Button)sender).Enabled = false;

                //For Dividing image into diffrent blocks
                //    Image img = Image.FromFile("d:\\a.png"); // a.png has 500X295 width and height
                var newimg = ScaleImage(img, 500, 295);
                int widthThird = (int)((double)newimg.Width / 10.0 + 0.5);
                int heightThird = (int)((double)newimg.Height / 10.0 + 0.5);
                Bitmap[,] bmps = new Bitmap[100, 100];
                for (int i = 0; i < 88; i++)
                    for (int j = 0; j < 88; j++)
                    {
                        bmps[i, j] = new Bitmap(widthThird, heightThird);
                        Graphics g = Graphics.FromImage(bmps[i, j]);
                        g.DrawImage(img, new Rectangle(0, 0, widthThird, heightThird), new Rectangle(j * widthThird, i * heightThird, widthThird, heightThird), GraphicsUnit.Pixel);
                        g.Dispose();
                    }
                button1.BackgroundImage = bmps[0, 0];
                button2.BackgroundImage = bmps[0, 1];
                button3.BackgroundImage = bmps[0, 2];
                button4.BackgroundImage = bmps[0, 3];
                button5.BackgroundImage = bmps[0, 4];
                button6.BackgroundImage = bmps[0, 5];
                button7.BackgroundImage = bmps[0, 6];
                button8.BackgroundImage = bmps[0, 7];
                button9.BackgroundImage = bmps[0, 8];
                button22.BackgroundImage = bmps[1, 0];
                button21.BackgroundImage = bmps[1, 1];
                button20.BackgroundImage = bmps[1, 2];
                button19.BackgroundImage = bmps[1, 3];
                button18.BackgroundImage = bmps[1, 4];
                button17.BackgroundImage = bmps[1, 5];
                button16.BackgroundImage = bmps[1, 6];
                button15.BackgroundImage = bmps[1, 7];
                button14.BackgroundImage = bmps[1, 8];

                button40.BackgroundImage = bmps[2, 0];
                button39.BackgroundImage = bmps[2, 1];
                button38.BackgroundImage = bmps[2, 2];
                button37.BackgroundImage = bmps[2, 3];
                button36.BackgroundImage = bmps[2, 4];
                button35.BackgroundImage = bmps[2, 5];
                button34.BackgroundImage = bmps[2, 6];
                button33.BackgroundImage = bmps[2, 7];
                button32.BackgroundImage = bmps[2, 8];
                button31.BackgroundImage = bmps[3, 0];
                button30.BackgroundImage = bmps[3, 1];
                button29.BackgroundImage = bmps[3, 2];
                button28.BackgroundImage = bmps[3, 3];
                button27.BackgroundImage = bmps[3, 4];
                button26.BackgroundImage = bmps[3, 5];
                button25.BackgroundImage = bmps[3, 6];
                button24.BackgroundImage = bmps[3, 7];
                button23.BackgroundImage = bmps[3, 8];

                button76.BackgroundImage = bmps[4, 0];
                button75.BackgroundImage = bmps[4, 1];
                button74.BackgroundImage = bmps[4, 2];
                button73.BackgroundImage = bmps[4, 3];
                button72.BackgroundImage = bmps[4, 4];
                button71.BackgroundImage = bmps[4, 5];
                button70.BackgroundImage = bmps[4, 6];
                button69.BackgroundImage = bmps[4, 7];
                button68.BackgroundImage = bmps[4, 8];
                button67.BackgroundImage = bmps[5, 0];
                button66.BackgroundImage = bmps[5, 1];
                button65.BackgroundImage = bmps[5, 2];
                button64.BackgroundImage = bmps[5, 3];
                button63.BackgroundImage = bmps[5, 4];
                button62.BackgroundImage = bmps[5, 5];
                button61.BackgroundImage = bmps[5, 6];
                button60.BackgroundImage = bmps[5, 7];
                button59.BackgroundImage = bmps[5, 8];

                button58.BackgroundImage = bmps[6, 0];
                button57.BackgroundImage = bmps[6, 1];
                button56.BackgroundImage = bmps[6, 2];
                button55.BackgroundImage = bmps[6, 3];
                button54.BackgroundImage = bmps[6, 4];
                button53.BackgroundImage = bmps[6, 5];
                button52.BackgroundImage = bmps[6, 6];
                button51.BackgroundImage = bmps[6, 7];
                button50.BackgroundImage = bmps[6, 8];
                button49.BackgroundImage = bmps[7, 0];
                button48.BackgroundImage = bmps[7, 1];
                button47.BackgroundImage = bmps[7, 2];
                button46.BackgroundImage = bmps[7, 3];
                button45.BackgroundImage = bmps[7, 4];
                button44.BackgroundImage = bmps[7, 5];
                button43.BackgroundImage = bmps[7, 6];
                button42.BackgroundImage = bmps[7, 7];
                button41.BackgroundImage = bmps[7, 8];

                button85.BackgroundImage = bmps[8, 0];
                button84.BackgroundImage = bmps[8, 1];
                button83.BackgroundImage = bmps[8, 2];
                button82.BackgroundImage = bmps[8, 3];
                button81.BackgroundImage = bmps[8, 4];
                button80.BackgroundImage = bmps[8, 5];
                button79.BackgroundImage = bmps[8, 6];
                button78.BackgroundImage = bmps[8, 7];
                button77.BackgroundImage = bmps[8, 8];

                button86.BackgroundImage = bmps[8, 9];
                button87.BackgroundImage = bmps[7, 9];
                button88.BackgroundImage = bmps[6, 9];
                button89.BackgroundImage = bmps[5, 9];
                button90.BackgroundImage = bmps[4, 9];
                button91.BackgroundImage = bmps[3, 9];
                button92.BackgroundImage = bmps[2, 9];
                button93.BackgroundImage = bmps[1, 9];
                button94.BackgroundImage = bmps[0, 9];

                button95.BackgroundImage = bmps[9, 0];
                button96.BackgroundImage = bmps[9, 9];
                button97.BackgroundImage = bmps[9, 8];
                button98.BackgroundImage = bmps[9, 7];
                button99.BackgroundImage = bmps[9, 6];
                button100.BackgroundImage = bmps[9, 5];
                button101.BackgroundImage = bmps[9, 4];
                button102.BackgroundImage = bmps[9, 3];
                button103.BackgroundImage = bmps[9, 2];
                button104.BackgroundImage = bmps[9, 1];
        }

        Image Resize(Image image, int w, int h)
        {
            Bitmap bmp = new Bitmap(w, h);
            Graphics graphic = Graphics.FromImage(bmp);
            graphic.DrawImage(image, 0, 0, w, h);
            graphic.Dispose();
            return bmp;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
           textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into picture values('" + textBox1.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            this.Hide();
            MessageBox.Show("Password Set");
            main MAIN = new main();
            MAIN.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button36_Click(object sender, EventArgs e)
        {
            textBox1.Text += "25";
        }

        private void button61_Click(object sender, EventArgs e)
        {
            textBox1.Text += "57";
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button94_Click(object sender, EventArgs e)
        {
            textBox1.Text += "10";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Text += "11";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text += "12";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text += "13";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text += "14";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text += "15";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text += "16";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += "17";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += "18";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "19";
        }

        private void button93_Click(object sender, EventArgs e)
        {
            textBox1.Text += "20";
        }

        private void button40_Click(object sender, EventArgs e)
        {
            textBox1.Text += "21";
        }

        private void button39_Click(object sender, EventArgs e)
        {
            textBox1.Text += "22";
        }

        private void button38_Click(object sender, EventArgs e)
        {
            textBox1.Text += "23";
        }

        private void button37_Click(object sender, EventArgs e)
        {
            textBox1.Text += "24";
        }

        private void button35_Click(object sender, EventArgs e)
        {
            textBox1.Text += "27";
        }

        private void button34_Click(object sender, EventArgs e)
        {
            textBox1.Text += "28";
        }

        private void button33_Click(object sender, EventArgs e)
        {
            textBox1.Text += "29";
        }

        private void button32_Click(object sender, EventArgs e)
        {
            textBox1.Text += "30";
        }

        private void button92_Click(object sender, EventArgs e)
        {
            textBox1.Text += "31";
        }

        private void button31_Click(object sender, EventArgs e)
        {
            textBox1.Text += "32";
        }

        private void button30_Click(object sender, EventArgs e)
        {
            textBox1.Text += "33";
        }

        private void button29_Click(object sender, EventArgs e)
        {
            textBox1.Text += "34";
        }

        private void button28_Click(object sender, EventArgs e)
        {
            textBox1.Text += "35";
        }

        private void button27_Click(object sender, EventArgs e)
        {
            textBox1.Text += "36";
        }

        private void button26_Click(object sender, EventArgs e)
        {
            textBox1.Text += "37";
        }

        private void button25_Click(object sender, EventArgs e)
        {
            textBox1.Text += "38";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            textBox1.Text += "39";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox1.Text += "40";
        }

        private void button91_Click(object sender, EventArgs e)
        {
            textBox1.Text += "41";
        }

        private void button76_Click(object sender, EventArgs e)
        {
            textBox1.Text += "42";
        }

        private void button75_Click(object sender, EventArgs e)
        {
            textBox1.Text += "43";
        }

        private void button74_Click(object sender, EventArgs e)
        {
            textBox1.Text += "44";
        }

        private void button73_Click(object sender, EventArgs e)
        {
            textBox1.Text += "45";
        }

        private void button72_Click(object sender, EventArgs e)
        {
            textBox1.Text += "46";
        }

        private void button71_Click(object sender, EventArgs e)
        {
            textBox1.Text += "47";
        }

        private void button70_Click(object sender, EventArgs e)
        {
            textBox1.Text += "47";
        }

        private void button69_Click(object sender, EventArgs e)
        {
            textBox1.Text += "48";
        }

        private void button68_Click(object sender, EventArgs e)
        {
            textBox1.Text += "49";
        }

        private void button90_Click(object sender, EventArgs e)
        {
            textBox1.Text += "50";
        }

        private void button67_Click(object sender, EventArgs e)
        {
            textBox1.Text += "51";
        }

        private void button66_Click(object sender, EventArgs e)
        {
            textBox1.Text += "52";
        }

        private void button65_Click(object sender, EventArgs e)
        {
            textBox1.Text += "53";
        }

        private void button55_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button64_Click(object sender, EventArgs e)
        {
            textBox1.Text += "54";
        }

        private void button63_Click(object sender, EventArgs e)
        {
            textBox1.Text += "55";
        }

        private void button62_Click(object sender, EventArgs e)
        {
            textBox1.Text += "56";
        }

        private void button60_Click(object sender, EventArgs e)
        {
            textBox1.Text += "58";
        }

        private void button59_Click(object sender, EventArgs e)
        {
            textBox1.Text += "59";
        }

        private void button89_Click(object sender, EventArgs e)
        {
            textBox1.Text += "60";
        }

        private void button58_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button57_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button56_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button54_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button53_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button52_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button51_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button50_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button88_Click(object sender, EventArgs e)
        {
            textBox1.Text += "10";
        }

        private void button49_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button48_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button47_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button46_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button44_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button43_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button42_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button41_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button87_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button85_Click(object sender, EventArgs e)
        {
            textBox1.Text += "10";
        }

        private void button84_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button83_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button82_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button81_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button80_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button79_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button78_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button77_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button86_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button45_Click(object sender, EventArgs e)
        {
            textBox1.Text += "10";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void picture_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
