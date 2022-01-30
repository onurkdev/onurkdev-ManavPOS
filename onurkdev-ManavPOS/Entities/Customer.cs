using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onurkdev_ManavPOS.Entities
{
    public class Customer
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int NationalID { get; set; }
        public bool IsDeleted { get; set; }
        public Customer(int ID, string FirstName , string LastName,int NationalID,bool IsDeleted=false )
        {
            this.ID = ID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.NationalID = NationalID;
            this.IsDeleted = IsDeleted;
        }
    }
    
}
