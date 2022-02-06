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
using DAL;
using WpfApplication3.ViewModels;

namespace WpfApplication3.Views
{
    /// <summary>
    /// Logique d'interaction pour ListDist1.xaml
    /// </summary>
    public partial class ListDist1 : UserControl
    {
        DisViewModel disvm ;
        public ListDist1(DeliveryMen del)
        {
            InitializeComponent();
            disvm = new DisViewModel();
            listView.ItemsSource = disvm.GetDistributionList(del).ToList();
        }
    }
}
