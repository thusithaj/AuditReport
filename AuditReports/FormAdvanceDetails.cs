using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;

namespace AuditReports
{
    public partial class FormAdvanceDetails : Form
    {
        public int SupplierNo { get; set; }
        public string DebitAcc { get; set; }
        public decimal Advance { get; set; }

        DataTable UnitCost;

        public FormAdvanceDetails()
        {
            InitializeComponent();
        }

        private void FormAdvanceDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
