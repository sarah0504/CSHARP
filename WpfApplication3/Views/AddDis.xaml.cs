using BE;
using BL;
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
using WpfApplication3.ViewModels;

namespace WpfApplication3.Views
{
    /// <summary>
    /// Interaction logic for AddDis.xaml
    /// </summary>
    public partial class AddDis : UserControl
    {

        public DeliveryMen del;
        public Distribution dis;

        addDisViewModel myvm;
        public AddDis()
        {
            InitializeComponent();
            
            del = new DeliveryMen();
            myvm = new addDisViewModel(this, page);
            this.ListDM.ItemsSource = myvm.GetAllDeliveryMen().Select(m => m.ID);

            dis = new Distribution();
            dater.SelectedDate = DateTime.Today;


            this.dataGrid.DataContext = dis;

            this.buttonGrid.DataContext = myvm;
            this.checkGrid.DataContext = myvm;

        }
        public AddDis(addDisViewModel addDisViewModel)
        {
            InitializeComponent();
            this.ListDM.ItemsSource = myvm.GetAllDeliveryMen().Select(m => m.ID);
            del = new DeliveryMen();
            dis = new Distribution();
            dater.SelectedDate = new DateTime(2020, 09, 30);
           


            this.dataGrid.DataContext = dis;
            myvm = addDisViewModel;
            this.buttonGrid.DataContext = myvm;
            this.checkGrid.DataContext = myvm;





        }


        private void ListDM_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(ListDM.SelectedItem!=null)
            { del = myvm.GetDEL(Int32.Parse(ListDM.SelectedItem.ToString()));

            }
    } }
}
