using BE;
using BL;
using DAL;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApplication3.Model;

namespace WpfApplication3.ViewModels
{
    class RemoveDMViewModel
    {
      
        private RemoveDelV myview;
        public ReplaceCommand removeDelComm { get; set; }
        public ReplaceCommand cancelComm { get; set; }
        DelModel model;
        // public System.Windows.Controls.ContentControl page;
        public RemoveDMViewModel(RemoveDelV view)
        {
            model = new DelModel();
            this.myview = view;
            removeDelComm = new ReplaceCommand();
            cancelComm = new ReplaceCommand();
            this.removeDelComm.ReplaceUserControl += remove;
            this.cancelComm.ReplaceUserControl += cancel;

            //this.page = page1;
        }
        public void remove(string obj)
        {
            model.RemoveDeliveryMen(myview.del);
            reset();
        }
        public void cancel(string obj)
        {
           
            reset();
        }
        private void reset()
        {
            myview.IDc.SelectedIndex = -1;
            myview.ado.Clear();

        }
        internal ObservableCollection<DeliveryMen> GetAllDeliveryMen(Func<DeliveryMen, bool> filter = null)
        {
            return model.GetAllDeliveryMen();
        }

        internal DeliveryMen GetDEL(int v)
        {
            return model.GetDEL(v);
        }
    }
}
