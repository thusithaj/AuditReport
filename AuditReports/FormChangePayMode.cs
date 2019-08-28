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
    public partial class FormChangePayMode : Form
    {
        DBAccess dB;
        string sql;
        string route;
        string paymode;
        string paym2;
        bool formLoading= true;
        public FormChangePayMode()
        {
            InitializeComponent();
            dB = new DBAccess();
        }

        private void FormChangePayMode_Load(object sender, EventArgs e)
        {
            LoadRoutes();
            ShowPayMode();
            //LoadBalancePayments();
            this.WindowState = FormWindowState.Maximized;
            bApply.Enabled = false;
            formLoading = false;

        }

        private void ShowPayMode()
        {
            DataTable dtpay = new DataTable();
            sql = "Select distinct PayMode from Main_Reg where Paymode in ('Cash','Cheque')";
            dtpay = dB.GetDataTable(sql, 0);
            cbPayMode.DataSource = dtpay;
            cbPayMode.DisplayMember = "PayMode";
            cbPayMode.ValueMember = "PayMode";

            DataTable dtpay2 = new DataTable();
            dtpay2 = dtpay.Copy();
            cbPayM2.DataSource = dtpay2;
            cbPayM2.DisplayMember = "PayMode";
            cbPayM2.ValueMember = "PayMode";
            //throw new NotImplementedException();
        }

        private void LoadRoutes()
        {
            DataTable rttab = new DataTable();
            sql = "select rname from route_list";
            rttab = dB.GetDataTable(sql, 0);
            cbRoute.DataSource = rttab;
            cbRoute.DisplayMember = "rname";
            cbRoute.ValueMember = "rname";
            //throw new NotImplementedException();
        }

        private void LoadBalancePayments( string route, int bal)
        {
            sql = "Select RegNo,RegName,Balance,PayMode from main_reg where Paymode in ('Cash','Cheque') " +
                "and LineManager= 0 and Balance >" + bal +" and  routeName like'" + route + "%'order by Balance";
            DataTable baltab = new DataTable();
            baltab = dB.GetDataTable(sql, 0);
            dgvBal.DataSource = baltab;
            //throw new NotImplementedException();
        }

        private void LoadBalancePayments( int regNo)
        {
            sql = "Select RegNo,RegName,Balance,PayMode from main_reg where Paymode in ('Cash','Cheque') " +
                "and LineManager= 0 and Balance > 0 and  RegNo =" + regNo ;
            DataTable baltab = new DataTable();
            baltab = dB.GetDataTable(sql, 0);
            dgvBal.DataSource = null;
            dgvBal.Refresh();
            dgvBal.DataSource = baltab;
            ShowValues(0);
        
            //throw new NotImplementedException();
        }

        private void ShowValues(int row)
        {
            tbName.Text = dgvBal.Rows[row].Cells[1].Value.ToString();
            nBalance.Value = decimal.Parse(dgvBal.Rows[row].Cells[2].Value.ToString());
            //throw new NotImplementedException();

        }

        private void cbRoute_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRoute.SelectedItem != null && !formLoading)
            {
                //route = cbRoute.SelectedItem.ToString();
                DataRowView drv = (DataRowView)cbRoute.SelectedItem;
                route = drv[0].ToString();
                LoadBalancePayments(route,0);
            }
        }

        private void nRegNo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode== Keys.Enter)
            {
                LoadBalancePayments((int)nRegNo.Value);
            }
        }

        private void nLimitAmt_Enter(object sender, EventArgs e)
        {
            nLimitAmt.Select(0,nLimitAmt.Value.ToString().Length);
        }

        private void nLimitAmt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode== Keys.Enter)
            {
                LoadBalancePayments(route, (int) nLimitAmt.Value);
            }
        }

        private void bApply_Click(object sender, EventArgs e)
        {
            UpdateBatch(route, nLimitAmt.Value);
        }

        private void UpdateBatch(string route, decimal value)
        {
            sql = "Update main_reg Set PayMode='" + paymode + "' Where routeName like '" + route + "%'  and balance > " + value;
            dB.ExecuteQuery(sql, 0);
            LoadBalancePayments(route, (int)value);
            //throw new NotImplementedException();
        }

        private void cbPayMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ( cbPayMode.SelectedItem != null)
            {
                DataRowView drv = (DataRowView)cbPayMode.SelectedItem;
                paymode = drv[0].ToString();
            }
        }

        private void cbPayM2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPayM2.SelectedItem != null)
            {
                DataRowView drv = (DataRowView)cbPayM2.SelectedItem;
                paym2 = drv[0].ToString();
            }
        }

        private void bUpdate_Click(object sender, EventArgs e)
        {
            UpdateSingle(nRegNo.Value);
        }

        private void UpdateSingle(decimal value)
        {
            sql = "Update main_reg Set PayMode='" + paym2 + "' Where RegNo =" + value;
            dB.ExecuteQuery(sql, 0);
            LoadBalancePayments( (int)value);
            //throw new NotImplementedException();
        }

        private void nLimitAmt_ValueChanged(object sender, EventArgs e)
        {
            if (nLimitAmt.Value > 0)
                bApply.Enabled = true;
            else
                bApply.Enabled = false;
        }
    }
}
