using BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WpfApplication3.Model;
using WpfApplication3.Views;

namespace WpfApplication3.ViewModels
{
    class AddclientVM
    {
       
        AddClientUserControlxaml myview;
        ClientModel model;
        //public BLimp mybl = new BLimp();
        public ReplaceCommand addClientComm { get; set; }
        public ReplaceCommand CancelComm { get; set; }
        public AddclientVM(AddClientUserControlxaml addClientUserControlxaml)
        {
            model = new ClientModel();
            this.myview = addClientUserControlxaml;
            this.addClientComm = new ReplaceCommand();
            this.CancelComm = new ReplaceCommand();
            addClientComm.ReplaceUserControl += addClientButton;
            CancelComm.ReplaceUserControl += cancel;

        }


        private void addClientButton(string obj)
        {
            myview.client.address = myview.address;
            model.AddClient(myview.client);
            reset();
            //int a = 26;
        }
        private void cancel(string obj)
        {
            reset();
        }
        private void reset()
        {
            myview.id.Clear();
            myview.name.Clear();
            myview.town.Clear();
            myview.tel.Clear();
            myview.mail.Clear();
            myview.addressxaml.Clear();
        }
    }
}
