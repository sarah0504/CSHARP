using ConsoleApplication1;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BE
{
  public class Distribution
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        public DateTime date { get; set; }
        public bool isDone { get; set; }
         public kindOfNeed mykind { get; set; }
        private ICollection<Client> clientList;



        public virtual ICollection<Client> ClientList
        {
            get { return clientList; }
            set { clientList = value; }
        }

        public Distribution(int id, DateTime date, bool isDone, List<Client> clientList)
        {

            this.ID = id;
            this.date = date;
            this.isDone = isDone;
            this.clientList = clientList;
            this.mykind = 0;
        }
        public Distribution()
        {
            this.ID = 2;
            this.clientList = new List<Client>() { };
            this.date = new DateTime();
            this.mykind = 0;
        }

        public Distribution(int v1, DateTime dateTime, bool v2)
        {
            this.ID = v1;
            this.clientList = new List<Client>() { };
            this.isDone = v2;
            this.date = dateTime;
            this.mykind = 0;

        }
        public Distribution( int v2)
        {
            this.ID = v2;
            this.clientList = new List<Client>() { };
            this.isDone =false;
            this.date = new DateTime();
            this.mykind = 0;
        }
        public Distribution(int v2 ,bool flag)
        {
            this.ID = v2;
            this.clientList = new List<Client>() { };
            this.isDone = flag;
         
        }
    }
}
