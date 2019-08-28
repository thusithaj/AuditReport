using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess
{
    public class ItemMaster
    {
        public int PK { get; set; }
        public int CatID { get; set; }
        public string ProductName { get; set; }
        public int CompanyID { get; set; }
        public double SellingPrice { get; set; }
        public double ReOrderLevel { get; set; }
        public double ReOrderQty { get; set; }
        public DateTime Installments { get; set; }
        public double Transport { get; set; }
        public double BalanceStock { get; set; }
    }
}
