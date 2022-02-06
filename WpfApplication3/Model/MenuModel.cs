using BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication3.Model
{
    class MenuModel
    {
        BLimp blimp { get; set; }

        public MenuModel()
        {
            this.blimp = new BLimp();
        }

        
    }
}
