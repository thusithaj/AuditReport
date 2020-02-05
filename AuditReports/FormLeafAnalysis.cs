using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using CrystalDecisions;
using CrystalDecisions.Shared;

namespace AuditReports
{
    public partial class FormLeafAnalysis : Form
    {
        DataTable yrs;
        DataTable mnths;
        private int AnalysisYear { get; set;}
        private int AnalysisMonth { get; set; }
        private string strYears;
        SupplierAuditEntry audit;
        DataTable auditReport;
        public FormLeafAnalysis()
        {
            InitializeComponent();
        }

        private void FormLeafAnalysis_Load(object sender, EventArgs e)
        {
            SetYearData();
            SetMonthData();
        }

        private void SetMonthData()
        {
            mnths = new DataTable();
            mnths.Columns.Add(new DataColumn("id", typeof(int)));
            mnths.Columns.Add(new DataColumn("Month", typeof(string)));
            DateTime dt = new DateTime(2000, 1, 1);
            for (int i = 1; i <= 12; i++)
            {
                
                mnths.Rows.Add(mnths.NewRow());
                mnths.Rows[mnths.Rows.Count - 1]["id"] = i;
                mnths.Rows[mnths.Rows.Count - 1]["Month"] = dt.ToString("MMMM");
                dt = dt.AddMonths(1);
            }
            cboAnalysisMnth.DataSource = mnths;
            cboAnalysisMnth.DisplayMember = "Month";
            cboAnalysisMnth.ValueMember = "id";
            // throw new NotImplementedException();
        }

        private void SetYearData()
        {
            yrs = new DataTable();
            yrs.Columns.Add(new DataColumn("id", typeof(int)));
            yrs.Columns.Add(new DataColumn("Analysis", typeof(string)));
            yrs.Rows.Add(yrs.NewRow());
            yrs.Rows[yrs.Rows.Count - 1]["id"] = 1;
            yrs.Rows[yrs.Rows.Count - 1]["Analysis"] = "Backward for 5 Years";
            yrs.Rows.Add(yrs.NewRow());
            yrs.Rows[yrs.Rows.Count - 1]["id"] = 2;
            yrs.Rows[yrs.Rows.Count - 1]["Analysis"] = "Backward for 4 Years";
            yrs.Rows.Add(yrs.NewRow());
            yrs.Rows[yrs.Rows.Count - 1]["id"] = 3;
            yrs.Rows[yrs.Rows.Count - 1]["Analysis"] = "Backward for 3 Years";
            yrs.Rows.Add(yrs.NewRow());
            yrs.Rows[yrs.Rows.Count - 1]["id"] = 4;
            yrs.Rows[yrs.Rows.Count - 1]["Analysis"] = "Backward for 2 Years";
            cboAnalysisYr.DataSource = yrs;
            cboAnalysisYr.DisplayMember = "Analysis";
            cboAnalysisYr.ValueMember = "id";
            //throw new NotImplementedException();
        }

        private void cboAnalysisYr_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ( cboAnalysisYr.SelectedItem != null)
            {
                DataRowView dvr = (DataRowView) cboAnalysisYr.SelectedItem;
                AnalysisYear = int.Parse(dvr[0].ToString());
                SetYears();
            }
        }

        private void SetYears()
        {
            DateTime dt = new DateTime();
            dt = DateTime.Now.AddYears(-1);
            strYears = "";
            switch(AnalysisYear)
            {
                case 1:
                    for (int i = 1; i<= 5; i++)
                    {
                        strYears = strYears + dt.Year.ToString() + ",";
                        dt = dt.AddYears(-1);
                    }
                    break;
                case 2:
                    for (int i = 1; i <= 4; i++)
                    {
                        strYears = strYears + dt.Year.ToString() + ",";
                        dt = dt.AddYears(-1);
                    }
                    break;
                case 3:
                    for (int i = 1; i <= 3; i++)
                    {
                        strYears = strYears + dt.Year.ToString() + ",";
                        dt = dt.AddYears(-1);
                    }
                    break;
                case 4:
                    for (int i = 1; i <= 2; i++)
                    {
                        strYears = strYears + dt.Year.ToString() + ",";
                        dt = dt.AddYears(-1);
                    }
                    break;
            }
            strYears = strYears.Substring(0, strYears.Length - 1);
            //throw new NotImplementedException();
        }

        private void cboAnalysisMnth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboAnalysisMnth.SelectedItem != null)
            {
                DataRowView dvr = (DataRowView)cboAnalysisMnth.SelectedItem;
                AnalysisMonth = int.Parse(dvr[0].ToString());
            }
        }

        private void bPreview_Click(object sender, EventArgs e)
        {
            GetAUditReport();
            CrystalDecisions.CrystalReports.Engine.ReportDocument report = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
            report.Load("LeafAnalysis2.rpt");
            report.SetDataSource(auditReport);
            crv.ReportSource = report;
            crv.Refresh();
        }
        private void GetAUditReport()
        {
            auditReport = new DataTable();
            audit = new SupplierAuditEntry();
            auditReport = audit.GetLeafAnalysis(strYears,AnalysisMonth);

            audit = null;
            //throw new NotImplementedException();
        }
    }
}
