using BE;
using ConsoleApplication1;
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
    /// Interaction logic for AddClientUserControlxaml.xaml
    /// </summary>
    public partial class AddClientUserControlxaml : UserControl
    {
      
       AddclientVM myaddvm;
            public Client client;
        public Address address;
        public AddClientUserControlxaml()
        {
            InitializeComponent();
            myaddvm = new AddclientVM(this);
            client = new Client();
            address = new Address();
            this.dataGrid.DataContext = client;
            this.addressGrid.DataContext = address;
            //del.mykind = kindOfNeed.Drugs;

           
            this.buttonGrid.DataContext = myaddvm;
        }

       
    }
}
