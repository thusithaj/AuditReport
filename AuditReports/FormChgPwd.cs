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
    public partial class FormChgPwd : Form
    {
        UserSecurity usec;
        EncodeSHA es;
        public string UserName { get; set; }
        public FormChgPwd()
        {
            InitializeComponent();
            usec = new UserSecurity();
            es = new EncodeSHA();
        }

        private void FormChgPwd_Load(object sender, EventArgs e)
        {
            if (UserName != "")
            {
                tbUID.Text = UserName;
                bAdd.Enabled = false;
                bChgPwd.Enabled = true;
                usec.GetUser(UserName);
                tbFullName.Text = usec.FullName;
                tbUID.Enabled = false;
            }
            else
            {
                bAdd.Enabled = true;
                bChgPwd.Enabled = false;
                tbUID.Enabled = true;
            }
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            if (!CheckPWDValidity())
            {
                MessageBox.Show("Password do not match", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (tbFullName.Text == "")
            {
                MessageBox.Show("Full name cannot be empty", "Full name Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            usec.UserName = tbUID.Text;
            usec.Password = es.EncodeText(tbPWD1.Text);
            usec.FullName = tbFullName.Text;
            usec.CreatedBy = 1;
            try
            {
                usec.AddUser();
                MessageBox.Show("Record Saved ", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch( Exception ex)
            {
                MessageBox.Show("Saving returned and error \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private bool CheckPWDValidity()
        {
            bool pValid = false;
            if (tbPWD1.Text == tbPWD2.Text)
                pValid = true;
            return pValid;
            //throw new NotImplementedException();
        }

        private void bChgPwd_Click(object sender, EventArgs e)
        {
            if (!CheckPWDValidity())
            {
                MessageBox.Show("Password do not match", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (tbFullName.Text == "")
            {
                MessageBox.Show("Full name cannot be empty", "Full name Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            usec.UserName = tbUID.Text;
            usec.Password = es.EncodeText(tbPWD1.Text);
            usec.FullName = tbFullName.Text;
            usec.CreatedBy = 1;
            try
            {
                usec.UpdateUser();//usec.AddUser();
                MessageBox.Show("Record Updated  ", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Updating returned and error \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
