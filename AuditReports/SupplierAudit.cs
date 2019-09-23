using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data;
using System.Data.SqlClient;

namespace AuditReports
{
    public class SupplierAuditMaster
    {
        public int id { get; set; }
        public int SupplierNo { get; set; }
        public string RouteName { get; set; }
        public string PayMode { get; set; }
        public string SupplierName { get; set; }
        public string SupplierAddress { get; set; }
        public string SupplierTP01 { get; set; }
        public string SupplierTP02 { get; set; }
        public DateTime LastSupplierDate { get; set; }
        public int SupplierStatus { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }

    }
    public class SupplierAudit
    {
        public int id { get; set; }
        public int SupplierId { get; set; }
        public DateTime TrnDate { get; set; }
        public float Amount { get; set; }
        public string Remarks { get; set; }
        public int LineStatus { get; set; }
        public string TrnNumber { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }

    }

    public class SupplierAuditEntry
    {
        public SupplierAuditEntry()
        {
            supplierAudits = new HashSet<SupplierAudit>();
        }
        public SupplierAuditMaster supplier { get; set; }
        public ICollection<SupplierAudit> supplierAudits { get; set; }
        string sql;
        DBAccess dB;
        public void AddAudit()
        {
            sql = "Select * from SupplierAuditMaster Where SupplierNo =" + supplier.SupplierNo;
            SqlCommand sqlcmd = new SqlCommand(sql);
            dB = new DBAccess();
            DataTable table = dB.GetDataTable(sql, DBAccess.AUDIT);
            if (table.Rows.Count == 0)
            {
                sql = "Insert Into SupplierAuditMaster (SupplierNo,	RouteName,	PayMode,	SupplierName,	SupplierAddress,	SupplierTP01,	SupplierTP02," +
                    "	LastSupplierDate,	SupplierStatus,	CreatedBy,	CreatedDate )" +
                    "Values( @SupplierNo,	@RouteName,	@PayMode,	@SupplierName,	@SupplierAddress,	@SupplierTP01,	@SupplierTP02," +
                    "	@LastSupplierDate,	@SupplierStatus,	@CreatedBy,	@CreatedDate)";
                sqlcmd = new SqlCommand(sql);
                sqlcmd.Parameters.Add("@SupplierNo", SqlDbType.Int).Value = supplier.SupplierNo;
                sqlcmd.Parameters.Add("@RouteName", SqlDbType.NChar).Value = supplier.RouteName;
                sqlcmd.Parameters.Add("@PayMode", SqlDbType.NChar).Value = supplier.PayMode;
                sqlcmd.Parameters.Add("@SupplierName", SqlDbType.NChar).Value = supplier.SupplierName;
                sqlcmd.Parameters.Add("@SupplierAddress", SqlDbType.NChar).Value = supplier.SupplierAddress;
                sqlcmd.Parameters.Add("@SupplierTP01", SqlDbType.NChar).Value = supplier.SupplierTP01;
                sqlcmd.Parameters.Add("@SupplierTP02", SqlDbType.NChar).Value = supplier.SupplierTP02;
                sqlcmd.Parameters.Add("@LastSupplierDate", SqlDbType.Date).Value = supplier.LastSupplierDate;
                sqlcmd.Parameters.Add("@SupplierStatus", SqlDbType.Int).Value = supplier.SupplierStatus;
                sqlcmd.Parameters.Add("@CreatedBy", SqlDbType.Int).Value = supplier.CreatedBy;
                sqlcmd.Parameters.Add("@CreatedDate", SqlDbType.DateTime).Value = supplier.CreatedDate;
                dB.ExecuteQuery(sqlcmd, DBAccess.AUDIT);

            }
            
            sql = "Insert Into SupplierAUditDetail ( SupplierId,	TrnDate,	Amount,	Remarks,	LineStatus,	TrnNumber," +
                "	CreatedBy,	CreatedDate) Values ( @SupplierId,	@TrnDate,	@Amount,	@Remarks,	@LineStatus,	@TrnNumber," +
                "	@CreatedBy,	@CreatedDate)";
            foreach (SupplierAudit audit in supplierAudits)
            {
                audit.SupplierId =int.Parse( table.Rows[0]["id"].ToString());
                sqlcmd = new SqlCommand(sql);
                sqlcmd.Parameters.Add("@SupplierId", SqlDbType.Int).Value = audit.SupplierId;
                sqlcmd.Parameters.Add("@TrnDate", SqlDbType.Date).Value = audit.TrnDate;
                sqlcmd.Parameters.Add("@Amount", SqlDbType.Float).Value = audit.Amount;
                sqlcmd.Parameters.Add("@Remarks", SqlDbType.NChar).Value = audit.Remarks;
                sqlcmd.Parameters.Add("@LineStatus", SqlDbType.Int).Value = audit.LineStatus;
                sqlcmd.Parameters.Add("@TrnNumber", SqlDbType.NChar).Value = audit.TrnNumber;
                sqlcmd.Parameters.Add("@CreatedBy", SqlDbType.Int).Value = audit.CreatedBy;
                sqlcmd.Parameters.Add("@CreatedDate", SqlDbType.DateTime).Value = audit.CreatedDate;
                dB.ExecuteQuery(sqlcmd, DBAccess.AUDIT);
            }
        }
        public void GetAuditEntry()
        {
            sql = " Select d.* from SupplierAuditDetail d inner join SupplierAUditMaster m on  d.SupplierId= m.id Where SupplierNo =" + supplier.SupplierNo +
                " Order by id Desc ";
            dB = new DBAccess();
            DataTable table = dB.GetDataTable(sql, DBAccess.AUDIT);
            foreach( DataRow dr in table.Rows)
            {
                SupplierAudit sa = new SupplierAudit();
                sa.id = int.Parse( dr["id"].ToString());
                sa.TrnDate = DateTime.Parse(dr["TrnDate"].ToString());
                sa.TrnNumber = dr["TrnNumber"].ToString();
                sa.Remarks = dr["Remarks"].ToString();
                sa.CreatedBy =int.Parse( dr["CreatedBy"].ToString());
                sa.CreatedDate = DateTime.Parse(dr["CreatedDate"].ToString());
                supplierAudits.Add(sa);
            }

        }
        public void UpdateAuditEntry()
        {
            sql = "Update SupplierAuditDetail Set Remarks=@Remarks ,ModifiedBy=@ModifiedBy,ModifiedDate=@ModifiedDate  Where id=@id";
            SqlCommand sqlcmd = new SqlCommand(sql);
            foreach (SupplierAudit audit in supplierAudits)
            {
                
                sqlcmd = new SqlCommand(sql);
                //sqlcmd.Parameters.Add("@SupplierId", SqlDbType.Int).Value = audit.SupplierId;
                //sqlcmd.Parameters.Add("@TrnDate", SqlDbType.Date).Value = audit.TrnDate;
                //sqlcmd.Parameters.Add("@Amount", SqlDbType.Float).Value = audit.Amount;
                sqlcmd.Parameters.Add("@Remarks", SqlDbType.NChar).Value = audit.Remarks;
                sqlcmd.Parameters.Add("@id", SqlDbType.Int).Value = audit.id;
                //sqlcmd.Parameters.Add("@TrnNumber", SqlDbType.NChar).Value = audit.TrnNumber;
                sqlcmd.Parameters.Add("@ModifiedBy", SqlDbType.Int).Value = audit.ModifiedBy;
                sqlcmd.Parameters.Add("@ModifiedDate", SqlDbType.DateTime).Value =DateTime.Now;
                dB.ExecuteQuery(sqlcmd, DBAccess.AUDIT);
            }
        }
    }

    
}
