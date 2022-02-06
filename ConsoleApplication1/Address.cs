using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Address
    {
        public string street { get; set; }
        public string city { get; set; }
        public Boolean Check_Status { get; set; }
        public Address(string street, string city)
        {
            this.street = street;
            this.city = city;
            this.Check_Status = false;
        }

        public Address()
        {
            this.street = "default";
            this.city = "default";
            this.Check_Status = false;

        }
        public override string ToString()
        {

            string s = street + " " +

            city + "\n";
            return s;

        }
    }
}
