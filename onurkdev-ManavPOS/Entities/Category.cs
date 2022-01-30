using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onurkdev_ManavPOS.Entities
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public int? CategoryImageID { get; set; }
        public bool IsDeleted { get; set; }

        public Category(int CategoryID, string CategoryName, int CategoryImageID=0)
        {
            this.CategoryID = CategoryID;
            this.CategoryName = CategoryName;
            this.CategoryImageID = CategoryImageID;

        }
    }
}
