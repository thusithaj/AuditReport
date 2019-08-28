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
    public partial class FormAdvance : Form
    {
        DataTable tableAdv;
        List<Account> DebitAcs;
        List<Account> CreditAcs;
        Supplier selectedSupplier;
        Route selectedRoute;
        List<Route> RouteList;
        AdvController advctr;
        StockController sc;
        private const int CASH = 0;
        private const int CHEQUE = 1;
        private const int TRANSFER = 2;
        bool isFormLoading = true;
        int selectedType = -1;
        int entryLevel = 0;
        bool isNew = false;
        bool isEdit = false;
        Account craccount;
        Account draccount;
        BlgAdvance blgAdv;
        TransferNN tr;
        ChequeNN chq;
        CashNN csh;
        public FormAdvance()
        {
            InitializeComponent();
        }

        private void FormAdvance_Load(object sender, EventArgs e)
        {
            tableAdv = new DataTable();
            GetAdvanceType();
            LoadDefaults();
            isFormLoading = false;
            EnableControls(false);
            InitializeInput();
        }

        private void InitializeInput()
        {
            if (entryLevel == 0 && !isFormLoading)
            {
                cbAdvType.SelectedIndex = -1;
                cbRoute.SelectedIndex = -1;

            }
            nSupNo.Value = 0;
            nAmt.Value = 0;
            //throw new NotImplementedException();
        }

        private void EnableControls(bool p)
        {
            cbAdvType.Enabled = p;
            cbRoute.Enabled = p;
            tbVoucherNo.Enabled = p;
            nSupNo.Enabled = p;
            tbName.Enabled = p;
            cbCreditAc.Enabled = p;
            cbDebitAc.Enabled = p;
            tbChqNo.Enabled = p;
            nAmt.Enabled = p;
            
        }

        private void LoadDefaults()
        {
            advctr = new AdvController();
            sc= new StockController();
            //selectedRoute.
            cbRoute.SelectedIndex = -1;
            this.RouteList = sc.GetRoutes().ToList();
            cbRoute.DataSource = RouteList;
            cbRoute.DisplayMember = "rName";
            cbRoute.ValueMember = "rName";
            
           
        }
        /// <summary>
        /// Get advance types
        /// </summary>
        private void GetAdvanceType()
        {

            tableAdv.Columns.Add(new DataColumn("id", typeof(int)));
            tableAdv.Columns.Add(new DataColumn("AdvType", typeof(string)));
            tableAdv.Rows.Add(tableAdv.NewRow());
            tableAdv.Rows[tableAdv.Rows.Count - 1]["id"] = 0;
            tableAdv.Rows[tableAdv.Rows.Count - 1]["AdvType"] = "Cash";
            tableAdv.Rows.Add(tableAdv.NewRow());
            tableAdv.Rows[tableAdv.Rows.Count - 1]["id"] = 1;
            tableAdv.Rows[tableAdv.Rows.Count - 1]["AdvType"] = "Cheque";
            tableAdv.Rows.Add(tableAdv.NewRow());
            tableAdv.Rows[tableAdv.Rows.Count - 1]["id"] = 2;
            tableAdv.Rows[tableAdv.Rows.Count - 1]["AdvType"] = "Transfer";
            
            cbAdvType.DataSource = tableAdv;
            cbAdvType.DisplayMember = "AdvType";
            cbAdvType.ValueMember = "id";
            cbAdvType.SelectedIndex = -1;


            
        }

        private void cbRoute_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isFormLoading)
            {
                selectedRoute = (Route) cbRoute.SelectedItem;
                blgAdv = new BlgAdvance();
            }
        }

        private void cbAdvType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!isFormLoading)
            {
                selectedType = (int)cbAdvType.SelectedValue;
                LoadAccounts(selectedType);
            }
        }
        /// <summary>
        /// Loading accounts
        /// </summary>
        /// <param name="selectedType"></param>
        private void LoadAccounts(int selectedType)
        {
            CreditAcs = new List<Account>();
            switch(selectedType)
            {
                case TRANSFER:
                    
                    CreditAcs = advctr.GetAccounts("PRE%").ToList();
                    
                    break;
                case CASH:
                    CreditAcs= advctr.GetAccounts("MAIN%").ToList();
                    //cbCreditAc.DataSource 
                    break;
                case CHEQUE:
                    CreditAcs = advctr.GetAccounts("%BANK%").ToList();
                    //cbCreditAc.DataSource;
                    break;
            }
            cbCreditAc.DataSource = CreditAcs;
            
        }
        /// <summary>
        /// Advance combo box down
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbAdvType_KeyDown(object sender, KeyEventArgs e)
        {
            if(cbAdvType.SelectedIndex != -1 && e.KeyCode== Keys.Enter)
            {
                cbRoute.Focus();
            }
            else
            {
                cbAdvType.Focus();
            }
        }

        private void cbRoute_KeyDown(object sender, KeyEventArgs e)
        {
            if (cbRoute.SelectedIndex != -1 && e.KeyCode == Keys.Enter)
            {
                nSupNo.Focus();
            }
        }

        private void nSupNo_Enter(object sender, EventArgs e)
        {
            nSupNo.Select(0, nSupNo.Value.ToString().Length);
        }

        private void nSupNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (nSupNo.Value >0 && e.KeyCode== Keys.Enter)
            {
                selectedSupplier = new Supplier();
                selectedSupplier = sc.GetSuppliers((int)nSupNo.Value).Where(o => o.regNo == (int)nSupNo.Value).FirstOrDefault();
                if (selectedSupplier != null)
                {
                    tbName.Text = selectedSupplier.regName;
                    cbCreditAc.Focus();
                }
            }
        }

        private void cbCreditAc_SelectedIndexChanged(object sender, EventArgs e)
        {
            craccount = new Account();
            if (cbCreditAc.SelectedIndex != -1)
            {
                craccount = (Account)cbCreditAc.SelectedItem;
                nAcBalance.Value = craccount.CurrentBalance;
                cbDebitAc.Focus();
            }

        }

        private void cbDebitAc_SelectedIndexChanged(object sender, EventArgs e)
        {
            draccount = new Account();
            if (cbDebitAc.SelectedIndex != -1)
            {
                craccount = (Account)cbDebitAc.SelectedItem;
                if (tbChqNo.Enabled) tbChqNo.Focus();
                else nAmt.Focus();
            }
        }

        private void nAmt_Enter(object sender, EventArgs e)
        {
            nAmt.Select(0, nAmt.Value.ToString().Length);
        }

        private void nAmt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                bSave.Focus();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                GatherObjectValue();
            }
        }

        private void GatherObjectValue()
        {
            if (advctr == null)
            {
                blgAdv.advanceMaster = advctr.GetLastAdvanceEntry();
                blgAdv.advanceMaster.crAcc = craccount.AccountName;
                blgAdv.advanceMaster.drAcc = draccount.AccountName;
                blgAdv.advanceMaster.trDate = dtAdvDate.Value;
                blgAdv.advanceMaster.trMonth = String.Format("{0:MMM}-{0:yyyy}", dtAdvDate.Value);
                blgAdv.advanceMaster.PayMode = cbAdvType.Text;
                blgAdv.advanceMaster.trRoute = selectedRoute.rName;
                LedgerTrnMaster trnmst = new LedgerTrnMaster();
                trnmst.Amount =(double) nAmt.Value;
                switch (selectedType)
                {
                    case TRANSFER:
                        trnmst.ChequeNo = "n/a";
                        tr = new TransferNN();
                        tr = (TransferNN) advctr.CreateMasterEntry(TRANSFER, tr);
                        trnmst.ledgerTransactions = CreateLedgerTran();
                        break;
                    case CHEQUE:
                        trnmst.ChequeNo = tbChqNo.Text;
                        chq = new ChequeNN();
                        chq=(ChequeNN) advctr.CreateMasterEntry(CHEQUE, chq);
                        break;
                    case CASH:
                        trnmst.ChequeNo = "n/a";
                        csh = new CashNN();
                        csh= (CashNN) advctr.CreateMasterEntry(CASH, csh);
                        break;
                }
                trnmst.CreditAcc = " ";
                trnmst.DebitAcc = " ";
                trnmst.CrMonth = String.Format("{0:MMM}-{0:yyyy}", dtAdvDate.Value);
                trnmst.Description = "B/L Advance " + selectedRoute.rName + " " + selectedSupplier.regNo.ToString();
                trnmst.PayeName = selectedSupplier.regName;
                trnmst.trDate = dtAdvDate.Value;
                trnmst.Route = selectedRoute.rName;
                trnmst.Amount = (double)nAmt.Value;
                trnmst.myModule = "GENBLP";
                trnmst.UserLog = Environment.MachineName + "/" + Environment.UserName;


            }

            //throw new NotImplementedException();
        }

        private ICollection<LedgerTransaction> CreateLedgerTran()
        {
            LedgerTransaction led = new LedgerTransaction();
            List<LedgerTransaction> newlst = new List<LedgerTransaction>();
            led.AcCode = craccount.AccountCode;
            //led.CopCode=
            //throw new NotImplementedException();
            return newlst;
        }

        private bool ValidateInput()
        {
            bool isValid = true;
            if (cbAdvType.SelectedIndex == -1)
            {
                MessageBox.Show("Advance type is not entered", "No Advance Type");
                isValid = false;
                cbAdvType.Focus();
            }
            if (cbRoute.SelectedIndex == -1)
            {
                MessageBox.Show("Route type is not entered", "No Route");
                isValid = false;
                cbAdvType.Focus();
            }
            if (nSupNo.Value == 0)
            {
                MessageBox.Show("Supplier No field is empty", "No supplier");
                isValid = false;
                nSupNo.Focus();
            }
            if (tbChqNo.Enabled && tbChqNo.Text == "")
            {
                MessageBox.Show("Cheque no cannot be empty", "No Cheque No");
                isValid = false;
                tbChqNo.Focus();
            }

            return isValid;
            //hrow new NotImplementedException();
        }

        private void badd_Click(object sender, EventArgs e)
        {
            isNew = true;
            
            EnableControls(true);
            InitializeInput();
            dtAdvDate.Focus();
        }

        private void dtAdvDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                cbAdvType.Focus();
        }
    }
}
