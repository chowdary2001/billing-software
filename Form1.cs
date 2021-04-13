using milk.milkDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Printing;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.IO;
using System.Drawing.Imaging;
using System.Windows.Forms.VisualStyles;

namespace milk
{

    public partial class Form1 : Form
    {
        string mdate = "";
        int tem = 0, tp = 0,tem1=0;
        float mk = 0;
        int ww = 0,z=0;
        int[] ned=new int[200];
        int target = 100;
        float totalmilk = 0, totalrs = 0, avgfat = 0;
        float mr, mf, cr1, cr2, cr3;
        int[] z1 = new int[120];
        float[] z2 = new float[120];
        float[] z3 = new float[120];

                  OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\milk.accdb");
                  OleDbConnection con1 = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\milk.accdb");
              //  OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\manya\source\repos\milk\milk\milk.accdb");
             // OleDbConnection con1 = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\manya\source\repos\milk\milk\milk.accdb");

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
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
                            check(int.Parse(sno.Text));
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

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            float ff = 0;
            if (e.KeyCode == Keys.Enter)
            {
                if (float.TryParse(milk.Text, out ff) && float.TryParse(fat.Text, out ff))
                {

                    

                    float m = float.Parse(milk.Text);
                    float f = float.Parse(fat.Text);
                    if ((f - (int)f) == 0)
                    {
                        int rp = (int)f;
                        fat.Text =  rp.ToString()+ ".0";
                    }
                    float r = (float)(m * f * mr);
                    r=(float)Math.Round((double)r,2);
                    rs.Text = r.ToString();




                    float m1 = float.Parse(mixset.Text);
                    float r1 = (float)(m * f / (m1 + 0.3));
                    r1 -= m;
                    r1 = (float)Math.Round((double)r1, 1);
                    mixx.Text = r1.ToString();
                }
                else rs.Text = "";
                SendKeys.Send("{TAB}");

            }

        }



        private void button1_Click(object sender, EventArgs e)
        {


            int f = 0;
            float ff = 0;


            if (name.Text.Equals("") || rs.Text.Equals("")|| (!(int.TryParse(sno.Text, out f)))  || (!(float.TryParse(milk.Text, out ff))) || (!(float.TryParse(fat.Text, out ff))))
            {
                MessageBox.Show("invalid data");
            }
            else
            {

                

                // if (printPreviewDialog1.ShowDialog() == DialogResult.OK)


                printDocument1.Print();

                
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                tem++;
                cmd.CommandText = "insert into maindata values('" + tem + "','" + mdate + "','" + sno.Text + "','" + milk.Text + "','" + fat.Text + "','" + rs.Text + "','"+tem.ToString()+"')";
                cmd.ExecuteNonQuery();
                con.Close();
                tp++;
                mk += float.Parse(milk.Text);
                mk = (float)Math.Round((double)mk, 1);
                tm.Text = mk.ToString();
                int tar = (int)(mk);
                if (tar > target) tar = target;
                verticalProgressBar1.Maximum = target;
                verticalProgressBar1.Value = tar;
                view.Rows.Insert(0, tp, name.Text, int.Parse(sno.Text), float.Parse(milk.Text), float.Parse(fat.Text), float.Parse(rs.Text));
                totalmilk += float.Parse(milk.Text);
                totalrs += float.Parse(rs.Text);
                totmilk.Text = tm.Text;
                float abd = (float)Math.Round((double)totalrs, 0);
                totrs.Text = abd.ToString();
                float abc = totalrs / (totalmilk * mr);
                abc = (float)Math.Round((double)abc, 1);
                totfat.Text = abc.ToString();


                for (int i = 0; i < ww; i++)
                {
                    if (ned[i] == int.Parse(sno.Text))
                    {
                        ned[i] = 0; break;
                    }
                }
                label6.Text = "";
                for (int i = 0; i < ww; i++)
                {
                    if (ned[i] != 0)
                        label6.Text += ned[i].ToString() + " , ";
                }



                sno.Text = "";
                milk.Text = "";
                fat.Text = "";
                rs.Text = "";
                name.Text = "";
                sno.Select();
               

            }

        }

        private void addNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'milkDataSet3.maindata' table. You can move, or remove it, as needed.
            // this.maindataTableAdapter.Fill(this.milkDataSet3.maindata);
            WindowState = FormWindowState.Maximized;



            string gg5 = "SELECT ID,dates,snos,milks,fats,rss,id2 FROM maindata";
            con.Open();
            OleDbCommand cmd5 = new OleDbCommand(gg5, con);
            OleDbDataReader rd5 = cmd5.ExecuteReader();
            int p = 0;
            while (rd5.Read())
            {
                if (rd5.GetString(1).Equals("00/00/00") && (rd5.GetString(2).Equals("rate")))
                {
                    mr = float.Parse(rd5.GetString(3));
                    mf = float.Parse(rd5.GetString(4));
                    mixset.Text = rd5.GetString(4);
                    target = Int16.Parse(rd5.GetString(5));
                    p++;

                }
                if ((rd5.GetString(2).Equals("crate")))
                {
                    Color vv = System.Drawing.ColorTranslator.FromHtml(rd5.GetString(1));
                    this.BackColor = vv;
                    cr1 = float.Parse(rd5.GetString(3));
                    cr2 = float.Parse(rd5.GetString(4));
                    cr3 = float.Parse(rd5.GetString(5));
                    p++;

                }
                if (p == 2) break;

            }
            rd5.Close();
            con.Close();


            string gg = "SELECT ID FROM maindata";
            con.Open();
            OleDbCommand cmd = new OleDbCommand(gg, con);
            OleDbDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                if (rd.GetInt32(0) > tem)
                {
                    tem = rd.GetInt32(0);
                }

            }

            rd.Close();
            con.Close();

            string gg2 = "SELECT ID FROM company";
            con.Open();
            OleDbCommand cmd2 = new OleDbCommand(gg2, con);
            OleDbDataReader rd2 = cmd2.ExecuteReader();
            while (rd2.Read())
            {
                if (rd2.GetInt32(0) > tem1)
                {
                    tem1 = rd2.GetInt32(0);
                }

            }

            rd2.Close();
            con.Close();








            string ff = DateTime.Now.ToString("HH");
            DateTime date = dateTimePicker1.Value;
            string d1 = date.Date + " ";
            string[] dat = d1.Split('-');
            int ch = Int16.Parse(ff);
            if (ch <= 12)
            {
                mdate = dat[0] + "/" + dat[1] + "/" + dat[2][2] + dat[2][3] + " AM";
                ap.SelectedIndex = 0;
            }
            else
            {
                mdate = dat[0] + "/" + dat[1] + "/" + dat[2][2] + dat[2][3] + " PM";
                ap.SelectedIndex = 1;
            }
            



        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker1.Value;
            string d1 = date.Date + " ";
            string[] dat = d1.Split('-');
            mdate = dat[0] + "/" + dat[1] + "/" + dat[2][2] + dat[2][3] + " " + ap.SelectedItem;

            load();

        }

        private void ap_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker1.Value;
            string d1 = date.Date + " ";
            string[] dat = d1.Split('-');

            mdate = dat[0] + "/" + dat[1] + "/" + dat[2][2] + dat[2][3] + " " + ap.SelectedItem;

            load();



        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            string pt = "దుర్గా కుసుమ సాయి శ్రీ    దేవి పాల కేంద్రం" + "\n" +
                       "----------------------------------------------------------\n" +
                       "        పేరు" + "         :          " + name.Text + "\n" +
                       "        నెంబర్     :               " + sno.Text + "\n" +
                       "        తేదీ           :     " + mdate + "\n" +
                        "----------------------------------------------------------\n" +
                        "     పాలు           వెన్న %            రూ  . పై \n \n" +
                        "      " + milk.Text + "\t           " + fat.Text + "\t        " + rs.Text;
            e.Graphics.DrawString(pt, new Font("Time New Romans", 10), Brushes.Black, new PointF(70, 10));
        }

      
       

        private void load()
        {
            string bdate = mdate;
            string temp = bdate[0] + "" + bdate[1];
            int t2 = Int16.Parse(temp);
            if (t2 == 1)
            {
                int[] mm = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                string temp2 = bdate[3] + "" + bdate[4];
                int t3 = Int16.Parse(temp2);
                if (t3 == 1)
                {
                    string temp4 = bdate[6] + "" + bdate[7];
                    int t4 = Int16.Parse(temp4);
                    t4--;
                    t3 = 12;
                    t2 = 31;
                    bdate = (t2 / 10).ToString() + (t2 % 10).ToString() + "/" + (t3 / 10).ToString() + (t3 % 10).ToString() + "/" + (t4 / 10).ToString() + (t4 % 10).ToString() + " " + mdate[9] + mdate[10];


                }
                else
                {
                    t3--;
                    t2 = mm[t3 - 1];
                    bdate = (t2 / 10).ToString() + (t2 % 10).ToString() + "/" + (t3 / 10).ToString() + (t3 % 10).ToString() + "/" + mdate[6] + mdate[7] + " " + mdate[9] + mdate[10];

                }

            }
            else
            {
                t2--;
                bdate = (t2 / 10).ToString() + (t2 % 10).ToString() + "/" + mdate[3] + mdate[4] + "/" + mdate[6] + mdate[7] + " " + mdate[9] + mdate[10];

            }


           
            string gm = "SELECT ID,dates,snos FROM maindata";
            con.Open();
            OleDbCommand cmd8 = new OleDbCommand(gm, con);
            OleDbDataReader rd8 = cmd8.ExecuteReader();
            ww = 0;
            while (rd8.Read())
            {
                if (rd8.GetString(1).Equals(bdate))
                {
                    ned[ww] = Int16.Parse(rd8.GetString(2));
                    ww++;

                }
            }

            rd8.Close();
            con.Close();
           


            tp = 0;
            mk = 0;
            totalmilk = 0; avgfat = 0; totalrs = 0;
            view.Rows.Clear();
            string gg = "SELECT ID,dates,snos,milks,fats,rss FROM maindata";
            con.Open();
            OleDbCommand cmd = new OleDbCommand(gg, con);
            OleDbDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                if (rd.GetString(1).Equals(mdate))
                {
                    totalmilk += float.Parse(rd.GetString(3));
                    totalrs += float.Parse(rd.GetString(5));
                    string g1 = "";
                    string ggg = "SELECT sno, cname FROM refer";
                    OleDbCommand cmd1 = new OleDbCommand(ggg, con1);
                    con1.Open();
                    OleDbDataReader rd1 = cmd1.ExecuteReader();
                    while (rd1.Read())
                    {
                        if (rd1.GetInt32(0) == int.Parse(rd.GetString(2)))
                        {
                            g1 = rd1.GetString(1);

                        }
                    }
                    rd1.Close();

                    cmd1.ExecuteNonQuery();

                    con1.Close();
                    tp++;
                    mk += float.Parse(rd.GetString(3));
                    view.Rows.Insert(0, tp, g1, int.Parse(rd.GetString(2)), float.Parse(rd.GetString(3)), float.Parse(rd.GetString(4)), float.Parse(rd.GetString(5)));
                    for(int i=0;i< ww;i++)
                    {
                        if(ned[i]== int.Parse(rd.GetString(2)))
                        {
                            ned[i] = 0; break;
                        }
                    }


                }
            }
            
            totmilk.Text = totalmilk.ToString();
             float abd = (float)Math.Round((double)totalrs, 0);
            totrs.Text = abd.ToString();
            float abc;
            if (totalmilk == 0)
                 abc = 0;
            else
                 abc = totalrs / (totalmilk * mr);
            abc = (float)Math.Round((double)abc, 1);
            totfat.Text = abc.ToString();

            int tar = (int)(mk);
            tm.Text = mk.ToString();
            if (tar > target) tar = target;
            verticalProgressBar1.Maximum = target;
            verticalProgressBar1.Value = tar;
            rd.Close();
            con.Close();

            label6.Text = "";
            for (int i = 0; i < ww; i++)
            {
                if (ned[i] != 0)
                    label6.Text += ned[i].ToString() + " , ";
            }

            cm1.Text = ""; cm2.Text = ""; cm3.Text = "";
            cf1.Text = ""; cf2.Text = ""; cf3.Text = ""; srs.Text = "";
            crs1.Text = "0"; crs2.Text = "0"; crs3.Text = "0";


            string gm1 = "SELECT ID,dates,snos,milks,fats,rss,id2 from company";
            con.Open();
            OleDbCommand cmd7 = new OleDbCommand(gm1, con);
            OleDbDataReader rd7 = cmd7.ExecuteReader();
           
            while (rd7.Read())
            {
                if (rd7.GetString(1).Equals(mdate))
                {
                    if(rd7.GetString(2).Equals("c1"))
                    {
                        cm1.Text = rd7.GetString(3); cf1.Text = rd7.GetString(4); crs1.Text = rd7.GetString(5);
                    }
                    else if (rd7.GetString(2).Equals("c2"))
                    {
                        cm2.Text = rd7.GetString(3); cf2.Text = rd7.GetString(4); crs2.Text = rd7.GetString(5);
                    }
                   else if (rd7.GetString(2).Equals("c3"))
                    {
                        cm3.Text = rd7.GetString(3); cf3.Text = rd7.GetString(4); crs3.Text = rd7.GetString(5);
                    }
                    else if (rd7.GetString(2).Equals("sl"))
                    {
                        srs.Text = rd7.GetString(3); 
                    }

                }
            }

            rd7.Close();
            con.Close();

            dude();



        }

        public void dude()
        {
           float c1, c2, c3,s,sam;
            float ff;

            if (!float.TryParse(cm1.Text, out ff))
                c1 = 0;
            else
                c1 = float.Parse(cm1.Text);

            if (!float.TryParse(cm2.Text, out ff))
                c2 = 0;
            else
                c2 = float.Parse(cm2.Text);

            if (!float.TryParse(cm3.Text, out ff))
                c3 = 0;
            else
                c3 = float.Parse(cm3.Text);

            if (!float.TryParse(srs.Text, out ff))
                s = 0;
            else
                s = float.Parse(srs.Text);

            sam = totalmilk - c1 - c2 - c3;
            sam = (float)Math.Round((double)sam, 1);
            sm.Text = sam.ToString();
            float rp = float.Parse(crs1.Text) + float.Parse(crs2.Text) + float.Parse(crs3.Text) + s - totalrs;
            rp = (float)Math.Round((double)rp, 0);

            pl.Text = rp.ToString();


        }

        private void cm1_KeyDown(object sender, KeyEventArgs e)
        {
            float ff = 0;
            if (e.KeyCode == Keys.Enter)
            {
                if (float.TryParse(cm1.Text, out ff))
                {
                    dude();
                    SendKeys.Send("{TAB}");
                }
                else
                {
                    if(cm1.Text.Equals(""))
                        SendKeys.Send("{TAB}");
                    else
                         MessageBox.Show("Wrong input");
                    cm1.Text = "";
                }
            }
        }

        private void cf1_KeyDown(object sender, KeyEventArgs e)
        {
            float ff = 0;
            if (e.KeyCode == Keys.Enter)
            {
                if (float.TryParse(cf1.Text, out ff))
                {
                    if (float.TryParse(cm1.Text, out ff))
                    {
                       float rp= float.Parse(cm1.Text) * float.Parse(cf1.Text) * cr1;
                       rp = (float)Math.Round((double)rp, 1);
                        crs1.Text = rp.ToString();


                        string gg = "SELECT ID,dates,snos,milks,fats,rss,id2 FROM company";
                        con.Open();
                        OleDbCommand cmd = new OleDbCommand(gg, con);
                        OleDbDataReader rd = cmd.ExecuteReader();
                   
                        while (rd.Read())
                        {
                            if (rd.GetString(1).Equals(mdate) && rd.GetString(2).Equals("c1"))
                            {
                              
                                int vv = rd.GetInt32(0);
                                OleDbCommand cmd21 = con.CreateCommand();
                                cmd21.CommandType = CommandType.Text;
                                cmd21.CommandText = "delete * from company where id2='" + rd.GetString(6) + "'";
                                cmd21.ExecuteNonQuery();
                                rd.Close();
                                break;
                            }

                        }
                        
                            
                            OleDbCommand cmd2 = con.CreateCommand();
                            cmd2.CommandType = CommandType.Text;
                            tem1++;
                            cmd2.CommandText = "insert into company values('" + tem1 + "','" + mdate + "','" + "c1" + "','" + cm1.Text + "','" + cf1.Text + "','" + crs1.Text + "','" + tem1.ToString() + "')";
                            cmd2.ExecuteNonQuery(); 
                            rd.Close();
                            con.Close();
  

                    }


                    SendKeys.Send("{TAB}");
                }
                else
                {
                    if (cf1.Text.Equals(""))
                    {
                        string gg = "SELECT ID,dates,snos,milks,fats,rss,id2 FROM company";
                        con.Open();
                        OleDbCommand cmd = new OleDbCommand(gg, con);
                        OleDbDataReader rd = cmd.ExecuteReader();

                        while (rd.Read())
                        {
                            if (rd.GetString(1).Equals(mdate) && rd.GetString(2).Equals("c1"))
                            {

                                int vv = rd.GetInt32(0);
                                OleDbCommand cmd21 = con.CreateCommand();
                                cmd21.CommandType = CommandType.Text;
                                cmd21.CommandText = "delete * from company where id2='" + rd.GetString(6) + "'";
                                cmd21.ExecuteNonQuery();
                                rd.Close();
                                break;
                            }

                        }
                        con.Close();
                        SendKeys.Send("{TAB}");
                    }
                    else
                        MessageBox.Show("Wrong input");
                    cf1.Text = "";
                    crs1.Text = "0";
                }
                dude();
            }
        }

        private void cm2_KeyDown(object sender, KeyEventArgs e)
        {
            float ff = 0;
            if (e.KeyCode == Keys.Enter)
            {
                if (float.TryParse(cm2.Text, out ff))
                {
                    dude();
                    SendKeys.Send("{TAB}");
                }
                else
                {
                    if (cm2.Text.Equals(""))
                        SendKeys.Send("{TAB}");
                    else
                        MessageBox.Show("Wrong input");
                    cm2.Text = "";
                }
            }
        }

        private void cf2_KeyDown(object sender, KeyEventArgs e)
        {
            float ff = 0;
            if (e.KeyCode == Keys.Enter)
            {
                if (float.TryParse(cf2.Text, out ff))
                {
                    if (float.TryParse(cm2.Text, out ff))
                    {
                        float rp = float.Parse(cm2.Text) * float.Parse(cf2.Text) * cr2;
                        rp = (float)Math.Round((double)rp, 1);
                        crs2.Text = rp.ToString();


                        string gg = "SELECT ID,dates,snos,milks,fats,rss,id2 FROM company";
                        con.Open();
                        OleDbCommand cmd = new OleDbCommand(gg, con);
                        OleDbDataReader rd = cmd.ExecuteReader();

                        while (rd.Read())
                        {
                            if (rd.GetString(1).Equals(mdate) && rd.GetString(2).Equals("c2"))
                            {

                                int vv = rd.GetInt32(0);
                                OleDbCommand cmd21 = con.CreateCommand();
                                cmd21.CommandType = CommandType.Text;
                                cmd21.CommandText = "delete * from company where id2='" + rd.GetString(6) + "'";
                                cmd21.ExecuteNonQuery();
                                rd.Close();
                                break;
                            }

                        }


                        OleDbCommand cmd2 = con.CreateCommand();
                        cmd2.CommandType = CommandType.Text;
                        tem1++;
                        cmd2.CommandText = "insert into company values('" + tem1 + "','" + mdate + "','" + "c2" + "','" + cm2.Text + "','" + cf2.Text + "','" + crs2.Text + "','" + tem1.ToString() + "')";
                        cmd2.ExecuteNonQuery();
                        rd.Close();
                        con.Close();


                    }


                    SendKeys.Send("{TAB}");
                }
                else
                {
                    if (cf2.Text.Equals(""))
                    {
                        string gg = "SELECT ID,dates,snos,milks,fats,rss,id2 FROM company";
                        con.Open();
                        OleDbCommand cmd = new OleDbCommand(gg, con);
                        OleDbDataReader rd = cmd.ExecuteReader();

                        while (rd.Read())
                        {
                            if (rd.GetString(1).Equals(mdate) && rd.GetString(2).Equals("c2"))
                            {

                                int vv = rd.GetInt32(0);
                                OleDbCommand cmd21 = con.CreateCommand();
                                cmd21.CommandType = CommandType.Text;
                                cmd21.CommandText = "delete * from company where id2='" + rd.GetString(6) + "'";
                                cmd21.ExecuteNonQuery();
                                rd.Close();
                                break;
                            }

                        }
                        con.Close();
                        SendKeys.Send("{TAB}");
                    }
                    else
                        MessageBox.Show("Wrong input");
                    cf2.Text = "";
                    crs2.Text = "0";
                }
                dude();
            }
        }

        private void cm3_KeyDown(object sender, KeyEventArgs e)
        {
            float ff = 0;
            if (e.KeyCode == Keys.Enter)
            {
                if (float.TryParse(cm3.Text, out ff))
                {
                    dude();
                    SendKeys.Send("{TAB}");
                }
                else
                {
                    if (cm3.Text.Equals(""))
                        SendKeys.Send("{TAB}");
                    else
                        MessageBox.Show("Wrong input");
                    cm3.Text = "";
                }
            }
        }

        private void cf3_KeyDown(object sender, KeyEventArgs e)
        {
            float ff = 0;
            if (e.KeyCode == Keys.Enter)
            {
                if (float.TryParse(cf3.Text, out ff))
                {
                    if (float.TryParse(cm3.Text, out ff))
                    {
                        float rp = float.Parse(cm3.Text) * float.Parse(cf3.Text) * cr3;
                        rp = (float)Math.Round((double)rp, 1);
                        crs3.Text = rp.ToString();


                        string gg = "SELECT ID,dates,snos,milks,fats,rss,id2 FROM company";
                        con.Open();
                        OleDbCommand cmd = new OleDbCommand(gg, con);
                        OleDbDataReader rd = cmd.ExecuteReader();

                        while (rd.Read())
                        {
                            if (rd.GetString(1).Equals(mdate) && rd.GetString(2).Equals("c3"))
                            {

                                int vv = rd.GetInt32(0);
                                OleDbCommand cmd21 = con.CreateCommand();
                                cmd21.CommandType = CommandType.Text;
                                cmd21.CommandText = "delete * from company where id2='" + rd.GetString(6) + "'";
                                cmd21.ExecuteNonQuery();
                                rd.Close();
                                break;
                            }

                        }


                        OleDbCommand cmd2 = con.CreateCommand();
                        cmd2.CommandType = CommandType.Text;
                        tem1++;
                        cmd2.CommandText = "insert into company values('" + tem1 + "','" + mdate + "','" + "c3" + "','" + cm3.Text + "','" + cf3.Text + "','" + crs3.Text + "','" + tem1.ToString() + "')";
                        cmd2.ExecuteNonQuery();
                        rd.Close();
                        con.Close();


                    }


                    SendKeys.Send("{TAB}");
                }
                else
                {
                    if (cf3.Text.Equals(""))
                    {
                        string gg = "SELECT ID,dates,snos,milks,fats,rss,id2 FROM company";
                        con.Open();
                        OleDbCommand cmd = new OleDbCommand(gg, con);
                        OleDbDataReader rd = cmd.ExecuteReader();

                        while (rd.Read())
                        {
                            if (rd.GetString(1).Equals(mdate) && rd.GetString(2).Equals("c3"))
                            {

                                int vv = rd.GetInt32(0);
                                OleDbCommand cmd21 = con.CreateCommand();
                                cmd21.CommandType = CommandType.Text;
                                cmd21.CommandText = "delete * from company where id2='" + rd.GetString(6) + "'";
                                cmd21.ExecuteNonQuery();
                                rd.Close();
                                break;
                            }

                        }
                        con.Close();
                        SendKeys.Send("{TAB}");
                    }
                    else
                        MessageBox.Show("Wrong input");
                    cf3.Text = "";
                    crs3.Text = "0";
                }
                dude();
            }
        }

        private void advancesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f2 = new Form5();
            f2.Show();
        }

        private void printDocument2_PrintPage(object sender, PrintPageEventArgs e)
        {
            int d = 1;
            string pt = mdate+" ";
            int f = 59;
            if (z < 59) f = z;
            for(int j=0;j<f;j++)
            {
                pt += z1[j].ToString() + " , " + z2[j].ToString() + " , " + z3[j].ToString() + " | ";
                d++;
                if (d % 4 == 0) pt += "\n";
            }    
            e.Graphics.DrawString(pt, new Font("Time New Romans", 8), Brushes.Black, new PointF(67, 10));

        }

        private void printDocument3_PrintPage(object sender, PrintPageEventArgs e)
        {
            int d = 0;
            string pt="";
            int f = 119;
            if (z < 119) f = z;
            for (int j = 59; j < f; j++)
            {
                pt += z1[j].ToString() + " , " + z2[j].ToString() + " , " + z3[j].ToString() + " | ";
                d++;
                if (d % 4 == 0) pt += "\n";
            }
            e.Graphics.DrawString(pt, new Font("Time New Romans", 8), Brushes.Black, new PointF(67, 10));
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 f2 = new Form6();
            f2.Show();

        }

        private void resultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 f2 = new Form7();
            f2.Show();

        }

        private void colourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {

                Color ff;
                ff = colorDialog1.Color;
                int dd = ff.ToArgb();
                Color vv = System.Drawing.ColorTranslator.FromHtml(dd.ToString());
                this.BackColor = vv;




                con.Open();
                int oo = -2;
                OleDbCommand cmd2 = con.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "delete * from maindata where id2='" + oo.ToString() + "'";
                cmd2.ExecuteNonQuery();
                con.Close();

                con.Open();
                OleDbCommand cmd4 = con.CreateCommand();
                cmd4.CommandType = CommandType.Text;
                cmd4.CommandText = "insert into maindata values('" + oo + "','" + dd.ToString() + "','" + "crate" + "','" + cr1.ToString() + "','" + cr2.ToString() + "','" + cr3.ToString() + "','" + oo.ToString() + "')";
                cmd4.ExecuteNonQuery();
                con.Close();







            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            z = 0;
           
            string gg = "SELECT ID,dates,snos,milks,fats,rss,id2 FROM maindata";
            con.Open();
            OleDbCommand cmd = new OleDbCommand(gg, con);
            OleDbDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                if (rd.GetString(1).Equals(mdate))
                {
                    z1[z] = Int16.Parse(rd.GetString(2));
                    z2[z] = float.Parse(rd.GetString(3));
                    z3[z] = float.Parse(rd.GetString(4));
                    z++;
                }
            }
            rd.Close();
            con.Close();
            if (z > 0)
            {
                //if (printPreviewDialog2.ShowDialog() == DialogResult.OK)
                    printDocument2.Print();
            }
            if(z>59)
            {

                //if (printPreviewDialog3.ShowDialog() == DialogResult.OK)
                    printDocument3.Print();

            }
            


        }

        private void srs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string gg = "SELECT ID,dates,snos,milks,fats,rss,id2 FROM company";
                con.Open();
                OleDbCommand cmd = new OleDbCommand(gg, con);
                OleDbDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    if (rd.GetString(1).Equals(mdate) && rd.GetString(2).Equals("sl"))
                    {

                        int vv = rd.GetInt32(0);
                        OleDbCommand cmd21 = con.CreateCommand();
                        cmd21.CommandType = CommandType.Text;
                        cmd21.CommandText = "delete * from company where id2='" + rd.GetString(6) + "'";
                        cmd21.ExecuteNonQuery();
                        rd.Close();
                        break;
                    }

                }


                OleDbCommand cmd2 = con.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                tem1++;
                cmd2.CommandText = "insert into company values('" + tem1 + "','" + mdate + "','" + "sl" + "','" + srs.Text + "','" + "0" + "','" + "0" + "','" + tem1.ToString() + "')";
                cmd2.ExecuteNonQuery();
                rd.Close();
                con.Close();
                dude();
                SendKeys.Send("{TAB}");
            }
        }

        private void finalPrintToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form3 f3 = new Form3();
            f3.Show();
        }

        private void save_Click(object sender, EventArgs e)
        {
            int f = 0;
            float ff = 0;


            if (name.Text.Equals("") || rs.Text.Equals("") || (!(int.TryParse(sno.Text, out f))) || (!(float.TryParse(milk.Text, out ff))) || (!(float.TryParse(fat.Text, out ff))))
            {
                MessageBox.Show("invalid data");
            }

            else
            {

              

                // if (printPreviewDialog1.ShowDialog() == DialogResult.OK)


                // printDocument1.Print();


                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                tem++;
                cmd.CommandText = "insert into maindata values('" + tem + "','" + mdate + "','" + sno.Text + "','" + milk.Text + "','" + fat.Text + "','" + rs.Text + "','" + tem.ToString() + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                tp++;
                mk += float.Parse(milk.Text);
                mk = (float)Math.Round((double)mk, 1);
                tm.Text = mk.ToString();
                int tar = (int)(mk);
                if (tar > target) tar = target;
                verticalProgressBar1.Maximum = target;
                verticalProgressBar1.Value = tar;
                view.Rows.Insert(0, tp, name.Text, int.Parse(sno.Text), float.Parse(milk.Text), float.Parse(fat.Text), float.Parse(rs.Text));
                totalmilk += float.Parse(milk.Text);
                totalrs += float.Parse(rs.Text);
                totmilk.Text = tm.Text;
                float abd = (float)Math.Round((double)totalrs, 0);
                totrs.Text = abd.ToString();
                float abc = totalrs / (totalmilk * mr);
                abc = (float)Math.Round((double)abc, 1);
                totfat.Text = abc.ToString();


                for (int i = 0; i < ww; i++)
                {
                    if (ned[i] == int.Parse(sno.Text))
                    {
                        ned[i] = 0; break;
                    }
                }
                label6.Text = "";
                for (int i = 0; i < ww; i++)
                {
                    if (ned[i] != 0)
                        label6.Text += ned[i].ToString() + " , ";
                }



                sno.Text = "";
                milk.Text = "";
                fat.Text = "";
                rs.Text = "";
                name.Text = "";
                sno.Select();


            }

        }

        private void mixfatset_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }

        }

        private void milkmix_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void fatmix_KeyDown(object sender, KeyEventArgs e)
        {
            float ff = 0;
            if (e.KeyCode == Keys.Enter)
            {
                if (float.TryParse(milkmix.Text, out ff) && float.TryParse(fatmix.Text, out ff) && float.TryParse(mixset.Text, out ff))
                {
                    float m = float.Parse(milkmix.Text);
                    float f = float.Parse(fatmix.Text);
                    float m1 = float.Parse(mixset.Text);
                    float r = (float)(m * f / (m1 + 0.3));
                    r -= m;
                    r = (float)Math.Round((double)r, 1);
                    mix.Text = r.ToString();

                    milkmix.Text = "";
                    fatmix.Text = "";
                    milkmix.Select();
                }
                else
                {
                    MessageBox.Show("CHECK THE MIXING DATA");
                }
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f2 = new Form4();
            f2.Show();

           
        }

        public void check(int num)
        {
            string gg = "SELECT ID,dates,snos,milks,fats,rss,id2 FROM maindata";
            con.Open();
            OleDbCommand cmd = new OleDbCommand(gg, con);
            OleDbDataReader rd = cmd.ExecuteReader();
            int c = 0;
            while (rd.Read())
            {
                if (rd.GetString(1).Equals(mdate) && rd.GetString(2).Equals(num.ToString()))
                {
                    milk.Text = rd.GetString(3);
                    fat.Text = rd.GetString(4);
                    rs.Text = rd.GetString(5);
                    c = 1;
                    MessageBox.Show("your trying to change the existing data save it after the change");
                    int vv = rd.GetInt32(0);                 
                    OleDbCommand cmd2 = con.CreateCommand();
                    cmd2.CommandType = CommandType.Text;
                    cmd2.CommandText = "delete * from maindata where id2='" + rd.GetString(6) + "'";
                    cmd2.ExecuteNonQuery();
                    rd.Close();
                    con.Close();
                    load();                 
                    break;
                }

            }
           if(c==0)
            {
                rd.Close();
                con.Close();
            }



        }
    }
}
