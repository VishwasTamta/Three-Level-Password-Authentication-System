using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TLPAS;
using System.Data.Sql;
using System.Configuration;
using System.Data.SqlClient;
namespace TLPAS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Vishwas\Documents\Mydb.mdf; Integrated Security = True; Connect Timeout = 30");
            /* con.Open();
             SqlCommand cmd = new SqlCommand();
             cmd.CommandText = "SELECT * FROM [LOGIN]";
             cmd.Connection = con;
             SqlDataReader rd = cmd.ExecuteReader();
             if (rd.HasRows)
             {

                 Application.Run(new TextChk());
             }
             else
             {
                 Application.Run(new main());
            }*/
            Application.Run(new main());
          
        }
    }
}
