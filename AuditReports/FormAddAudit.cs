using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuditReports
{
    public partial class FormAddAudit : Form
    {
        public SupplierAuditMaster selSupplier { get; set; }
        public SupplierAudit audit { get; set; }
        SupplierAuditEntry auditEntry;

        bool isEdit = false, isNew = true;
        public FormAddAudit()
        {
            
            InitializeComponent();
            selSupplier = new SupplierAuditMaster();
            auditEntry = new SupplierAuditEntry();
            
        }

        private void FormAddAudit_Load(object sender, EventArgs e)
        {

            auditEntry.supplier = selSupplier;
            auditEntry.GetAuditEntry();
            if (auditEntry.supplierAudits.Count > 0)
            {
                SupplierAudit auditTemp = auditEntry.supplierAudits.Where(o => o.TrnNumber.Trim() == audit.TrnNumber).FirstOrDefault();
                tbComment.Text = auditTemp.Remarks;
                audit.Remarks = auditTemp.Remarks;
                audit.id = auditTemp.id;
                dgvAC.DataSource = auditEntry.supplierAudits.ToList();
                isEdit = true;
                isNew = false;
                
            }
            
            tbVNo.Text = audit.TrnNumber;
            nAmt.Value = (decimal)audit.Amount;
            SetButtons();
        }

        private void SetButtons()
        {
            if (isEdit)
            {
                bAdd.Enabled = false;
                bModify.Enabled = true;
            }
            if(isNew)
            {
                bModify.Enabled = false;
                bAdd.Enabled = true;
            }
        }
        private void bAdd_Click(object sender, EventArgs e)
        {
            if (!GetComments()) return;
            try
            {
                if (isNew)
                {
                    auditEntry.AddAudit();
                    MessageBox.Show("Succesfully Saved the audit comments \n ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bAdd.Enabled = false;
                }
                if (isEdit)
                {
                    auditEntry.UpdateAuditEntry();
                    MessageBox.Show("Succesfully Updated the audit comments \n ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Errors occured while saving audit comments \n " + ex.Message, "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private bool GetComments()
        {
            bool commentStat = false;
            if ( tbComment.Text.Trim().Count() == 0)
            {
                MessageBox.Show("The Comments fields cannot be empty", "No Comments", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbComment.Focus();
                commentStat = false;
            }
            else
            {
                selSupplier.CreatedBy = RuntimeDefaults.UserId;
                selSupplier.CreatedDate = DateTime.Now;
                audit.Remarks = tbComment.Text;
                if (auditEntry == null)
                {
                    auditEntry = new SupplierAuditEntry();
                    auditEntry.supplier = selSupplier;

                }
                if (isNew)
                {
                    audit.CreatedBy = RuntimeDefaults.UserId;
                    audit.CreatedDate = DateTime.Now;
                    auditEntry.supplier = selSupplier;
                    auditEntry.supplierAudits.Add(audit);
                }
                if (isEdit)
                {
                    audit.ModifiedBy = RuntimeDefaults.UserId;
                    audit.ModifiedDate = DateTime.Now;
                    SupplierAudit audittemp = auditEntry.supplierAudits.Where(o => o.id == audit.id).FirstOrDefault();
                    audittemp.Remarks = audit.Remarks;
                    audittemp.ModifiedBy = audit.ModifiedBy;
                    audittemp.ModifiedDate = audit.ModifiedDate;
                }
                
                commentStat = true;
            }
            return commentStat;
            //throw new NotImplementedException();
        }

        private void bModify_Click(object sender, EventArgs e)
        {
            if (!GetComments()) return;
            try
            {
                if (isEdit)
                {
                    auditEntry.UpdateAuditEntry();
                    MessageBox.Show("Succesfully Updated the audit comments \n ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Errors occured while saving audit comments \n " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
