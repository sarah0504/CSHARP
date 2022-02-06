using BE;
using BL;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows;
using WpfApplication3.Model;
using WpfApplication3.ViewModel2;
using WpfApplication3.Views;

namespace WpfApplication3.ViewModels
{
    public class addDisViewModel
    {
        public  AddDis myview;
        
        DistributionModel model;
        public bool checkfood;
        public bool checkdrugs;
        public List<Client> clientlistrecupered { get; set; }
         public ReplaceCommand addDisComm { get; set; }
        public ReplaceCommand cancelComm { get; set; }
         public ReplaceCommand selectClientComm { get; set; }
         public ReplaceCommand foodCheckComm { get; set; }
         public ReplaceCommand drugCheckComm { get; set; }
        public addDisViewModel(AddDis addDis, System.Windows.Controls.ContentControl page)
        {
            model = new DistributionModel();
            this.myview = addDis;
            addDisComm = new ReplaceCommand();
            foodCheckComm = new ReplaceCommand();
            drugCheckComm = new ReplaceCommand();
            cancelComm = new ReplaceCommand();
            selectClientComm = new ReplaceCommand();
            addDisComm.ReplaceUserControl += add;
            cancelComm.ReplaceUserControl += cancel;
            selectClientComm.ReplaceUserControl += select;
            foodCheckComm.ReplaceUserControl += foodCheck;
            drugCheckComm.ReplaceUserControl += drugCheck;
        }
 
        public  void select(string obj)
        {
            
           Window1 win = new Window1(this);
            win.ShowDialog();

        }
        private async void add (string obj)
        {
            myview.dis.mykind=whichKind();
            myview.dis.ClientList = clientlistrecupered; //peut etre on fait en foreach et sur chacun on fait assignation 
      //    myview.dis= new Distribution(78, new DateTime(2011, 6, 10), true);
            await model.AddDistribution(myview.dis);
            await model.Assignation(myview.dis, myview.del);
            reset();
        }
        private async void cancel(string obj)
        {
           
            reset();
        }
        private  void foodCheck(string obj)
        {
           if(myview.checkFoodCB.IsChecked==true)
            {
                checkfood = true;
            }
            else
            {
                checkfood = false;
            }

        }
        private void drugCheck(string obj)
        {
            if (myview.checkDrugCB.IsChecked == true)
            {
                checkdrugs = true;
            }
            else
            {
                checkdrugs = false;
            }

        }
        private kindOfNeed whichKind()
        {
            kindOfNeed kind = 0; ;
            if(checkdrugs && checkfood)
            {
                kind = kindOfNeed.Both;
            }
            else if (checkdrugs && !checkfood)
            {
                kind = kindOfNeed.Drugs;
            }
            else if (!checkdrugs && checkfood)
            {
                kind = kindOfNeed.Food;
            }
            return kind;
        }
        internal ObservableCollection<DeliveryMen> GetAllDeliveryMen(Func<DeliveryMen, bool> filter = null)
        {
            return model.GetAllDeliveryMen();
        }
        internal ObservableCollection<Client> GetAllClients(Func<Client, bool> filter = null)
        {
            return model.GetAllClients();
        }
        internal DeliveryMen GetDEL(int v)
        {
            return model.GetDEL(v);
        }
        private void reset()//.Value
        {
            myview.dater.SelectedDate = new DateTime(2020, 09, 01);
            myview.ListDM.SelectedIndex = -1;//Items.Clear();//model.GetAllDeliveryMen().Select(m => m.ID);
            myview.checkDrugCB.IsChecked = false;
            myview.checkFoodCB.IsChecked = false;
            myview.box1.Visibility = Visibility.Hidden;
            myview.box2.Visibility = Visibility.Hidden;
            myview.box3.Visibility = Visibility.Hidden;
            myview.box4.Visibility = Visibility.Hidden;

        }
    }
   
}
