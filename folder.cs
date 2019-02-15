using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Security.AccessControl;

namespace TLPAS
{
    public partial class folder: Form
    {
     
        public static string fc;
        public string status;
        public static string sp;
        string[] arr;
        private string _pathkey;
        public folder()
        {
            InitializeComponent();
            arr = new string[6];
            status = "";
            arr[0] = ".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}";
        }
        public string pathkey
        {
            get { return _pathkey; }
            set { _pathkey = value; }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            status = arr[0];
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath;
                sp = folderBrowserDialog1.SelectedPath;
                DirectoryInfo d = new DirectoryInfo(folderBrowserDialog1.SelectedPath);
                string selectedpath = d.Parent.FullName + d.Name;
                
            }
        }


        private string getstatus(string stat)
        {
            for (int i = 0; i < 6; i++)
                stat = stat.Substring(stat.LastIndexOf("."));
            return stat;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

       private void button2_Click(object sender, EventArgs e)
        {
            status = arr[0];
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
       {
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            //if (textBox1.Text==null)
            //{
            if (textBox1.Text.LastIndexOf(".{") == -1 )
                {
                    
                     DirectoryInfo d = new DirectoryInfo(sp);
                    string selectedpath = d.Parent.FullName + d.Name;
                    if (!d.Root.Equals(d.Parent.FullName))
                        d.MoveTo(d.Parent.FullName + "\\" + d.Name + status);

                    else d.MoveTo(d.Parent.FullName + d.Name + status);
                    pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\lock.jpg");
                
                        sp = sp + ".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}";
                        FileSecurity fileSecurity = File.GetAccessControl(sp);
                        fileSecurity.AddAccessRule(new FileSystemAccessRule(Environment.UserName, FileSystemRights.FullControl, AccessControlType.Deny));
                        File.SetAccessControl(sp, fileSecurity);

                        MessageBox.Show("The Selected Folder has been LOCKED for " + Environment.UserName, "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                 }
                else
                {
                    MessageBox.Show("Folder is already locked");
                   
                }
            }
        //}

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (sp.LastIndexOf(".{") == -1)
            {
                MessageBox.Show("Folder is already unlocked");
            }
            else
            {
                fc = null;
                DirectoryInfo d = new DirectoryInfo(sp);
                
                string selectedpath = d.Parent.FullName + d.Name;
                FileSecurity fileSecurity = File.GetAccessControl(sp);
                fileSecurity.RemoveAccessRule(new FileSystemAccessRule(Environment.UserName, FileSystemRights.FullControl, AccessControlType.Deny));
                File.SetAccessControl(sp, fileSecurity);

                MessageBox.Show("The Selected Folder has been UNLOCKED for " + Environment.UserName, "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                status = getstatus(status);
                d.MoveTo(sp.Substring(0, sp.LastIndexOf(".")));
                //textBox1.Text = folderBrowserDialog1.SelectedPath.Substring(0, folderBrowserDialog1.SelectedPath.LastIndexOf("."));
                pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\unlock.jpg");
                string nsp = sp.Replace(".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}", "");
                sp= nsp;
                textBox1.Text = nsp;
                

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Text1Rst tr = new Text1Rst();
            this.Hide();
            tr.Show();
        }

    }
}