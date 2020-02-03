using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions;
using CrystalDecisions.Shared;

namespace AuditReports
{
    public partial class formAuditPrint : Form
    {
        List<SupplierAuditMaster> suppliers;
        public bool ShowSingle { get; set; }
        public SupplierAuditMaster supplier { get; set; }
        SupplierAuditEntry audit;
        DataTable auditReport;
        public formAuditPrint()
        {
            InitializeComponent();
            if (!ShowSingle)
            {
                suppliers = new List<SupplierAuditMaster>();
                audit = new SupplierAuditEntry();
                suppliers = audit.GetSupplierAuditMasters();
            }
        }

        private void formAuditPrint_Load(object sender, EventArgs e)
        {
            if (!ShowSingle)
            {
                cbSupplier.DataSource = suppliers;
                cbSupplier.DisplayMember = "SupplierName";
                cbSupplier.ValueMember = "id";
            }
            else
            {
                panel1.Visible = false;
                bPrint_Click(sender, e);
            }

        }

        private void bPrint_Click(object sender, EventArgs e)
        {
            GetAUditReport();
            CrystalDecisions.CrystalReports.Engine.ReportDocument report = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
            report.Load("AuditReport.rpt");
            report.SetDataSource(auditReport);
            crv.ReportSource = report;
            crv.Refresh();
        }

        private void GetAUditReport()
        {
            auditReport = new DataTable();
            //audit = new SupplierAuditEntry
            auditReport = audit.GetAuditReport(supplier);

            //throw new NotImplementedException();
        }
    }
}
