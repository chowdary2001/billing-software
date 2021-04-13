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
    public partial class Form4 : Form
    {
        string col;
        //OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\manya\source\repos\milk\milk\milk.accdb");
         OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\milk.accdb");
        public Form4()
        {
            InitializeComponent();
        }

        private void milk_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            string gg = "SELECT ID,dates,snos,milks,fats,rss,id2 FROM maindata";
            con.Open();
            OleDbCommand cmd = new OleDbCommand(gg, con);
            OleDbDataReader rd = cmd.ExecuteReader();
            int p = 0;
            while (rd.Read())
            {
                if (rd.GetString(1).Equals("00/00/00") && (rd.GetString(2).Equals("rate")))
                {
                    milkrate.Text = rd.GetString(3);
                    mixfat.Text = rd.GetString(4);
                    tarmilk.Text = rd.GetString(5);
                    p++;

                }
                if ((rd.GetString(2).Equals("crate")))
                {
                    col = rd.GetString(1);
                    cr1.Text = rd.GetString(3);
                    cr2.Text = rd.GetString(4);
                    cr3.Text = rd.GetString(5);
                    p++;

                }
                if (p == 2) break;

            }
            rd.Close();
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            int o = -1, oo = -2;
            cmd.CommandText = "delete * from maindata where id2='" + o.ToString() + "'";
            cmd.ExecuteNonQuery();
            OleDbCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "delete * from maindata where id2='" + oo.ToString() + "'";
            cmd2.ExecuteNonQuery();
            con.Close();

            con.Open();
            OleDbCommand cmd3 = con.CreateCommand();
            cmd3.CommandType = CommandType.Text;
            cmd3.CommandText = "insert into maindata values('" + o + "','" + "00/00/00" + "','" + "rate" + "','" + milkrate.Text + "','" + mixfat.Text + "','" + tarmilk.Text + "','" + o.ToString() + "')";
            cmd3.ExecuteNonQuery();
            OleDbCommand cmd4 = con.CreateCommand();
            cmd4.CommandType = CommandType.Text;
            cmd4.CommandText = "insert into maindata values('" + oo + "','" + col + "','" + "crate" + "','" + cr1.Text + "','" + cr2.Text + "','" + cr3.Text + "','" + oo.ToString() + "')";
            cmd4.ExecuteNonQuery();


            con.Close();

        }

       
    }
}
