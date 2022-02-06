using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApplication3.Model;
using BE;
using ConsoleApplication1;
using WpfApplication3.Views;

namespace WpfApplication3.ViewModels
{
 
    class StatVM
    {
        private StatsUserControl stat;
        public ReplaceCommand generateComm { get; set; }
        StatModel model;
        public StatVM(StatsUserControl stat)
        {
            this.stat = stat;
            model = new StatModel();
            generateComm = new ReplaceCommand();
            this.generateComm.ReplaceUserControl += gener;
            
        }
        public void gener(string obj)
        {
            model.distdone();
            if (stat.bymonth.IsChecked == true) { stat.radio = 0; }
            if (stat.byday.IsChecked == true) { stat.radio = 1; }
            if (stat.byweek.IsChecked == true) { stat.radio = 2; }
            if (stat.byday.IsChecked == true) { stat.radio = 1; }
            if (stat.byone.IsChecked == true) { stat.radio2 = 0; }
            if (stat.bymore.IsChecked == true) { stat.radio2 = 1; }
            DateTime newdate = (DateTime)stat.eric.SelectedDate;

            if (stat.radio2 == 0)

            {
                String select = this.stat.combo.SelectedValue.ToString();
                Form1 ado = new Form1(newdate, stat.radio, select);
                ado.ShowDialog();
            }
            if (stat.radio2 == 1)
            {
                Form2 ado = new Form2(newdate, stat.radio, stat.testListbox);
                ado.ShowDialog();
                stat.testListbox = new List<String>();
            }

        }
        internal ObservableCollection<Client> GetAllClients(Func<Client, bool> filter = null)
        {
            return model.GetAllClients();
        }
        internal DeliveryMen GetDEL(int v)
        {
            return model.GetDEL(v);
        }
        internal ObservableCollection<DeliveryMen> GetAllDeliveryMen()
        {
            return model.GetAllDeliveryMen();
        }
        internal ObservableCollection<Address> GetAllCountry(Func<Address, bool> filter = null)
        {
            return model.GetAllCountry();
        }

    }
}
