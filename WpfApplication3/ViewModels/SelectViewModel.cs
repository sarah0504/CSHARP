using BE;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WpfApplication3.Model;
using WpfApplication3.Views;

namespace WpfApplication3.ViewModels
{
    class SelectViewModel
    {
        public selectUserControl myview { get; set; }
        ClientModel model;
        public ReplaceCommand ericCommand { get; set; }

        System.Windows.Controls.ContentControl page;

        public SelectViewModel(selectUserControl selectUserControl, System.Windows.Controls.ContentControl page)
        {
            model = new ClientModel();
            this.page = page;
            myview = selectUserControl;
            ericCommand = new ReplaceCommand();
            ericCommand.ReplaceUserControl+= mapfunction;
        }

       public void mapfunction(string obj)
        {
            int a = 26;
            this.page.Content = new MapsUserControlxaml();
        }
        internal ObservableCollection<Client> GetAllClients(Func<Client, bool> filter = null)
        {
            return model.GetAllClients();
        }
    }
}
