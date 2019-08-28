using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class BlgAdvance
    {
        public BlgAdvance()
        {
            advanceMaster = new AdvanceMaster();
            transactionMaster = new HashSet<LedgerTrnMaster>();
        }
        public AdvanceMaster advanceMaster { get; set; }
        public ICollection<LedgerTrnMaster> transactionMaster { get; set; }
    }
}
