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
   
    public partial class Form2 : Form
    {
        int c;
       //OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\manya\source\repos\milk\milk\milk.accdb");
       OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\milk.accdb");

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            con.Open();
             OleDbCommand cmd = con.CreateCommand();

              cmd.CommandType = CommandType.Text;
            if (c == 1)
            {
                cmd.CommandText = "delete * from refer where snos='" + sno1.Text + "'";
                cmd.ExecuteNonQuery();
            }
           
                cmd.CommandText = "insert into refer values('" + sno1.Text + "','" + name1.Text + "','" + sno1.Text + "')";
                cmd.ExecuteNonQuery();
                comment.Text = "number saved";
           
            sno1.Text = "";
            name1.Text = "";
            sno1.Select();
            con.Close();
           
       
        }

        private void sno1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int f = 0;
                if (int.TryParse(sno1.Text, out f))
                {
                    string gg = "SELECT sno, cname FROM refer";
                    OleDbCommand cmd = new OleDbCommand(gg, con);
                    con.Open();
                    OleDbDataReader rd = cmd.ExecuteReader();
                    c = 0;
                    while (rd.Read())
                    {
                        if (rd.GetInt32(0) == int.Parse(sno1.Text))
                        {
                            name1.Text = rd.GetString(1);
                            rd.Close();
                            cmd.ExecuteNonQuery();
                            con.Close();

                            c = 1;
                            break;
                        }
                    }

                    if (c == 0)
                    {
                        name1.Text = "";
                        rd.Close();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    SendKeys.Send("{TAB}");
                   

                }
                else
                {
                    MessageBox.Show("Wrong num format");
                    

                }
                comment.Text = "";
            }
        }

        private void name1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comment.Text = "";
        }
    }
    }
    

