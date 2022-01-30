using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace onurkdev_ManavPOS.Entities
{
    public class Bill
    {
        public int ID { get; set; }
        public int? CustomerID { get; set; }
        public string CustomerName { get; set; }
        public decimal? GrandTotal { get; set; } //database e trigger sumofbill eklenecek
        public List<BillDetail> Products { get; set; }
        public bool IsDeleted { get; set; }
        public Bill(int ID, string CustomerName, List<BillDetail> Products, int CustomerID=1, decimal GrandTotal=0) // CustomerID=1 isimsiz satış Anonymous Sale 
        {
            this.ID = ID;
            this.CustomerID = CustomerID;
            
            this.CustomerName= CustomerName;
            this.Products = Products;
            this.GrandTotal = CalculateGrandTotal(Products);

        }
        private decimal? CalculateGrandTotal(List<BillDetail> products)
        {   
            decimal? total = 0;  
            foreach (BillDetail item in products)
            {
                total += item.Subtotal;
            }
            return total;
        }


    }
}
