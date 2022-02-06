using BE;
using BL;
using ConsoleApplication1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApplication3.ViewModels;

namespace WpfApplication3.Model
{
    public class KmeansModel 
    { 
  private KmeansViewModel KmeansVM;
    BLimp blimp { get; set; }


    public KmeansModel(KmeansViewModel kmeansVM)
    {
        this.KmeansVM = kmeansVM;
        blimp = new BLimp();
    }

    public DeliveryMen getDman(int index)
    {
        List<DeliveryMen> mylist = blimp.GetAllDeliveryMen().ToList();
        return mylist.ElementAt(index);

    }



    internal List<Address> getAddressFromDis(Distribution dis)
    {
        return blimp.getAddressFromDis(dis);
    }

    internal async Task<Client[][]> KMeans(bool food, bool drug)
    {

        return await blimp.KMeans(food, drug);

    }



    public async Task<object> SearchAddress(String myaddress)
    {
        Object o = new object();

        return await blimp.SearchLocation(myaddress, o);


    }
}
}
