namespace AuditReports
{
    partial class FormChangePayMode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChangePayMode));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvBal = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bUpdate = new System.Windows.Forms.Button();
            this.lPM = new System.Windows.Forms.Label();
            this.lBal = new System.Windows.Forms.Label();
            this.cbPayM2 = new System.Windows.Forms.ComboBox();
            this.nBalance = new System.Windows.Forms.NumericUpDown();
            this.lName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lRegNo = new System.Windows.Forms.Label();
            this.nRegNo = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bApply = new System.Windows.Forms.Button();
            this.nLimitAmt = new System.Windows.Forms.NumericUpDown();
            this.lLimit = new System.Windows.Forms.Label();
            this.lMode = new System.Windows.Forms.Label();
            this.cbPayMode = new System.Windows.Forms.ComboBox();
            this.cbRoute = new System.Windows.Forms.ComboBox();
            this.lRt = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBal)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nRegNo)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nLimitAmt)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dgvBal, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.77778F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.22222F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(859, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvBal
            // 
            this.dgvBal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBal.Location = new System.Drawing.Point(3, 156);
            this.dgvBal.Name = "dgvBal";
            this.dgvBal.Size = new System.Drawing.Size(853, 291);
            this.dgvBal.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bUpdate);
            this.panel1.Controls.Add(this.lPM);
            this.panel1.Controls.Add(this.lBal);
            this.panel1.Controls.Add(this.cbPayM2);
            this.panel1.Controls.Add(this.nBalance);
            this.panel1.Controls.Add(this.lName);
            this.panel1.Controls.Add(this.tbName);
            this.panel1.Controls.Add(this.lRegNo);
            this.panel1.Controls.Add(this.nRegNo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(3, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(853, 44);
            this.panel1.TabIndex = 1;
            // 
            // bUpdate
            // 
            this.bUpdate.Location = new System.Drawing.Point(743, 24);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(75, 23);
            this.bUpdate.TabIndex = 8;
            this.bUpdate.Text = "Update";
            this.bUpdate.UseVisualStyleBackColor = true;
            this.bUpdate.Click += new System.EventHandler(this.bUpdate_Click);
            // 
            // lPM
            // 
            this.lPM.AutoSize = true;
            this.lPM.Location = new System.Drawing.Point(570, 7);
            this.lPM.Name = "lPM";
            this.lPM.Size = new System.Drawing.Size(63, 13);
            this.lPM.TabIndex = 7;
            this.lPM.Text = "Pay Mode";
            // 
            // lBal
            // 
            this.lBal.AutoSize = true;
            this.lBal.Location = new System.Drawing.Point(437, 8);
            this.lBal.Name = "lBal";
            this.lBal.Size = new System.Drawing.Size(53, 13);
            this.lBal.TabIndex = 6;
            this.lBal.Text = "Balance";
            // 
            // cbPayM2
            // 
            this.cbPayM2.FormattingEnabled = true;
            this.cbPayM2.Location = new System.Drawing.Point(531, 23);
            this.cbPayM2.Name = "cbPayM2";
            this.cbPayM2.Size = new System.Drawing.Size(206, 21);
            this.cbPayM2.TabIndex = 5;
            this.cbPayM2.SelectedIndexChanged += new System.EventHandler(this.cbPayM2_SelectedIndexChanged);
            // 
            // nBalance
            // 
            this.nBalance.Location = new System.Drawing.Point(410, 24);
            this.nBalance.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            131072});
            this.nBalance.Name = "nBalance";
            this.nBalance.Size = new System.Drawing.Size(120, 20);
            this.nBalance.TabIndex = 4;
            this.nBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(178, 8);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(39, 13);
            this.lName.TabIndex = 3;
            this.lName.Text = "Name";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(106, 24);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(303, 20);
            this.tbName.TabIndex = 2;
            // 
            // lRegNo
            // 
            this.lRegNo.AutoSize = true;
            this.lRegNo.Location = new System.Drawing.Point(30, 8);
            this.lRegNo.Name = "lRegNo";
            this.lRegNo.Size = new System.Drawing.Size(50, 13);
            this.lRegNo.TabIndex = 1;
            this.lRegNo.Text = "Reg No";
            // 
            // nRegNo
            // 
            this.nRegNo.Location = new System.Drawing.Point(9, 24);
            this.nRegNo.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nRegNo.Name = "nRegNo";
            this.nRegNo.Size = new System.Drawing.Size(97, 20);
            this.nRegNo.TabIndex = 0;
            this.nRegNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nRegNo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nRegNo_KeyUp);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bApply);
            this.panel2.Controls.Add(this.nLimitAmt);
            this.panel2.Controls.Add(this.lLimit);
            this.panel2.Controls.Add(this.lMode);
            this.panel2.Controls.Add(this.cbPayMode);
            this.panel2.Controls.Add(this.cbRoute);
            this.panel2.Controls.Add(this.lRt);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(853, 97);
            this.panel2.TabIndex = 2;
            // 
            // bApply
            // 
            this.bApply.Location = new System.Drawing.Point(334, 49);
            this.bApply.Name = "bApply";
            this.bApply.Size = new System.Drawing.Size(75, 23);
            this.bApply.TabIndex = 6;
            this.bApply.Text = "Apply";
            this.bApply.UseVisualStyleBackColor = true;
            this.bApply.Click += new System.EventHandler(this.bApply_Click);
            // 
            // nLimitAmt
            // 
            this.nLimitAmt.Location = new System.Drawing.Point(85, 49);
            this.nLimitAmt.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nLimitAmt.Name = "nLimitAmt";
            this.nLimitAmt.Size = new System.Drawing.Size(169, 20);
            this.nLimitAmt.TabIndex = 5;
            this.nLimitAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nLimitAmt.ValueChanged += new System.EventHandler(this.nLimitAmt_ValueChanged);
            this.nLimitAmt.Enter += new System.EventHandler(this.nLimitAmt_Enter);
            this.nLimitAmt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nLimitAmt_KeyUp);
            // 
            // lLimit
            // 
            this.lLimit.AutoSize = true;
            this.lLimit.Location = new System.Drawing.Point(5, 49);
            this.lLimit.Name = "lLimit";
            this.lLimit.Size = new System.Drawing.Size(73, 13);
            this.lLimit.TabIndex = 4;
            this.lLimit.Text = "Limit Amount :";
            // 
            // lMode
            // 
            this.lMode.AutoSize = true;
            this.lMode.Location = new System.Drawing.Point(349, 20);
            this.lMode.Name = "lMode";
            this.lMode.Size = new System.Drawing.Size(61, 13);
            this.lMode.TabIndex = 3;
            this.lMode.Text = "Pay Mode :";
            // 
            // cbPayMode
            // 
            this.cbPayMode.FormattingEnabled = true;
            this.cbPayMode.Location = new System.Drawing.Point(420, 17);
            this.cbPayMode.Name = "cbPayMode";
            this.cbPayMode.Size = new System.Drawing.Size(275, 21);
            this.cbPayMode.TabIndex = 2;
            this.cbPayMode.SelectedIndexChanged += new System.EventHandler(this.cbPayMode_SelectedIndexChanged);
            // 
            // cbRoute
            // 
            this.cbRoute.FormattingEnabled = true;
            this.cbRoute.Location = new System.Drawing.Point(85, 17);
            this.cbRoute.Name = "cbRoute";
            this.cbRoute.Size = new System.Drawing.Size(238, 21);
            this.cbRoute.TabIndex = 1;
            this.cbRoute.SelectedIndexChanged += new System.EventHandler(this.cbRoute_SelectedIndexChanged);
            // 
            // lRt
            // 
            this.lRt.AutoSize = true;
            this.lRt.Location = new System.Drawing.Point(37, 20);
            this.lRt.Name = "lRt";
            this.lRt.Size = new System.Drawing.Size(42, 13);
            this.lRt.TabIndex = 0;
            this.lRt.Text = "Route :";
            // 
            // FormChangePayMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormChangePayMode";
            this.Text = "Change Pay Mode";
            this.Load += new System.EventHandler(this.FormChangePayMode_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBal)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nRegNo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nLimitAmt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvBal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown nLimitAmt;
        private System.Windows.Forms.Label lLimit;
        private System.Windows.Forms.Label lMode;
        private System.Windows.Forms.ComboBox cbPayMode;
        private System.Windows.Forms.ComboBox cbRoute;
        private System.Windows.Forms.Label lRt;
        private System.Windows.Forms.NumericUpDown nBalance;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lRegNo;
        private System.Windows.Forms.NumericUpDown nRegNo;
        private System.Windows.Forms.Button bApply;
        private System.Windows.Forms.Button bUpdate;
        private System.Windows.Forms.Label lPM;
        private System.Windows.Forms.Label lBal;
        private System.Windows.Forms.ComboBox cbPayM2;
    }
}