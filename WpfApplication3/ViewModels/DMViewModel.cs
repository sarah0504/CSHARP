using BE;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WpfApplication3.Model;
using WpfApplication3.ViewModel2;
using WpfApplication3.Views;

namespace WpfApplication3.ViewModels
{
     class DMViewModel
    {
        DelModel model;
         DeliveryMenUserControl deliveryMenUserControl;
         ContentControl page;
        public ReplaceCommand addDMComm { get; set; }
        public ReplaceCommand removeDMComm { get; set; }
        public ReplaceCommand updateDMComm { get; set; }
        public ReplaceCommand pdfDMComm { get; set; }
        public ReplaceCommand addDelComm { get; set; }


        public DMViewModel(DeliveryMenUserControl deliveryMenUserControl, ContentControl page1)
        {
            model = new DelModel();
            this.deliveryMenUserControl = deliveryMenUserControl;
            this.page = page1;
            this.addDMComm = new ReplaceCommand();
            this.removeDMComm = new ReplaceCommand();
            this.updateDMComm = new ReplaceCommand();
            this.pdfDMComm = new ReplaceCommand();
            addDMComm.ReplaceUserControl += addDMButton;
            removeDMComm.ReplaceUserControl += removeDMButton;
            updateDMComm.ReplaceUserControl += updateDMButton;
            pdfDMComm.ReplaceUserControl += pdfDMButton;

        }
        private void addDMButton(string obj)
        {
            page.Content = new AddDelV();
        }
        private void removeDMButton(string obj)
        {
            page.Content = new RemoveDelV();
        }
        private void updateDMButton(string obj)
        {
            page.Content = new UpdateDelV();
        }
        private void pdfDMButton(string obj)
        {
            Window2 win = new Window2();
            win.Show();

        }
        internal ObservableCollection<DeliveryMen> GetAllDeliveryMen(Func<DeliveryMen, bool> filter = null)
        {
            return model.GetAllDeliveryMen();
        }
    }
}
