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
    public partial class FormUserLogin : Form
    {
        EncodeSHA esha;
        UserSecurity user;

        public FormUserLogin()
        {
            InitializeComponent();
            esha = new EncodeSHA();
            user = new UserSecurity();
        }

        private void FormUserLogin_Load(object sender, EventArgs e)
        {

        }

        private void tbUID_KeyUp(object sender, KeyEventArgs e)
        {
            if ( e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }

        private void tbPWD_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }

        private void bLogon_Click(object sender, EventArgs e)
        {
            if (user.GetUser(tbUID.Text))
            {
                if (user.Password.Trim().Length == 0)
                {
                    FormChgPwd form = new FormChgPwd();
                    form.UserName = tbUID.Text;
                    form.Owner = this;
                    form.ShowDialog();
                }
                else
                {
                    string encodePwd = esha.EncodeText(tbPWD.Text).Trim();
                    string savedPwd = user.Password.Trim();
                    if (user.Password.Trim() == encodePwd)
                    {
                        RuntimeDefaults.UserName = user.UserName;
                        RuntimeDefaults.LoggedStatus = true;
                        this.Close(); 
                    }
                    else
                    {
                        MessageBox.Show("Password does not  match");
                        return;
                    }
                }
            }
            else
            {
                //Here we should add new admin user
            }
        }

        private void lLChgPwd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (user.GetUser(tbUID.Text))
            {
                if (user.Password.Trim().Length == 0)
                {
                    FormChgPwd form = new FormChgPwd();
                    form.UserName = tbUID.Text;
                    form.Owner = this;
                    form.ShowDialog();
                }
                else
                {
                    string encodePwd = esha.EncodeText(tbPWD.Text).Trim();
                    string savedPwd = user.Password.Trim();
                    if (user.Password.Trim() == encodePwd)
                    {
                        FormChgPwd form = new FormChgPwd();
                        form.UserName = tbUID.Text;
                        form.Owner = this;
                        form.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Please enter correct password to change.");
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("User Does not exists");
            }
            
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
