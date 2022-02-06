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
using BE;
using BL;
using DAL;
using WpfApplication3.ViewModels;
using WpfApplication3.Views;

namespace WpfApplication3
{
    /// <summary>
    /// Logique d'interaction pour Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        ListViewModel myvm;
        public List<Client> listSelectedClients;
        DALimp mydal = new DALimp();
        public addDisViewModel addDisViewModel;
        // public event System.Windows.Forms.MouseEventHandler MouseClick;
        public Window1(addDisViewModel addDisViewModel)
        {
            InitializeComponent();
            this.addDisViewModel = addDisViewModel;
            DALimp test = new DALimp();
            listSelectedClients = new List<Client>();
            listView.ItemsSource = test.GetAllClients();
            myvm = new ListViewModel(this);
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
                addDisViewModel.myview.box1.Visibility = Visibility.Visible;
                addDisViewModel.myview.box2.Visibility = Visibility.Visible;
                addDisViewModel.myview.box4.Text= ""+listView.SelectedItems.Count;
                addDisViewModel.myview.box4.Visibility = Visibility.Visible;
                addDisViewModel.myview.box3.Visibility = Visibility.Visible;

            }
        }

        private void addButt_Click(object sender, RoutedEventArgs e)
        {

            this.Close();
        }

        private void MapWinButt_Click(object sender, RoutedEventArgs e)
        {
            
            this.mainGrid.Children.Add(new KmeansView(this,addDisViewModel));

        }
    }
}
