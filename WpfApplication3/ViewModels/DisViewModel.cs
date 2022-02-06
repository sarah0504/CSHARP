using BE;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApplication3.Model;
using WpfApplication3.ViewModel2;
using WpfApplication3.Views;

namespace WpfApplication3.ViewModels
{
    class DisViewModel : INotifyPropertyChanged
    {
        private DistUserControl distUserControl;
        public ReplaceCommand addDisComm { get; set; }
        public ReplaceCommand successDisComm { get; set; }
        DistributionModel model;
        public event PropertyChangedEventHandler PropertyChanged;

        public System.Windows.Controls.ContentControl page;
        private SuccessDis successDis;

        public DisViewModel(DistUserControl distUserControl, System.Windows.Controls.ContentControl page1)
        {
            model = new DistributionModel();
            this.distUserControl = distUserControl;
            addDisComm = new ReplaceCommand();
            successDisComm = new ReplaceCommand();
            this.addDisComm.ReplaceUserControl += addButton;
            this.successDisComm.ReplaceUserControl += successButton;
            this.page=page1;
        }
        public DisViewModel()
        {
            model = new DistributionModel();
        }

        public DisViewModel(SuccessDis successDis)
        {
            model = new DistributionModel();
            this.successDis = successDis;
        }

        public void addButton(string obj)
        {
            page.Content = new AddDis();
        }
        public void successButton(string obj)
        {
            page.Content = new SuccessDis();
        }
      
        internal ObservableCollection<Distribution> GetAllDistribution(Func<Distribution, bool> filter = null)
        {
            return model.GetAllDistribution();
        }
        internal List<Distribution> GetDistributionList(DeliveryMen del)
        {
            return model.GetDistributionList(del);
        }
    }
}
