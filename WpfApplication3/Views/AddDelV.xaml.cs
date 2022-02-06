using System.Windows.Controls;
using BE;
using DAL;
using WpfApplication3.ViewModels;

namespace WpfApplication3
{
    /// <summary>
    /// Logique d'interaction pour UserControl1.xaml
    /// </summary>
    public partial class AddDelV : UserControl
    {
       
        addDMviewModel myaddvm;
       public  DeliveryMen del = new DeliveryMen();
        public AddDelV()
        {
            InitializeComponent();
            myaddvm = new addDMviewModel();
            DeliveryMen del1 = new DeliveryMen();
            this.dataGrid.DataContext = del;

            myaddvm = new addDMviewModel(this);
            this.buttonGrid.DataContext = myaddvm; 
        }

     
    }
}

