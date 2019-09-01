using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
namespace DataAccess
{
    public class StockController
    {
        public ICollection<StockItem> stockItems;
        public ItemMaster itemMaster { get; set; }
        public StockItem stockItem;
        public Advance advance;
        public GeneralIssue generalIssue;
        public ICollection<Supplier> suppliers;
        public ICollection<Route> routes;
        public ICollection<Product> products;
        public ICollection<Period> periods;
        public ICollection<ItemLst> itemLsts;
        public ICollection<Vehicle> vehicles;
        public ICollection<GeneralIssue> generalIssues;
        public DataTable hisToryTable;

        private string strFormat = "{0:yyyy}-{0:MM}-{0:dd}";
        OleDbCommand command;
        //SqlCommand sqlCommand;
        string strsql;
        DBAccess dB;
        AddDedTransaction transaction;
        DataTable data;

        public GeneralIssue GetGeneralIssue(string flag)
        {
            if (flag == "0")
            {
                strsql = "select top 1 * from GenaralIssues where IssueDate >='2018-11-01' order by IssueId desc";
            }
            else
                strsql = " select top 1 * from GenaralIssues where IssueId='" + flag + "'";
            dB = new DBAccess();
            command = new OleDbCommand();
            command.CommandText = strsql;
            DataTable dataTable = dB.GetDataTable(strsql, DBAccess.Inventory);
            generalIssue = new GeneralIssue();
            if (dataTable.Rows.Count == 1)
            {
                generalIssue.IssueID = dataTable.Rows[0]["IssueID"].ToString();
                generalIssue.IssueDate = DateTime.Parse(dataTable.Rows[0]["IssueDate"].ToString());
                generalIssue.AccID = int.Parse(dataTable.Rows[0]["AccID"].ToString());
                generalIssue.Amount = double.Parse(dataTable.Rows[0]["Amount"].ToString());
                generalIssue.RegNo = int.Parse(dataTable.Rows[0]["RegNo"].ToString());
                generalIssue.RegName = dataTable.Rows[0]["RegName"].ToString();
                generalIssue.RegRoute = dataTable.Rows[0]["RegRoute"].ToString();
                generalIssue.DIscountAmt = double.Parse(dataTable.Rows[0]["DIscountAmt"].ToString());
                generalIssue.DeductionAmt = double.Parse(dataTable.Rows[0]["DeductionAmt"].ToString());
                generalIssue.IssueType = dataTable.Rows[0]["IssueType"].ToString();
                generalIssue.GatePass = int.Parse(dataTable.Rows[0]["GatePass"].ToString());
                generalIssue.GatePassName = dataTable.Rows[0]["GatePassName"].ToString();
                generalIssue.VehicleNo = dataTable.Rows[0]["VehicleNo"].ToString();
                generalIssue.CatFK = int.Parse(dataTable.Rows[0]["CatFK"].ToString());
            }
            return generalIssue;
        }
        /// <summary>
        /// Get the stock item or last stock no based on the parameter
        /// id = -1  will returns the last stock no 
        /// any other no ill return stock item or null
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Stock Item</returns>
        public StockItem GetStockItem(int id)
        {

            if (id == -1)
                strsql = "select top 1 *  from stock_data where stockdate>'2018-11-30' and StockID Like 'FT%'  order by ind desc ";
            else
                strsql = "select * from  stock_data where ind = " + id;

            dB = new DBAccess();
            command = new OleDbCommand();
            command.CommandText = strsql;
            DataTable dataTable = dB.GetDataTable(strsql, DBAccess.Inventory);
            stockItem = new StockItem();
            if (dataTable.Rows.Count > 0)
            {
                stockItem.AcCode = dataTable.Rows[0]["AcCode"].ToString();
                stockItem.BLregNo = int.Parse(dataTable.Rows[0]["BLregNo"].ToString());
                stockItem.Cost = double.Parse(dataTable.Rows[0]["Cost"].ToString());
                stockItem.CostID = int.Parse(dataTable.Rows[0]["CostID"].ToString());
                stockItem.Cr = double.Parse(dataTable.Rows[0]["Cr"].ToString());
                stockItem.Dr = double.Parse(dataTable.Rows[0]["Dr"].ToString());
                stockItem.ExpCode = int.Parse(dataTable.Rows[0]["ExpCode"].ToString());
                stockItem.GatePass = int.Parse(dataTable.Rows[0]["GatePass"].ToString());
                stockItem.GatePassName = dataTable.Rows[0]["GatePassName"].ToString();
                stockItem.Ind = int.Parse(dataTable.Rows[0]["Ind"].ToString());
                stockItem.Price = double.Parse(dataTable.Rows[0]["Price"].ToString());
                stockItem.ProductID = int.Parse(dataTable.Rows[0]["Ind"].ToString());
                stockItem.StockDate = DateTime.Parse(dataTable.Rows[0]["StockDate"].ToString());
                stockItem.StockID = dataTable.Rows[0]["StockID"].ToString();
                stockItem.StockType = dataTable.Rows[0]["StockType"].ToString();

            }
            return stockItem;
        }

        /// <summary>
        /// Get the stock item based on the stock issue no
        /// </summary>
        /// <param name="stockId"></param>
        /// <returns> stock itemor null/returns>
        public StockItem GetStockItem(string stockId)
        {

            //if (id == -1)
            //    strsql = "select top 1 *  from stock_data where stockdate>'2018-11-30' and StockID Like 'FT%'  order by ind desc ";
            //else
            strsql = "select * from  stock_data where StockId = '" + stockId + "'";

            dB = new DBAccess();
            command = new OleDbCommand();
            command.CommandText = strsql;
            DataTable dataTable = dB.GetDataTable(strsql, DBAccess.Inventory);
            stockItem = new StockItem();
            if (dataTable.Rows.Count > 0)
            {
                stockItem.AcCode = dataTable.Rows[0]["AcCode"].ToString();
                stockItem.BLregNo = int.Parse(dataTable.Rows[0]["BLregNo"].ToString());
                stockItem.Cost = double.Parse(dataTable.Rows[0]["Cost"].ToString());
                stockItem.CostID = int.Parse(dataTable.Rows[0]["CostID"].ToString());
                stockItem.Cr = double.Parse(dataTable.Rows[0]["Cr"].ToString());
                stockItem.Dr = double.Parse(dataTable.Rows[0]["Dr"].ToString());
                stockItem.ExpCode = int.Parse(dataTable.Rows[0]["ExpCode"].ToString());
                stockItem.GatePass = int.Parse(dataTable.Rows[0]["GatePass"].ToString());
                stockItem.GatePassName = dataTable.Rows[0]["GatePassName"].ToString();
                stockItem.Ind = int.Parse(dataTable.Rows[0]["Ind"].ToString());
                stockItem.Price = double.Parse(dataTable.Rows[0]["Price"].ToString());
                stockItem.ProductID = int.Parse(dataTable.Rows[0]["Ind"].ToString());
                stockItem.StockDate = DateTime.Parse(dataTable.Rows[0]["StockDate"].ToString());
                stockItem.StockID = dataTable.Rows[0]["StockID"].ToString();
                stockItem.StockType = dataTable.Rows[0]["StockType"].ToString();

            }
            return stockItem;
        }

        public AddDedTransaction GetAddDedTransaction(bool isLast, int id)
        {
            transaction = new AddDedTransaction();
            if (isLast)
                strsql = " select top 1 *  from [Transaction] Order by TransactionDate Desc ";
            else
                strsql = " select *  from [Transaction] where id =" + id;
            dB = new DBAccess();
            DataTable dataTable = new DataTable();
            dataTable = dB.GetDataTable(strsql, 3);
            if (dataTable.Rows.Count == 1)
            {
                transaction.Amount = double.Parse(dataTable.Rows[0]["Amount"].ToString());
                transaction.EnteredDate = DateTime.Parse(dataTable.Rows[0]["EnteredDate"].ToString());
                transaction.EnteredUserId = int.Parse(dataTable.Rows[0]["EnteredUserId"].ToString());
                transaction.id = int.Parse(dataTable.Rows[0]["id"].ToString());
                transaction.Quantity = int.Parse(dataTable.Rows[0]["Quantity"].ToString());
                transaction.Rate = double.Parse(dataTable.Rows[0]["Rate"].ToString());
                transaction.Sign = dataTable.Rows[0]["Sign"].ToString();
                transaction.Status = dataTable.Rows[0]["Status"].ToString();
                transaction.SupplierCode = int.Parse(dataTable.Rows[0]["SupplierCode"].ToString());
                transaction.TransactionDate = DateTime.Parse(dataTable.Rows[0]["TransactionDate"].ToString());
                transaction.Unit = dataTable.Rows[0]["Unit"].ToString();
            }
            return transaction;
        }
        /// <summary>
        /// Add Advances to the old advance table
        /// </summary>
        /// <param name="advance"></param>
        public void AddOldAdvanceTable(Advance advance)
        {
            strsql = "INSERT INTO Advance_Tbl (trDate,IssuedMonth,trMonth,regNo,Route," +
                "regName,Amount,trType,LogDate,IssueID,crRoute,ItemID,Price,Qty)" +
                " Values ( CONVERT (dateTime,'" + String.Format(strFormat, advance.trDate )+ "',102),'" + advance.IssuedMonth + "','" +
                advance.trMonth + "'," + advance.regNo + ",'" + advance.Route + "','" +
                advance.regName + "'," + advance.Amount + ",'" + advance.trType + "'," +
                "Getdate(),'" + advance.IssueID + "','" + advance.crRoute + "'," +
                advance.ItemID + "," + advance.Price + "," + advance.Qty + ")";
            dB = new DBAccess();
            command = new OleDbCommand();
            command.CommandText = strsql;
            //command.Parameters.Add(new OleDbParameter("@trDate", OleDbType.Date)).Value = advance.trDate;
            //command.Parameters.Add(new OleDbParameter("@IssuedMonth", OleDbType.Char)).Value = advance.IssuedMonth;
            //command.Parameters.Add(new OleDbParameter("@trMonth", OleDbType.Char)).Value = advance.trMonth;
            //command.Parameters.Add(new OleDbParameter("@regNo", OleDbType.Integer)).Value = advance.regNo;
            //command.Parameters.Add(new OleDbParameter("@Route", OleDbType.Char)).Value = advance.Route;
            //command.Parameters.Add(new OleDbParameter("@regName", OleDbType.Char)).Value = advance.regName;
            //command.Parameters.Add(new OleDbParameter("@Amount", OleDbType.Numeric)).Value = advance.Amount;
            //command.Parameters.Add(new OleDbParameter("@trType", OleDbType.Char)).Value = advance.trType;
            //command.Parameters.Add(new OleDbParameter("@LogDate", OleDbType.Date)).Value = advance.LogDate;
            //command.Parameters.Add(new OleDbParameter("@IssueID", OleDbType.Char)).Value = advance.IssueID;
            //command.Parameters.Add(new OleDbParameter("@crRoute", OleDbType.Char)).Value = advance.crRoute;
            //command.Parameters.Add(new OleDbParameter("@ItemID", OleDbType.Integer)).Value = advance.ItemID;
            //command.Parameters.Add(new OleDbParameter("@Price", OleDbType.Numeric)).Value = advance.Price;
            //command.Parameters.Add(new OleDbParameter("@Qty", OleDbType.Numeric)).Value = advance.Qty;
            dB.ExecuteQuery(command, DBAccess.BoughtLeaf);
            //DataTable dataTable = dB.GetDataTable(strsql, 1);
        }

        /// <summary>
        /// UpdateOld advance table
        /// </summary>
        /// <param name="advance"></param>
        public void UpdateOldAdvanceTable(Advance advance)
        {
            strsql = "Update  Advance_Tbl Set trDate = @trDate ,IssuedMonth=@IssuedMonth,trMonth=@trMonth,regNo=@regNo,Route=@Route," +
               "regName=@regName,Amount=@Amount,trType=@trType,LogDate=@LogDate,IssueID=@IssueID,crRoute=@crRoute,ItemID=@ItemID" +
               ",Price=@Price,Qty =@Qty) WHERE ind = @ind";
            dB = new DBAccess();
            command = new OleDbCommand();
            command.CommandText = strsql;
            command.Parameters.Add(new OleDbParameter("@trDate", OleDbType.Date)).Value = advance.trDate;
            command.Parameters.Add(new OleDbParameter("@IssuedMonth", OleDbType.Char)).Value = advance.IssuedMonth;
            command.Parameters.Add(new OleDbParameter("@trMonth", OleDbType.Char)).Value = advance.trMonth;
            command.Parameters.Add(new OleDbParameter("@regNo", OleDbType.Integer)).Value = advance.regNo;
            command.Parameters.Add(new OleDbParameter("@Route", OleDbType.Char)).Value = advance.Route;
            command.Parameters.Add(new OleDbParameter("@regName", OleDbType.Char)).Value = advance.regName;
            command.Parameters.Add(new OleDbParameter("@Amount", OleDbType.Numeric)).Value = advance.Amount;
            command.Parameters.Add(new OleDbParameter("@trType", OleDbType.Char)).Value = advance.trType;
            command.Parameters.Add(new OleDbParameter("@LogDate", OleDbType.Date)).Value = advance.LogDate;
            command.Parameters.Add(new OleDbParameter("@IssueID", OleDbType.Char)).Value = advance.IssueID;
            command.Parameters.Add(new OleDbParameter("@crRoute", OleDbType.Char)).Value = advance.crRoute;
            command.Parameters.Add(new OleDbParameter("@ItemID", OleDbType.Integer)).Value = advance.ItemID;
            command.Parameters.Add(new OleDbParameter("@Price", OleDbType.Numeric)).Value = advance.Price;
            command.Parameters.Add(new OleDbParameter("@Qty", OleDbType.Numeric)).Value = advance.Qty;
            command.Parameters.Add(new OleDbParameter("@ind", OleDbType.Integer)).Value = advance.ind;
            dB.ExecuteQuery(command, DBAccess.BoughtLeaf);
        }

        public StockItem AddStockRecord(StockItem stockItem)
        {
            //stockItem.StockID = GetStockItem(-1).StockID;
            strsql = "insert into Stock_Data (StockID,StockDate,CostID,StockType,ProductID,Cost,Price," +
                    "Dr,Cr,AcCode,ExpCode,GatePass,GatePassName,BLregNo)" +
                    "Values ('" + stockItem.StockID + "',CONVERT(DateTime,'" + String.Format(strFormat, stockItem.StockDate) + "',102)," +
                    stockItem.CostID + ",'" + stockItem.StockType + "'," + stockItem.ProductID + "," + stockItem.Cost +
                    "," + stockItem.Price + "," + stockItem.Dr + "," + stockItem.Cr + ",'" +
                    stockItem.AcCode + "'," + stockItem.ExpCode + "," + stockItem.GatePass + ",'" +
                    stockItem.GatePassName + "'," + stockItem.BLregNo + ")";
            dB = new DBAccess();
            command = new OleDbCommand();
            command.CommandText = strsql;
            
            dB.ExecuteQuery(command, DBAccess.Inventory);
            //UpdateCurrentMonthFertilizer(stockItem);
            StockItem savedItem = new StockItem();
            savedItem = GetStockItem(-1);
            return savedItem;
        }

        public StockItem UpdateStockRecord(StockItem stockItem)
        {
            //stockItem.StockID = GetStockItem(-1).StockID;
            strsql = "UPDATE Stock_Data  SET StockID='" + stockItem.StockID + "',StockDate=CONVERT(DateTime,'" + stockItem.StockDate + "',102)," +
                "CostID=" + stockItem.CostID + ",StockType='" + stockItem.StockType + "'," +
                ",ProductID =" + stockItem.ProductID + ",Cost=" + stockItem.Cost + ",Price=" + stockItem.Price + "," +
                    "Dr=" + stockItem.Dr + ",Cr=" + stockItem.Cr + ",AcCode='" + stockItem.AcCode + ",ExpCode=" + stockItem.ExpCode +
                    ",GatePass=" + stockItem.GatePass + " ,GatePassName='" + stockItem.GatePassName + "',BLregNo=" + stockItem.BLregNo +
                    " WHERE ind = " + stockItem.Ind;
            dB = new DBAccess();
            command = new OleDbCommand();
            command.CommandText = strsql;
          
            dB.ExecuteQuery(command, DBAccess.Inventory); 
            
            stockItem = GetStockItem(-1);
           
            return stockItem;
        }

        private void UpdateCurrentMonthFertilizer(Advance adv)
        {
            strsql = " Update Main_Reg Set Fertilizer= Fertilizer + " + adv.Amount + " Where regNo=" + adv.regNo;
            dB = new DBAccess();
            command = new OleDbCommand();
            command.CommandText = strsql;

            dB.ExecuteQuery(command, DBAccess.BoughtLeaf);
            //throw new NotImplementedException();
        }
        /// <summary>
        /// Creating Advance ledger and update current month fertilizer issues
        /// </summary>
        /// <param name="advance"></param>
        /// <param name="stock"></param>
        /// <param name="noofTerms"></param>
        public void CreateAdvanceLedger(Advance advance, StockItem stock, int noofTerms)
        {
            DateTime tranDate = advance.trDate;
            for (int i = 0; i < noofTerms; i++)
            {
                advance.IssuedMonth = String.Format("{0:MMM}-{0:yyyy}", tranDate);
                advance.trMonth = String.Format("{0:MMM}-{0:yyyy}", tranDate);
                advance.trType = stock.StockType;
                //advance.Route= stock.
                AddOldAdvanceTable(advance);
                if (i == 0)
                    UpdateCurrentMonthFertilizer(advance); // Here we update current month
                tranDate = tranDate.AddMonths(i + 1);
            }
        }
        /// <summary>
        /// Get suppliers
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Supplier List</returns>
        public ICollection<Supplier> GetSuppliers(int id)
        {
            suppliers = new HashSet<Supplier>();
            strsql = " Select * from Main_Reg Where LineManager=0";
            if (id == -1 )
                strsql = "Select * From Main_Reg Where LineManager=1";
            dB = new DBAccess();
            //command = new OleDbCommand();
            //command.CommandText = strsql;
            data = new DataTable();
            data = dB.GetDataTable(strsql, DBAccess.BoughtLeaf);
            foreach (DataRow dr in data.Rows)
            {
                Supplier supplier = new Supplier();
                supplier.ind = int.Parse(dr["ind"].ToString());
                supplier.regNo = int.Parse(dr["regNo"].ToString());
                supplier.regName = dr["regName"].ToString();
                supplier.rCode = dr["rCode"].ToString();
                supplier.routeName = dr["routeName"].ToString();
                supplier.NICno = dr["NICno"].ToString();
                supplier.RegDate = DateTime.Parse(String.IsNullOrEmpty(dr["RegDate"].ToString()) ? new DateTime(2000, 1, 1).ToString() : dr["RegDate"].ToString());
                supplier.LineManager = (bool.Parse(dr["LineManager"].ToString())) ? 1 : 0;
                supplier.LineID = int.Parse(dr["LineID"].ToString());
                supplier.SpLine = (bool.Parse(dr["SpLine"].ToString())) ? 1 : 0;
                supplier.DyNo = int.Parse(dr["DyNo"].ToString());
                supplier.BankFK = int.Parse(String.IsNullOrEmpty(dr["BankFK"].ToString()) ? "0" : dr["BankFK"].ToString());
                supplier.NameAcHold = dr["NameAcHold"].ToString();
                supplier.AcNumber = dr["AcNumber"].ToString();
                supplier.WelfareID = int.Parse(dr["WelfareID"].ToString());
                supplier.Address = dr["Address"].ToString();
                supplier.PayMode = dr["PayMode"].ToString();
                //supplier.FunaralRegDate =DateTime.Parse( dr["FunaralRegDate"].ToString());
                supplier.Phone1 = dr["TpNo"].ToString();
                suppliers.Add(supplier);
            }
            return suppliers;
        }
        /// <summary>
        /// Get Routes of the System
        /// </summary>
        /// <returns>Route List</returns>
        public ICollection<Route> GetRoutes()
        {
            routes = new HashSet<Route>();
            strsql = " Select * from Route_List Where trActive=1 order by rName";
            dB = new DBAccess();
            //command = new OleDbCommand();
            //command.CommandText = strsql;
            data = new DataTable();
            data = dB.GetDataTable(strsql, DBAccess.BoughtLeaf);
            foreach (DataRow dr in data.Rows)
            {
                Route route = new Route();
                route.ind = int.Parse(dr["ind"].ToString());
                route.RouteID = int.Parse(dr["RouteID"].ToString());
                route.rCode = dr["rCode"].ToString();
                route.rName = dr["rName"].ToString();
                route.trRate = double.Parse(dr["trRate"].ToString());
                route.blRate = double.Parse(dr["blRate"].ToString());
                route.trActive = (bool.Parse(dr["trActive"].ToString()) ? 1 : 0);
                route.newBlRate = double.Parse(dr["newBlRate"].ToString());
                route.Incentive = double.Parse(dr["Incentive"].ToString());
                route.blRateSL = double.Parse(dr["blRateSL"].ToString());
                route.newBlRateSL = double.Parse(dr["newBlRateSL"].ToString());
                route.Target = double.Parse(dr["Target"].ToString());
                route.ExtraRate = double.Parse(dr["ExtraRate"].ToString());
                route.AreaID = int.Parse(dr["AreaID"].ToString());
                routes.Add(route);
            }
            return routes;
        }
        /// <summary>
        /// Get products
        /// </summary>
        /// <returns>Collection of Products</returns>
        public ICollection<Product> GetProducts()
        {

            products = new HashSet<Product>();
            strsql = " Select * from Products";
            dB = new DBAccess();
            //command = new OleDbCommand();
            //command.CommandText = strsql;
            data = new DataTable();
            data = dB.GetDataTable(strsql, DBAccess.Inventory);
            foreach (DataRow dr in data.Rows)
            {
                Product product = new Product();
                product.PK = int.Parse(dr["PK"].ToString());
                product.CatID = int.Parse(dr["CatID"].ToString());
                product.ProductName = dr["ProductName"].ToString();
                product.CompanyID = int.Parse(dr["CompanyID"].ToString());
                product.SellingPrice = double.Parse(dr["SellingPrice"].ToString());
                product.ReOrderLevel = double.Parse(dr["ReOrderLevel"].ToString());
                product.ReOrderQty = double.Parse(dr["ReOrderQty"].ToString());
                product.Installments = int.Parse(dr["Installments"].ToString());
                product.Transport = double.Parse(dr["Transport"].ToString());
                product.StockBalance = GetProductStockBalance(product.PK);
                products.Add(product);
            }
            return products;
        }
        public ICollection<Product> GetProducts( int Category)
        {

            products = new HashSet<Product>();
            strsql = " Select * from Products Where CatID=" + Category ;
            dB = new DBAccess();
            //command = new OleDbCommand();
            //command.CommandText = strsql;
            data = new DataTable();
            data = dB.GetDataTable(strsql, DBAccess.Inventory);
            foreach (DataRow dr in data.Rows)
            {
                Product product = new Product();
                product.PK = int.Parse(dr["PK"].ToString());
                product.CatID = int.Parse(dr["CatID"].ToString());
                product.ProductName = dr["ProductName"].ToString();
                product.CompanyID = int.Parse(dr["CompanyID"].ToString());
                product.SellingPrice = double.Parse(dr["SellingPrice"].ToString());
                product.ReOrderLevel = double.Parse(dr["ReOrderLevel"].ToString());
                product.ReOrderQty = double.Parse(dr["ReOrderQty"].ToString());
                product.Installments = int.Parse(dr["Installments"].ToString());
                product.Transport = double.Parse(dr["Transport"].ToString());
                product.StockBalance = GetProductStockBalance(product.PK);
                products.Add(product);
            }
            return products;
        }

        private double GetProductStockBalance(int pK)
        {
            strsql = " Select sum(dr) InQty, sum(Cr) OutQty from Stock_Data where ProductID=" + pK;
            double stockBalance = 0.00;
            dB = new DBAccess();
            data = new DataTable();
            data = dB.GetDataTable(strsql, DBAccess.Inventory);
            double inQty = 0.00;
            inQty = data.Rows[0][0].ToString().Trim() == "" ? 0.00 : double.Parse(data.Rows[0][0].ToString());
            if (inQty == 0) stockBalance = 0.00;
            else
            {
                stockBalance = double.Parse(data.Rows[0][0].ToString()) - double.Parse(data.Rows[0][1].ToString());
                if (stockBalance < 0.00)
                    stockBalance = 0.00;
            }
            return stockBalance;
            //throw new NotImplementedException();
        }
        /// <summary>
        /// Get the system periods
        /// </summary>
        /// <returns>Collection of Periods</returns>
        public ICollection<Period> GetPeriods()
        {
            
            periods = new HashSet<Period>();
            strsql = " Select * from Month_Tbl";
            dB = new DBAccess();
          
            data = new DataTable();
            data = dB.GetDataTable(strsql, DBAccess.BoughtLeaf);
            foreach (DataRow dr in data.Rows)
            {
                Period period = new Period();
                period.ind =int.Parse( dr["ind"].ToString());
                period.mName = dr["mName"].ToString();
                periods.Add(period);
            }
            return periods;
        }
        /// <summary>
        /// Getting month setup
        /// </summary>
        /// <returns>Month Setup objects</returns>
        public MonthSetup GetMonthSetup()
        {
            MonthSetup monthsetup = new MonthSetup();
            strsql = " Select * from Month_Setup";
            dB = new DBAccess();
            //command = new OleDbCommand();
            //command.CommandText = strsql;
            data = new DataTable();
            data = dB.GetDataTable(strsql, DBAccess.BoughtLeaf);
            foreach (DataRow dr in data.Rows)
            {
                monthsetup.ind = int.Parse( dr["ind"].ToString());
                monthsetup.PrevMonth = dr["PrevMonth"].ToString();
                monthsetup.ThisMonth= dr["ThisMonth"].ToString();
                monthsetup.FunaralRate=double.Parse(dr["FunaralRate"].ToString());
                monthsetup.FunaralRateA = double.Parse(dr["FunaralRate_A"].ToString());
                monthsetup.FunaralRateB = double.Parse(dr["FunaralRate_B"].ToString());
            }
            return monthsetup;
        }
        /// <summary>
        /// Get the BL Items list from LedgerBl
        /// </summary>
        /// <returns> Collection of Item List</returns>
        public ICollection<ItemLst> GetItemLsts()
        {
            itemLsts = new HashSet<ItemLst>();
            strsql = " Select * from Item_LST";
            dB = new DBAccess();
            //command = new OleDbCommand();
            //command.CommandText = strsql;
            data = null;
            data = new DataTable();
            data = dB.GetDataTable(strsql, DBAccess.BoughtLeaf);
            foreach(DataRow dr in data.Rows)
            {
                ItemLst item = new ItemLst();
                item.ItemID =int.Parse( dr["ItemID"].ToString());
                item.ItemType = dr["ItemType"].ToString();
                item.ItemName = dr["ItemName"].ToString();
                item.Price = double.Parse(dr["Price"].ToString());
                itemLsts.Add(item);
            }
            return itemLsts;
        }
        /// <summary>
        /// Get Leaf Supplied History
        /// </summary>
        /// <param name="currentMonth"></param>
        /// <param name="SupplierNo"></param>
        /// <returns>Data Table with History</returns>
        public DataTable GetBlgHistory( DateTime currentMonth, int SupplierNo)
        {
            DataTable singleTable = new DataTable();
            string tabName = "Main_Reg_";
            data = null;
            data = new DataTable();
            dB = new DBAccess();
            SetCustomDataTable(currentMonth.AddMonths(-1));
            DateTime beginDate = new DateTime(currentMonth.Year, 1, 1);
            strsql = "Select * From  Main_Reg Where regno=" + SupplierNo;
            singleTable = dB.GetDataTable(strsql, DBAccess.BoughtLeaf);
            if (singleTable.Rows.Count >= 0)
                FormatHistoryTable(singleTable, 0);
            singleTable.Clear();
            foreach (MonthTableName mtn in GetMonthTableNames(1))
            {
                tabName = tabName + mtn.mName.Replace('-', '_');
                strsql = "Select * From " + tabName + " Where regno=" + SupplierNo;
                singleTable = dB.GetDataTable(strsql, DBAccess.BLHistory);
                if (singleTable.Rows.Count >= 1)
                    FormatHistoryTable(singleTable, 1);  //data.Merge(singleTable);
                singleTable.Clear();
            }
            //for (int i = 1; i <= currentMonth.Month; i++)
            //{
            //    //tabName = tabName + String.Format("{0:MMM}", beginDate) + "_" + beginDate.Year.ToString();

            //    //tabName = "Main_Reg_";
            //}
            //if (currentMonth.Month > 1)
            //{
            //    for (int i = 1; i <= 1; i++)
            //    {
            //        tabName = tabName + String.Format("{0:MMM}", beginDate) + "_" + beginDate.Year.ToString();
            //        strsql = "Select * From " + tabName + " Where regno=" + SupplierNo;
            //        singleTable = dB.GetDataTable(strsql, DBAccess.BLHistory);
            //        if (singleTable.Rows.Count >= 1)
            //            FormatHistoryTable(data, 1);  //data.Merge(singleTable);
            //        singleTable.Clear();
            //        tabName = "Main_Reg_";
            //    }
            //}
            //tabName = "Main_Reg";
            //strsql = "Select * From " + tabName + " Where regno=" + SupplierNo;
            //singleTable.Clear();
            //singleTable = dB.GetDataTable(strsql, DBAccess.BoughtLeaf);
            //if (singleTable.Rows.Count >= 0)
            //    data.Merge(singleTable);

            return hisToryTable;
        }

        private void FormatHistoryTable(DataTable table,int colno)
        {
            //SetCustomDataTable();
            //hisToryTable = new DataTable();
            colno++;
            int row = 0;
            if (colno == 1)
            {
                hisToryTable.Rows.Add(hisToryTable.NewRow()); // Row no 1
                //row = 
                hisToryTable.Rows[row][0] = "Total Leaf";
            }
            
            hisToryTable.Rows[row][colno] = table.Rows[0]["TotKg"];
            row++;
            if (colno == 1)
            {
                hisToryTable.Rows.Add(hisToryTable.NewRow()); // Row no 2
                hisToryTable.Rows[row][0] = "Leaf Amount";
            }
            
            hisToryTable.Rows[row][colno] = table.Rows[0]["Gross"];
            row++;
            if (colno == 1)
            {
                hisToryTable.Rows.Add(hisToryTable.NewRow()); // Row no 3
                hisToryTable.Rows[row][0] = "Prev. Coins";
            }
            
            hisToryTable.Rows[row][colno] = table.Rows[0]["prCoins"];
            row++;
            if (colno == 1)
            {
                hisToryTable.Rows.Add(hisToryTable.NewRow()); // Row no 4
                hisToryTable.Rows[row][0] = "Gross Amount";
                
            }
            
            hisToryTable.Rows[row][colno] = table.Rows[0]["TempGross"];
            row++;
            if (colno == 1)
            {
                hisToryTable.Rows.Add(hisToryTable.NewRow()); // Row no 5
                hisToryTable.Rows[row][0] = "Transport";
            }
            hisToryTable.Rows[row][colno] = table.Rows[0]["Transport"];
            row++;
            if (colno == 1)
            {
                hisToryTable.Rows.Add(hisToryTable.NewRow()); // Row no 6
                hisToryTable.Rows[row][0] = "Incentive";
            }
            hisToryTable.Rows[row][colno] = table.Rows[0]["Incentive"];
            row++;
            if (colno == 1)
            {
                hisToryTable.Rows.Add(hisToryTable.NewRow()); // Row no 7
                hisToryTable.Rows[row][0] = "BF Fertilizer";
            }
            hisToryTable.Rows[row][colno] = table.Rows[0]["FertLMB"];
            row++;
            if (colno == 1)
            {
                hisToryTable.Rows.Add(hisToryTable.NewRow()); // Row no 8
                hisToryTable.Rows[row][0] = "Cur. Month Fertilizer";
            }
            hisToryTable.Rows[row][colno] = table.Rows[0]["Fertilizer"];
            row++;
            if (colno == 1)
            {
                hisToryTable.Rows.Add(hisToryTable.NewRow()); // Row no 9
                hisToryTable.Rows[row][0] = "Tea";
            }
            hisToryTable.Rows[row][colno] = table.Rows[0]["Tea"];
            row++;
            if (colno == 1)
            {
                hisToryTable.Rows.Add(hisToryTable.NewRow()); // Row no 10
                hisToryTable.Rows[row][0] = "Welfare";
            }
            hisToryTable.Rows[row][colno] = table.Rows[0]["Funaral"];
            row++;
            if (colno == 1)
            {
                hisToryTable.Rows.Add(hisToryTable.NewRow()); // Row no 11
                hisToryTable.Rows[row][0] = "Savings";
            }
            hisToryTable.Rows[row][colno] = table.Rows[0]["SavingAMT"];
            row++;
            if (colno == 1)
            {
                hisToryTable.Rows.Add(hisToryTable.NewRow()); // Row no 12
                hisToryTable.Rows[row][0] = "Stamp";
            }
            hisToryTable.Rows[row][colno] = table.Rows[0]["Stamp"];
            row++;
            if (colno == 1)
            {
                hisToryTable.Rows.Add(hisToryTable.NewRow());// Row no 13
                hisToryTable.Rows[row][0] = "Loan";
            }
            hisToryTable.Rows[row][colno] = table.Rows[0]["LoanInstalment"];
            row++;
            if (colno == 1)
            {
                hisToryTable.Rows.Add(hisToryTable.NewRow());// Row no 14
                hisToryTable.Rows[row][0] = "Prev, Debts";
            }
            hisToryTable.Rows[row][colno] = table.Rows[0]["xDebt"];
            row++;
            if (colno == 1)
            {
                hisToryTable.Rows.Add(hisToryTable.NewRow());// Row no 15
                hisToryTable.Rows[row][0] = "Cash Advance";
            }
            hisToryTable.Rows[row][colno] = table.Rows[0]["CashAdv"];
            row++;
            if (colno == 1)
            {
                hisToryTable.Rows.Add(hisToryTable.NewRow());// Row no 16
                hisToryTable.Rows[row][0] = "Total Deductions";
            }
            hisToryTable.Rows[row][colno] = table.Rows[0]["TotalDeduction"];
            row++;
            if (colno == 1)
            {
                hisToryTable.Rows.Add(hisToryTable.NewRow());// Row no 17
                hisToryTable.Rows[row][0] = "Net Amount";
            }
            hisToryTable.Rows[row][colno] = table.Rows[0]["Balance"];
            row++;

            //throw new NotImplementedException();
        }

        /// <summary>
        /// Get getting advance 
        /// </summary>
        /// <param name="currentMonth"></param>
        /// <returns> Return </returns>
        public DataTable GetAdvanceIssue( DateTime currentMonth, string route, string StockID)
        {
            //DateTime cpDataTime = new DateTime(currentMonth)
            strsql = "select  m.routeName, a.trDate,s.StockID,m.regNo, m.regName,p.ProductName,a.Qty,a.Amount, a.ind TRNo, a.TrMonth" +
                    " from Advance_tbl a inner join InventoryDB.dbo.Stock_Data s on a.IssueID = s.StockID " +
                    " and a.regNo = s.BLregNo inner join Main_Reg m on a.regNo = m.regNo " +
                    " inner join InventoryDB.dbo.Products p on s.ProductID = p.PK " +
                    " where trtype Like '%Fert%' AND "  +
                " a.trDate >= '" + String.Format(strFormat, currentMonth) + "' AND a.Route Like '" + route +"%'" +
                " AND s.StockID='" + StockID +"'" +
                " Order by a.ind ";
            dB = new DBAccess();
            data = null;
            data = new DataTable();
            data = dB.GetDataTable(strsql, DBAccess.BoughtLeaf);
            return data;
        }
        /// <summary>
        /// Add a general issue for the General Issue table
        /// </summary>
        /// <param name="general"></param>
        public void AddGeneralIssue (GeneralIssue general)
        {
            GeneralIssue issue = GetGeneralIssue(general.IssueID);
            dB = new DBAccess();
            command = new OleDbCommand();

            int mode = 0;
            if (issue.IssueID == null)
            {
                strsql = "insert into GenaralIssues (IssueID,IssueDate,AccID," +
                    "Amount,RegNo,RegName," +
                    "RegRoute,DIscountAmt,DeductionAmt,IssueType,GatePass,GatePassName,VehicleNo,CatFK) " +
                    " Values ('" + general.IssueID +"',CONVERT (DateTime,'" +String.Format(strFormat, general.IssueDate) +"',102)," + general.AccID +"," +
                    general.Amount +"," + general.RegNo +",'" + general.RegName +"','" +general.RegRoute +"',"  +
                   general.DIscountAmt +"," + general.DeductionAmt +",'" + general.IssueType +"'," + general.GatePass +
                   ",'" + general.GatePassName +"','" +general.VehicleNo +"'," +general.CatFK +")"  ;
                mode = 1;
                command.CommandText = strsql;
              
            }
            else
            {
                strsql = "Update  GenaralIssues SET Amount= Amount +" + general.Amount +
                    " , DeductionAmt =DeductionAmt + " +general.DeductionAmt +
                    ", VehicleNo = '" +general.VehicleNo +"'" +
                    " WHERE IssueID='" +general.IssueID +"'";
                mode = 2;
                command.CommandText = strsql;
              
            }
            
            dB.ExecuteQuery(command, DBAccess.Inventory);
        }

        public void UpdateGeneralIssueVehicleNo (GeneralIssue general)
        {
            strsql = "Update  GenaralIssues SET  VehicleNo = '" + general.VehicleNo + "'" +
                   " WHERE IssueID='" + general.IssueID + "'";
            dB = new DBAccess();
            command = new OleDbCommand();
           
            command.CommandText = strsql;
        
        

            dB.ExecuteQuery(command, DBAccess.Inventory);
        }
        /// <summary>
        /// Returns the collection of vehicles 
        /// </summary>
        /// <returns>Returns the collection of vehicles</returns>
        public ICollection<Vehicle> GetVehicles()
        {
            vehicles = new HashSet<Vehicle>();
            strsql = " Select * from Vehicale_List where active=1";
            dB = new DBAccess();
            //command = new OleDbCommand();
            //command.CommandText = strsql;
            data = null;
            data = new DataTable();
            data = dB.GetDataTable(strsql, DBAccess.BoughtLeaf);
            foreach (DataRow row in data.Rows)
            {
                Vehicle vehicle = new Vehicle();
                vehicle.Ind = int.Parse(row["Ind"].ToString());
                vehicle.Name = row["Name"].ToString();
                vehicle.Active = int.Parse(bool.Parse( row["Active"].ToString()) ?"1" :"0");
                vehicles.Add(vehicle);
            }
            return vehicles;
        }
        /// <summary>
        /// Get get pass to print
        /// </summary>
        /// <param name="issueId"></param>
        /// <returns>gate pass data table</returns>
        public DataTable GetGatePassToPrint( string issueId)
        {
            DataTable dataTable = new DataTable();
            strsql = " SELECT '0' DocType,  g.IssueID,g.IssueDate,g.GatePass,g.GatePassName,g.VehicleNo," +
                    " 0 ProductID, sum(s.cr) Quantity,' ' ProductName,0 SellingPrice,g.IssueType , g.RegRoute RouteName" +
                " FROM GenaralIssues g inner join dbo.Stock_Data s ON g.IssueID = s.StockID INNER JOIN " +
                " dbo.Products p on " +
                    " p.PK = s.ProductID " +
                    " where  g.IssueID ='" +issueId +"'" +
                    " group by g.IssueID,g.IssueDate,g.GatePass,g.GatePassName,g.VehicleNo," +
                    "g.IssueType, g.RegRoute ";
            dB = new DBAccess();
            //command = new OleDbCommand();
            //command.CommandText = strsql;
            data = new DataTable();
            dataTable = dB.GetDataTable(strsql, DBAccess.Inventory);
            data.Merge(dataTable);
            dataTable = new DataTable();
            strsql = " SELECT '1' DocType,  g.IssueID,g.IssueDate,g.GatePass,g.GatePassName,g.VehicleNo," +
                    " 0 ProductID, sum(0.00) Quantity,' 'ProductName,0 SellingPrice,g.IssueType , g.RegRoute RouteName" +
                " FROM GenaralIssues g inner join dbo.Stock_Data s ON g.IssueID = s.StockID INNER JOIN " +
                " dbo.Products p on " +
                    " p.PK = s.ProductID " +
                    " where  g.IssueID ='" + issueId + "'" +
                    " group by g.IssueID,g.IssueDate,g.GatePass,g.GatePassName,g.VehicleNo," +
                    "g.IssueType, g.RegRoute ";
            dataTable = dB.GetDataTable(strsql, DBAccess.Inventory);
            data.Merge(dataTable);
            return data;
        }

        public DataTable GetStockDataToPrint( string IssueId)
        {
            strsql = " select '0' as DocType, 0 ind, ' ' StockId, GetDate()STockDate,0 costid,s.StockType , s.ProductID ," +
                " p.SellingPrice Price, 0.00 Dr, Sum(s.Cr) Cr,' ' AcCode,  0 ExpCode,0 GatePass,' ' GatePassName, 0 BLregNo, " +
                " p.ProductName as ItemName,' ' as SupplierName , ' ' RouteName from " +
                "  InventoryDB.dbo.Stock_Data s inner join InventoryDB.dbo.Products p on s.ProductID = p.PK " +
                 "  where s.StockID = '" + IssueId+"'" +
                " Group by s.StockType , s.ProductID , p.SellingPrice,p.ProductName" ;
            dB = new DBAccess();
            DataTable dataTable = new DataTable();
            data = null;
            data = new DataTable();
            dataTable = dB.GetDataTable(strsql, DBAccess.Inventory);
            data.Merge(dataTable);
            strsql = " select '1' as DocType, s.*,p.ProductName as ItemName, m.regName as SupplierName , m.RouteName from " +
               " InventoryDB.dbo.Stock_Data s inner join InventoryDB.dbo.Products p on s.ProductID= p.PK inner join LedgerBl.dbo.Main_Reg m " +
               " on s.BLregNo = m.regNo where s.StockID = '" + IssueId + "'";
            dataTable = dB.GetDataTable(strsql, DBAccess.Inventory);
            data.Merge(dataTable);
           
            return data;
        }

        public ICollection<GeneralIssue>GetGeneralIssues(DateTime issueDate)
        {
            generalIssues = new HashSet<GeneralIssue>();
            strsql = " Select * from GenaralIssues Where Month(IssueDate)=" + issueDate.Month + " AND " +
               "Year(IssueDate)=" +issueDate.Year + " AND  Day(IssueDate)=" + issueDate.Day;
            dB = new DBAccess();
            //command = new OleDbCommand();
            //command.CommandText = strsql;
            data = new DataTable();
            data = dB.GetDataTable(strsql, DBAccess.Inventory);
            foreach (DataRow dr in data.Rows)
            {
                generalIssue = new GeneralIssue();
                generalIssue.IssueID = dr["IssueID"].ToString();
                generalIssue.IssueDate = DateTime.Parse(dr["IssueDate"].ToString());
                generalIssue.AccID= int.Parse(dr["AccID"].ToString());
                generalIssue.Amount=double.Parse( dr["Amount"].ToString());
                generalIssue.RegNo=int.Parse( dr["RegNo"].ToString());
                generalIssue.RegName= dr["RegName"].ToString();
                generalIssue.RegRoute= dr["RegRoute"].ToString();
                generalIssue.DIscountAmt=double.Parse( dr["DIscountAmt"].ToString());
                generalIssue.DeductionAmt=double.Parse( dr["DeductionAmt"].ToString());
                generalIssue.IssueType= dr["IssueType"].ToString();
                generalIssue.GatePass=int.Parse( dr["GatePass"].ToString());
                generalIssue.GatePassName= dr["GatePassName"].ToString();
                generalIssue.VehicleNo= dr["VehicleNo"].ToString();
                generalIssue.CatFK= int.Parse(dr["CatFK"].ToString());
                generalIssues.Add(generalIssue);
            }
            return generalIssues;
        }

        public ICollection<StockItem> GetCustomStockItems( string stockId)
        {
            stockItems = new HashSet<StockItem>();
            strsql = "select * from  stock_data where StockId = '" + stockId +"'";
            dB = new DBAccess();
            data = new DataTable();
            data = dB.GetDataTable(strsql, DBAccess.Inventory);
            foreach (DataRow dr in data.Rows)
            {
                stockItem = new StockItem();
                stockItem.AcCode = dr["AcCode"].ToString();
                stockItem.BLregNo = int.Parse(dr["BLregNo"].ToString());
                stockItem.Cost = double.Parse( dr["Cost"].ToString());
                stockItem.CostID = int.Parse( dr["CostID"].ToString());
                stockItem.Cr =double.Parse( dr["Cr"].ToString());
                stockItem.Dr = double.Parse( dr["Dr"].ToString());
                stockItem.ExpCode =int.Parse( dr["ExpCode"].ToString());
                stockItem.GatePass =int.Parse( dr["GatePass"].ToString());
                stockItem.GatePassName = dr["GatePassName"].ToString();
                stockItem.Ind =int.Parse( dr["Ind"].ToString());
                stockItem.Price =double.Parse( dr["Price"].ToString());
                stockItem.ProductID =int.Parse( dr["ProductID"].ToString());
                stockItem.StockDate =DateTime.Parse( dr["StockDate"].ToString());
                stockItem.StockID = dr["StockID"].ToString();
                stockItem.StockType = dr["StockType"].ToString();
                stockItems.Add(stockItem);
            }
            return stockItems;
        }

        public void SetCustomDataTable( DateTime historyDate)
        {
            string preHeading = String.Format("{0:MMM}-{0:yyyy}", historyDate);
            hisToryTable = new DataTable();

            hisToryTable.Columns.Add(new DataColumn("RowsDesc", typeof(string)));
            hisToryTable.Columns.Add(new DataColumn("CurrentMonth", typeof(double)));
            hisToryTable.Columns.Add(new DataColumn("PrevMonth", typeof(double)));

        }

        public ICollection<LeafAdvanceRate> GetLeafAdvanceRates()
        {
            ICollection<LeafAdvanceRate> advanceRates = new HashSet<LeafAdvanceRate>();
            strsql = "Select * from AdvanceRate";
            dB = new DBAccess();
            data = new DataTable();
            data = dB.GetDataTable(strsql, DBAccess.BoughtLeaf);
            foreach( DataRow dr in data.Rows)
            {
                LeafAdvanceRate advrate = new LeafAdvanceRate();
                advrate.ind = int.Parse(dr[0].ToString());
                advrate.Rate = double.Parse(dr[1].ToString());
                advanceRates.Add(advrate);
            }
            return advanceRates;

        }
        /// <summary>
        /// DeleteAdvance Record
        /// </summary>
        /// <param name="issueid"></param>
        /// <param name="supplier"></param>
        /// <param name="trDate"></param>
        public void DeleteAdvanceRecord( string issueid, int supplier, DateTime trDate)
        {
            // Here we have think about two time issues.

            strsql ="Select Top 1 Amount from Advance_Tbl where IssueID='" + issueid + "' and year(trDate) =" + trDate.Year +
                "and month(trdate) =" + trDate.Month + " and day(trdate) = " + trDate.Day + " and regno = " + supplier;
            DataTable advAmtTable = new DataTable();
            decimal FertiAmt = 0;
            dB = new DBAccess();
            advAmtTable = dB.GetDataTable(strsql, DBAccess.BoughtLeaf);
            if (advAmtTable.Rows.Count == 1)
                FertiAmt =decimal.Parse( advAmtTable.Rows[0][0].ToString());

            strsql = "Delete From Stock_Data where StockID='" + issueid + "'and Year (StockDate) =" + trDate.Year +
            "and  month(STockdate) =" + trDate.Month + " and Day(Stockdate) = " + trDate.Day + " and BLregNo = " + supplier;
            dB.ExecuteQuery(strsql, DBAccess.Inventory);

            strsql = "Delete from Advance_Tbl where IssueID='" + issueid + "' and year(trDate) =" + trDate.Year +
                "and month(trdate) =" + trDate.Month + " and day(trdate) = " + trDate.Day + " and regno = " + supplier;
            //dB = new DBAccess();
            dB.ExecuteQuery(strsql, DBAccess.BoughtLeaf);

            strsql = "Update Main_Reg Set Fertilizer= Fertilizer - " + FertiAmt + " Where RegNo=" + supplier;
            dB.ExecuteQuery(strsql, DBAccess.BoughtLeaf);

        }

        public Advance GetAdvance( int id)
        {
            advance = new Advance();
            strsql = "Select * From Advance_Tbl where ind=" + id;
            dB = new DBAccess();
            data = new DataTable();
            data =dB.GetDataTable (strsql, DBAccess.BoughtLeaf);
            if (data.Rows.Count == 1)
            {
                advance.Amount = double.Parse(data.Rows[0]["Amount"].ToString());
                advance.crRoute = data.Rows[0]["crRoute"].ToString();
                advance.IssuedMonth = data.Rows[0]["IssuedMonth"].ToString();
                advance.IssueID = data.Rows[0]["IssueID"].ToString();
                advance.ItemID =int.Parse( data.Rows[0]["ItemID"].ToString());
                advance.LogDate = DateTime.Parse( data.Rows[0]["LogDate"].ToString());
                advance.Price = double.Parse(data.Rows[0]["Price"].ToString());
                advance.Qty = double.Parse( data.Rows[0]["Qty"].ToString());
                advance.regName = data.Rows[0]["regName"].ToString();
                advance.regNo = int.Parse( data.Rows[0]["regNo"].ToString());
                advance.Route = data.Rows[0]["Route"].ToString();
                advance.trDate =DateTime.Parse( data.Rows[0]["trDate"].ToString());
                advance.trMonth = data.Rows[0]["trMonth"].ToString();
                advance.trType = data.Rows[0]["trType"].ToString();
            }
            return advance;
        }
        public ICollection<MonthTableName> GetMonthTableNames( int cnt )
        {
            List<MonthTableName> monthTableNames= new List<MonthTableName>();
            if (cnt == 0 )
                strsql = "Select * From Month_Tbl ";
            else
                strsql = "Select top " + cnt + " * from Month_tbl order by ind desc ";
            MonthTableName tableName;
            dB = new DBAccess();
            data = new DataTable();
            data = dB.GetDataTable(strsql, DBAccess.BoughtLeaf);
            if (data.Rows.Count > 0)
            {
                foreach (DataRow dr in data.Rows)
                {
                    tableName = new MonthTableName();
                    tableName.ind = int.Parse(dr["ind"].ToString());
                    tableName.mName = dr["mName"].ToString();
                    monthTableNames.Add(tableName);
                }
            }
            return monthTableNames;
        }
        //public ICollection<MonthTableName> GetMonthTablesHistory( int cnt)
        //{
        //    strsql = "Select top " + cnt + " from Month_tbl order by ind desc ";

        //}

        public DataTable GetAdvanceSummary(string route, string DebitAcc, int ncycle)
        {
            //DataTable advsum = new DataTable();
            //strsql = " SELECT        m.TrID, m.trDate, m.RegNo, r.routeName, r.regName, r.Address, r.PayMode, r.TpNo, r.Phone1 " +
            //        " FROM Ac_TrMain AS m INNER JOIN " +
            //        "     LedgerBl.dbo.Main_Reg AS r ON m.RegNo = r.regNo " +
            //        " WHERE(m.trType = 'TR') ";
            strsql = "SELECT        m.RegNo, r.routeName, r.regName, r.Address, r.PayMode, r.TpNo, r.Phone1, COUNT(m.RegNo) AS cycle, Sum(Amount) TotalAdvance " +
                " FROM            Ac_TrMain AS m INNER JOIN  LedgerBl.dbo.Main_Reg AS r ON m.RegNo = r.regNo" +
                " INNER JOIN LedgerBl.dbo.Advance_File A on a.ListId = m.ListId " +
                "   WHERE        (m.trType = 'TR')  AND routeName LIKE '" + route +"%' AND A.drAcc Like '" + DebitAcc +"%'"+
                "   GROUP BY m.RegNo, r.routeName, r.regName, r.Address, r.PayMode, r.TpNo, r.Phone1 " +
                " HAVING COUNT(m.RegNo) >= " + ncycle;
            dB = new DBAccess();
            data = new DataTable();
            data = dB.GetDataTable(strsql, DBAccess.GL);

            return data;
        }

        public DataTable GetAdvanceDetail( int nSupplier, string DebitAcc)
        {
            strsql = "SELECT        m.RegNo, r.routeName, r.regName, r.Address, r.PayMode, r.TpNo, r.Phone1, m.TrId VoucherNo,m.TrDate [Trn.Data],  m.Amount Advance" +
               " , r.Fertilizer, r.LMB PrevDebt FROM            Ac_TrMain AS m INNER JOIN  LedgerBl.dbo.Main_Reg AS r ON m.RegNo = r.regNo" +
               " INNER JOIN LedgerBl.dbo.Advance_File A on a.ListId = m.ListId " +
               "   WHERE        (m.trType = 'TR')  AND m.RegNo = " + nSupplier + " AND A.drAcc Like '" + DebitAcc + "%'" +
               " Order by m.TrDate ";
            dB = new DBAccess();
            data = new DataTable();
            data = dB.GetDataTable(strsql, DBAccess.GL);

            return data;
        }

        public DataTable GetFiscalAccount()
        {
            strsql = " SELECT    AcName,  AcCode   FROM            Accounts_2019.dbo.Account_List " +
                " WHERE        (AcCode LIKE '1-203%') Order by AcCode";
                //"SELECT DISTINCT ACName FROM Accounts_2019.dbo.Account_List  WHERE(AcCode LIKE '[1-203%]'";
            data = new DataTable();
            data = dB.GetDataTable(strsql, DBAccess.BoughtLeaf);

            return data;
        }

    }
}
