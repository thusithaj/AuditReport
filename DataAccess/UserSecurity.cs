using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class UserSecurity
    {
        public int id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreateDate { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }

        DBAccess db;
        DataTable table;
        string strsql;
        public UserSecurity()
        {
            db = new DBAccess();
        }

        public DataTable Users()
        {
            strsql = "SELECT * FROM SystemUser";
            table = db.GetDataTable(strsql, DBAccess.AUDIT);
            return table;
        }

        public bool GetUser( string uid)
        {
            bool bretval = false;
            strsql = "SELECT * FROM SystemUser Where LOWER(UserName) ='" + uid.ToLower() + "'" ;
            table = db.GetDataTable(strsql, DBAccess.AUDIT);
            if (table.Rows.Count > 0)
            {
                bretval = true;
                id= int.Parse(table.Rows[0]["id"].ToString());
                UserName = table.Rows[0]["UserName"].ToString();
                Password = table.Rows[0]["UserPassword"].ToString();
                FullName= table.Rows[0]["UserFullName"].ToString();
                CreatedBy = int.Parse( table.Rows[0]["CreatedBy"].ToString());
                string dttemp = table.Rows[0]["CreatedDate"].ToString();//== "01/01/0001";
                CreateDate = table.Rows[0]["CreatedDate"].ToString()=="" ? DateTime.Now: DateTime.Parse(table.Rows[0]["CreatedDate"].ToString());
                ModifiedBy = table.Rows[0]["ModifiedBy"].ToString() =="" ? 0 :int.Parse(table.Rows[0]["ModifiedBy"].ToString());
                ModifiedDate = table.Rows[0]["ModifiedDate"].ToString() == "" ? DateTime.Now : DateTime.Parse(table.Rows[0]["ModifiedDate"].ToString());
            }
            else
                bretval = false;
            return bretval;
        }
        public bool AddUser ()
        {
            bool bretval = false;
            strsql = "Insert into SystemUser (UserName,UserPassword,UserFullName,CreatedBy, Createddate)" +
                " Values ('" + UserName + "','" + Password + "','" + FullName + "'," + CreatedBy + ",GETDATE()";
            try
            {
                db.ExecuteQuery(strsql, DBAccess.AUDIT);
                bretval = true;
            }
            catch(Exception ex)
            {
                bretval = false;
            }
            return bretval;
        }
        public bool UpdateUser()
        {
            bool bretval = false;
            strsql = "Update SystemUser Set UserPassword = @Password ,UserFullName =@FullName ,ModifiedBy=1, ModifiedDate=GETDATE() " +
                " WHERE  id =" +id;
            try
            {
                SqlParameter param1 = new SqlParameter("@Password", SqlDbType.NChar);
                param1.Value = Password;
                SqlParameter param2 = new SqlParameter("@FullName", SqlDbType.NChar);
                param2.Value = FullName;
                SqlCommand cmd = new SqlCommand(strsql);
                cmd.Parameters.Add(param1);
                cmd.Parameters.Add(param2);
                db.ExecuteQuery(cmd, DBAccess.AUDIT);
                bretval = true;
            }
            catch (Exception ex)
            {
                bretval = false;
                throw ex;
            }
            return bretval;
        }
    }
}
