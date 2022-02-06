using BL;
using Microsoft.Maps.MapControl.WPF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using WpfApplication3.Model;
using WpfApplication3.ViewModel2;
using WpfApplication3.Views;

namespace WpfApplication3.ViewModels
{
    class MapsViewModel
    {
        MapModel model;
        private MapsUserControlxaml myview;
        public ReplaceCommand returnMapCommand { get; set; }
    //    BLimp mybl;
        public MapsViewModel(MapsUserControlxaml mapsUserControlxaml)
        {
            model = new MapModel();
            this.myview = mapsUserControlxaml;
            initializeMap();
            returnMapCommand = new ReplaceCommand();
            returnMapCommand.ReplaceUserControl += returnWin;
        }
        public void returnWin(string obj)
        {
            myview.Content= new ClientUserControl();
        }
        public async Task initializeMap()
        {
            List<Pushpin> pushpins = new List<Pushpin>();
            foreach (var client in model.GetAllClients())
            {
                
                Pushpin pin = new Pushpin { Location = client.location, Background = new SolidColorBrush(Colors.Yellow) };
                pushpins.Add(pin);
            }

            //on les rentre dans la carte 
            foreach (var pin in pushpins)
            {
                myview.myMap.Children.Add(pin);
            }
        }
    }
}
