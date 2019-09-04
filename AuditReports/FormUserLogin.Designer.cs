namespace AuditReports
{
    partial class FormUserLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUserLogin));
            this.lUID = new System.Windows.Forms.Label();
            this.tbUID = new System.Windows.Forms.TextBox();
            this.tbPWD = new System.Windows.Forms.TextBox();
            this.lPWD = new System.Windows.Forms.Label();
            this.bLogon = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.lLChgPwd = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lUID
            // 
            this.lUID.AutoSize = true;
            this.lUID.Location = new System.Drawing.Point(89, 70);
            this.lUID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lUID.Name = "lUID";
            this.lUID.Size = new System.Drawing.Size(92, 18);
            this.lUID.TabIndex = 0;
            this.lUID.Text = "User Name :";
            // 
            // tbUID
            // 
            this.tbUID.Location = new System.Drawing.Point(184, 67);
            this.tbUID.Name = "tbUID";
            this.tbUID.Size = new System.Drawing.Size(318, 24);
            this.tbUID.TabIndex = 1;
            this.tbUID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbUID_KeyUp);
            // 
            // tbPWD
            // 
            this.tbPWD.Location = new System.Drawing.Point(184, 97);
            this.tbPWD.Name = "tbPWD";
            this.tbPWD.PasswordChar = '*';
            this.tbPWD.Size = new System.Drawing.Size(318, 24);
            this.tbPWD.TabIndex = 3;
            this.tbPWD.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbPWD_KeyUp);
            // 
            // lPWD
            // 
            this.lPWD.AutoSize = true;
            this.lPWD.Location = new System.Drawing.Point(89, 100);
            this.lPWD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lPWD.Name = "lPWD";
            this.lPWD.Size = new System.Drawing.Size(83, 18);
            this.lPWD.TabIndex = 2;
            this.lPWD.Text = "Password :";
            // 
            // bLogon
            // 
            this.bLogon.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bLogon.Location = new System.Drawing.Point(100, 194);
            this.bLogon.Name = "bLogon";
            this.bLogon.Size = new System.Drawing.Size(81, 36);
            this.bLogon.TabIndex = 4;
            this.bLogon.Text = "Log on";
            this.bLogon.UseVisualStyleBackColor = false;
            this.bLogon.Click += new System.EventHandler(this.bLogon_Click);
            // 
            // bCancel
            // 
            this.bCancel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bCancel.Location = new System.Drawing.Point(421, 194);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(81, 36);
            this.bCancel.TabIndex = 5;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = false;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // lLChgPwd
            // 
            this.lLChgPwd.AutoSize = true;
            this.lLChgPwd.Location = new System.Drawing.Point(92, 145);
            this.lLChgPwd.Name = "lLChgPwd";
            this.lLChgPwd.Size = new System.Drawing.Size(130, 18);
            this.lLChgPwd.TabIndex = 6;
            this.lLChgPwd.TabStop = true;
            this.lLChgPwd.Text = "Change Password";
            this.lLChgPwd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lLChgPwd_LinkClicked);
            // 
            // FormUserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 259);
            this.Controls.Add(this.lLChgPwd);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bLogon);
            this.Controls.Add(this.tbPWD);
            this.Controls.Add(this.lPWD);
            this.Controls.Add(this.tbUID);
            this.Controls.Add(this.lUID);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormUserLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log on";
            this.Load += new System.EventHandler(this.FormUserLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lUID;
        private System.Windows.Forms.TextBox tbUID;
        private System.Windows.Forms.TextBox tbPWD;
        private System.Windows.Forms.Label lPWD;
        private System.Windows.Forms.Button bLogon;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.LinkLabel lLChgPwd;
    }
}