using BE;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Data.Entity.Migrations;
using Microsoft.Maps.MapControl.WPF;
using ConsoleApplication1;
using System.Net.Http;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.Runtime.ExceptionServices;
using Newtonsoft.Json.Linq;
using System.CodeDom;

namespace DAL
{
    public class DALimp
    {
        DALContext data = new DALContext();

        public DALimp() { }

        public async Task AddClient(Client Client1)
        {

            using (var db = new DALContext())
            {
                bool isexisting = false;
                foreach (var item in db.ClientList)
                {
                    if (item.ID == Client1.ID)
                        isexisting = true;
                }
                if (Client1 == null || isexisting == true)
                    throw new Exception("the client that you want to add is empty or already existing");
                bool problem = true;
                if ((Client1.telephone.Substring(0, 1) == "0" || Client1.telephone.Substring(0, 1) == "+" || Client1.telephone.Substring(0, 1) == "*") && (Client1.telephone.Length == 10 || Client1.telephone.Length == 13 || Client1.telephone.Length == 5))
                    problem = false;
                if (problem)
                    throw new Exception("You can't add a client without an valid phone number");

                if (Client1.mail.Contains("@") == false)
                    throw new Exception("You can't add a client without an valid email address");


                db.ClientList.Add(Client1);
               
                    await db.SaveChangesAsync();
               
            }
        }

        public List<Address> getAddressFromDis(Distribution dis)
        {
            List<Address> adres = new List<Address>();

            using (var db = new DALContext())
            {
                foreach (var item in dis.ClientList)
                {
                    adres.Add(item.address);
                }

            }
            return adres;
        }
        public List<Client> AddressDispo(Boolean food, Boolean drug)
        {
            List<Client> addressdispo = new List<Client>();

            using (var db = new DALContext())
            {

                foreach (Client myclient in db.ClientList)
                {


                    addressdispo.Add(myclient);


                }


                return addressdispo;

            }

        }



        [HandleProcessCorruptedStateExceptions]
        public async Task<Client[][]> Kmeans2(Boolean food, Boolean drug)
        {
            List<Client> myaddresslist = AddressDispo(food, drug);
            if (myaddresslist.Count == 0)
                return null;

            double[][] rawData = new double[myaddresslist.Count()][];
            int i = 0;
            foreach (Client client in myaddresslist)
            {

                Console.WriteLine(client.address.city);
                Object o = new object();


                while (rawData[i] == null)
                {
                    try
                    {
                        string streetname = client.address.city;
                        if (streetname.Contains("TelAviv"))
                            streetname = streetname.Replace("TelAviv", "Tel Aviv");

                        string adhelp = client.address.street + " " + client.address.city;
                        var x = await SearchLocation(adhelp, o);
                        var jo1 = JArray.Parse(x.ToString());
                        //var jo = JObject.Parse(x.ToString());
                        //var joke = jo["value"][0]["joke"].ToString();

                        Console.WriteLine(jo1[0]["lat"].ToString());
                        Console.WriteLine(jo1[0]["lon"].ToString());

                        rawData[i] = new double[] { Double.Parse(jo1[0]["lat"].ToString().Replace(".", ",")), Double.Parse(jo1[0]["lon"].ToString().Replace(".", ",")) };

                    }
                    catch (Newtonsoft.Json.JsonReaderException e)
                    {

                        continue;
                    }
                }
                i++;


            }


            int numClusters = GetAllDeliveryMen().Count;
            int[] clustering = Cluster(rawData, numClusters);


            Client[][] listAddressdis = GetAddressFromCluster(rawData, clustering, numClusters, 1, AAAA(myaddresslist));
            MessageBox.Show(listAddressdis.Length.ToString());

            return listAddressdis;
        }
        public List<Client> AAAA(List<Client> ado)
        {
            List<Client> adis = new List<Client>();
            foreach (var client in ado)
            {
                adis.Add(client);
            }
            return adis;
        }
        #region helpKmeans
        public int[] Cluster(double[][] rawData,
         int numClusters)
        {
            //  double[][] data = Normalized(rawData);
            double[][] data = rawData;
            bool changed = true; bool success = true;
            int[] clustering = InitClustering(data.Length, numClusters, 0);
            double[][] means = Allocate(numClusters, data[0].Length);
            int maxCount = data.Length * 10;
            int ct = 0;
            while (changed == true && success == true && ct < maxCount)
            {
                ++ct;
                success = UpdateMeans(data, clustering, means);
                changed = UpdateClustering(data, clustering, means);
            }
            return clustering;
        }

        private double[][] Normalized(double[][] rawData)
        {
            double[][] result = new double[rawData.Length][];
            for (int i = 0; i < rawData.Length; ++i)
            {
                result[i] = new double[rawData[i].Length];
                Array.Copy(rawData[i], result[i], rawData[i].Length);
            }

            for (int j = 0; j < result[0].Length; ++j)
            {
                double colSum = 0.0;
                for (int i = 0; i < result.Length; ++i)
                    colSum += result[i][j];
                double mean = colSum / result.Length;
                double sum = 0.0;
                for (int i = 0; i < result.Length; ++i)
                    sum += (result[i][j] - mean) * (result[i][j] - mean);
                double sd = sum / result.Length;
                for (int i = 0; i < result.Length; ++i)
                    result[i][j] = (result[i][j] - mean) / sd;
            }
            return result;
        }
        private int[] InitClustering(int numTuples,
          int numClusters, int seed)
        {
            Random random = new Random(seed);
            int[] clustering = new int[numTuples];
            for (int i = 0; i < numClusters; ++i)
                clustering[i] = i;
            for (int i = numClusters; i < clustering.Length; ++i)
                clustering[i] = random.Next(0, numClusters);
            return clustering;
        }
        private double[][] Allocate(int numClusters,
          int numColumns)
        {
            double[][] result = new double[numClusters][];
            for (int k = 0; k < numClusters; ++k)
                result[k] = new double[numColumns];
            return result;
        }
        private bool UpdateMeans(double[][] data,
          int[] clustering, double[][] means)
        {
            int numClusters = means.Length;
            int[] clusterCounts = new int[numClusters];
            for (int i = 0; i < data.Length; ++i)
            {
                int cluster = clustering[i];
                ++clusterCounts[cluster];
            }

            for (int k = 0; k < numClusters; ++k)
                if (clusterCounts[k] == 0)
                    return false;

            for (int k = 0; k < means.Length; ++k)
                for (int j = 0; j < means[k].Length; ++j)
                    means[k][j] = 0.0;

            for (int i = 0; i < data.Length; ++i)
            {
                int cluster = clustering[i];
                for (int j = 0; j < data[i].Length; ++j)
                    means[cluster][j] += data[i][j]; // accumulate sum
            }

            for (int k = 0; k < means.Length; ++k)
                for (int j = 0; j < means[k].Length; ++j)
                    means[k][j] /= clusterCounts[k]; // danger of div by 0
            return true;
        }
        private bool UpdateClustering(double[][] data,
          int[] clustering, double[][] means)
        {
            int numClusters = means.Length;
            bool changed = false;

            int[] newClustering = new int[clustering.Length];
            Array.Copy(clustering, newClustering, clustering.Length);

            double[] distances = new double[numClusters];

            for (int i = 0; i < data.Length; ++i)
            {
                for (int k = 0; k < numClusters; ++k)
                    distances[k] = Distance(data[i], means[k]);

                int newClusterID = MinIndex(distances);
                if (newClusterID != newClustering[i])
                {
                    changed = true;
                    newClustering[i] = newClusterID;
                }
            }

            if (changed == false)
                return false;

            int[] clusterCounts = new int[numClusters];
            for (int i = 0; i < data.Length; ++i)
            {
                int cluster = newClustering[i];
                ++clusterCounts[cluster];
            }

            for (int k = 0; k < numClusters; ++k)
                if (clusterCounts[k] == 0)
                    return false;

            Array.Copy(newClustering, clustering, newClustering.Length);
            return true; // no zero-counts and at least one change 

        }

        private double Distance(double[] tuple, double[] mean)
        {
            double sumSquaredDiffs = 0.0;
            for (int j = 0; j < tuple.Length; ++j)
                sumSquaredDiffs += Math.Pow((tuple[j] - mean[j]), 2);
            return Math.Sqrt(sumSquaredDiffs);
        }

        private int MinIndex(double[] distances)
        {
            int indexOfMin = 0;
            double smallDist = distances[0];
            for (int k = 0; k < distances.Length; ++k)
            {
                if (distances[k] < smallDist)
                {
                    smallDist = distances[k];
                    indexOfMin = k;
                }
            }
            return indexOfMin;
        }


        Client[][] GetAddressFromCluster(double[][] data, int[] clustering,
         int numClusters, int decimals, List<Client> addressdispo)
        {
            Client[][] mylist = new Client[numClusters][];


            for (int k = 0; k < numClusters; ++k)
            {
                Client[] mylistaddress = new Client[data.Length];
                for (int i = 0; i < data.Length; ++i)
                {
                    int clusterID = clustering[i];
                    if (clusterID != k) continue;

                    mylistaddress[i] = addressdispo.ElementAt(i);


                }
                mylist[k] = mylistaddress;
            } // k

            return mylist;
        }
        #endregion

        public async Task<object> SearchLocation(String myaddress, object jsonObject)
        {
            string token = "735f8e90cb196c";
            string url = "https://eu1.locationiq.com/v1/search.php?key=" + token + "&q=" + myaddress + "&format=json";
            try
            {

                using (HttpClient client = new HttpClient())
                {
                    var content = new StringContent(jsonObject.ToString(), Encoding.UTF8, "application/json");
                    var response = await client.PostAsync(url, content);
                    if (response != null)
                    {
                        var jsonString = await response.Content.ReadAsStringAsync();
                        return JsonConvert.DeserializeObject<object>(jsonString);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return null;
        }

        public async Task setLocation(Client myobj)
        {
            using (var db = new DALContext())
            {
                (double lat, double lng) = (myobj.location.Latitude, myobj.location.Longitude);

                string addressClient = myobj.address.street + " " + myobj.address.city;
                if (myobj.address.street=="default" || myobj.address.city=="default")
                {
                    throw new Exception("the address is not a valid address");
                }
                (lat, lng) = await LocationHelper.GetLatLong(addressClient);
               


            

            myobj.location = new Microsoft.Maps.MapControl.WPF.Location(lat, lng);
            await db.SaveChangesAsync();
        }
        }
        public List<Client> GetClientList(Distribution del)
        {
            using (var db = new DALContext())
            {
                List<Client> newl = new List<Client>();
                foreach (var item in db.DistributionList)
                {
                    if (item.ID == del.ID)
                    {
                        foreach (var lol in item.ClientList)
                        {
                            newl.Add(lol);
                        }
                    }
                }
                return newl;
            }
        }
        public ObservableCollection<Address> GetAllCountry(Func<Address, bool> filter = null)
        {
            using (var db = new DALContext())
            {
                List<String> listcity = new List<String>();
                foreach(var client in db.ClientList)
                {
                    listcity.Add(client.address.city);
                }
                listcity = listcity.Distinct().ToList();
                List<Address> listaddress = new List<Address>();
                foreach(var client in db.ClientList)
                { if (listcity.Contains(client.address.city))
                    {
                        listcity.Remove(client.address.city);
                        listaddress.Add(client.address);
                    }
                }
                var list = new ObservableCollection<Address>(listaddress.Distinct());
                return new ObservableCollection<Address>(list);
            }
        }
        public async Task updateClient(Client Client1)
        {
            using (var db = new DALContext())
            {
                if (Client1 == null)
                    throw new Exception("the client that you want to update is empty ");
                bool problem = true;
                if ((Client1.telephone.Substring(0, 1) == "0" || Client1.telephone.Substring(0, 1) == "+" || Client1.telephone.Substring(0, 1) == "*") && (Client1.telephone.Length == 10 || Client1.telephone.Length == 13 || Client1.telephone.Length == 5))
                    problem = false;
                if (problem)
                    throw new Exception("You can't update a client without an valid phone number");

                if (Client1.mail.Contains("@") == false)
                    throw new Exception("You can't update a client without an valid email address");

                bool flag = false;
                foreach (var item in db.ClientList)
                {

                    if (item.ID == Client1.ID)
                    {
                        flag = true;
                    }
                }
                if (flag)
                {
                    db.ClientList.AddOrUpdate(Client1);
                    await db.SaveChangesAsync();
                }

            }
        }
        public async Task removeClient(Client client1)
        {
            if (client1 == null)
                throw new Exception("the client that you want to remove doesn't exist ");
            else
            {
                using (var db = new DALContext())
                {
                    Client a = db.ClientList.Find(client1.ID);
                    db.Entry(a).State = EntityState.Deleted;
                    await db.SaveChangesAsync();
                }
            }
        }

        public async Task Assignation(Distribution mydist, DeliveryMen mydel)
        {
            using (var db = new DALContext())
            {
                Distribution dist = db.DistributionList.FirstOrDefault(distribution => distribution.ID == mydist.ID);
                if (dist == null)
                {
                    throw new ArgumentNullException("Doesn't exist");
                }

                DeliveryMen del = db.DeliveryMenList.FirstOrDefault(deliverym => deliverym.ID == mydel.ID);
                if (del == null)
                {
                    throw new ArgumentNullException("Doesn't exist");
                }

                del.DistributionList.Add(dist);

              await  db.SaveChangesAsync();
            }

        }
        public void Assignation2(Client mycl,Distribution mydist)
        {
            using (var db = new DALContext())
            {
                Client client = db.ClientList.FirstOrDefault(clien => clien.ID == mycl.ID);
                if (client == null)
                {
                    throw new ArgumentNullException("Doesn't exist");
                }

                Distribution del = db.DistributionList.FirstOrDefault(dist => dist.ID == mydist.ID);
                if (del == null)
                {
                    throw new ArgumentNullException("Doesn't exist");
                }

                del.ClientList.Add(client);

                db.SaveChanges();
            }

        }

        public async Task AddDeliveryMen(DeliveryMen DeliveryMen1)
        {
            using (var db = new DALContext())
            {
                bool isexisting = false;
                foreach (var item in db.DeliveryMenList)
                {
                    if (item.ID == DeliveryMen1.ID)
                        isexisting = true;
                }
                if (DeliveryMen1 == null || isexisting == true)
                    throw new Exception("the DeliveryMen that you want to add is empty or already existing");
                bool problem = true;
                if (!(DeliveryMen1.telephone=="") &&(DeliveryMen1.telephone.Substring(0, 1) == "0" || DeliveryMen1.telephone.Substring(0, 1) == "+" || DeliveryMen1.telephone.Substring(0, 1) == "*") && (DeliveryMen1.telephone.Length == 10 || DeliveryMen1.telephone.Length == 13 || DeliveryMen1.telephone.Length == 5))
                    problem = false;
                if (problem)
                    throw new Exception("You can't add a DeliveryMen without an valid phone number");

                if (DeliveryMen1.mail.Contains("@") == false)
                    throw new Exception("You can't add a DeliveryMen without an valid email address");
        
                db.DeliveryMenList.Add(DeliveryMen1);
                await db.SaveChangesAsync();

                

                           }
        }
        public async Task UpdateDeliveryMen(DeliveryMen DeliveryMen1)
        {
            
            using (var db = new DALContext())
            {
                bool flag = false;
                foreach (var item in db.DeliveryMenList)
                {
                    if (item.ID == DeliveryMen1.ID)
                    {
                        flag = true;
                    }
                }
                if (DeliveryMen1 == null)
                    throw new Exception("the DeliveryMen that you want to update is null");
                bool problem = true;
                if ((DeliveryMen1.telephone.Substring(0, 1) == "0" || DeliveryMen1.telephone.Substring(0, 1) == "+" || DeliveryMen1.telephone.Substring(0, 1) == "*") && (DeliveryMen1.telephone.Length == 10 || DeliveryMen1.telephone.Length == 13 || DeliveryMen1.telephone.Length == 5))
                    problem = false;
                if (problem)
                    throw new Exception("You can't update a DeliveryMen without an valid phone number");

                if (DeliveryMen1.mail.Contains("@") == false)
                    throw new Exception("You can't update a DeliveryMen without an valid email address");

                if (flag)
                {
                    await removeDeliveryMen(DeliveryMen1);
                    int a = 5;
                    await AddDeliveryMen(DeliveryMen1);

                }


            }
    }
        public async Task UpdateDeliveryMen2(DeliveryMen DeliveryMen1)
        {

            using (var db = new DALContext())
            {
                
                DeliveryMen del = db.DeliveryMenList.FirstOrDefault(deliverym => deliverym.ID == DeliveryMen1.ID);

                Distribution[] newlist = new Distribution[del.DistributionList.Count];

                del.DistributionList.CopyTo(newlist, 0);
                foreach (var item in newlist)
                    del.DistributionList.Remove(item);
                db.DeliveryMenList.AddOrUpdate(DeliveryMen1);
                await db.SaveChangesAsync();

                for (int i = 0; i < newlist.Length; i++)
                {
                    Assignation(newlist[i], DeliveryMen1);
                }

                await db.SaveChangesAsync();

          


                //}


            }
        }
        public async Task removeDeliveryMen(DeliveryMen delivery1)
        {
            if (GetDistributionList(delivery1).Count != 0)
                throw new Exception("this delivery men is already assigned to a distribution,you can't remove it");

            if (delivery1 == null)
                throw new Exception("the delivery men that you want to add doesn't exist ");
            //else
            //{
            using (var db = new DALContext())
                {
                    DeliveryMen a = await db.DeliveryMenList.FindAsync(delivery1.ID);
                    db.Entry(a).State = EntityState.Deleted;
                    await db.SaveChangesAsync();
                }
            //}
        }

        public async Task AddDistribution(Distribution Distribution1)
        {
            using (var db = new DALContext())
            {
                bool isexisting = false;
                foreach (var item in db.DistributionList)
                {
                    if (item.ID == Distribution1.ID)
                        isexisting = true;
                }
                if (Distribution1 == null && isexisting == true)
                    throw new Exception("the DeliveryMen that you want to add is empty or already existing");
                if (Distribution1.ClientList==null)
                {
                    throw new Exception("you must select at least one client to this distribution");
                }

                Client[] newlist = new Client[Distribution1.ClientList.Count];
              
                Distribution1.ClientList.CopyTo(newlist, 0);
                foreach (var item in newlist)
                    Distribution1.ClientList.Remove(item);
                db.DistributionList.Add(Distribution1);
                await db.SaveChangesAsync();

                for (int i = 0; i < newlist.Length; i++)
                {
                    Assignation2(newlist[i], Distribution1);
                }

                await db.SaveChangesAsync();

            }
        }
        public async Task UpdateDistribution()
        {

            using (var db = new DALContext())
            {
                bool flag = false;
                foreach (var item in db.DistributionList)
                {
                    if (item.date <DateTime.Now)
                    {
                        item.isDone = true;
                    }
                }


                await db.SaveChangesAsync();

            }
        }
        public async Task removeDistribution(Distribution Distribution1)
        {
            if (Distribution1.ClientList.Count != 0)
                throw new Exception("this distribution is already assigned");
            if (Distribution1 == null)
                throw new Exception("the distribution does'nt exist ");
            else
            {
                using (var db = new DALContext())
                {
                    Distribution a = await db.DistributionList.FindAsync(Distribution1.ID);
                    db.Entry(a).State = EntityState.Deleted;
                    await db.SaveChangesAsync();
                }
            }
        }

        public ObservableCollection<Client> GetAllClients(Func<Client, bool> filter = null)
        {
            using (var db = new DALContext())
            {
                var list = new ObservableCollection<Client>(db.ClientList
                    .Distinct()
                    .AsNoTracking());
        

                return new ObservableCollection<Client>(list);
            }
        }
        public ObservableCollection<DeliveryMen> GetAllDeliveryMen(Func<DeliveryMen, bool> filter = null)
        {
            using (var db = new DALContext())
            {
                var list = new ObservableCollection<DeliveryMen>(db.DeliveryMenList
                    .Distinct()
                    .AsNoTracking());

                return new ObservableCollection<DeliveryMen>(list);
            }
        }
        public ObservableCollection<Distribution> GetAllDistribution(Func<Distribution, bool> filter = null)
        {
            using (var db = new DALContext())
            {
                var list = new ObservableCollection<Distribution>(db.DistributionList
                    .Distinct()
                    .AsNoTracking());         
                return new ObservableCollection<Distribution>(list);
            }
        }
        public List<Distribution> GetDistributionList(DeliveryMen del)
        {
            using (var db = new DALContext())
            {
                List<Distribution> newl = new List<Distribution>();
                foreach (var item in db.DeliveryMenList)
                {if (item.ID==del.ID)
                    { 
                    foreach (var lol in item.DistributionList)
                    {
                        newl.Add(lol);
                    }}
                }
                return newl;
            }
        }
        public DeliveryMen GetDEL(int id)
        {

            using (var db = new DALContext())
            {
                var list = new ObservableCollection<DeliveryMen>(db.DeliveryMenList
                    .Distinct()
                    .Where(m=>m.ID==id)
                    .AsNoTracking());         
                DeliveryMen mymen= list.FirstOrDefault();
                return mymen;
            }
        }
        public void distdone()
        {
            using (var db = new DALContext())
            { foreach (var item in db.DistributionList)
                { if (item.date<DateTime.Now)
                    {if (item.isDone == false)
                        { item.isDone = true;
                           
                        }
                    }
                }
                db.SaveChanges();
            }
        }
     
        public int Combien(int kind, bool flag)
        {
            using (var db = new DALContext())
            { return db.DistributionList.Where(m => m.date.Month == kind).Where(m => m.isDone == flag).Count(); } }
    }
}


