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
using System.Windows.Shapes;
using WpfApplication3.ViewModels;

namespace WpfApplication3.Views
{
    /// <summary>
    /// Logique d'interaction pour Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        ClientViewModel clientvm;
        DALimp dal = new DALimp();
        BLimp bl = new BLimp();
        DeliveryMen del;
        PdfViewModel myvvm { get; set; }
        public Window2()
        {
            InitializeComponent();
            del = new DeliveryMen();
            clientvm = new ClientViewModel();
            this.lol.ItemsSource = clientvm.GetAllDeliveryMen().Select(m => m.ID);
            //  listView.ItemsSource = dal.GetDistributionList(del);
            this.DataContext = del;
            myvvm = new PdfViewModel(this);
            this.buttGrid.DataContext = myvvm;

        }


        private void lol_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lol.SelectedItem != null)
            {
                del = clientvm.GetDEL(Int32.Parse(lol.SelectedItem.ToString()));

                this.DataContext = del;
                this.lolita.Content = new ListDist1(del);
            }
            else;


        }
    }

}
