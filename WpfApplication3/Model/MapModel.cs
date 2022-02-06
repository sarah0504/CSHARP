using BE;
using BL;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication3.Model
{
    class MapModel
    {
        BLimp blimp { get; set; }

        public MapModel()
        {
            this.blimp = new BLimp();
        }

  
        internal ObservableCollection<Client> GetAllClients(Func<DeliveryMen, bool> filter = null)
        {
            return blimp.GetAllClients();
        }
    }
}
