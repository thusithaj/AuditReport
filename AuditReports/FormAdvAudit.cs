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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;

namespace AuditReports
{
    public partial class FormAdvAudit : Form
    {
        AdvController advController;
        StockController stock;
        DataTable reportTable;
        DataTable reportDataSource;
        List<Route> routeTable;
        List<Supplier> supplierTable;
        string reportFileName;
        string selectedRoute = "";
        int selectedSupplier = 0;
        public FormAdvAudit()
        {
            InitializeComponent();
        }

        private void FormAdvAudit_Load(object sender, EventArgs e)
        {
            advController = new AdvController();
            ShowReports();
            LoadRoutes();
            LoadSuppliers();
        }

        private void LoadSuppliers()
        {
            supplierTable = new List<Supplier>();
            if (stock == null)
                stock = new StockController();
            Supplier allSupp = new Supplier();
            allSupp.regName = "All";
            allSupp.regNo = 0;
            supplierTable.Add(allSupp);
            foreach( Supplier s in stock.GetSuppliers(0).ToList())
            {
                supplierTable.Add(s);
            }
            cbSupplier.DataSource = supplierTable;
            cbSupplier.DisplayMember = "RegName";
            cbSupplier.ValueMember = "RegNo";
            //throw new NotImplementedException();
        }

        private void LoadRoutes()
        {
            routeTable = new List<Route>();
            stock = new StockController();
            Route allReoute = new Route();
            allReoute.rName = "All";
            routeTable.Add(allReoute);
            foreach (Route r in stock.GetRoutes().ToList())
            {
                routeTable.Add(r);
            }
            cbRoute.DataSource = routeTable;
            cbRoute.DisplayMember = "rName";
            cbRoute.ValueMember = "rName";
            //throw new NotImplementedException();
        }

        private void ShowReports()
        {
            reportTable = new DataTable();
            reportTable.Columns.Add(new DataColumn("ReportName", typeof(string)));
            reportTable.Rows.Add(reportTable.NewRow());
            reportTable.Rows[reportTable.Rows.Count - 1]["ReportName"] = "AdvanceAuditDetail.rpt";
            reportTable.Rows.Add(reportTable.NewRow());
            reportTable.Rows[reportTable.Rows.Count - 1]["ReportName"] = "AdvanceAuditSummary.rpt";
            cbReports.DataSource = reportTable;
            cbReports.DisplayMember = "ReportName";
            cbReports.ValueMember = "ReportName";
            //throw new NotImplementedException();
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void PrintReport()
        {
            ReportDocument report = new ReportDocument();
            report.FileName = Application.StartupPath + "\\" + reportFileName;
            switch (reportFileName)
            {
                case "AdvanceAuditDetail.rpt":
                    {
                        reportDataSource = new DataTable();
                        reportDataSource = advController.GetAdvances("TR", dtFrom.Value, 
                            dtTo.Value, selectedRoute, selectedSupplier);
                        break;
                    }
                case "AdvanceAuditSummary.rpt":
                    {
                        reportDataSource = new DataTable();
                        reportDataSource = advController.GetAdvances("TR", dtFrom.Value,
                            dtTo.Value, selectedRoute, selectedSupplier);
                        break;
                    }
            }
            report.SetDataSource(reportDataSource);
            crv.ReportSource = report;
            crv.Refresh();
        }

        private void bPrint_Click(object sender, EventArgs e)
        {
            PrintReport();
        }

        private void cbReports_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView dv = (DataRowView) cbReports.SelectedItem;
            reportFileName = dv["ReportName"].ToString();
        }

        private void cbRoute_SelectedIndexChanged(object sender, EventArgs e)
        {
            Route route = (Route)cbRoute.SelectedItem;
            selectedRoute = route.rName;
        }

        private void cbSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            Supplier supplier = (Supplier)cbSupplier.SelectedItem;
            selectedSupplier = supplier.regNo;
        }
    }
}
