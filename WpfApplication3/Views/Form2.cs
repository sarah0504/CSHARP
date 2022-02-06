using BE;
using ConsoleApplication1;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WpfApplication3.Views
{
    public partial class Form2 : Form
    {
        DALimp dal = new DALimp();

        public Form2(DateTime newdate, int byhow, List<String> listselected)
        {
            List<Client> addresse = new List<Client>();

            InitializeComponent();


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
                        foreach (var lis in listdate)
                        {
                            foreach (var item in dal.GetAllDistribution().Where(m => m.isDone == true).Where(m => m.date == lis.Date))
                            {
                                foreach (var client1 in dal.GetClientList(item))
                                {
                                    addresse.Add(client1);
                                }
                            }
                        }
                        var lol = addresse.GroupBy(p => p.address.city);
               
                        foreach (var p in lol)
                        {
                            if (listselected.Contains(p.Key)) {
                            chart1.Series["town"].Points.AddXY(p.Key, p.Count()); }
                        }



                        break;
                    }
                case 1:
                    {
                        foreach (var item in dal.GetAllDistribution().Where(m => m.isDone == true).Where(m => m.date == newdate.Date))
                        {
                            foreach (var client1 in dal.GetClientList(item))
                            {
                                addresse.Add(client1);
                            }
                        }


                        var lol = addresse.GroupBy(p => p.address.city);
                        List<string> selectad = new List<string>();
               
                        foreach (var p in lol)
                        {
                            if (listselected.Contains(p.Key))
                            {
                                chart1.Series["town"].Points.AddXY(p.Key, p.Count());
                            }
                        }
                        break;

                    }
                case 0:
                    {
                        foreach (var item in dal.GetAllDistribution().Where(m => m.isDone == true).Where(m => m.date.Month == newdate.Date.Month).Where(m => m.date.Year == newdate.Date.Year))
                        {
                            foreach (var client1 in dal.GetClientList(item))
                            {
                                addresse.Add(client1);
                            }
                        }
                        var lol = addresse.GroupBy(p => p.address.city);
                   
                        foreach (var p in lol)
                        {
                            if (listselected.Contains(p.Key))
                            {
                                chart1.Series["town"].Points.AddXY(p.Key, p.Count());
                            }
                        }

                        break;

                    }
                default:
                    Console.WriteLine("Default case");
                    break;
            }

        }





    }
}
