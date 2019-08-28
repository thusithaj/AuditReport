using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class AddDedTransaction
    {
        public int id { get; set; }
        public DateTime TransactionDate { get; set; }
        public int SupplierCode { get; set; }
        public string RateCode { get; set; }
        public string Unit { get; set; }
        public double Quantity { get; set; }
        public double Rate { get; set; }
        public double Amount { get; set; }
        public string Sign { get; set; }
        public int EnteredUserId { get; set; }
        public DateTime EnteredDate { get; set; }
        public string Status { get; set; }

    }
}
