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
    /// Interaction logic for SuccessDis.xaml
    /// </summary>
    public partial class SuccessDis : UserControl
    {
        DistributionModel model;
        DisViewModel mydisvm { get; set; }
        public SuccessDis()
        {
            InitializeComponent();
            model = new DistributionModel();
            model.distdone();
            mydisvm = new DisViewModel(this);
            listView.ItemsSource = mydisvm.GetAllDistribution().Where(m => m.isDone == true);
        
        }
    }
}
