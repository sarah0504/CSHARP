using BE;
using BL;
using DAL;
using Microsoft.Maps.MapControl.WPF;
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
using WpfApplication3.ViewModel2;
using WpfApplication3.ViewModels;

namespace WpfApplication3.Views
{
    /// <summary>
    /// Interaction logic for MapsUserControlxaml.xaml
    /// </summary>
    public partial class MapsUserControlxaml : UserControl
    {
        MapsViewModel myvm;
        public MapsUserControlxaml()
        {
            InitializeComponent();
            myMap.Mode = new AerialMode(true);
            myMap.Focus();
            help();
            myvm = new MapsViewModel(this);
            DataContext = myvm;
           
        }

        public async Task help()
        {
            BLimp mybl = new BLimp();
            //Client a = new BE.Client { name = "harry", mail = "sarita.benzaquen@gmail.com", telephone = "0584494104", town = "ירושלים", address = "בן יהודה 7 ירושלים ", ID = 1 };
            //Client b = new BE.Client { name = "ado", mail = "sarita.benzaquen@gmail.com", telephone = "0584494104", town = "ירושלים", address = "הטורים 128 ירושלים", ID = 2 };
            //Client c = new BE.Client { name = "banane", mail = "sarita.benzaquen@gmail.com", telephone = "0584494104", town = "ירושלים", address = "כנפי נשרים 3 ירושלים ", ID = 3 };
            //Client d = new BE.Client { name = "banane", mail = "sarita.benzaquen@gmail.com", telephone = "0584494104", town = "ירושלים", address = "שלום יהודה 6 תלפיות ירושלים", ID = 4 };

            //DALimp mydal = new DALimp();
            //await mydal.setLocation(a);
            //await mydal.setLocation(b);
            //await mydal.setLocation(c);
            //await mydal.setLocation(d);

            //await mybl.AddClient(a);
            //await mybl.AddClient(b);
            //await mybl.AddClient(c);
            //await mybl.AddClient(d);

            //on rajoute a la liste des psuhpin tout les push pin 
            //List<Pushpin> pushpins = new List<Pushpin>();
            //foreach (var client in mybl.GetAllClients())
            //{
            //    Pushpin pin = new Pushpin { Location = client.location, Background = new SolidColorBrush(Colors.Yellow) };
            //    pushpins.Add(pin);
            //}

            ////on les rentre dans la carte 
            //foreach (var pin in pushpins)
            //{
            //    this.myMap.Children.Add(pin);
            //}
            // }
        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    this.Content = new ClientUserControl();
        //}
    }
}
