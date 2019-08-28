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
    public partial class FormInquiry : Form
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
        Route selRoute;
        string rtFilter;
        public FormInquiry()
        {
            InitializeComponent();
        }

        private void FormInquiry_Load(object sender, EventArgs e)
        {
            LoadRoutes();
        }
        /// <summary>
        /// Load suppliers
        /// </summary>
        private void LoadSuppliers()
        {
            supplierTable = new List<Supplier>();
            if (stock == null)
                stock = new StockController();
            Supplier allSupp = new Supplier();
            allSupp.regName = "All";
            allSupp.regNo = 0;
            supplierTable.Add(allSupp);
            foreach (Supplier s in stock.GetSuppliers(0).ToList())
            {
                supplierTable.Add(s);
            }
            cbSupplier.DataSource = supplierTable;
            cbSupplier.DisplayMember = "RegName";
            cbSupplier.ValueMember = "RegNo";
            //throw new NotImplementedException();
        }
        /// <summary>
        /// Load routes 
        /// </summary>
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

        private void GetAdvanceAudit()
        {

        }

        private void cbRoute_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRoute.SelectedItem != null)
            {
                selRoute = new Route();
                selRoute = (Route) cbRoute.SelectedItem;
            }
        }

        private void bPrint_Click(object sender, EventArgs e)
        {
            if (selRoute.rName == "All")
            {
                rtFilter = "%";
            }
            else
            {
                rtFilter = selRoute.rName.Trim() + '%';
            }
            ShowAdvanceSUmmary();

        }

        private void ShowAdvanceSUmmary()
        {
            //throw new NotImplementedException();
            if (stock == null)
                stock = new StockController();
            dgvAdvSumm.DataSource = stock.GetAdvanceSummary(rtFilter, 0, (int)nCycle.Value);
        }
    }
}
