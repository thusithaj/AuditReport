using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Configuration;
using System.Configuration.Install;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DBAccess
    {
        public enum DBAccessConnection
        {
            BoughtLeaf = 0,
            Inventory,
            BLHistory,
            GL

        }
        public const int BoughtLeaf = 0;
        public const int Inventory = 1;
        public const int BLHistory = 2;
        public const int GL = 3;
        public const int AUDIT = 4;
        public OleDbCommand oleDbCmd;
        public OleDbConnection oleDbBLCn;
        public OleDbConnection oleDbINVCn;
        public OleDbConnection oleDBBLPrvCn;
        public OleDbConnection oleDBGLcn;
        public SqlConnection connection;
        public SqlCommand command;


        string oledbBLCnStr;
        string oledbINVCnStr;
        string oledbBLPrvCnStr;
        string oleDBGLCnstr;
        string sqlcn;
        public string blDBname { get; set; }
        public string blPrvBDname { get; set; }
        public string InvDBname { get; set; }
        public string GLDBname { get; set; }
        DataTable table;
        public DBAccess()
        {
            oleDbCmd = new OleDbCommand();
            oleDbBLCn = new OleDbConnection();
            oleDBBLPrvCn = new OleDbConnection();
            oleDbINVCn = new OleDbConnection();
            oleDBGLcn = new OleDbConnection();
            connection = new SqlConnection();
            SetCnString();
            //oledbBLCnStr = System.Configuration.ConfigurationManager.ConnectionStrings["BLConnection"].ConnectionString;
            //oledbINVCnStr = System.Configuration.ConfigurationManager.ConnectionStrings["StockConnection"].ConnectionString;
            //oledbBLPrvCnStr = System.Configuration.ConfigurationManager.ConnectionStrings["BLPrvConnection"].ConnectionString;
            //oleDBGLCnstr = System.Configuration.ConfigurationManager.ConnectionStrings["GLConnection"].ConnectionString;
            //sqlcn = System.Configuration.ConfigurationManager.ConnectionStrings["AuditConnection"].ConnectionString;
            command = new SqlCommand();
            oleDBBLPrvCn.ConnectionString = oledbBLPrvCnStr;
            oleDbBLCn.ConnectionString = oledbBLCnStr;
            //oleDbINVCn.ConnectionString = oledbINVCnStr;
            oleDBGLcn.ConnectionString = oleDBGLCnstr;
            connection.ConnectionString = sqlcn;
            SetDBname();

        }

        private void SetCnString()
        {
            oledbBLCnStr = System.Configuration.ConfigurationManager.ConnectionStrings["BLConnection"].ConnectionString;
            oledbINVCnStr = System.Configuration.ConfigurationManager.ConnectionStrings["StockConnection"].ConnectionString;
            oledbBLPrvCnStr = System.Configuration.ConfigurationManager.ConnectionStrings["BLPrvConnection"].ConnectionString;
            oleDBGLCnstr = System.Configuration.ConfigurationManager.ConnectionStrings["GLConnection"].ConnectionString;
            sqlcn = System.Configuration.ConfigurationManager.ConnectionStrings["AuditConnection"].ConnectionString;

        }
        public DataTable GetDataTable(string strsql, int conType)
        {
            oleDbCmd.CommandText = strsql;
            OpenConnection();
            if (conType == 0)
                oleDbCmd.Connection = oleDbBLCn;
            if (conType == 1)
                oleDbCmd.Connection = oleDbINVCn;
            if (conType == 2)
                oleDbCmd.Connection = oleDBBLPrvCn;
            if (conType == 3)
                oleDbCmd.Connection = oleDBGLcn;
            if (conType == 4)
            {
                command.CommandText = strsql;
                command.Connection = connection;

            }
            //table = oleDbCmd.ExecuteReader()
            if (conType <= 3)
            {
                OleDbDataAdapter oleda = new OleDbDataAdapter();
                oleda.SelectCommand = oleDbCmd;
                table = new DataTable();
                //try 
                //{
                oleda.Fill(table);
            }
            else
            {
                SqlDataAdapter sqlda = new SqlDataAdapter();
                sqlda.SelectCommand = command;
                table = new DataTable();
                sqlda.Fill(table);
            }
            //}
            //catch( Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            CloseConnection();
            return table;
        }
        public void OpenConnection()
        {
            //if (oleDbINVCn.State == ConnectionState.Closed)
            //    oleDbINVCn.Open();
            if (oleDbBLCn.State == ConnectionState.Closed)
                oleDbBLCn.Open();
            if (oleDBBLPrvCn.State == ConnectionState.Closed)
                oleDBBLPrvCn.Open();
            //if (oleDBGLcn.State == ConnectionState.Closed)
            //    oleDBGLcn.Open();
            connection.Open();
        }
        public void OpenConnection(string customCon)
        {
            oleDbBLCn.ConnectionString = customCon;
            oleDbBLCn.Open();
        }
        public void CloseConnection()
        {
            //if (oleDbINVCn.State == ConnectionState.Open)
            //    oleDbINVCn.Close();
            if (oleDbBLCn.State == ConnectionState.Open)
                oleDbBLCn.Close();
            if (oleDBBLPrvCn.State == ConnectionState.Open)
                oleDBBLPrvCn.Close();
            if (oleDBGLcn.State == ConnectionState.Open)
                oleDBGLcn.Close();
            if (connection.State == ConnectionState.Open)
                connection.Close();
        }
        private void SetDBname()
        {
            if (oledbBLCnStr.Contains("wk"))
            {

            
            //table=GetDataBases("Databases");
            //if(table.Rows[0][0].ToString().Contains("wk") )
            //{
                blDBname = "wkBLP";
                blPrvBDname = "wkBLP";
                InvDBname = "wkINV";
                GLDBname = "wkACC";
            }
            else
            {
                blDBname = "LedgerBl";
                blPrvBDname = "LedgerBl_Prv";
                InvDBname = "InventoryDB";
                GLDBname = "AcountS_";
            }
            //blDBname = "LedgerBl";
            //blPrvBDname = "LedgerBl_Prv";
            //InvDBname = "InventoryDB";
            //GLDBname = "AcountS_";
        }
        public DataTable GetDataBases(string customcn)
        {
            OpenConnection();
            oleDbCmd.CommandText = "select [name] DBName from sys.databases where database_id > 4 order by name desc";
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            oleDbCmd.Connection = oleDbBLCn;
            adapter.SelectCommand = oleDbCmd;
            table = new DataTable();
            adapter.Fill(table);
            CloseConnection();
            return table;
        }

        public DataTable GetTables(string customcn)
        {
            OpenConnection(customcn);
            oleDbCmd.CommandText = "select [name] TabName from sys.objects where type='U'";
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            oleDbCmd.Connection = oleDbBLCn;
            adapter.SelectCommand = oleDbCmd;
            table = new DataTable();
            adapter.Fill(table);
            CloseConnection();
            return table;
        }

        public void ExecuteQuery(OleDbCommand ole, int conType)
        {
            //oleDbCmd = new OleDbCommand();
            OleDbCommand  BlCmd, blPrvCmd;
            OpenConnection();
            //oleDbCmd = ole;InvCmd,

            if (conType == 0)
            {
                BlCmd = new OleDbCommand();
                BlCmd = ole;
                BlCmd.Connection = oleDbBLCn;
                BlCmd.ExecuteNonQuery();
            }
            //if (conType == 1)
            //{
            //    InvCmd = new OleDbCommand();
            //    //InvCmd = ole;
            //    InvCmd.Connection = oleDbINVCn;
            //    InvCmd.CommandText = ole.CommandText;
            //    foreach (OleDbParameter para in ole.Parameters)
            //    {
            //        //para.
            //        InvCmd.Parameters.AddWithValue(para.ParameterName, para.Value);
            //        //InvCmd.Parameters[para.ParameterName].Value = para.Value;
            //    }
            //    InvCmd.ExecuteNonQuery();
            //}
            if (conType == 2)
            {
                blPrvCmd = new OleDbCommand();
                blPrvCmd = ole;
                blPrvCmd.Connection = oleDBBLPrvCn;
                blPrvCmd.ExecuteNonQuery();
            }
            //if (conType == 3)
            //    command.Connection = connection;
            //oleDbCmd.ExecuteNonQuery();
            CloseConnection();
        }

        public void ExecuteQuery(string query, int conType)
        {
            //oleDbCmd = new OleDbCommand();InvCmd,
            OleDbCommand  BlCmd, blPrvCmd;
            OpenConnection();
            //oleDbCmd = ole;

            if (conType == 0)
            {
                BlCmd = new OleDbCommand();
                BlCmd.CommandText = query;
                BlCmd.Connection = oleDbBLCn;
                BlCmd.ExecuteNonQuery();
            }
            //if (conType == 1)
            //{
            //    InvCmd = new OleDbCommand();
            //    //InvCmd = ole;
            //    InvCmd.Connection = oleDbINVCn;
            //    InvCmd.CommandText = query;

            //    InvCmd.ExecuteNonQuery();
            //}
            if (conType == 2)
            {
                blPrvCmd = new OleDbCommand();
                blPrvCmd.CommandText = query;
                blPrvCmd.Connection = oleDBBLPrvCn;
                blPrvCmd.ExecuteNonQuery();
            }
            //if (conType == 3)
            //    command.Connection = connection;
            //oleDbCmd.ExecuteNonQuery();
            if (conType==DBAccess.AUDIT)
            {
                command = new SqlCommand();
                command.CommandText = query;
                command.Connection = connection;
                command.ExecuteNonQuery();
            }
            CloseConnection();
        }

        public void ExecuteQuery(SqlCommand query, int conType)
        {
            OpenConnection();
            if (conType == DBAccess.AUDIT)
            {
                command = new SqlCommand();
                command = query;
                command.Connection = connection;
                command.ExecuteNonQuery();
            }
            CloseConnection();
        }

        //public static async Task ExecuteSavingTransaction(int conType, DataTable dataTable)
        //{
        //    //string connectionString = oledbBLCnStr;

        //    using (OleDbConnection connection = new OleDbConnection(connectionString))
        //    {
        //        await connection.OpenAsync();

        //        OleDbCommand command = connection.CreateCommand();
        //        OleDbTransaction transaction = null;

        //        // Start a local transaction.
        //        //transaction = await Task.Run<OleDbTransaction>(
        //        //    () => connection.BeginTransaction()
        //        //    );
        //        //transaction = connection.BeginTransaction();

        //        // Must assign both transaction object and connection
        //        // to Command object for a pending local transaction
        //        //command.Connection = connection;
        //        //command.Transaction = transaction;

        //        try
        //        {
        //            foreach (DataRow dr in dataTable.Rows)
        //            {
        //                transaction = connection.BeginTransaction();
        //                command.Connection = connection;
        //                command.Transaction = transaction;
        //                command.CommandText = " INSERT INTO SavingLedger(RegNo,RegName,Route,ItemName,Amount,Unit, ItemOrder,Qty,MainCategory)" +
        //                    " VALUES ( " + int.Parse(dr["RegNo"].ToString()) + ",'" + dr["RegName"].ToString() + "','"  + dr["Route"].ToString() +"','" +
        //                    dr["ItemName"].ToString() +"'," + double.Parse(dr["Amount"].ToString()) +",' '," + int.Parse(dr["ItemOrder"].ToString()) + "," +
        //                    0 +",'" + dr["MainCategory"].ToString() +"')";


        //                // Attempt to commit the transaction.
        //                await command.ExecuteNonQueryAsync();
        //                transaction.Commit();
        //                //await Task.Run(() => transaction.Commit());
        //                //Console.WriteLine("Records are written to database.");
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine("Commit Exception Type: {0}", ex.GetType());
        //            Console.WriteLine("  Message: {0}", ex.Message);

        //            // Attempt to roll back the transaction.
        //            try
        //            {
        //                transaction.Rollback();
        //            }
        //            catch (Exception ex2)
        //            {
        //                // This catch block will handle any errors that may have occurred
        //                // on the server that would cause the rollback to fail, such as
        //                // a closed connection.
        //                Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
        //                Console.WriteLine("  Message: {0}", ex2.Message);
        //                throw ex2;
        //            }
        //        }
        //    }
        //}
    }
}
//command.Parameters.Add(new OleDbParameter("@RegNo", OleDbType.Integer)).Value = int.Parse(dr["RegNo"].ToString());
//command.Parameters.Add(new OleDbParameter("@RegName", OleDbType.Char)).Value = dr["RegName"].ToString();
//command.Parameters.Add(new OleDbParameter("@Route", OleDbType.Char)).Value = dr["Route"].ToString();
//command.Parameters.Add(new OleDbParameter("@ItemName", OleDbType.Char)).Value = dr["ItemName"].ToString();
//command.Parameters.Add(new OleDbParameter("@Amount", OleDbType.Numeric)).Value = double.Parse( dr["Amount"].ToString());
//command.Parameters.Add(new OleDbParameter("@Unit", OleDbType.Char)).Value = " ";
//command.Parameters.Add(new OleDbParameter("@ItemOrder", OleDbType.Char)).Value = int.Parse(dr["ItemOrder"].ToString());
//command.Parameters.Add(new OleDbParameter("@Qty", OleDbType.Numeric)).Value = 0.00; //double.Parse(dr["Qty"].ToString());
//command.Parameters.Add(new OleDbParameter("@MainCategory", OleDbType.Char)).Value = dr["MainCategory"].ToString();
//command.CommandText =
//    "Insert into Region (RegionID, RegionDescription) VALUES (555, 'Description')";
//await command.ExecuteNonQueryAsync();

//command.CommandText =
//    "Insert into Region (RegionID, RegionDescription) VALUES (556, 'Description')";
//await command.ExecuteNonQueryAsync();