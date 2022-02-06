using BE;
using BL;
using ConsoleApplication1;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            using (var db = new DALContext())
            {

                InitializeComponent();
                BLimp mybl = new BLimp();
                DALimp mydal = new DALimp();
                //mydal.AddDeliveryMen(new DeliveryMen(1567, "sa", "fzeyd@kzrjh", "0658311966"));
                //mydal.Assignation(new Distribution(1), new DeliveryMen(1567));
                //    mydal.UpdateDeliveryMen2(new DeliveryMen(12345, "MALKI34", "fzeyd@kzrjh", "0658311966"));
                //Client a = new BE.Client { name = "harry", mail = "sarita.benzaquen@gmail.com", telephone = "0584494104", address = "3 villa fleurie", ID = 12 };
                //   Client b = new BE.Client { name = "ado", mail = "sarita.benzaquen@gmail.com", telephone = "0584494104", address = "3 villa fleurie", ID = 12 };
                //     Address a = new Address();
                //     Client c = new BE.Client { name = "banane", mail = "sarita.benzaquen@gmail.com", telephone = "0584494104", address = a, ID = 12 };
                //     int cvgv = 78;
                //  //   mybl.AddClient(c);
                //     int step1 = 7;
                //     int step2 = 89;
                //     int step3 = 12;
                //     int step4 = 23;
                //     List<Client> mylist = mybl.GetAllClients().ToList<Client>();
                //     int a13 = 26;
                //     Distribution b1 = new Distribution(78, new DateTime(2020, 09, 18), true);
                ////   mybl.AddDistribution(b1);
                //   mybl.Assignation2(c, new Distribution(1));
                // //    foreach (var item in mydal.GetAllCountry())
                // //    {
                // //        Console.WriteLine(item.city);
                // //    }
                // }
                mydal.distdone();



            }
        }
    }
}

