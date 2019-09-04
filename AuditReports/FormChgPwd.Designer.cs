namespace AuditReports
{
    partial class FormChgPwd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChgPwd));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bAdd = new System.Windows.Forms.Button();
            this.bChgPwd = new System.Windows.Forms.Button();
            this.bClose = new System.Windows.Forms.Button();
            this.lUID = new System.Windows.Forms.Label();
            this.tbUID = new System.Windows.Forms.TextBox();
            this.tbPWD1 = new System.Windows.Forms.TextBox();
            this.lPwd1 = new System.Windows.Forms.Label();
            this.tbPWD2 = new System.Windows.Forms.TextBox();
            this.lPWD2 = new System.Windows.Forms.Label();
            this.lFN = new System.Windows.Forms.Label();
            this.tbFullName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bClose);
            this.panel1.Controls.Add(this.bChgPwd);
            this.panel1.Controls.Add(this.bAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 339);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(873, 61);
            this.panel1.TabIndex = 0;
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(39, 4);
            this.bAdd.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(125, 57);
            this.bAdd.TabIndex = 0;
            this.bAdd.Text = "Add";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bChgPwd
            // 
            this.bChgPwd.Location = new System.Drawing.Point(366, 4);
            this.bChgPwd.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bChgPwd.Name = "bChgPwd";
            this.bChgPwd.Size = new System.Drawing.Size(125, 57);
            this.bChgPwd.TabIndex = 1;
            this.bChgPwd.Text = "Change Pwd";
            this.bChgPwd.UseVisualStyleBackColor = true;
            this.bChgPwd.Click += new System.EventHandler(this.bChgPwd_Click);
            // 
            // bClose
            // 
            this.bClose.Location = new System.Drawing.Point(693, 4);
            this.bClose.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(125, 57);
            this.bClose.TabIndex = 2;
            this.bClose.Text = "&Close";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // lUID
            // 
            this.lUID.AutoSize = true;
            this.lUID.Location = new System.Drawing.Point(142, 65);
            this.lUID.Name = "lUID";
            this.lUID.Size = new System.Drawing.Size(103, 18);
            this.lUID.TabIndex = 1;
            this.lUID.Text = "&User Name :";
            // 
            // tbUID
            // 
            this.tbUID.Location = new System.Drawing.Point(248, 63);
            this.tbUID.Name = "tbUID";
            this.tbUID.Size = new System.Drawing.Size(406, 24);
            this.tbUID.TabIndex = 2;
            // 
            // tbPWD1
            // 
            this.tbPWD1.Location = new System.Drawing.Point(248, 103);
            this.tbPWD1.Name = "tbPWD1";
            this.tbPWD1.PasswordChar = '*';
            this.tbPWD1.Size = new System.Drawing.Size(406, 24);
            this.tbPWD1.TabIndex = 4;
            // 
            // lPwd1
            // 
            this.lPwd1.AutoSize = true;
            this.lPwd1.Location = new System.Drawing.Point(152, 104);
            this.lPwd1.Name = "lPwd1";
            this.lPwd1.Size = new System.Drawing.Size(93, 18);
            this.lPwd1.TabIndex = 3;
            this.lPwd1.Text = "&Password :";
            // 
            // tbPWD2
            // 
            this.tbPWD2.Location = new System.Drawing.Point(248, 143);
            this.tbPWD2.Name = "tbPWD2";
            this.tbPWD2.PasswordChar = '*';
            this.tbPWD2.Size = new System.Drawing.Size(406, 24);
            this.tbPWD2.TabIndex = 6;
            // 
            // lPWD2
            // 
            this.lPWD2.AutoSize = true;
            this.lPWD2.Location = new System.Drawing.Point(87, 145);
            this.lPWD2.Name = "lPWD2";
            this.lPWD2.Size = new System.Drawing.Size(158, 18);
            this.lPWD2.TabIndex = 5;
            this.lPWD2.Text = "C&onfirm Password :";
            // 
            // lFN
            // 
            this.lFN.AutoSize = true;
            this.lFN.Location = new System.Drawing.Point(150, 186);
            this.lFN.Name = "lFN";
            this.lFN.Size = new System.Drawing.Size(94, 18);
            this.lFN.TabIndex = 1;
            this.lFN.Text = "&Full Name :";
            // 
            // tbFullName
            // 
            this.tbFullName.Location = new System.Drawing.Point(248, 184);
            this.tbFullName.Name = "tbFullName";
            this.tbFullName.Size = new System.Drawing.Size(406, 24);
            this.tbFullName.TabIndex = 2;
            // 
            // FormChgPwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(873, 400);
            this.Controls.Add(this.tbPWD2);
            this.Controls.Add(this.lPWD2);
            this.Controls.Add(this.tbPWD1);
            this.Controls.Add(this.lPwd1);
            this.Controls.Add(this.tbFullName);
            this.Controls.Add(this.lFN);
            this.Controls.Add(this.tbUID);
            this.Controls.Add(this.lUID);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FormChgPwd";
            this.Text = "Change /Add User && Password";
            this.Load += new System.EventHandler(this.FormChgPwd_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Button bChgPwd;
        private System.Windows.Forms.Label lUID;
        private System.Windows.Forms.TextBox tbUID;
        private System.Windows.Forms.TextBox tbPWD1;
        private System.Windows.Forms.Label lPwd1;
        private System.Windows.Forms.TextBox tbPWD2;
        private System.Windows.Forms.Label lPWD2;
        private System.Windows.Forms.Label lFN;
        private System.Windows.Forms.TextBox tbFullName;
    }
}