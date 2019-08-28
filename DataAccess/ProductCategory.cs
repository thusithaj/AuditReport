using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess
{
    public class ProductCategory
    {
        public int CatID { get; set; }
        public string CatName { get; set; }
        public int LastCode { get; set; }
        public string AccNo { get; set; }
        public string AccName { get; set; }
        public ICollection<ItemMaster> items;
        public ProductCategory()
        {

            items = new HashSet<ItemMaster>();
        }
    }
}
