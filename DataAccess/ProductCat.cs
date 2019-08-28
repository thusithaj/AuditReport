using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ProductCat
    {
        public ProductCat()
        {
            products = new HashSet<Product>();
        }
        public int CatID { get; set; }
        public string CatName { get; set; }
        public int LastCode { get; set; }
        public string AccNo { get; set; }
        public string AccName { get; set; }
        public ICollection<Product> products;
    }
}
