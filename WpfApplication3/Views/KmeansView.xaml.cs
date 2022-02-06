using BE;
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
using WpfApplication3.ViewModels;

namespace WpfApplication3.Views
{
    /// <summary>
    /// Logique d'interaction pour KmeansView.xaml
    /// </summary>
    public partial class KmeansView : UserControl
    {
        KmeansViewModel myvm;
        public List<Client> listSelectedClients;
        
        public addDisViewModel addDisViewModel;
        public Window1 win;
        // public event System.Windows.Forms.MouseEventHandler MouseClick;
        public KmeansView(Window1 win,addDisViewModel addDisViewModel)
        {
            InitializeComponent();
            this.win = win;
            this.addDisViewModel = addDisViewModel;
           
            listSelectedClients = new List<Client>();

            myvm = new KmeansViewModel(this);
            this.DataContext = myvm;
            myvm.KMeans();

        }


   
        
    }
}

