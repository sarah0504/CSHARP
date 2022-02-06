using BE;
using BL;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
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
using WpfApplication3.ViewModels;

namespace WpfApplication3.Views
{
    /// <summary>
    /// Interaction logic for ClientBISmapUserControl.xaml
    /// </summary>
     public partial class ClientBISmapUserControl : UserControl
    {
        ClientViewModel myvm;
        public List<Client> listSelectedClients;
    
        public  addDisViewModel addDisViewModel;
        // public event System.Windows.Forms.MouseEventHandler MouseClick;
         public ClientBISmapUserControl(addDisViewModel addDisViewModel)
        {
            InitializeComponent();
            this.addDisViewModel = addDisViewModel;
            listSelectedClients = new List<Client>();
            listView.ItemsSource = addDisViewModel.GetAllClients();
            myvm = new ClientViewModel(this, page);
            DataContext = myvm;
        }



        private void listView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                foreach (var drv in listView.SelectedItems)
                {
                    Client selectedclient = (Client)drv;
                    listSelectedClients.Add(selectedclient);
                  

                }
            }
        }

    }
}
