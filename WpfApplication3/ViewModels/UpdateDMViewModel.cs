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
using WpfApplication3.Views;

namespace WpfApplication3.ViewModels
{
    class UpdateDMViewModel
    {
        DALimp mydal = new DALimp();
        DelModel model;
        private UpdateDelV myview;
        public ReplaceCommand updateDelComm { get; set; }
        public ReplaceCommand cancelComm { get; set; }
        // public System.Windows.Controls.ContentControl page;
        public UpdateDMViewModel(UpdateDelV view)
        {
            model = new DelModel();
            this.myview = view;
            updateDelComm = new ReplaceCommand();
            cancelComm = new ReplaceCommand();
            this.updateDelComm.ReplaceUserControl += update;
            cancelComm.ReplaceUserControl += cancel;
            //this.page = page1;
        }
        public void update(string obj)
        {
             model.UpdateDeliveryMen(myview.del);
           // mydal.UpdateDeliveryMen2(myview.del);
            reset();
        }
        public void cancel(string obj)
        {
            reset();
        }
        internal ObservableCollection<DeliveryMen> GetAllDeliveryMen(Func<DeliveryMen, bool> filter = null)
        {
            return model.GetAllDeliveryMen();
        }

        internal DeliveryMen GetDEL(int v)
        {
            return model.GetDEL(v);
        }
        private void reset()
        {
            myview.name.Clear();
            myview.tel.Clear();
            myview.mail.Clear();
            myview.lol.SelectedIndex = -1;
        }
    }
}

