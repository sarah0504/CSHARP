using BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using WpfApplication3.Model;

namespace WpfApplication3.ViewModels
{
    class addDMviewModel
    {
        //  public BLimp mybl =new BLimp();
        DelModel model;
        private AddDelV myview;
        public ReplaceCommand addDelComm { get; set; }
        public ReplaceCommand cancelComm { get; set; }
        // public System.Windows.Controls.ContentControl page;
        public addDMviewModel(AddDelV view)
        {
            model = new DelModel();
            this.myview = view;
            addDelComm = new ReplaceCommand();
            this.addDelComm.ReplaceUserControl += add;
            cancelComm = new ReplaceCommand();
            cancelComm.ReplaceUserControl += cancel;
            //this.page = page1;
        }

        public addDMviewModel()
        {
            model = new DelModel();
        }
        public void cancel(string obj)
        {
            reset();
        }
            
        public void add(string obj)
        {
            try
            {
                model.AddDeliveryMen(myview.del);
                reset();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void reset()
        {
            myview.id.Clear();
            myview.name.Clear();
            myview.addressxaml.Clear();
            myview.tel.Clear();
            myview.mail.Clear();
        }
    }
}
