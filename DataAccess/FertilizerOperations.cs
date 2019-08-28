using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DataAccess
{
    public class FertilizerOperations
    {
        DataTable SavingData;
        DBAccess DBAccess;
        DataTable dbNames;
        string sql;
        /// <summary>
        /// Constructor
        /// </summary>
        public FertilizerOperations()
        {
            DBAccess = new DBAccess();
            dbNames = new DataTable();

        }
        /// <summary>
        /// Get all the ledger data from the 
        /// </summary>
        /// <param name="dtMonth"></param>
        /// <returns></returns>
        public DataTable GetFertilizerDataTable(DateTime dtMonth, int intOrder)
        {
            sql = "SELECT        a.IssueID, a.IssueDate, a.AccID, a.Amount, a.RegNo, a.RegName, a.RegRoute, a.DIscountAmt, " +
                "a.DeductionAmt, a.IssueType, a.GatePass, a.GatePassName, a.VehicleNo, a.CatFK, b.Cr, b.BLregNo, " + intOrder + " AS ind," +
                " b.ProductID, c.CatID, c.ProductName FROM       " + DBAccess.InvDBname + ".dbo.GenaralIssues AS a INNER JOIN " +
                 DBAccess.InvDBname + ".dbo.Stock_Data AS b ON a.IssueID = b.StockID INNER JOIN " + DBAccess.InvDBname +
                 ".dbo.Products AS c ON b.ProductID = c.PK" +
                 " WHERE(MONTH(a.IssueDate) = " + dtMonth.Month + ") AND(YEAR(a.IssueDate) =" + dtMonth.Year+")";

            //sql = " SELECT   " +intOrder + "As ind, a.trDate, a.IssuedMonth, a.trMonth, a.regNo, a.Route, a.regName, a.Amount, a.trType, a.LogDate, a.IssueID, a.crRoute, a.ItemID, a.Price, a.Qty, b.Cr, b.BLregNo, " +
            //    "c.RegRoute, c.GatePassName, c.VehicleNo, b.ProductID, p.ProductName, p.CatID " +
            //    "FROM            " + DBAccess.blDBname +".dbo.Advance_tbl"  +
            //    " AS a INNER JOIN " + DBAccess.InvDBname + ".dbo.Stock_Data AS b ON a.IssueID = b.StockID INNER JOIN " +
            //    "         " + DBAccess.InvDBname + ".dbo.GenaralIssues AS c ON a.IssueID = c.IssueID INNER JOIN " +
            //     "        " + DBAccess.InvDBname + ".dbo.Products AS p ON b.ProductID = p.PK WHERE Month(a.TRDate )=" + dtMonth.Month +
            //     " AND Year(a.TRDate )=" + dtMonth.Year ;
            //sql = sql + " Where SavingReg=1";
            SavingData = new DataTable();
            try
            {
                SavingData = DBAccess.GetDataTable(sql, DBAccess.BoughtLeaf);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return SavingData;
        }
        public DataTable GetFertilizerDataTable( int intOrder)
        {

            sql = " SELECT   " + intOrder + "As ind, a.trDate, a.IssuedMonth, a.trMonth, a.regNo, a.Route, a.regName, a.Amount, a.trType, a.LogDate, a.IssueID, a.crRoute, a.ItemID, a.Price, a.Qty, b.Cr, b.BLregNo, " +
                "c.RegRoute, c.GatePassName, c.VehicleNo, b.ProductID, p.ProductName, p.CatID " +
                "FROM            LedgerBL.dbo.Advance_tbl" +
                " AS a INNER JOIN Inventorydb.dbo.Stock_Data AS b ON a.IssueID = b.StockID INNER JOIN " +
                "         Inventorydb.dbo.GenaralIssues AS c ON a.IssueID = c.IssueID INNER JOIN " +
                 "        Inventorydb.dbo.Products AS p ON b.ProductID = p.PK WHERE Month(a.TRDate )=" +DateTime.Now.Month +
                 " AND Year(a.TRDate )=" + DateTime.Now.Year;
            //sql = sql + " Where SavingReg=1";
            SavingData = new DataTable();
            try
            {
                SavingData = DBAccess.GetDataTable(sql, DBAccess.BoughtLeaf);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return SavingData;
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
