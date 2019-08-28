using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess
{
    public class StockItem
    {
        public int Ind { get; set; }
        public string StockID { get; set; }
        public DateTime StockDate { get; set; }
        public int CostID { get; set; }
        public string StockType { get; set; }
        public int ProductID { get; set; }
        public double Cost { get; set; }
        public double Price { get; set; }
        public double Dr { get; set; }
        public double Cr { get; set; }
        public string AcCode { get; set; }
        public int ExpCode { get; set; }
        public int GatePass { get; set; }
        public string GatePassName { get; set; }
        public int BLregNo { get; set; }

    }
}
