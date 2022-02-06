using ConsoleApplication1;
using Microsoft.Maps.MapControl.WPF;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public enum kindOfNeed { Food, Drugs, Both }
    public  class Client
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        public string name { get; set; }
        public string mail { get; set; }
        public string telephone { get; set; }
        public Address address { get; set; }
        public Location location { get; set; }
        public Boolean Check_Status { get; set; }

        public Client(string name, string mail, string telephone, Address address2,int ID2,kindOfNeed mykind1)
        {
            this.ID = ID2;
            this.name = name;
            this.mail = mail;
            this.telephone = telephone;
            address = address2;
            this.location = new Location();
           this.Check_Status = false;
           

        }
        public Client()
        {

            this.ID = 0;
            this.name = "default";
            this.mail = "default";
            this.telephone = "default";
            address = new Address();
            this.location = new Location();
           this.Check_Status = false;
        }
        public override string ToString()
        {

            string s = address+ "\n";
            return s;

        }

    }
}
 