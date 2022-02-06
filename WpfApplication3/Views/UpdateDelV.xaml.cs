using BE;
using BL;
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
using WpfApplication3.Model;
using WpfApplication3.ViewModels;

namespace WpfApplication3.Views
{
    /// <summary>
    /// Interaction logic for UpdateDelV.xaml
    /// </summary>
    public partial class UpdateDelV : UserControl
    {
       
        public DeliveryMen del = new DeliveryMen();
        UpdateDMViewModel myvm;
        public UpdateDelV()
        {
            InitializeComponent();
        
            this.myvm = new UpdateDMViewModel(this);
            this.lol.ItemsSource = myvm.GetAllDeliveryMen().Select(m => m.ID);
            this.big.DataContext = del;
            this.little.DataContext = myvm;
        }
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lol.SelectedItem != null)
            {
                del = myvm.GetDEL(Int32.Parse(lol.SelectedItem.ToString()));
                this.big.DataContext = del;
            }
            else;
        }

    }
}
