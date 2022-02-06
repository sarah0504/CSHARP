using BE;
using BL;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApplication3.Model
{
    public class ClientModel
    {
        BLimp blimp { get; set; }

        public ClientModel()
        {
            this.blimp = new BLimp();
        }

        internal async Task AddClient(Client client)
        {
            try
            {
                 await blimp.setLocation(client);
                await blimp.AddClient(client);
                 MessageBox.Show("The client has been added successfuly");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        internal ObservableCollection<Client> GetAllClients(Func<Client, bool> filter = null)
        {
            return blimp.GetAllClients();
        }
        internal DeliveryMen GetDEL(int v)
        {
            return blimp.GetDEL(v);
        }
        internal ObservableCollection<DeliveryMen> GetAllDeliveryMen()
        {
            return blimp.GetAllDeliveryMen();
        }
    }
}
