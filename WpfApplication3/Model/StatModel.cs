using BL;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using ConsoleApplication1;

namespace WpfApplication3.Model
{
    class StatModel
    {
        BLimp blimp { get; set; }

        public StatModel()
        {
            this.blimp = new BLimp();
        }
        internal ObservableCollection<Client> GetAllClients(Func<Client, bool> filter = null)
        {
            return blimp.GetAllClients();
        }
        internal ObservableCollection<Address> GetAllCountry(Func<Address, bool> filter = null)
        {
            return blimp.GetAllCountry();
        }
       
        internal DeliveryMen GetDEL(int v)
        {
            return blimp.GetDEL(v);
        }
        internal ObservableCollection<DeliveryMen> GetAllDeliveryMen()
        {
            return blimp.GetAllDeliveryMen();
        }
        public void distdone()
        {
            blimp.distdone();
        }
    }
}
