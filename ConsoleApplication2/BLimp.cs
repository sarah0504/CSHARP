using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using ConsoleApplication1;
using DAL;
namespace BL
{
    public class BLimp
    {
        DALimp testdal;

        public BLimp()
        {
            this.testdal = new DALimp();
        }

        public async Task AddClient(Client client1)
        {
            //await setLocation(client1);
            await testdal.AddClient(client1);
        }

        public async Task UpdateClient(Client client1)
        {
            await testdal.updateClient(client1);
        }

        public void distdone()
        {
             testdal.distdone();
        }

        public async Task RemoveClient(Client client1)
        {
            await testdal.removeClient(client1);
        }

        public List<Address> getAddressFromDis(Distribution dis)
        {
            return testdal.getAddressFromDis(dis);
        }
        public async Task<Client[][]> KMeans(bool food, bool drug)
        {
            return await testdal.Kmeans2(food, drug);

        }
        public async Task<object> SearchLocation(String myaddress, object jsonObject)
        {

            return await testdal.SearchLocation(myaddress, jsonObject);

        }


        public async Task AddDistribution(Distribution Distribution1)
        {
            await testdal.AddDistribution(Distribution1);
        }

        public ObservableCollection<DeliveryMen> GetAllDeliveryMen(Func<DeliveryMen, bool> filter = null)
        {
            return testdal.GetAllDeliveryMen();
        }
        public ObservableCollection<Client> GetAllClients(Func<DeliveryMen, bool> filter = null)
        {
            return testdal.GetAllClients();
        }

        public void Assignation2(Client client, Distribution dis)
        {
            testdal.Assignation2(client, dis);
        }
        public async Task setLocation(Client client)
        {
            await testdal.setLocation(client);
        }

        public async Task UpdateDistribution()
        {
            await testdal.UpdateDistribution();
        }



        public DeliveryMen GetDEL(int v)
        {
            return testdal.GetDEL(v);
        }

        public async Task RemoveDistribution(Distribution Distribution1)
        {
            await testdal.removeDistribution(Distribution1);
        }

        public async Task AddDeliveryMen(DeliveryMen DeliveryMen1)
        {
            //try
            //{
            await testdal.AddDeliveryMen(DeliveryMen1);
            //}
            //catch()
        }

        public async Task UpdateShop(DeliveryMen DeliveryMen1)
        {
            await testdal.UpdateDeliveryMen(DeliveryMen1);
        }

        public async Task RemoveDeliveryMen(DeliveryMen DeliveryMen1)
        {
            await testdal.removeDeliveryMen(DeliveryMen1);
        }
        public async Task UpdateDeliveryMen(DeliveryMen DeliveryMen1)
        {
            await testdal.UpdateDeliveryMen2(DeliveryMen1);
        }
        public async Task Assignation(Distribution mydist, DeliveryMen mydel)
        {
            await testdal.Assignation(mydist, mydel);
        }
        public ObservableCollection<Distribution> GetAllDistribution(Func<Distribution, bool> filter = null)
        {
            return testdal.GetAllDistribution();
        }
        public List<Distribution> GetDistributionList(DeliveryMen del)
        {
            return testdal.GetDistributionList(del);
        }
        public ObservableCollection<Address> GetAllCountry(Func<Address, bool> filter = null)
        {
            return testdal.GetAllCountry();
        }
    }
}

