using BE;
using BL;
using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WpfApplication3.Model;
using WpfApplication3.ViewModel2;
using WpfApplication3.Views;

namespace WpfApplication3.ViewModels
{
    class ClientViewModel
    {
        ClientModel model;
        public ReplaceCommand addWinCommand { get; set; }
        public ReplaceCommand addListCommand { get; set; }
        public ReplaceCommand mapWinCommand { get; set; }
        public ReplaceCommand mapBISWinCommand { get; set; }
        public ClientBISmapUserControl myview { get; }
    //    BLimp mybl = new BLimp();
        public System.Windows.Controls.ContentControl page;
        private ClientUserControl clientUserControl;

        public ClientViewModel(ClientUserControl clientUserControl, ContentControl page)
        {
            model = new ClientModel();
            this.clientUserControl = clientUserControl;
            this.page = page;
            addWinCommand = new ReplaceCommand();
            mapWinCommand = new ReplaceCommand();
            addWinCommand.ReplaceUserControl += addwindow;
            mapWinCommand.ReplaceUserControl += mapwindow;
           
        }

        internal ObservableCollection<DeliveryMen> GetAllDeliveryMen()
        {
            return model.GetAllDeliveryMen();
        }

        private void mapwindow(string obj)
        {
            this.page.Content = new MapsUserControlxaml();
        }
        public ClientViewModel(ClientBISmapUserControl clientBISmapUserControl, ContentControl page)
        {
            this.myview = clientBISmapUserControl;
            this.page = page;
            mapBISWinCommand = new ReplaceCommand();
            addListCommand = new ReplaceCommand();
        
        }

        public ClientViewModel()
        {
            model = new ClientModel();
        }

        internal ObservableCollection<Client> GetAllClients(Func<Client, bool> filter = null)
        {
            return model.GetAllClients();
        }


        internal DeliveryMen GetDEL(int v)
        {
            return model.GetDEL(v);
        }
        private void addwindow(string obj)
        {
            AddClientUserControlxaml AD = new AddClientUserControlxaml();
            this.page.Content = AD;
        }
    }
}
