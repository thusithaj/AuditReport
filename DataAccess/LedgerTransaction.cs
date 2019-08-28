using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class LedgerTransaction
    {
        public int ind { get; set; }
        public DateTime trDate { get; set; }
        public int trNo { get; set; }
        public string trCode { get; set; }
        public string trCdeNo { get; set; }
        public string AcCode { get; set; }
        public double Debit { get; set; }
        public double Credit { get; set; }
        public string trMode { get; set; }
        public DateTime sTime { get; set; }
        public string ItemType { get; set; }
        public string ItemName { get; set; }
        public string ItemCode { get; set; }
        public double qtIn { get; set; }
        public double qtOut { get; set; }
        public double Rate { get; set; }
        public int ExpCode { get; set; }
        public int CopCode { get; set; }
        public double LabourCR { get; set; }
        public double LabourCW { get; set; }
        public string InvNo { get; set; }
        public int TxVal { get; set; }
        public string CostID { get; set; }
        public string ExpSubCode { get; set; }
        public int CopMainCode { get; set; }
        public int ZynkeD { get; set; }

    }
}
