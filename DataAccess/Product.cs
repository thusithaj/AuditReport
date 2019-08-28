using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Product
    {
        public int PK { get; set; }
        public int CatID { get; set; }
        public string ProductName { get; set; }
        public int CompanyID { get; set; }
        public double SellingPrice { get; set; }
        public double ReOrderLevel { get; set; }
        public double ReOrderQty { get; set; }
        public int Installments { get; set; }
        public double Transport { get; set; }
        public virtual double StockBalance { get; set; }
    }
}
