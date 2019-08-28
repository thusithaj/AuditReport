using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataAccess
{
    public class AdvController
    {
        public ICollection<Advance> advances;
        public ICollection<Account> accountsList;
        public TransferNN trnn;
        public CashNN cashnn;
        public ChequeNN chqnn;
        public AdvanceMaster advHead;
        //public ICollection<Account> GetAccounts;
        public string strsql;
        public DBAccess db;
        private DataTable table;

        public void SaveAdvance(AdvanceMaster advmaster, LedgerTrnMaster master)
        {
            strsql = " INSERT INTO Advance_File( trDate,trMonth,PayMode,crAcc,drAcc,trRoute)" +
                " Values (CONVERT(DateTime,'" + String.Format("{0:yyyy-{0:mm}-{0:dd}", advmaster.trDate) + "',102 '" + String.Format("{0:MMM}- {0:yyyy}", advmaster.trDate) + "'," +
                "'" + advmaster.PayMode + "','" + advmaster.crAcc + "','" + advmaster.drAcc + "','" + advmaster.trRoute + "')";
            db = new DBAccess();
            db.ExecuteQuery(strsql, DBAccess.BoughtLeaf);
           
            SaveLedger(master);

        }

        public AdvanceMaster GetLastAdvanceEntry()
        {
            table = new DataTable();
            strsql = "Select top 1 * From Advance_File Order By ListId Desc";
            table = db.GetDataTable(strsql, DBAccess.BoughtLeaf);
            advHead = new AdvanceMaster();
            if (table.Rows.Count == 1)
            {
                advHead.crAcc = table.Rows[0]["crAcc"].ToString();
                advHead.drAcc = table.Rows[0]["drAcc"].ToString();
                advHead.ListId = int.Parse(table.Rows[0]["ListId"].ToString());
                advHead.PayMode = table.Rows[0]["PayMode"].ToString();
                advHead.trDate = DateTime.Parse(table.Rows[0]["trDate"].ToString());
                advHead.trMonth = table.Rows[0]["trMonth"].ToString();
                advHead.trRoute = table.Rows[0]["trRoute"].ToString();
            }
            return advHead;
        }
        /// <summary>
        /// Saving Accounts Ledger 
        /// </summary>
        /// <param name="trnMaster"></param>
        public void SaveLedger ( LedgerTrnMaster trnMaster)
        {
            strsql = "Insert Into Ac_TrMain (  [TrID],[trType],[trDate],[Description],[PayeName],[ChequeNo],[PresentDate], " +
                    " [CreditAcc],[DebitAcc],[Amount] ,[FormName],[RegNo],[CrMonth] ,[Route], " +
                    " [myModule],[UserLog],[ListID] Values ('" + trnMaster.TrID + "','" + trnMaster.trType + "'," +
                    " CONVERT( DateTime,'" + String.Format("{0:yyyy-{0:mm}-{0:dd}", trnMaster.trDate) + "',23)," +
                    "'" + trnMaster.Description + "','" + trnMaster.PayeName + "','" + trnMaster.ChequeNo + "',NULL," +
                    "'" + trnMaster.CreditAcc + "','" + trnMaster.DebitAcc + "'," + trnMaster.Amount + ",'" + trnMaster.FormName + "'," +
                    trnMaster.RegNo + ",'" + trnMaster.CrMonth + "','" + trnMaster.Route + "','" + trnMaster.myModule + "','" +
                    trnMaster.UserLog + "','" + trnMaster.ListID + "')";
            db = new DBAccess();
            db.ExecuteQuery(strsql, DBAccess.BoughtLeaf);
            foreach ( LedgerTransaction ledger in trnMaster.ledgerTransactions)
            {
                SaveLedgerDetails(ledger);
            }

        }
        /// <summary>
        /// Saving details of the ledger as accounts transactions
        /// </summary>
        /// <param name="transaction"></param>
        public void SaveLedgerDetails( LedgerTransaction transaction)
        {
            strsql = " Insert Into Ac_Trans ( [trDate],[trNo],[trCode] ,[trCdeNo],[AcCode],[Debit],[Credit],[trMode], " +
                    " [sTime], [ItemType],[ItemName],[ItemCode],[qtIn],[qtOut],[Rate] ,[ExpCode], " +
                    " [CopCode],[LabourCR],[LabourCW] ,[InvNo],[TxVal],[CostID],[ExpSubCode],[CopMainCode],[ZynkeD]) " +
                    " Values ( CONVERT(DateTime,'," + String.Format("{0:yyyy-{0:mm}-{0:dd}", transaction.trDate) + ",23)," +
                    transaction.trNo + ",'" + transaction.trCode + "','" + transaction.trCdeNo + "','" + transaction.AcCode + "'," +
                    transaction.Debit + "," + transaction.Credit + ",'" + transaction.trMode + "',GETDATE(),'" + transaction.ItemType + "'," +
                    "'" + transaction.ItemName + "','" + transaction.ItemCode + "'," + transaction.qtIn + "," + transaction.qtOut + "," +
                    transaction.Rate + "," + transaction.ExpCode + "," + transaction.CopCode + "," + transaction.LabourCR + "," + transaction.LabourCW +
                    ",'" + transaction.InvNo + "'," + transaction.TxVal + ",'" + transaction.CostID + "'," + transaction.CopMainCode + "," +
                    transaction.ZynkeD + ")";
            db = new DBAccess();
            db.ExecuteQuery(strsql, DBAccess.BoughtLeaf);
        }
        /// <summary>
        /// Get Accounts from the Account Master Table
        /// </summary>
        /// <param name="acType"></param>
        /// <returns>Collection of Accounts</returns>
        public ICollection<Account> GetAccounts( string acType)
        {
            strsql = "SELECT * From dbo.Account_List WHERE (AcName = N'" + acType + "')";
            table = new DataTable();
            db = new DBAccess();
            table = db.GetDataTable(strsql, DBAccess.GL);
            accountsList = new HashSet<Account>();
            foreach (DataRow dr in table.Rows)
            {
                Account account = new Account();
                account.AccountCode = dr["AccountCode"].ToString();
                account.AccountName= dr["AccountName"].ToString();
                account.CurrentBalance = decimal.Parse( dr["CurrentBalance"].ToString());
                account.CreditBalance = decimal.Parse(dr["CreditBalance"].ToString());
                account.DebitBalance = decimal.Parse(dr["DebitBalance"].ToString());
                account.id = int.Parse(dr["id"].ToString());
                accountsList.Add(account);
            }
            return accountsList;
        }
        /// <summary>
        /// Creating master entries for GL Updating
        /// </summary>
        /// <param name="type"> 0- Cash, 1- Cheque, 2- Transfer</param>
        public object CreateMasterEntry( int type,object nextNoObj)
        {
            object retObj;
            retObj = new object();
            switch (type)
            {
                case 0:
                    cashnn = new CashNN();
                    cashnn = (CashNN)nextNoObj;
                    cashnn=InsertCashMaster(cashnn);
                    retObj = cashnn;
                    break;
                case 1:
                    chqnn = new ChequeNN();
                    chqnn = (ChequeNN)nextNoObj;
                    chqnn = InsertChequeMaster(chqnn);
                    retObj = chqnn;
                    break;
                case 2:
                    trnn = new TransferNN();
                    trnn = (TransferNN)nextNoObj;
                    trnn = InsertTransferMaster(trnn);
                    retObj = trnn;
                    break;
            }
            //strsql = " ";
            return retObj; 
            
        }
        /// <summary>
        /// Transfer master entry
        /// </summary>
        /// <param name="trnn"></param>
        /// <returns>Transfer object</returns>
        private TransferNN InsertTransferMaster(TransferNN trnn)
        {
           // throw new NotImplementedException();
            trnn.ws = Environment.MachineName + DateTime.Now.ToShortTimeString().Trim();
            strsql = "Insert into indTR Values ('" + trnn.ws + "',GETDATE())";
            db = new DBAccess();
            db.ExecuteQuery(strsql, DBAccess.GL);

            //strsql = "Select top 1 * from indCA Order by Ind Desc";
            //table = db.GetDataTable(strsql, DBAccess.GL);
            //if (table.Rows.Count == 1)
            //{
            //    trnn.ind = int.Parse(table.Rows[0]["ind"].ToString());
            //    trnn.ws = table.Rows[0]["ws"].ToString();
            //    trnn.st = DateTime.Parse(table.Rows[0]["st"].ToString());
            //}
            trnn = GetTransferLastNo();
            return trnn;

        }

        public TransferNN GetTransferLastNo()
        {
            TransferNN trLast = new TransferNN();
            strsql = "Select top 1 * from indCA Order by Ind Desc";
            table = db.GetDataTable(strsql, DBAccess.GL);
            if (table.Rows.Count == 1)
            {
                trLast.ind = int.Parse(table.Rows[0]["ind"].ToString());
                trLast.ws = table.Rows[0]["ws"].ToString();
                trLast.st = DateTime.Parse(table.Rows[0]["st"].ToString());
            }
            return trLast;
        }
        /// <summary>
        /// Insert Cheque master entry
        /// </summary>
        /// <param name="chqnn"></param>
        /// <returns>Chq master object</returns>
        private ChequeNN InsertChequeMaster(ChequeNN chqnn)
        {
            //throw new NotImplementedException();
            chqnn.ws = Environment.MachineName + DateTime.Now.ToShortTimeString().Trim();
            strsql = "Insert into indCH Values ('" + chqnn.ws + "',GETDATE())";
            db = new DBAccess();
            db.ExecuteQuery(strsql, DBAccess.GL);

            //strsql = "Select top 1 * from indCH Order by Ind Desc";
            //table = db.GetDataTable(strsql, DBAccess.GL);
            //if (table.Rows.Count == 1)
            //{
            //    chqnn.ind = int.Parse(table.Rows[0]["ind"].ToString());
            //    chqnn.ws = table.Rows[0]["ws"].ToString();
            //    chqnn.st = DateTime.Parse(table.Rows[0]["st"].ToString());
            //}
            chqnn = GetChequeLastNo();
            return chqnn;
        }

        public ChequeNN GetChequeLastNo()
        {
            ChequeNN lastChq = new ChequeNN();
            strsql = "Select top 1 * from indCH Order by Ind Desc";
            table = db.GetDataTable(strsql, DBAccess.GL);
            if (table.Rows.Count == 1)
            {
                lastChq.ind = int.Parse(table.Rows[0]["ind"].ToString());
                lastChq.ws = table.Rows[0]["ws"].ToString();
                lastChq.st = DateTime.Parse(table.Rows[0]["st"].ToString());
            }
            return lastChq;
        }
        /// <summary>
        /// Cash master entry
        /// </summary>
        /// <param name="cashnn"></param>
        /// <returns>Cash master object</returns>
        private CashNN InsertCashMaster(CashNN cashnn)
        {
            cashnn.ws = Environment.MachineName + DateTime.Now.ToShortTimeString().Trim();
            strsql = "Insert into indCA Values ('" + cashnn.ws + "',GETDATE())";
            db = new DBAccess();
            db.ExecuteQuery(strsql, DBAccess.GL);

            //strsql = "Select top 1 * from indCA Order by Ind Desc";
            //table = db.GetDataTable(strsql, DBAccess.GL);
            //if (table.Rows.Count == 1)
            //{
            //    cashnn.ind = int.Parse(table.Rows[0]["ind"].ToString());
            //    cashnn.ws = table.Rows[0]["ws"].ToString();
            //    cashnn.st = DateTime.Parse(table.Rows[0]["st"].ToString());
            //}
            cashnn = GetCashLastNo();
            return cashnn;
            //throw new NotImplementedException();
        }
        public CashNN GetCashLastNo()
        {
            CashNN lastCashNo = new CashNN();
            strsql = "Select top 1 * from indCA Order by Ind Desc";
            table = db.GetDataTable(strsql, DBAccess.GL);
            if (table.Rows.Count == 1)
            {
                lastCashNo.ind = int.Parse(table.Rows[0]["ind"].ToString());
                lastCashNo.ws = table.Rows[0]["ws"].ToString();
                lastCashNo.st = DateTime.Parse(table.Rows[0]["st"].ToString());
            }
            return lastCashNo;
        }
        /// <summary>
        /// Get the advances for AUdit Report
        /// </summary>
        /// <param name="advtype"></param>
        /// <returns>Advance Data Table</returns>
        public DataTable GetAdvances( string advtype, DateTime fromdate, DateTime todate, string route)
        {
            DataTable table = new DataTable();
            strsql = "SELECT        Ac_TrMain.ind, Ac_TrMain.TrID, Ac_TrMain.trType, Ac_TrMain.trDate, Ac_TrMain.Description, Ac_TrMain.PayeName," +
                " Ac_TrMain.ChequeNo, Ac_TrMain.PresentDate, Ac_TrMain.CreditAcc, Ac_TrMain.DebitAcc, Ac_TrMain.Amount,    Ac_TrMain.FormName," +
                " Ac_TrMain.RegNo, Ac_TrMain.CrMonth, Ac_TrMain.Route, Ac_TrMain.myModule, Ac_TrMain.UserLog, Ac_TrMain.ListID, Ac_Trans.trNo, " +
                " Ac_Trans.trCdeNo, Ac_Trans.Debit, Account_List.AcCode,   Account_List.AcName , '" + String.Format("{0:yyyy-MM-dd}", fromdate) + "' AS Fromdate" +
                "'" + String.Format("{0:yyyy-MM-dd}", todate) + "' AS Todate " +
                "FROM   Ac_TrMain INNER JOIN " +
                " Ac_Trans ON Ac_TrMain.TrID = Ac_Trans.trCdeNo" +
                " INNER JOIN     Account_List ON Ac_Trans.AcCode = Account_List.AcCode " +
                " WHERE(Ac_TrMain.trType = '" + advtype + "') AND(Ac_Trans.Debit > 0)' AND trDate Between " +
                "'" + String.Format ("{0:yyyy-MM-dd}", fromdate) + "', AND '" + String.Format("{0:yyyy-MM-dd}", todate) + "'";
            if (route != "*" || route.ToUpper() !="ALL" || route != "" )
            {
                strsql = strsql + " AND Ac_TrMain.Route ='" + route + "'";
            }
            table = db.GetDataTable(strsql, DBAccess.GL);
            return table;
        }
        public DataTable GetAdvances(string advtype, DateTime fromdate, DateTime todate, string route, int supplier)
        {
            DataTable table = new DataTable();
            strsql = "SELECT        Ac_TrMain.ind, Ac_TrMain.TrID, Ac_TrMain.trType, Ac_TrMain.trDate, Ac_TrMain.Description, Ac_TrMain.PayeName," +
                " Ac_TrMain.ChequeNo, Ac_TrMain.PresentDate, Ac_TrMain.CreditAcc, Ac_TrMain.DebitAcc, Ac_TrMain.Amount,    Ac_TrMain.FormName," +
                " Ac_TrMain.RegNo, Ac_TrMain.CrMonth, Ac_TrMain.Route, Ac_TrMain.myModule, Ac_TrMain.UserLog, Ac_TrMain.ListID, Ac_Trans.trNo, " +
                " Ac_Trans.trCdeNo, Ac_Trans.Debit, Account_List.AcCode,   Account_List.AcName , '" + String.Format("{0:yyyy-MM-dd}", fromdate) + "' AS Fromdate" +
                ",'" + String.Format("{0:yyyy-MM-dd}", todate) + "' AS Todate , r.TpNo, r.Phone1 " +
                " FROM   Ac_TrMain INNER JOIN " +
                " Ac_Trans ON Ac_TrMain.TrID = Ac_Trans.trCdeNo" +
                " INNER JOIN     Account_List ON Ac_Trans.AcCode = Account_List.AcCode  INNER JOIN LedgerBl.dbo.Main_reg r ON  r.RegNo = Ac_TrMain.RegNo " +
                " WHERE(Ac_TrMain.trType = '" + advtype + "') AND(Ac_Trans.Debit > 0)  AND Ac_TrMain.trDate >= " + 
                  "'" + String.Format("{0:yyyy-MM-dd}", fromdate) + "' AND Ac_TrMain.trDate <='" + String.Format("{0:yyyy-MM-dd}", todate) + "'";
            if ( route.ToUpper() != "ALL")
            {
                strsql = strsql + " AND Ac_TrMain.Route ='" + route + "'";
            }
            if ( supplier != 0 && supplier != -1 )
            {
                strsql = strsql + " AND Ac_TrMain.RegNo =" + supplier;
            }
            if (db == null)
                db = new DBAccess();
            table = db.GetDataTable(strsql, DBAccess.GL);
            return table;
        }
    }
}
