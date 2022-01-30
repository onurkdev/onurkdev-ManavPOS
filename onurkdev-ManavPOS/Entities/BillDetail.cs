using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace onurkdev_ManavPOS.Entities
{
    public class BillDetail
    {
        public int ID { get; set; }
        public int? BillID { get; set; }
        public int? CustomerID{ get; set; }
        
        public int? ProductID { get; set; }
        public decimal? Price { get; set; }
        public string ProductName { get; set; }
        public string UnitOfMeasure { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Subtotal { get; set; }
        

        public BillDetail(int ID , int BillID, int ProductID , decimal Amount , decimal Subtotal, string UnitOfMeasure, decimal Price, int CustomerID=0)
        {
            this.ID = ID;
            this.BillID = BillID;
            this.ProductID = ProductID;
           
            this.Amount = Amount;
            this.Subtotal = Price*Amount;
            this.UnitOfMeasure = UnitOfMeasure;
            this.CustomerID = CustomerID;
            this.ProductName = GetProductName(ProductID);
            
        }
        public ListViewItem CreateTile()
        {
            ListViewItem item = new ListViewItem(new string[]
            {this.BillID.ToString(),
            this.ProductName,
            this.UnitOfMeasure,
            this.Amount.ToString(),
            this.Subtotal.ToString()}, 3);//Imagellist1 kullanılacak
            return item;
        }
        private string GetProductName(int ID)
        {
            return ""; // ID den Customer Name getirecek
        }
        public void CreateBillDetail(int BillID)
        {
            // bill ID alıp Create Bill Detail yapacak
        }
    }
}
