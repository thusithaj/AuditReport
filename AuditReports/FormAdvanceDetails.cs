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

        StockController stock;

        DataTable UnitCost;
        List<string> accounts;
        string strMonth;

        public FormAdvanceDetails()
        {
            InitializeComponent();
        }

        private void FormAdvanceDetails_Load(object sender, EventArgs e)
        {
            LoadAdvanceDetails();
        }
        private void LoadAdvanceDetails()
        {
            stock = new StockController();
            if ( SupplierNo == 0 || DebitAcc.Trim().Length == 0 || Advance == 0)
            {
                MessageBox.Show(" No supplier selected for the display", "No Suppliet", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            UnitCost = new DataTable();
            UnitCost = stock.GetAdvanceDetail(SupplierNo, DebitAcc);
            ShowSupplierHead();
            ShowTimePeriod();
            dgvAdvDetail.DataSource = UnitCost;
        }

        private void ShowTimePeriod()
        {
            string strtime = DebitAcc.Substring((DebitAcc.IndexOf('_')) , (DebitAcc.Length - DebitAcc.IndexOf('_') ));
            string stryear = strtime.Substring(strtime.IndexOf(' ') + 1);
            string strmonth = strtime.Substring(1, strtime.IndexOf(' '));
            DateTime fromDate;//= new DateTime(int.Parse(stryear),1,1);
            int month = 0, year = int.Parse(stryear);
            switch (strmonth.Trim())
            {
                case "JANUARY":
                    month = 1;
                    break;
                case "FEBRUARY":
                    month = 2;
                    break;
                case "MARCH":
                    month = 3;
                    break;
                case "APRIL":
                    month = 4;
                    break;
                case "MAY":
                    month = 5;
                    break;
                case "JUNE":
                    month = 6;
                    break;
                case "JULY":
                    month = 7;
                    break;
                case "AUGUST":
                    month = 8;
                    break;
                case "SEPTEMBER":
                    month = 9;
                    break;
                case "OCTOBER":
                    month = 10;
                    break;
                case "NOVEMBER":
                    month = 11;
                    break;
                case "DECEMBER":
                    month = 12;
                    break;

            }
            fromDate = new DateTime(int.Parse(stryear), month, 1);
            dtFrom.Value = fromDate;
            dtTo.Value = fromDate.AddMonths(1).AddDays(-1);
            
            //throw new NotImplementedException();
        }

        private void ShowSupplierHead()
        {
            DataRow dr = UnitCost.Rows[0];
            tbSupNo.Text = SupplierNo.ToString();

            tbAddress.Text = dr["Address"].ToString();
            tbName.Text = dr["regName"].ToString();
            tbRoute.Text = dr["routeName"].ToString();
            tbTPNo1.Text = dr["TpNo"].ToString();
            tbTpNo2.Text= dr["Phone1"].ToString();
            nTotalAdvance.Value = Advance;
            tbPayMode.Text= dr["PayMode"].ToString();
            //throw new NotImplementedException();
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
            //this.Dispose();
        }

        private void bPrint_Click(object sender, EventArgs e)
        {
            accounts = new List<string>();
            DateTime temp;
            temp = dtFrom.Value;
            for ( int m = dtFrom.Value.Month; m<= dtTo.Value.Month;m++)
            {
                
                string acc = "B/L ADVANCE_" + string.Format("{0:MMMM}", temp).ToUpper() + " " + temp.Year.ToString().Trim();
                accounts.Add(acc);
                temp = temp.AddMonths(1);
            }

            if (stock == null)
                stock = new StockController();
            UnitCost = stock.GetAdvanceDetail(SupplierNo, accounts);

            dgvAdvDetail.DataSource = UnitCost;
            dgvAdvDetail.Refresh();

        }

        private void dtFrom_ValueChanged(object sender, EventArgs e)
        {
            strMonth = String.Format("{0:MMM}", dtFrom.Value);
        }

        private void dgvAdvDetail_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormAddAudit form = new FormAddAudit();
            SupplierAuditMaster supplier = new SupplierAuditMaster();
            supplier.SupplierNo = int.Parse(tbSupNo.Text);
            supplier.SupplierAddress = tbAddress.Text;
            supplier.SupplierName = tbName.Text;
            supplier.SupplierStatus = 1;
            supplier.SupplierTP01 = tbTPNo1.Text;
            supplier.SupplierTP02 = tbTpNo2.Text;
            supplier.PayMode = tbPayMode.Text;
            supplier.RouteName = tbRoute.Text;
            SupplierAudit audit = new SupplierAudit();
            audit.Amount = float.Parse(dgvAdvDetail.Rows[e.RowIndex].Cells["Advance"].Value.ToString()); //Trn.Date
            audit.TrnDate = DateTime.Parse(dgvAdvDetail.Rows[e.RowIndex].Cells["Trn.Date"].Value.ToString());
            audit.TrnNumber = dgvAdvDetail.Rows[e.RowIndex].Cells["VoucherNo"].Value.ToString();
            form.selSupplier = supplier;
            form.audit = audit;
            form.Owner = this;
            
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
        }
    }
}
