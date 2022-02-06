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
using DAL;
using WpfApplication3.ViewModels;
using WpfApplication3.Views;

namespace WpfApplication3.ViewModel2
{
    /// <summary>
    /// Logique d'interaction pour ClientUserControl.xaml
    /// </summary>
    public partial class ClientUserControl : UserControl
    {
        ClientViewModel myvm;
        public ClientUserControl()
        { 
            InitializeComponent();
            myvm = new ClientViewModel(this, page);
            listView.ItemsSource = myvm.GetAllClients();
            DataContext = myvm;
        }

       
    }
}
