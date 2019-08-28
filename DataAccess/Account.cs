using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Account
    {
        public int id { get; set; }
        public string AccountCode { get; set; }
        public string AccountName { get; set; }
        public decimal CurrentBalance { get; set; }
        public decimal DebitBalance { get; set; }
        public decimal CreditBalance { get; set; }
    }
}
