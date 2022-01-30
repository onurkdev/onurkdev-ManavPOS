using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace onurkdev_ManavPOS.Entities
{
    public class Product
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public int? CategoryID { get; set; }
        public string CategoryName { get; set; }
        public decimal Price { get; set; }
        public string UnitOfMeasure { get; set; }
        public int? UnitsInStock { get; set; }
        public int? ImageID { get; set; }
        public bool IsDeleted { get; set; }
        public int? SupplierID { get; set; }
        public string SupplierName { get; set; }
        public int? UnitOfMeasureID { get; set; }



        public Product(int ID, string ProductName, int CategoryID, decimal Price,string CategoryName,int SupplierID,string SupplierName, int ImageID =0,int UnitsInStock=0, string UnitOfMeasure="Kg",int UnitOfMeasureID=1,bool IsDeleted=false )
        {
            this.ID = ID;
            this.ProductName = ProductName;
            this.CategoryID = CategoryID;
            this.CategoryName = CategoryName;
            this.Price = Price;
            this.ImageID = ImageID;
            this.UnitOfMeasure=UnitOfMeasure;
            this.UnitsInStock = UnitsInStock;
            this.SupplierID = SupplierID;
            this.SupplierName = SupplierName;
            this.UnitOfMeasureID = UnitOfMeasureID;
            this.IsDeleted = IsDeleted;

        }

        public ListViewItem CreateTile()
        {
            ListViewItem item = new ListViewItem(new string[]
            {this.ProductName,
            this.UnitOfMeasure,
            this.Price.ToString()}, Convert.ToInt32(this.ImageID));
            return item;
        }

        private string GetCategory(int ID)
        {
            return "";// category id den category name gelecek 
        }


    }
}
