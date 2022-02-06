using BL;
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
using WpfApplication3.Model;
using WpfApplication3.ViewModels;

namespace WpfApplication3.Views
{
    /// <summary>
    /// Interaction logic for StatsUserControl.xaml
    /// </summary>
    public partial class StatsUserControl : UserControl
    {
        StatVM stat;

        public int radio;
        public int radio2;

       public List<Address> objCountryList;
       public List<String> testListbox = new List<string>();
        public StatsUserControl()
        {
            InitializeComponent();
           stat = new StatVM(this);
            using (var db = new DALContext())
            {
                objCountryList = stat.GetAllCountry().ToList();

                BindCountryDropDown();
                this.combo.ItemsSource = stat.GetAllCountry().Select(m=> m.city).Distinct();

            }
            this.DataContext = stat;
            
        }


   
        private void BindCountryDropDown()
        {
            ddlCountry.ItemsSource = objCountryList;
        }
      

        private void ddlCountry_TextChanged(object sender, TextChangedEventArgs e)
        {
            ddlCountry.ItemsSource = objCountryList.Where(x => x.city.StartsWith(ddlCountry.Text.Trim()));
        }

        private void AllCheckbocx_CheckedAndUnchecked(object sender, RoutedEventArgs e)
        {
            BindListBOX();
        }

        private void BindListBOX()
        {
      
            foreach (var country in objCountryList)
            {
                if (country.Check_Status == true)
                {
                    testListbox.Add(country.city) ;
                }
            }
        }


    }


}