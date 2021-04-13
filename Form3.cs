using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace milk
{
    public partial class Form3 : Form
    {
      // OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\manya\source\repos\milk\milk\milk.accdb");
      // OleDbConnection con1 = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\manya\source\repos\milk\milk\milk.accdb");

       OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\milk.accdb");
       OleDbConnection con1 = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\milk.accdb");
        string m1, m2, f1, f2, r1, r2,pt="";
        int[] adm = new int[500];
        int cn = 0;

        private void button3_Click(object sender, EventArgs e)
        {
            pt = "";
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




                pt = "\t\t దుర్గా కుసుమ \tసాయి శ్రీ  దేవి\t పాల కేంద్రం \t ఫోన్ - 9505647789 " + " \n" +
                   "----------------------------------------------------------------------------------------------------------------------------------\n";

                pt = pt + "\t\tపేరు   :\t" + "Kakinada" + "   \t \t\tనెంబర్    :   \t" + "C3" + "\n" +
                   "------------------------------------------------------------------------------------------------------------------------------------\n";

                pt = pt + "   తేదీ  \t\t\t\t" + "ఉదయం	    | 	      \t\t సాయంత్రం   \n" +
                  "-----------------------------------------------------------------------------------------------------------------------------------\n";

                pt = pt + " \t \t  పాలు       వెన్న %       రూ  . పై            |          పాలు       వెన్న %      రూ  . పై    \n" +
                "-----------------------------------------------------------------------------------------------------------------------------------\n";






                string gg1 = "SELECT ID,dates,snos,milks,fats,rss FROM company";
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
                    m1 = "---   "; f1 = "---   "; r1 = "---   ";
                    m2 = "---   "; f2 = "---   "; r2 = "---    ";
                    while (rd1.Read())
                    {
                        int xx = 0;
                        if (rd1.GetString(1).Equals(datea) && rd1.GetString(2).Equals("c3"))
                        {
                            m1 = rd1.GetString(3);
                            f1 = rd1.GetString(4);
                            r1 = rd1.GetString(5);
                            rss += float.Parse(r1);
                            xx++;
                        }
                        else if (rd1.GetString(1).Equals(datep) && rd1.GetString(2).Equals("c3"))
                    {
                            m2 = rd1.GetString(3);
                            f2 = rd1.GetString(4);
                            r2 = rd1.GetString(5);
                            rss += float.Parse(r2);
                            xx++;
                        }
                        if (xx == 2) break;

                    }
                    float ff = 0;
                    if (float.TryParse(m1, out ff) && float.TryParse(f1, out ff))
                    {
                        if (float.Parse(m1) > 10.0 && float.Parse(f1) > 10.0 && float.Parse(r1) > 1000.0)
                            pt = pt + "   " + ddd + "\t    " + m1 + "         " + f1 + "             " + r1 + "         |";
                        else if (float.Parse(m1) > 10.0 && float.Parse(f1) > 10.0 && float.Parse(r1) > 100.0)
                            pt = pt + "   " + ddd + "\t    " + m1 + "         " + f1 + "             " + r1 + "           |";
                        else if (float.Parse(m1) > 10.0 && float.Parse(f1) > 10.0 && float.Parse(r1) > 10.0)
                            pt = pt + "   " + ddd + "\t    " + m1 + "         " + f1 + "             " + r1 + "             |";


                        else if (float.Parse(m1) > 10.0 && float.Parse(f1) > 0.0 && float.Parse(r1) > 1000.0)
                            pt = pt + "   " + ddd + "\t    " + m1 + "         " + f1 + "               " + r1 + "         |";
                        else if (float.Parse(m1) > 10.0 && float.Parse(f1) > 0.0 && float.Parse(r1) > 100.0)
                            pt = pt + "   " + ddd + "\t    " + m1 + "         " + f1 + "               " + r1 + "           |";
                        else if (float.Parse(m1) > 10.0 && float.Parse(f1) > 0.0 && float.Parse(r1) > 10.0)
                            pt = pt + "   " + ddd + "\t    " + m1 + "         " + f1 + "               " + r1 + "             |";


                        else if (float.Parse(m1) > 0.0 && float.Parse(f1) > 10.0 && float.Parse(r1) > 1000.0)
                            pt = pt + "   " + ddd + "\t    " + m1 + "           " + f1 + "             " + r1 + "         |";
                        else if (float.Parse(m1) > 0.0 && float.Parse(f1) > 10.0 && float.Parse(r1) > 100.0)
                            pt = pt + "   " + ddd + "\t    " + m1 + "           " + f1 + "             " + r1 + "           |";
                        else if (float.Parse(m1) > 0.0 && float.Parse(f1) > 10.0 && float.Parse(r1) > 10.0)
                            pt = pt + "   " + ddd + "\t    " + m1 + "           " + f1 + "             " + r1 + "             |";



                        else if (float.Parse(m1) > 0.0 && float.Parse(f1) > 0.0 && float.Parse(r1) > 1000.0)
                            pt = pt + "   " + ddd + "\t    " + m1 + "           " + f1 + "               " + r1 + "         |";
                        else if (float.Parse(m1) > 0.0 && float.Parse(f1) > 0.0 && float.Parse(r1) > 100.0)
                            pt = pt + "   " + ddd + "\t    " + m1 + "           " + f1 + "               " + r1 + "           |";
                        else
                            pt = pt + "   " + ddd + "\t    " + m1 + "           " + f1 + "               " + r1 + "             |";

                    }
                    else
                    {
                        pt = pt + "   " + ddd + "\t    " + m1 + "           " + f1 + "               " + r1 + "             |";

                    }




                    if (float.TryParse(m2, out ff) && float.TryParse(f2, out ff))
                    {
                        if (float.Parse(m2) > 10.0 && float.Parse(f2) > 10.0)
                            pt = pt + "           " + m2 + "          " + f2 + "           " + r2 + "  \n";



                        else if (float.Parse(m2) > 10.0 && float.Parse(f2) > 0.0)
                            pt = pt + "           " + m2 + "          " + f2 + "             " + r2 + "  \n";



                        else if (float.Parse(m2) > 0.0 && float.Parse(f2) > 10.0)
                            pt = pt + "           " + m2 + "            " + f2 + "           " + r2 + "  \n";

                        else
                            pt = pt + "           " + m2 + "            " + f2 + "             " + r2 + "  \n";

                    }
                    else
                    {
                        pt = pt + "           " + m2 + "            " + f2 + "             " + r2 + "  \n";
                    }

                    dat[0] = (Int16.Parse(dat[0]) + 1).ToString();
                    if (Int16.Parse(dat[0]) < 10) { dat[0] = "0" + dat[0]; }

                    rd1.Close();

                    if (Int16.Parse(dat[0]) > Int16.Parse(dat2[0])) break;
                }
                con1.Close();

               
                int fin = (int)(rss);

                pt = pt + "-----------------------------------------------------------------------------------------------------------------------------------\n" +
                    "\t\tTotal payable			---	        	" + fin.ToString() + "\n";


                if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                {

                    printDocument1.Print();

                }
            
           



        }

        private void button4_Click(object sender, EventArgs e)
        {
            pt = "";
            if (!name.Text.Equals(""))
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




                pt = "\t\t దుర్గా కుసుమ \tసాయి శ్రీ  దేవి\t పాల కేంద్రం \t ఫోన్ - 9505647789 " + " \n" +
                   "----------------------------------------------------------------------------------------------------------------------------------\n";

                pt = pt + "\t\tపేరు   :\t" + name.Text + "   \t \t\tనెంబర్    :   \t" + sno1.Text + "\n" +
                   "------------------------------------------------------------------------------------------------------------------------------------\n";

                pt = pt + "   తేదీ  \t\t\t\t" + "ఉదయం	    | 	      \t\t సాయంత్రం   \n" +
                  "-----------------------------------------------------------------------------------------------------------------------------------\n";

                pt = pt + " \t \t  పాలు       వెన్న %       రూ  . పై            |          పాలు       వెన్న %      రూ  . పై    \n" +
                "-----------------------------------------------------------------------------------------------------------------------------------\n";






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
                    m1 = "---   "; f1 = "---   "; r1 = "---   ";
                    m2 = "---   "; f2 = "---   "; r2 = "---    ";
                    while (rd1.Read())
                    {
                        int xx = 0;
                        if (rd1.GetString(1).Equals(datea) && sno1.Text.Equals(rd1.GetString(2)))
                        {
                            m1 = rd1.GetString(3);
                            f1 = rd1.GetString(4);
                            r1 = rd1.GetString(5);
                            rss += float.Parse(r1);
                            xx++;
                        }
                        else if (rd1.GetString(1).Equals(datep) && sno1.Text.Equals(rd1.GetString(2)))
                        {
                            m2 = rd1.GetString(3);
                            f2 = rd1.GetString(4);
                            r2 = rd1.GetString(5);
                            rss += float.Parse(r2);
                            xx++;
                        }
                        if (xx == 2) break;

                    }
                    float ff = 0;
                    if (float.TryParse(m1, out ff) && float.TryParse(f1, out ff))
                    {
                        float fz = float.Parse(m1);
                        if ((fz - (int)fz) == 0)
                        {
                            int rp = (int)fz;
                            m1 = rp.ToString() + ".0";
                        }
                        else if (fz < 1)
                        {
                            m1 = "0" + m1;
                        }

                        fz = float.Parse(f1);
                        if ((fz - (int)fz) == 0)
                        {
                            int rp = (int)fz;
                            f1 = rp.ToString() + ".0";
                        }

                        fz = float.Parse(r1);
                        if ((fz - (int)fz) == 0)
                        {
                            int rp = (int)fz;
                            r1 = rp.ToString() + ".00";
                        }
                        else
                        {
                            fz *= 100;
                            int hi = (int)fz;
                            if (hi % 10 == 0)
                            {
                                r1 = r1 + "0";
                            }
                        }


                        if (float.Parse(m1) >= 10.0 && float.Parse(f1) >= 10.0 && float.Parse(r1) >= 1000.0)
                            pt = pt + "   " + ddd + "\t    " + m1 + "         " + f1 + "             " + r1 + "         |";
                        else if (float.Parse(m1) >= 10.0 && float.Parse(f1) >= 10.0 && float.Parse(r1) >= 100.0)
                            pt = pt + "   " + ddd + "\t    " + m1 + "         " + f1 + "             " + r1 + "           |";
                        else if (float.Parse(m1) >= 10.0 && float.Parse(f1) >= 10.0 && float.Parse(r1) >= 10.0)
                            pt = pt + "   " + ddd + "\t    " + m1 + "         " + f1 + "             " + r1 + "             |";


                        else if (float.Parse(m1) >= 10.0 && float.Parse(f1) >= 0.0 && float.Parse(r1) >= 1000.0)
                            pt = pt + "   " + ddd + "\t    " + m1 + "         " + f1 + "               " + r1 + "         |";
                        else if (float.Parse(m1) >= 10.0 && float.Parse(f1) >= 0.0 && float.Parse(r1) >= 100.0)
                            pt = pt + "   " + ddd + "\t    " + m1 + "         " + f1 + "               " + r1 + "           |";
                        else if (float.Parse(m1) >= 10.0 && float.Parse(f1) >= 0.0 && float.Parse(r1) >= 10.0)
                            pt = pt + "   " + ddd + "\t    " + m1 + "         " + f1 + "               " + r1 + "             |";


                        else if (float.Parse(m1) >= 0.0 && float.Parse(f1) >= 10.0 && float.Parse(r1) >= 1000.0)
                            pt = pt + "   " + ddd + "\t    " + m1 + "           " + f1 + "             " + r1 + "         |";
                        else if (float.Parse(m1) >= 0.0 && float.Parse(f1) >= 10.0 && float.Parse(r1) >= 100.0)
                            pt = pt + "   " + ddd + "\t    " + m1 + "           " + f1 + "             " + r1 + "           |";
                        else if (float.Parse(m1) >= 0.0 && float.Parse(f1) >= 10.0 && float.Parse(r1) >= 10.0)
                            pt = pt + "   " + ddd + "\t    " + m1 + "           " + f1 + "             " + r1 + "             |";



                        else if (float.Parse(m1) >= 0.0 && float.Parse(f1) >= 0.0 && float.Parse(r1) >= 1000.0)
                            pt = pt + "   " + ddd + "\t    " + m1 + "           " + f1 + "               " + r1 + "         |";
                        else if (float.Parse(m1) >= 0.0 && float.Parse(f1) >= 0.0 && float.Parse(r1) >= 100.0)
                            pt = pt + "   " + ddd + "\t    " + m1 + "           " + f1 + "               " + r1 + "           |";
                        else
                            pt = pt + "   " + ddd + "\t    " + m1 + "           " + f1 + "               " + r1 + "             |";

                    }
                    else
                    {
                        pt = pt + "   " + ddd + "\t    " + m1 + "           " + f1 + "               " + r1 + "             |";

                    }




                    if (float.TryParse(m2, out ff) && float.TryParse(f2, out ff))
                    {

                        float fz = float.Parse(m2);
                        if ((fz - (int)fz) == 0)
                        {
                            int rp = (int)fz;
                            m2 = rp.ToString() + ".0";
                        }
                        else if (fz < 1)
                        {
                            m2 = "0" + m2;
                        }

                        fz = float.Parse(f2);
                        if ((fz - (int)fz) == 0)
                        {
                            int rp = (int)fz;
                            f2 = rp.ToString() + ".0";
                        }

                        fz = float.Parse(r2);
                        if ((fz - (int)fz) == 0)
                        {
                            int rp = (int)fz;
                            r2 = rp.ToString() + ".00";
                        }
                        else
                        {
                            fz *= 100;
                            int hi = (int)fz;
                            if (hi % 10 == 0)
                            {
                                r2 = r2 + "0";
                            }
                        }
                        if (float.Parse(m2) >= 10.0 && float.Parse(f2) >= 10.0)
                            pt = pt + "           " + m2 + "          " + f2 + "           " + r2 + "  \n";



                        else if (float.Parse(m2) >= 10.0 && float.Parse(f2) >= 0.0)
                            pt = pt + "           " + m2 + "          " + f2 + "             " + r2 + "  \n";



                        else if (float.Parse(m2) >= 0.0 && float.Parse(f2) >= 10.0)
                            pt = pt + "           " + m2 + "            " + f2 + "           " + r2 + "  \n";

                        else
                            pt = pt + "           " + m2 + "            " + f2 + "             " + r2 + "  \n";

                    }
                    else
                    {
                        pt = pt + "           " + m2 + "            " + f2 + "             " + r2 + "  \n";
                    }











                    //  pt = pt + "   " + ddd + "\t    " + m1 + "           " + f1 + "               " + r1 + "             |";
                    // pt =pt+ "           " + m2 + "            " + f2 + "             " + r2 + "  \n";










                    dat[0] = (Int16.Parse(dat[0]) + 1).ToString();
                    if (Int16.Parse(dat[0]) < 10) { dat[0] = "0" + dat[0]; }

                    rd1.Close();

                    if (Int16.Parse(dat[0]) > Int16.Parse(dat2[0])) break;
                }
                con1.Close();

                string ggf = "SELECT ID,adv,id2 FROM advance";

                OleDbCommand cmd13 = new OleDbCommand(ggf, con);
                con.Open();

                OleDbDataReader rd7 = cmd13.ExecuteReader();

                int add = 0;
                while (rd7.Read())
                {
                    if (rd7.GetString(2).Equals(sno1.Text))
                    {
                        add = Int32.Parse(rd7.GetString(1));
                        break;
                    }
                }
                rd7.Close();
                con.Close();
                int fin = (int)(rss) - add;
                int rps = (int)(rss);

                pt = pt + "-----------------------------------------------------------------------------------------------------------------------------------\n" +
                    "\t\tTotal payable			---	        	" + rps.ToString() + "\n\t\tTotal Advances			---	        	" + add.ToString() +
                    "\n-----------------------------------------------------------------------------------------------------------------------------------\n" +
                    "\t\tNet Payable			---	        	" + fin.ToString();

                MessageBox.Show(pt);

            }
            else
            {
                MessageBox.Show("Wrong Num Cant Print");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
           //string flu = @"C:/Users/manya/Desktop/data.txt";
             string flu = @"D:/data.txt";
           
            if (File.Exists(flu))
                File.Delete(flu);
            FileStream ff = File.Create(flu);
           
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

            while (rd.Read())
            {
                int fu = 0;
                string pt = "\t\t దుర్గా కుసుమ \tసాయి శ్రీ  దేవి\t పాల కేంద్రం \t ఫోన్ - 9505647789 " + " \n";
               // AddText(ff, pt);
                pt =pt+ "\t\tపేరు   :\t" + rd.GetString(1) + "   \t \t\tనెంబర్    :   \t" + rd.GetString(2) + "\n" +
                   "------------------------------------------------------------------------------------------------------------------------------------\n";
               // AddText(ff, pt);
                pt = pt+"   తేదీ  \t\t\t\t" + "ఉదయం		           |\t \t\t సాయంత్రం   \n";
               // AddText(ff, pt);
                pt =pt+ " \t \t  పాలు       వెన్న %       రూ  . పై        |        పాలు       వెన్న %      రూ  . పై    \n" +
                "-----------------------------------------------------------------------------------------------------------------------------------\n";
               // AddText(ff, pt);





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
                    m1 = "---    "; f1 = "---    "; r1 = "--- ";
                    m2 = "---    "; f2 = "---    "; r2 = "---    ";
                    while (rd1.Read())
                    {
                        int xx = 0;
                        if (rd1.GetString(1).Equals(datea) && rd.GetString(2).Equals(rd1.GetString(2)))
                        {
                            m1 = rd1.GetString(3);
                            f1 = rd1.GetString(4);
                            r1 = rd1.GetString(5);
                            rss += float.Parse(r1);
                            fu++;
                            xx++;
                        }
                        else if (rd1.GetString(1).Equals(datep) && rd.GetString(2).Equals(rd1.GetString(2)))
                        {
                            m2 = rd1.GetString(3);
                            f2 = rd1.GetString(4);
                            r2 = rd1.GetString(5);
                            rss += float.Parse(r2);
                            fu++;
                            xx++;
                        }
                        if (xx == 2) break;

                    }


                    float ff1 = 0;
                    if (float.TryParse(m1, out ff1) && float.TryParse(f1, out ff1))
                    {
                        float fz = float.Parse(m1);
                        if ((fz - (int)fz) == 0)
                        {
                            int rp = (int)fz;
                            m1 = rp.ToString() + ".0";
                        }
                        else if (fz < 1)
                        {
                            m1 = "0" + m1;
                        }
                        fz = float.Parse(f1);
                        if ((fz - (int)fz) == 0)
                        {
                            int rp = (int)fz;
                            f1 = rp.ToString() + ".0";
                        }

                         fz = float.Parse(r1);
                        if ((fz - (int)fz) == 0)
                        {
                            int rp = (int)fz;
                            r1 = rp.ToString() + ".00";
                        }
                        else
                        {
                            fz *= 100;
                            int hi = (int)fz;
                            if (hi % 10 == 0)
                            {
                                r1 = r1 + "0";
                            }
                        }



                        if (float.Parse(m1) >= 10.0 && float.Parse(f1) >= 10.0 && float.Parse(r1) >= 1000.0)
                            pt = pt+ "   " + ddd + "\t    " + m1 + "         " + f1 + "             " + r1 + "         |";
                        else if (float.Parse(m1) >= 10.0 && float.Parse(f1) >= 10.0 && float.Parse(r1) >= 100.0)
                            pt = pt+ "   " + ddd + "\t    " + m1 + "         " + f1 + "             " + r1 + "           |";
                        else if (float.Parse(m1) >= 10.0 && float.Parse(f1) >= 10.0 && float.Parse(r1) >= 10.0)
                            pt = pt+ "   " + ddd + "\t    " + m1 + "         " + f1 + "             " + r1 + "             |";


                        else if (float.Parse(m1) >= 10.0 && float.Parse(f1) >= 0.0 && float.Parse(r1) >= 1000.0)
                            pt = pt+ "   " + ddd + "\t    " + m1 + "         " + f1 + "               " + r1 + "         |";
                        else if (float.Parse(m1) >= 10.0 && float.Parse(f1) >= 0.0 && float.Parse(r1) >= 100.0)
                            pt = pt+"   " + ddd + "\t    " + m1 + "         " + f1 + "               " + r1 + "           |";
                        else if (float.Parse(m1) >= 10.0 && float.Parse(f1) >= 0.0 && float.Parse(r1) >= 10.0)
                            pt =pt+ "   " + ddd + "\t    " + m1 + "         " + f1 + "               " + r1 + "             |";


                        else if (float.Parse(m1) >= 0.0 && float.Parse(f1) >= 10.0 && float.Parse(r1) >= 1000.0)
                            pt =pt+  "   " + ddd + "\t    " + m1 + "           " + f1 + "             " + r1 + "         |";
                        else if (float.Parse(m1) >= 0.0 && float.Parse(f1) >= 10.0 && float.Parse(r1) >= 100.0)
                            pt = pt+ "   " + ddd + "\t    " + m1 + "           " + f1 + "             " + r1 + "           |";
                        else if (float.Parse(m1) >= 0.0 && float.Parse(f1) >= 10.0 && float.Parse(r1) >= 10.0)
                            pt = pt+ "   " + ddd + "\t    " + m1 + "           " + f1 + "             " + r1 + "             |";



                        else if (float.Parse(m1) >= 0.0 && float.Parse(f1) >= 0.0 && float.Parse(r1) >= 1000.0)
                            pt = pt+ "   " + ddd + "\t    " + m1 + "           " + f1 + "               " + r1 + "         |";
                        else if (float.Parse(m1) >= 0.0 && float.Parse(f1) >= 0.0 && float.Parse(r1) >= 100.0)
                            pt = pt+ "   " + ddd + "\t    " + m1 + "           " + f1 + "               " + r1 + "           |";
                        else
                            pt = pt+ "   " + ddd + "\t    " + m1 + "           " + f1 + "               " + r1 + "             |";

                    }
                    else
                    {
                        pt = pt+ "   " + ddd + "\t    " + m1 + "           " + f1 + "               " + r1 + "             |";

                    }




                    if (float.TryParse(m2, out ff1) && float.TryParse(f2, out ff1))
                    {
                        float fz = float.Parse(m2);
                        if ((fz - (int)fz) == 0)
                        {
                            int rp = (int)fz;
                            m2 = rp.ToString() + ".0";
                        }
                        else if (fz < 1)
                        {
                            m2 = "0" + m2;
                        }

                        fz = float.Parse(f2);
                        if ((fz - (int)fz) == 0)
                        {
                            int rp = (int)fz;
                            f2 = rp.ToString() + ".0";
                        }

                        fz = float.Parse(r2);
                        if ((fz - (int)fz) == 0)
                        {
                            int rp = (int)fz;
                            r2 = rp.ToString() + ".00";
                        }
                        else
                        {
                            fz *= 100;
                            int hi = (int)fz;
                            if (hi % 10 == 0)
                            {
                                r2 = r2 + "0";
                            }
                        }


                        if (float.Parse(m2) >= 10.0 && float.Parse(f2) >= 10.0)
                            pt =pt+  "           " + m2 + "          " + f2 + "           " + r2 + "  \n";



                        else if (float.Parse(m2) >= 10.0 && float.Parse(f2) >= 0.0)
                            pt = pt+ "           " + m2 + "          " + f2 + "             " + r2 + "  \n";



                        else if (float.Parse(m2) >= 0.0 && float.Parse(f2) >= 10.0)
                            pt = pt+ "           " + m2 + "            " + f2 + "           " + r2 + "  \n";

                        else
                            pt =pt+  "           " + m2 + "            " + f2 + "             " + r2 + "  \n";

                    }
                    else
                    {
                        pt =pt+  "           " + m2 + "            " + f2 + "             " + r2 + "  \n";
                    }









                   // AddText(ff, pt);
                    dat[0] = (Int16.Parse(dat[0]) + 1).ToString();
                    if (Int16.Parse(dat[0]) < 10) { dat[0] = "0" + dat[0]; }

                    rd1.Close();

                    if (Int16.Parse(dat[0]) > Int16.Parse(dat2[0])) break;




                }
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
                int fin = (int)(rss) - add;
                int rps = (int)(rss);



                pt = pt+"-----------------------------------------------------------------------------------------------------------------------------------\n" +
                   "\t\tTotal payable			---	        	" + rps.ToString() + "\n\t\tTotal Advances			---	        	" + add.ToString() +
                   "\n-----------------------------------------------------------------------------------------------------------------------------------\n" +
                   "\t\tNet Payable			---	        	" + fin.ToString() + "\n \n \n";
                if(fu!=0)
                  AddText(ff, pt);


            }
            rd.Close();
            con.Close();
            ff.Close();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(pt, new Font("Time New Romans", 10), Brushes.Black, new PointF(30, 10));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pt = "";
            if(!name.Text.Equals(""))
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

                

               
                     pt = "\t\t దుర్గా కుసుమ \tసాయి శ్రీ  దేవి\t పాల కేంద్రం \t ఫోన్ - 9505647789 " + " \n" +
                        "----------------------------------------------------------------------------------------------------------------------------------\n";
                   
                    pt =pt+ "\t\tపేరు   :\t" + name.Text + "   \t \t\tనెంబర్    :   \t" + sno1.Text + "\n" +
                       "------------------------------------------------------------------------------------------------------------------------------------\n";
                    
                    pt =pt+ "   తేదీ  \t\t\t\t" + "ఉదయం	    | 	      \t\t సాయంత్రం   \n" +
                      "-----------------------------------------------------------------------------------------------------------------------------------\n";
                    
                    pt = pt+" \t \t  పాలు       వెన్న %       రూ  . పై            |          పాలు       వెన్న %      రూ  . పై    \n" +
                    "-----------------------------------------------------------------------------------------------------------------------------------\n";
                    





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
                        m1 = "---   "; f1 = "---   "; r1 = "---   ";
                        m2 = "---   "; f2 = "---   "; r2 = "---    ";
                        while (rd1.Read())
                        {
                            int xx = 0;
                            if (rd1.GetString(1).Equals(datea) && sno1.Text.Equals(rd1.GetString(2)))
                            {
                                m1 = rd1.GetString(3);
                                f1 = rd1.GetString(4);
                                r1 = rd1.GetString(5);
                            rss += float.Parse(r1);
                                xx++;
                            }
                            else if (rd1.GetString(1).Equals(datep) && sno1.Text.Equals(rd1.GetString(2)))
                            {
                                m2 = rd1.GetString(3);
                                f2 = rd1.GetString(4);
                                r2 = rd1.GetString(5);
                            rss += float.Parse(r2);
                            xx++;
                            }
                            if (xx == 2) break;

                        }
                    float ff = 0;
                    if (float.TryParse(m1, out ff) && float.TryParse(f1, out ff))
                    {
                        float fz = float.Parse(m1);
                        if ((fz - (int)fz) == 0)
                        {
                            int rp = (int)fz;
                            m1 = rp.ToString() + ".0";
                        }
                        else if (fz < 1)
                        {
                            m1 = "0" + m1;
                        }

                        fz = float.Parse(f1);
                        if ((fz - (int)fz) == 0)
                        {
                            int rp = (int)fz;
                            f1 = rp.ToString() + ".0";
                        }

                        fz = float.Parse(r1);
                        if ((fz - (int)fz) == 0)
                        {
                            int rp = (int)fz;
                            r1 = rp.ToString() + ".00";
                        }
                        else
                        {
                            fz *= 100;
                            int hi = (int)fz;
                            if (hi % 10 == 0)
                            {
                                r1 = r1 + "0";
                            }
                        }


                        if (float.Parse(m1) >= 10.0 && float.Parse(f1) >= 10.0 && float.Parse(r1) >= 1000.0)
                            pt = pt + "   " + ddd + "\t    " + m1 + "         " + f1 + "             " + r1 + "         |";
                        else if (float.Parse(m1) >= 10.0 && float.Parse(f1) >= 10.0 && float.Parse(r1) >= 100.0)
                            pt = pt + "   " + ddd + "\t    " + m1 + "         " + f1 + "             " + r1 + "           |";
                        else if (float.Parse(m1) >= 10.0 && float.Parse(f1) >= 10.0 && float.Parse(r1) >= 10.0)
                            pt = pt + "   " + ddd + "\t    " + m1 + "         " + f1 + "             " + r1 + "             |";


                        else if (float.Parse(m1) >= 10.0 && float.Parse(f1) >= 0.0 && float.Parse(r1) >= 1000.0)
                            pt = pt + "   " + ddd + "\t    " + m1 + "         " + f1 + "               " + r1 + "         |";
                        else if (float.Parse(m1) >= 10.0 && float.Parse(f1) >= 0.0 && float.Parse(r1) >= 100.0)
                            pt = pt + "   " + ddd + "\t    " + m1 + "         " + f1 + "               " + r1 + "           |";
                        else if (float.Parse(m1) >= 10.0 && float.Parse(f1) >= 0.0 && float.Parse(r1) >= 10.0)
                            pt = pt + "   " + ddd + "\t    " + m1 + "         " + f1 + "               " + r1 + "             |";


                        else if (float.Parse(m1) >= 0.0 && float.Parse(f1) >= 10.0 && float.Parse(r1) >= 1000.0)
                            pt = pt + "   " + ddd + "\t    " + m1 + "           " + f1 + "             " + r1 + "         |";
                        else if (float.Parse(m1) >= 0.0 && float.Parse(f1) >= 10.0 && float.Parse(r1) >= 100.0)
                            pt = pt + "   " + ddd + "\t    " + m1 + "           " + f1 + "             " + r1 + "           |";
                        else if (float.Parse(m1) >= 0.0 && float.Parse(f1) >= 10.0 && float.Parse(r1) >= 10.0)
                            pt = pt + "   " + ddd + "\t    " + m1 + "           " + f1 + "             " + r1 + "             |";



                        else if (float.Parse(m1) >= 0.0 && float.Parse(f1) >= 0.0 && float.Parse(r1) >= 1000.0)
                            pt = pt + "   " + ddd + "\t    " + m1 + "           " + f1 + "               " + r1 + "         |";
                        else if (float.Parse(m1) >= 0.0 && float.Parse(f1) >= 0.0 && float.Parse(r1) >= 100.0)
                            pt = pt + "   " + ddd + "\t    " + m1 + "           " + f1 + "               " + r1 + "           |";
                        else
                            pt = pt + "   " + ddd + "\t    " + m1 + "           " + f1 + "               " + r1 + "             |";

                    }
                    else
                    {
                        pt = pt + "   " + ddd + "\t    " + m1 + "           " + f1 + "               " + r1 + "             |";

                    }




                    if (float.TryParse(m2, out ff) && float.TryParse(f2, out ff))
                    {

                        float fz = float.Parse(m2);
                        if ((fz - (int)fz) == 0)
                        {
                            int rp = (int)fz;
                            m2 = rp.ToString() + ".0";
                        }
                        else if (fz < 1)
                        {
                            m2 = "0" + m2;
                        }

                        fz = float.Parse(f2);
                        if ((fz - (int)fz) == 0)
                        {
                            int rp = (int)fz;
                            f2 = rp.ToString() + ".0";
                        }

                        fz = float.Parse(r2);
                        if ((fz - (int)fz) == 0)
                        {
                            int rp = (int)fz;
                            r2 = rp.ToString() + ".00";
                        }
                        else
                        {
                            fz *= 100;
                            int hi = (int)fz;
                            if (hi % 10 == 0)
                            {
                                r2 = r2 + "0";
                            }
                        }
                        if (float.Parse(m2) >= 10.0 && float.Parse(f2) >= 10.0)
                            pt = pt + "           " + m2 + "          " + f2 + "           " + r2 + "  \n";
                       


                        else if (float.Parse(m2) >= 10.0 && float.Parse(f2) >= 0.0 )
                            pt = pt + "           " + m2 + "          " + f2 + "             " + r2 + "  \n";
                      


                        else if (float.Parse(m2) >= 0.0 && float.Parse(f2) >= 10.0 )
                            pt = pt + "           " + m2 + "            " + f2 + "           " + r2 + "  \n";
                      
                        else
                            pt = pt + "           " + m2 + "            " + f2 + "             " + r2 + "  \n";

                    }
                    else
                    {
                        pt = pt + "           " + m2 + "            " + f2 + "             " + r2 + "  \n";
                    }











                    //  pt = pt + "   " + ddd + "\t    " + m1 + "           " + f1 + "               " + r1 + "             |";
                   // pt =pt+ "           " + m2 + "            " + f2 + "             " + r2 + "  \n";










                    dat[0] = (Int16.Parse(dat[0]) + 1).ToString();
                        if (Int16.Parse(dat[0]) < 10) { dat[0] = "0" + dat[0]; }

                        rd1.Close();

                        if (Int16.Parse(dat[0]) > Int16.Parse(dat2[0])) break;
                    }
                    con1.Close();

                string ggf = "SELECT ID,adv,id2 FROM advance";

                OleDbCommand cmd13 = new OleDbCommand(ggf, con);
                con.Open();

                OleDbDataReader rd7 = cmd13.ExecuteReader();

                int add=0;
                while (rd7.Read())
                {
                    if (rd7.GetString(2).Equals(sno1.Text))
                    {
                        add = Int32.Parse(rd7.GetString(1));
                        break;
                    }
                }
                rd7.Close();
                con.Close();
                int fin = (int)(rss) - add;
                int rps = (int)(rss);

                pt = pt + "-----------------------------------------------------------------------------------------------------------------------------------\n" +
                    "\t\tTotal payable			---	        	" + rps.ToString() + "\n\t\tTotal Advances			---	        	" + add.ToString() +
                    "\n-----------------------------------------------------------------------------------------------------------------------------------\n" +
                    "\t\tNet Payable			---	        	" + fin.ToString();


                if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                {
                    
                    printDocument1.Print();
                    
                }
            }
            else
            {
                MessageBox.Show("Wrong Num Cant Print");
            }
        }




        private void sno1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int f = 0;
                int c;
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
                            name.Text = rd.GetString(1);
                            rd.Close();
                            cmd.ExecuteNonQuery();
                            con.Close();
                            SendKeys.Send("{TAB}");
                            c = 1;
                            break;
                        }
                    }

                    if (c == 0)
                    {
                        name.Text = "";
                        sno1.Text = "";
                        MessageBox.Show("Wrong Num");
                        rd.Close();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    


                }
                else
                {
                    name.Text = "";
                    sno1.Text = "";
                    MessageBox.Show("Wrong Num");


                }
               
            }
        }

        public Form3()
        {
            InitializeComponent();
        }

       
        private void AddText(FileStream fs, string val)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(val);
            fs.Write(info, 0, info.Length);
           
        }

      
    }
}
