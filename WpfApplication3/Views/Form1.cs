using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using DAL;

namespace WpfApplication3
{
    public partial class Form1 : Form
    {
        DALimp dal = new DALimp();


        public Form1(DateTime newdate, int byhow, String listselected)
        {
            List<Client> addresse = new List<Client>();
            List<Client> addresse2 = new List<Client>();

            InitializeComponent();

            using (var db = new DALContext())
            {

                switch (byhow)
                {
                    case 2:
                        {
                            int count = 0;
                            List<DateTime> listdate = new List<DateTime>();
                            DateTime time = newdate;
                            listdate.Add(newdate);
                            while (newdate.DayOfWeek != DayOfWeek.Sunday)
                            {
                                count = count + 1;
                                newdate = newdate.AddDays(1);
                                listdate.Add(newdate);
                            }
                            for (int i = count; i > 0; i--)
                            {
                                time = time.AddDays(-1);
                                listdate.Add(time);
                            }
                            listdate.Sort();
                            int countad = 0;
                            foreach (var lis in listdate)
                            {
                                foreach (var item in dal.GetAllDistribution().Where(m => m.isDone == true).Where(m => m.date == lis.Date))
                                {
                                    foreach (var client1 in dal.GetClientList(item))
                                    {
                                        if (client1.address.city == listselected)
                                            countad = countad + 1;
                                    }
                                }
                                chart1.Series["isDone"].Points.AddXY(lis.ToString(), countad);
                                countad = 0;
                            }
                            foreach (var lis in listdate)
                            {
                                foreach (var item in dal.GetAllDistribution().Where(m => m.isDone == false).Where(m => m.date == lis.Date))
                                {
                                    foreach (var client1 in dal.GetClientList(item))
                                    {
                                        if (client1.address.city == listselected)
                                            countad = countad + 1;
                                    }
                                }
                                chart1.Series["isNotDone"].Points.AddXY(lis.ToString(), countad);
                                countad = 0;
                            }
                            break;
                        }



                    case 1:
                        {

                            int countad = 0;


                            List<Distribution> dist = dal.GetAllDistribution().Where(m => m.isDone == true).Where(m => m.date == newdate).ToList();
                            foreach (var item in dist)
                            {
                                List<Client> cli = dal.GetClientList(item);
                                foreach (var client1 in cli)
                                {

                                    if (client1.address.city == listselected)
                                        countad = countad + 1;
                                }

                            }
                            chart1.Series["isDone"].Points.AddXY(newdate.ToString(), countad);
                            countad = 0;
                            foreach (var item in dal.GetAllDistribution().Where(m => m.isDone == false).Where(m => m.date == newdate))
                            {
                                foreach (var client1 in dal.GetClientList(item))
                                {
                                    if (client1.address.city == listselected)
                                        countad = countad + 1;
                                }

                            }
                            chart1.Series["isNotDone"].Points.AddXY(newdate.ToString(), countad);
                            break;
                        }
                    case 0:
                        {
                            int countad = 0;
                            foreach (var item in dal.GetAllDistribution().Where(m => m.isDone == true).Where(m => m.date.Year == newdate.Year).Where(m => m.date.Year == newdate.Year))
                            {
                                foreach (var client1 in dal.GetClientList(item))
                                {
                                    if (client1.address.city == listselected)
                                        countad = countad + 1;
                                }

                            }
                            string name = newdate.Month.ToString() + " " + newdate.Year.ToString();
                            chart1.Series["isDone"].Points.AddXY(name, countad);
                            countad = 0;
                            foreach (var item in dal.GetAllDistribution().Where(m => m.isDone == false).Where(m => m.date.Year == newdate.Year).Where(m => m.date.Year == newdate.Year))
                            {
                                foreach (var client1 in dal.GetClientList(item))
                                {
                                    if (client1.address.city == listselected)
                                        countad = countad + 1;
                                }

                            }
                            chart1.Series["isNotDone"].Points.AddXY(name.ToString(), countad);
                            break;
                        }


                    default:
                        Console.WriteLine("Default case");
                        break;
                }

            }

        }

    }
}

