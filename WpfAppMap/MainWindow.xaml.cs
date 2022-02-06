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
using Microsoft.Maps.MapControl.WPF;
using System.Windows.Controls;
using BL;
using BE;
using DAL;
using ConsoleApplication1;

namespace WpfAppMap
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //using (var db = new DALContext())
            //{
            InitializeComponent();
            //1 ca se voit en vrai 
            myMap.Mode = new AerialMode(true);
            //2 permet le zoom avec le clavier 
            myMap.Focus();
            help();
            //3 cree une forme de polygone avec des coordonees sur la carte 
            //    MapPolygon polygon = new MapPolygon();
            //    polygon.Fill = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Colors.Blue);
            //    polygon.Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Colors.Green);
            //    polygon.StrokeThickness = 5;
            //    polygon.Opacity = 0.7;
            //    polygon.Locations = new LocationCollection() {
            //new Location(47.6424,-122.3219),
            //new Location(47.8424,-122.1747),
            //new Location(47.5814,-122.1747)};

            //    myMap.Children.Add(polygon);
            //4 ca cree une ligne sur la map
            //        MapPolyline polyline = new MapPolyline();
            //        polyline.Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Colors.Blue);
            //        polyline.StrokeThickness = 5;
            //        polyline.Opacity = 0.7;
            //        polyline.Locations = new LocationCollection() {
            //new Location(47.6424,-122.3219),
            //new Location(47.8424,-122.1747),
            //new Location(47.67856,-122.130994)};

            //        myMap.Children.Add(polyline);

            //BLimp mybl = new BLimp();
            //Client a = new BE.Client { name = "harry", mail = "sarita.benzaquen@gmail.com", telephone = "0584494104", address = "Rue du Lt Jean Vigneux, Saint Gratien, France", ID = 1 };
            //Client b = new BE.Client { name = "ado", mail = "sarita.benzaquen@gmail.com", telephone = "0584494104", address = "52 rue jean collet meyzieu", ID = 2 };
            //Client c = new BE.Client { name = "banane", mail = "sarita.benzaquen@gmail.com", telephone = "0584494104", address = "35 rue chemin des pommiers meyzieu ", ID = 3 };
            //DALimp mydal = new DALimp();
            // mydal.setLocation(a);
            //int a26 = 26;
            //mybl.AddClient(a);
            //mybl.AddClient(b);
            //mybl.AddClient(c);

            ////on rajoute a la liste des psuhpin tout les push pin 
            //List<Pushpin> pushpins = new List<Pushpin>();
            //foreach(var client in mybl.GetAllClients())
            //{
            //    Pushpin pin = new Pushpin { Location = client.location, Background = new SolidColorBrush(Colors.Yellow) };
            //    pushpins.Add(pin);
            //}

            ////on les rentre dans la carte 
            //foreach (var pin in pushpins)
            //{
            //    this.myMap.Children.Add(pin);
            //}
            //// }
        }

        public async Task help()
        {
            BLimp mybl = new BLimp();
            //Client a = new BE.Client { name = "harry", mail = "sarita.benzaquen@gmail.com", telephone = "0584494104", address = "Rue du Lt Jean Vigneux, Saint Gratien, France", ID = 1 };
            //Client b = new BE.Client { name = "ado", mail = "sarita.benzaquen@gmail.com", telephone = "0584494104", address = "52 rue jean collet meyzieu", ID = 2 };
            //Client c = new BE.Client { name = "banane", mail = "sarita.benzaquen@gmail.com", telephone = "0584494104", address = "35 rue chemin des pommiers meyzieu ", ID = 3 };
            Address a = new Address("שלום יהודה 6 תלפיות ירושלים", "ירושלים");
            Client d = new Client { name = "banane", mail = "sarita.benzaquen@gmail.com", telephone = "0584494104",address=a, ID = 4 };
   
            DALimp mydal = new DALimp();
            //await mydal.setLocation(a);
            //await mydal.setLocation(b);
            await mydal.setLocation(d);
            //await mybl.AddClient(a);
            //await mybl.AddClient(b);
            await mybl.AddClient(d);

            //on rajoute a la liste des psuhpin tout les push pin 
            List<Pushpin> pushpins = new List<Pushpin>();
            foreach (var client in mybl.GetAllClients())
            {
                Pushpin pin = new Pushpin { Location = client.location, Background = new SolidColorBrush(Colors.Yellow) };
                pushpins.Add(pin);
             }

            //on les rentre dans la carte 
            foreach (var pin in pushpins)
            {
                this.myMap.Children.Add(pin);
            }
            // }
        }
    }
}
