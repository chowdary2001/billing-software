using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace milk
{
    public partial class Form6 : Form
    {
        //OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\manya\source\repos\milk\milk\milk.accdb");
         OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\milk.accdb");
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            view.Rows.Clear();
            string gg = "SELECT sno,cname,snos FROM refer";

            OleDbCommand cmd1 = new OleDbCommand(gg, con);
            con.Open();

            OleDbDataReader rd7 = cmd1.ExecuteReader();


            while (rd7.Read())
            {
                int xx = Int32.Parse(rd7.GetString(2));

                    view.Rows.Insert(0, xx, rd7.GetString(1));

                
            }
            rd7.Close();
            con.Close();
        }

      
    }
}
