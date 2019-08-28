using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class LedgerTrnMaster
    {
        public LedgerTrnMaster()
        {
            ledgerTransactions = new HashSet<LedgerTransaction>();
        }
        public int ind { get; set; }
        public string TrID { get; set; }
        public string trType { get; set; }
        public DateTime trDate { get; set; }
        public string Description { get; set; }
        public string PayeName { get; set; }
        public string ChequeNo { get; set; }
        public DateTime PresentDate { get; set; }
        public string CreditAcc { get; set; }
        public string DebitAcc { get; set; }
        public double Amount { get; set; }
        public string FormName { get; set; }
        public int RegNo { get; set; }
        public string CrMonth { get; set; }
        public string Route { get; set; }
        public string myModule { get; set; }
        public string UserLog { get; set; }
        public string ListID { get; set; }
        public ICollection<LedgerTransaction> ledgerTransactions;

    }
}
