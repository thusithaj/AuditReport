using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class GeneralIssue
    {
        public string IssueID { get; set; }
        public DateTime IssueDate { get; set; }
        public int AccID { get; set; }
        public double Amount { get; set; }
        public int RegNo { get; set; }
        public string RegName { get; set; }
        public string RegRoute { get; set; }
        public double DIscountAmt { get; set; }
        public double DeductionAmt { get; set; }
        public string IssueType { get; set; }
        public int GatePass { get; set; }
        public string GatePassName { get; set; }
        public string VehicleNo { get; set; }
        public int CatFK { get; set; }


    }
}
