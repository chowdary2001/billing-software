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
    public partial class Form5 : Form
    {
         OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\milk.accdb");
         OleDbConnection con1 = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\milk.accdb");
       // OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\manya\source\repos\milk\milk\milk.accdb");
      // OleDbConnection con1 = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\manya\source\repos\milk\milk\milk.accdb");
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            load1();
        }

        private void sno_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                int f = 0;
                if (int.TryParse(sno.Text, out f))
                {
                    string gg = "SELECT sno, cname FROM refer";
                    OleDbCommand cmd = new OleDbCommand(gg, con);
                    con.Open();
                    OleDbDataReader rd = cmd.ExecuteReader();
                    int c = 0;
                    while (rd.Read())
                    {
                        if (rd.GetInt32(0) == int.Parse(sno.Text))
                        {
                            name.Text = rd.GetString(1);
                            rd.Close();
                            cmd.ExecuteNonQuery();
                            con.Close();
                            c = 1;
                            break;
                        }
                    }

                    if (c == 0)
                    {
                        name.Text = "";
                        rd.Close();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
                else
                {
                    name.Text = "";

                }
                SendKeys.Send("{TAB}");






            }
        }

        private void milk_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete * from advance ";
            cmd.ExecuteNonQuery();
            con.Close();
            create();

        }
        public void create()
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;

            string gg5 = "SELECT sno,cname,snos FROM refer";
            con1.Open();
            OleDbCommand cmd5 = new OleDbCommand(gg5, con1);
            OleDbDataReader rd5 = cmd5.ExecuteReader();
            while (rd5.Read())
            {
                cmd.CommandText = "insert into advance values('" + rd5.GetString(2) + "','" + "0"+ "','" + rd5.GetString(2) + "')";
                cmd.ExecuteNonQuery();

            }
            rd5.Close();
            con1.Close();


            con.Close();
            load1();
        }

        private void save_Click(object sender, EventArgs e)
        {
            int f = 0;
            if ((!name.Text.Equals("")) && int.TryParse(adv.Text, out f))
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete * from advance where id2='" + sno.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();

                con1.Open();
                OleDbCommand cmd1 = con1.CreateCommand();
                cmd1.CommandType = CommandType.Text;

                cmd1.CommandText = "insert into advance values('" + sno.Text + "','" + adv.Text + "','" + sno.Text + "')";
                cmd1.ExecuteNonQuery();
                con1.Close();
                sno.Text = "";
                name.Text = "";
                adv.Text = "";
                sno.Select();
                load1();



            }
            else
            {
                MessageBox.Show("invalid data");
                sno.Text = "";
                name.Text = "";
                adv.Text = "";
                sno.Select();
            }


        }
        public void load1()
        {
            view.Rows.Clear();
            string gg = "SELECT ID,adv,id2 FROM advance";
           
            OleDbCommand cmd1 = new OleDbCommand(gg, con);
            con.Open();

            OleDbDataReader rd7 = cmd1.ExecuteReader();


            while (rd7.Read())
            {
                if (!rd7.GetString(1).Equals("0"))
                {
                   
                    view.Rows.Insert(0, Int32.Parse(rd7.GetString(2)), Int32.Parse(rd7.GetString(1)));
                   
                }
            }
            rd7.Close();
            con.Close();
        }


       
    }
}
