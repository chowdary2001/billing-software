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
    public partial class Form7 : Form
    {
       // OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\manya\source\repos\milk\milk\milk.accdb");
       // OleDbConnection con1 = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\manya\source\repos\milk\milk\milk.accdb");

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\milk.accdb");
        OleDbConnection con1 = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\milk.accdb");
        string  r1, r2, pt = "";
        int cn = 0;
        float tm = 0, ta = 0, tp = 0;
        float cm1 = 0, cm2 = 0, cm3 = 0, sl = 0;








        public Form7()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string gg = "SELECT sno,cname,snos FROM refer";
            OleDbCommand cmd = new OleDbCommand(gg, con);
            con.Open();
            OleDbDataReader rd = cmd.ExecuteReader();
            DateTime fd = fromd.Value;
            string d1 = fd.Date + " ";
            string[] dat = d1.Split('-');
            string sdate = dat[0] + "/" + dat[1] + "/" + dat[2][2] + dat[2][3];
            string ft = dat[0];
            dat[0] = (Int16.Parse(dat[0])).ToString();
            DateTime td = tod.Value;
            string d2 = td.Date + " ";
            string[] dat2 = d2.Split('-');
            string edate = dat2[0] + "/" + dat2[1] + "/" + dat2[2][2] + dat2[2][3];
            tm = 0; tp = 0; ta = 0;

            while (rd.Read())
            {
                

                string gg1 = "SELECT ID,dates,snos,milks,fats,rss FROM maindata";
                con1.Open();
                OleDbCommand cmd1 = new OleDbCommand(gg1, con1);
                float rss = 0;
                dat[0] = ft;
                while (true)
                {
                    OleDbDataReader rd1 = cmd1.ExecuteReader();
                    string ddd = dat[0] + "/" + dat[1] + "/" + dat[2][2] + dat[2][3];
                    string datea = dat[0] + "/" + dat[1] + "/" + dat[2][2] + dat[2][3] + " AM";
                    string datep = dat[0] + "/" + dat[1] + "/" + dat[2][2] + dat[2][3] + " PM";
                    while (rd1.Read())
                    {
                        int xx = 0;
                        if (rd1.GetString(1).Equals(datea) && rd.GetString(2).Equals(rd1.GetString(2)))
                        {
                            r1 = rd1.GetString(5);
                            rss += float.Parse(r1);
                            xx++;
                        }
                        else if (rd1.GetString(1).Equals(datep) && rd.GetString(2).Equals(rd1.GetString(2)))
                        {
                            r2 = rd1.GetString(5);
                            rss += float.Parse(r2);                           
                            xx++;
                        }
                        if (xx == 2) break;

                    }


               
                    dat[0] = (Int16.Parse(dat[0]) + 1).ToString();
                    if (Int16.Parse(dat[0]) < 10) { dat[0] = "0" + dat[0]; }

                    rd1.Close();

                    if (Int16.Parse(dat[0]) > Int16.Parse(dat2[0])) break;




                }
                tm = tm + rss;
                
                con1.Close();

                string ggf = "SELECT ID,adv,id2 FROM advance";

                OleDbCommand cmd13 = new OleDbCommand(ggf, con1);
                con1.Open();

                OleDbDataReader rd7 = cmd13.ExecuteReader();

                int add = 0;
                while (rd7.Read())
                {
                    if (rd7.GetString(2).Equals(rd.GetString(2)))
                    {
                        add = Int32.Parse(rd7.GetString(1));

                        break;
                    }
                }
                rd7.Close();
                con1.Close();
                ta = ta + add;

                int fin = (int)(rss) - add;

                if (fin > 0) tp = tp + fin;

              
            }
            rd.Close();
            con.Close();











            gf1();








            int a1 = (int)tm;
            int a2 = (int)ta;
            int a3 = (int)tp;

            otm.Text = a1.ToString();
            ota.Text = a2.ToString();
            otp.Text = a3.ToString();
            

        }

        public void gf1()
        {

           
           
            DateTime fd = fromd.Value;
            string d1 = fd.Date + " ";
            string[] dat = d1.Split('-');
            string sdate = dat[0] + "/" + dat[1] + "/" + dat[2][2] + dat[2][3];
            string ft = dat[0];
            dat[0] = (Int16.Parse(dat[0])).ToString();
            DateTime td = tod.Value;
            string d2 = td.Date + " ";
            string[] dat2 = d2.Split('-');
            string edate = dat2[0] + "/" + dat2[1] + "/" + dat2[2][2] + dat2[2][3];
            cm1 = 0;cm2 = 0;cm3 = 0;sl = 0;         
                string gg1 = "SELECT ID,dates,snos,milks,fats,rss FROM company";
                con1.Open();
                OleDbCommand cmd1 = new OleDbCommand(gg1, con1);
              
                dat[0] = ft;
                while (true)
                {
                    OleDbDataReader rd1 = cmd1.ExecuteReader();
                    string ddd = dat[0] + "/" + dat[1] + "/" + dat[2][2] + dat[2][3];
                    string datea = dat[0] + "/" + dat[1] + "/" + dat[2][2] + dat[2][3] + " AM";
                    string datep = dat[0] + "/" + dat[1] + "/" + dat[2][2] + dat[2][3] + " PM";
                    while (rd1.Read())
                    {
                        int xx = 0;
                        if (rd1.GetString(1).Equals(datea))
                        {
                        if (rd1.GetString(2).Equals("c1")) cm1 = cm1 + float.Parse(rd1.GetString(5));
                        else if (rd1.GetString(2).Equals("c2")) cm2 = cm2 + float.Parse(rd1.GetString(5));
                        else if (rd1.GetString(2).Equals("c3")) cm3 = cm3 + float.Parse(rd1.GetString(5));
                        else if (rd1.GetString(2).Equals("sl"))
                        {
                            float fflu = 0;
                            if ((float.TryParse(rd1.GetString(3), out fflu)) )
                                     sl = sl + float.Parse(rd1.GetString(3));
                        }


                        xx++;
                        }
                        else if (rd1.GetString(1).Equals(datep))
                        {
                        if (rd1.GetString(2).Equals("c1")) cm1 = cm1 + float.Parse(rd1.GetString(5));
                        else if (rd1.GetString(2).Equals("c2")) cm2 = cm2 + float.Parse(rd1.GetString(5));
                        else if (rd1.GetString(2).Equals("c3")) cm3 = cm3 + float.Parse(rd1.GetString(5));
                        else if (rd1.GetString(2).Equals("sl"))
                        {
                            float fflu = 0;
                            if ((float.TryParse(rd1.GetString(3), out fflu)))
                                     sl = sl + float.Parse(rd1.GetString(3));
                        }

                        xx++;
                        }
                        if (xx == 2) break;

                    }



                    dat[0] = (Int16.Parse(dat[0]) + 1).ToString();
                    if (Int16.Parse(dat[0]) < 10) { dat[0] = "0" + dat[0]; }

                    rd1.Close();

                    if (Int16.Parse(dat[0]) > Int16.Parse(dat2[0])) break;




                }
                

                con1.Close();

            int b1 = (int)cm1;
            int b2 = (int)cm2;
            int b3 = (int)cm3;
            int b4 = (int)sl;

            oc1.Text = b1.ToString();
            oc2.Text = b2.ToString();
            oc3.Text = b3.ToString();
            ots.Text = b4.ToString();



        }
            






        



    }
}
