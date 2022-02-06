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
using BE;
using BL;
using DAL;
using WpfApplication3.ViewModels;

namespace WpfApplication3
{
    /// <summary>
    /// Logique d'interaction pour UserControl2.xaml
    /// </summary>
    public partial class RemoveDelV : UserControl
    {
        
        public DeliveryMen del = new DeliveryMen();
        RemoveDMViewModel myvm;
        public RemoveDelV()
        {
            InitializeComponent();
            this.myvm = new RemoveDMViewModel(this);
            this.IDc.ItemsSource = myvm.GetAllDeliveryMen().Select(m => m.ID);
            this.dataGrid.DataContext = del;
            this.buttonGrid.DataContext = myvm;
        }
        private void IDc_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (IDc.SelectedItem != null)
            {
                del = myvm.GetDEL(Int32.Parse(IDc.SelectedItem.ToString()));
                this.dataGrid.DataContext = del;
            }
            else;
        }
    }
}
