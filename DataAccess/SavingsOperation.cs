using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataAccess
{
    /// <summary>
    /// The business logic and the controller class
    /// </summary>
    public class SavingsOperation
    {
        DataTable SavingData;
        DBAccess DBAccess;
        string sql;
        /// <summary>
        /// Constructor
        /// </summary>
        public SavingsOperation()
        {
            DBAccess = new DBAccess();
            
        }
        /// <summary>
        /// Get all the ledger data from the 
        /// </summary>
        /// <param name="dtMonth"></param>
        /// <returns></returns>
        public DataTable GetSavingDataTable( DateTime dtMonth)
        {

            sql = " Select routeName,RegNo, RegName, SavingAMT,TotKg from Main_Reg_" + String.Format("{0:MMM_yyyy}", dtMonth);
            sql = sql + " Where SavingReg=1";
            SavingData = new DataTable();
            try
            {
                SavingData = DBAccess.GetDataTable(sql, DBAccess.BLHistory);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return SavingData;
        }
        /// <summary>
        /// Getting Previous saving coins
        /// </summary>
        /// <param name="dtMonth"></param>
        /// <returns></returns>
        public DataTable GetPreviousSavCoin( DateTime dtMonth)
        {
            sql = " Select routeName,RegNo, RegName, savingPrvCoin from Main_Reg_" + String.Format("{0:MMM_yyyy}", dtMonth);
            sql = sql + " Where SavingReg=1";
            SavingData = new DataTable();
            SavingData = DBAccess.GetDataTable(sql, DBAccess.BLHistory);
            return SavingData;
        }
        /// <summary>
        /// Get the current month Savings
        /// </summary>
        /// <returns></returns>
        public DataTable GetCurrentMonth()
        {
            sql = " Select routeName,RegNo, RegName,TotKg , SavingAMT from Main_Reg ";
            sql = sql + " Where SavingReg=1";
            SavingData = new DataTable();
            SavingData = DBAccess.GetDataTable(sql, DBAccess.BoughtLeaf);
            return SavingData;
        }
        /// <summary>
        /// get debtsuppliers
        /// </summary>
        /// <returns></returns>
        public DataTable GetDebtSuppliers()
        {
            sql = "select a.Regno,a.LastSuppliedDate,b.RouteName as Route,b.RegName,b.nmb as Amount" +
                " from ( select regno, max(trdate) LastSuppliedDate from Collection_tbl " +
                    " where regno in (select regno from Main_Reg where TotKg = 0 and NMB > 0) " +
                        " group by regno) a inner join " +
                    " (select routeName , regno, regName, nmb  from Main_Reg where TotKg = 0 and NMB > 0) b on a.regNo = b.regNo " +
                " order by routeName, b.regNo ";
            //sql = sql + " Where totkg = 0";
            SavingData = new DataTable();
            SavingData = DBAccess.GetDataTable(sql, DBAccess.BoughtLeaf);
            return SavingData;
        }

        //public void CommitSavingPayment(DataTable table)
        //{
        //    if (!TableExisits("SavingLedger"))
        //    {
        //        CreateSavingLedgerTable();

        //    }
        //    Task task = DBAccess.ExecuteSavingTransaction(0, table);
        //    task.Wait();
        //    //task.
        //}

        public void CreateSavingLedgerTable()
        {
            string sql = " CREATE TABLE SavingLedger (" +
                " RegNo int, RegName nchar(50), Route nchar(30),ItemName nchar(50), Amount money, Unit nchar(10), " +
                " ItemOrder int, Qty numeric(18,2),Maincategory nchar(10))";
            try
            {
                DBAccess.ExecuteQuery(sql, DBAccess.BoughtLeaf);
            }
            catch ( Exception ex)
            {
                throw ex;
            }
            //throw new NotImplementedException();
        }


        public DataTable GetCommittedSavings()
        {
            string sql = "Select * from SavingLedger";
            DataTable table = DBAccess.GetDataTable(sql, DBAccess.BoughtLeaf);
            return table;
        }
        public bool TableExisits(string v)
        {
            bool isTableExists = false;
            string sql = "Select [name] from sysobjects where [name] ='" + v + "'";
            DataTable tableNames = DBAccess.GetDataTable(sql, DBAccess.BoughtLeaf);
            if (tableNames.Rows.Count == 0)
                isTableExists = false;
            else
                isTableExists = true;
            return isTableExists;
            //throw new NotImplementedException();
        }
        /// <summary>
        /// Get Routes and sort the list
        /// </summary>
        /// <returns> sorted list</returns>
        public List<Route> GetRoutes()
        {
            StockController sc = new StockController();
            List<Route> routes = new List<Route>();
            Route route = new Route();
            route.rName = "All";
            //routes = ;
            routes.Add(route);
            foreach (Route r in sc.GetRoutes().ToList())
            {
                routes.Add(r);
            }
            //routes.Reverse();
            return routes;
        }
    }
}
