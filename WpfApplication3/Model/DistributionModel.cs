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
    class DistributionModel
    {

        BLimp blimp { get; set; }

        public DistributionModel()
        {
            this.blimp = new BLimp();
        }
        internal ObservableCollection<Client> GetAllClients(Func<Client, bool> filter = null)
        {
            return blimp.GetAllClients();
        }
        internal List<Distribution> GetDistributionList(DeliveryMen del)
        {
            return blimp.GetDistributionList(del);
        }
        internal ObservableCollection<Distribution> GetAllDistribution(Func<Distribution, bool> filter = null)
        {
            return blimp.GetAllDistribution();
        }
        public async Task Assignation(Distribution mydist, DeliveryMen mydel)
        {
            await blimp.Assignation(mydist, mydel);
        }
        internal async Task AddDistribution(Distribution dist)
        {
            try
            {
             await  blimp.AddDistribution(dist);
                MessageBox.Show("The distribution has been added successfuly");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        internal ObservableCollection<DeliveryMen> GetAllDeliveryMen(Func<DeliveryMen, bool> filter = null)
        {
            return blimp.GetAllDeliveryMen();
        }

        internal DeliveryMen GetDEL(int v)
        {
            return blimp.GetDEL(v);
        }
        public void distdone()
        {
           blimp.distdone();
        }
    }
}
