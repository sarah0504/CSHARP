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
    class DelModel
    {
        BLimp blimp { get; set; }

        public DelModel()
        {
            this.blimp = new BLimp();
        }

        internal async Task AddDeliveryMen(DeliveryMen del)
        {
            try
            {
                await blimp.AddDeliveryMen(del);
                MessageBox.Show("The deliveryMen has been added successfuly");

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
        internal async Task UpdateDeliveryMen(DeliveryMen del)
        {
            try
            {
                await blimp.UpdateDeliveryMen(del);
                int a = 79;
                int b = 45;
                MessageBox.Show("The deliveryMen has been updated successfuly");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        internal async Task RemoveDeliveryMen(DeliveryMen del)
        {
            try
            {
                await blimp.RemoveDeliveryMen(del);
                MessageBox.Show("The deliveryMen has been removed successfuly");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
