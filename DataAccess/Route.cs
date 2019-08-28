using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Route
    {
        public int ind { get; set; }
        public int RouteID { get; set; }
        public string rCode { get; set; }
        public string rName { get; set; }
        public double trRate { get; set; }
        public double blRate { get; set; }
        public int trActive { get; set; }
        public double newBlRate { get; set; }
        public double Incentive { get; set; }
        public double blRateSL { get; set; }
        public double newBlRateSL { get; set; }
        public double Target { get; set; }
        public double ExtraRate { get; set; }
        public int AreaID { get; set; }


    }
}
