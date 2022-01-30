using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onurkdev_ManavPOS.Entities
{
    public class Supplier
    {
        public int ID { get; set; }
        public string CompanyName { get; set; }

        public string CompanyLocation { get; set; }
        public bool IsDeleted { get; set; }

        public Supplier(int SupplierID, string CompanyName, string CompanyLocation)
        {
            this.ID = SupplierID;
            this.CompanyName = CompanyName;
            this.CompanyLocation = CompanyLocation;
        }

    }

}
