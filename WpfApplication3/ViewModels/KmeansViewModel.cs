using BE;
using ConsoleApplication1;
using Microsoft.Maps.MapControl.WPF;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using WpfApplication3.Model;
using WpfApplication3.Views;

namespace WpfApplication3.ViewModels
{
   public class KmeansViewModel : INotifyPropertyChanged
    {
        public Window1 myview;
        public ReplaceCommand MyReplaceUCCommand { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        public KmeansModel CurrentModel { get; set; }
        public KmeansView myUC { get; set; }
        public String MyName;
        public String DisNB;
        public bool food;
        public bool drug;
        Client[][] mylistaddress;
        List<Address> ad = new List<Address>();
        List<Client> listclient = new List<Client>();
        public int Index = 0;
        List<string> longlat;


        public KmeansViewModel(KmeansView kmeansUC)
        {
            myUC = kmeansUC;
            MyReplaceUCCommand = new ReplaceCommand();
            MyReplaceUCCommand.ReplaceUserControl += Fourbutton;
            CurrentModel = new KmeansModel(this);
            food = false;
            drug = false;
            myUC.prev.IsEnabled = false;
            myUC.next.IsEnabled = false;
            myUC.ok.IsEnabled = false;
            // KMeans();
          


        }

        [HandleProcessCorruptedStateExceptions]

        public async void KMeans()
        {
            myUC.progress.IsIndeterminate = true;
            
            MessageBox.Show("Configuring Distribution", "Configuration", MessageBoxButton.OK, MessageBoxImage.Information);


            mylistaddress = await CurrentModel.KMeans(food, drug);

            Index = 0;
            HelpDisplayMap(Index);

            if (mylistaddress != null)
            {
                myUC.next.IsEnabled = true;
                myUC.prev.IsEnabled = false;
                myUC.ok.IsEnabled = true;
                DisNB = (Index + 1).ToString();
                myUC.disnb.Text = DisNB;

                GetName();
            }
            else
            {
                myUC.next.IsEnabled = true;
                myUC.prev.IsEnabled = false;
                myUC.ok.IsEnabled = true;
                MyName = string.Empty;
                DisNB = string.Empty;
            }


            myUC.progress.IsIndeterminate = false;

        }

        public async void HelpDisplayMap(int index)
        {
            myUC.map.Children.Clear();
            ad = new List<Address>();

            if (mylistaddress != null)
            {
                int i = 0;
                foreach (Client client in mylistaddress[index])
                {
                    
                    if (client!=null && client.address != null)
                    {
                        MessageBox.Show("New Address : " + client.address.street + " " + client.address.city);
                        ad.Add(client.address);
                        listclient.Add(client);
                        Boolean flag = false;
                        while (!flag)
                        {
                            try
                            {
                                //    MessageBox.Show("while");
                                string streetname = client.address.street+" " + client.address.city;
                                //if (streetname.Contains("TelAviv"))
                                //    streetname = streetname.Replace("TelAviv", "Tel Aviv");

                                var x = await CurrentModel.SearchAddress(streetname);
                                var jo1 = JArray.Parse(x.ToString());


                                longlat = new List<string>();
                                longlat.Add(jo1[0]["lon"].ToString());
                                longlat.Add(jo1[0]["lat"].ToString());

                                flag = true;
                            }
                            catch (Exception e)
                            {
                                continue;
                            }
                        }
                        i++;
                        
                       Pushpin pinbis = new Pushpin { Location = client.location, Background = new SolidColorBrush(Colors.Yellow) };

                        
                        
                      
                        myUC.map.Children.Add(pinbis);

                    }
                }
                myUC.listado.ItemsSource = ad;
            }
       
            
            MessageBox.Show("Distribution automatic successfuly done", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

        }




        public void GetName()
        {
            DeliveryMen myman = CurrentModel.getDman(Index);
            MyName = myman.name ;
            myUC.dmanFname.Text = MyName;
        }


        public void Fourbutton(string obj)
        {
            switch (obj)
            {
                case "Prev.":
                    {
                        listclient = new List<Client>();
                        ad = new List<Address>();
                        myUC.next.IsEnabled = true;
                        Index -= 1;
                        DisNB = (Index + 1).ToString();
                        myUC.disnb.Text = DisNB;
                        GetName();
                        if (Index == 0)
                            myUC.prev.IsEnabled = false;
                        HelpDisplayMap(Index);
                        break;
                    }
                case "Next":
                    {
                        listclient = new List<Client>();
                        ad = new List<Address>();

                        myUC.prev.IsEnabled = true;
                        Index += 1;
                        DisNB = (Index + 1).ToString();
                        myUC.disnb.Text = DisNB;

                        GetName();
                        if (Index == mylistaddress.Length - 1)
                            myUC.next.IsEnabled = false;
                        HelpDisplayMap(Index);
                        break;
                    }
                case "OK":
                    {
                        //do something
                        MessageBox.Show("Distributions successfuly added", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                        myUC.addDisViewModel.clientlistrecupered= listclient;
                        myUC.addDisViewModel.myview.box1.Visibility = Visibility.Visible;
                        myUC.addDisViewModel.myview.box2.Visibility = Visibility.Visible;
                        myUC.addDisViewModel.myview.box4.Text = "" + listclient.Count;

                        myUC.addDisViewModel.myview.box3.Visibility = Visibility.Visible;
                        //((MainWindow)System.Windows.Application.Current.MainWindow).mainGrid.Children.Clear();
                        //((MainWindow)System.Windows.Application.Current.MainWindow).mainGrid.Children.Add(new AddDis(myUC.addDisViewModel));
                        myUC.win.Close();
                        break;
                    }
                case "Cancel":
                    {
                        myUC.win.Close();//.Children.Clear();
                        //((MainWindow)System.Windows.Application.Current.MainWindow).mainGrid.Children.Add(new MenuV());
                        break;
                    }
            }
        }


    }
}
