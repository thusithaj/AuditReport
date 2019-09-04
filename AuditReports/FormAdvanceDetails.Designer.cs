namespace AuditReports
{
    partial class FormAdvanceDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdvanceDetails));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nBalance = new System.Windows.Forms.NumericUpDown();
            this.nPayAmt = new System.Windows.Forms.NumericUpDown();
            this.lKgs = new System.Windows.Forms.Label();
            this.nQty = new System.Windows.Forms.NumericUpDown();
            this.cbUnitCost = new System.Windows.Forms.ComboBox();
            this.lKgAmt = new System.Windows.Forms.Label();
            this.tbTpNo2 = new System.Windows.Forms.TextBox();
            this.tbTPNo1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSupNo = new System.Windows.Forms.TextBox();
            this.tbRoute = new System.Windows.Forms.TextBox();
            this.lAddr = new System.Windows.Forms.Label();
            this.bClose = new System.Windows.Forms.Button();
            this.bPrint = new System.Windows.Forms.Button();
            this.nTotalAdvance = new System.Windows.Forms.NumericUpDown();
            this.lCycle = new System.Windows.Forms.Label();
            this.lSup = new System.Windows.Forms.Label();
            this.lRoute = new System.Windows.Forms.Label();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.lPer = new System.Windows.Forms.Label();
            this.dgvAdvDetail = new System.Windows.Forms.DataGridView();
            this.lPM = new System.Windows.Forms.Label();
            this.tbPayMode = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPayAmt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTotalAdvance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdvDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvAdvDetail, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.05634F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.94366F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1149, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1143, 111);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbPayMode);
            this.panel2.Controls.Add(this.lPM);
            this.panel2.Controls.Add(this.nBalance);
            this.panel2.Controls.Add(this.nPayAmt);
            this.panel2.Controls.Add(this.lKgs);
            this.panel2.Controls.Add(this.nQty);
            this.panel2.Controls.Add(this.cbUnitCost);
            this.panel2.Controls.Add(this.lKgAmt);
            this.panel2.Controls.Add(this.tbTpNo2);
            this.panel2.Controls.Add(this.tbTPNo1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tbAddress);
            this.panel2.Controls.Add(this.tbName);
            this.panel2.Controls.Add(this.tbSupNo);
            this.panel2.Controls.Add(this.tbRoute);
            this.panel2.Controls.Add(this.lAddr);
            this.panel2.Controls.Add(this.bClose);
            this.panel2.Controls.Add(this.bPrint);
            this.panel2.Controls.Add(this.nTotalAdvance);
            this.panel2.Controls.Add(this.lCycle);
            this.panel2.Controls.Add(this.lSup);
            this.panel2.Controls.Add(this.lRoute);
            this.panel2.Controls.Add(this.dtTo);
            this.panel2.Controls.Add(this.dtFrom);
            this.panel2.Controls.Add(this.lPer);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1143, 111);
            this.panel2.TabIndex = 1;
            // 
            // nBalance
            // 
            this.nBalance.DecimalPlaces = 2;
            this.nBalance.Location = new System.Drawing.Point(799, 60);
            this.nBalance.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            131072});
            this.nBalance.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nBalance.Name = "nBalance";
            this.nBalance.Size = new System.Drawing.Size(147, 20);
            this.nBalance.TabIndex = 29;
            this.nBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nBalance.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nPayAmt
            // 
            this.nPayAmt.DecimalPlaces = 2;
            this.nPayAmt.Location = new System.Drawing.Point(646, 60);
            this.nPayAmt.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            131072});
            this.nPayAmt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nPayAmt.Name = "nPayAmt";
            this.nPayAmt.Size = new System.Drawing.Size(147, 20);
            this.nPayAmt.TabIndex = 28;
            this.nPayAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nPayAmt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lKgs
            // 
            this.lKgs.AutoSize = true;
            this.lKgs.Location = new System.Drawing.Point(501, 65);
            this.lKgs.Name = "lKgs";
            this.lKgs.Size = new System.Drawing.Size(34, 13);
            this.lKgs.TabIndex = 27;
            this.lKgs.Text = "Qty :";
            // 
            // nQty
            // 
            this.nQty.DecimalPlaces = 2;
            this.nQty.Location = new System.Drawing.Point(541, 60);
            this.nQty.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            131072});
            this.nQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nQty.Name = "nQty";
            this.nQty.Size = new System.Drawing.Size(99, 20);
            this.nQty.TabIndex = 26;
            this.nQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbUnitCost
            // 
            this.cbUnitCost.FormattingEnabled = true;
            this.cbUnitCost.Location = new System.Drawing.Point(374, 60);
            this.cbUnitCost.Name = "cbUnitCost";
            this.cbUnitCost.Size = new System.Drawing.Size(121, 21);
            this.cbUnitCost.TabIndex = 25;
            // 
            // lKgAmt
            // 
            this.lKgAmt.AutoSize = true;
            this.lKgAmt.Location = new System.Drawing.Point(294, 63);
            this.lKgAmt.Name = "lKgAmt";
            this.lKgAmt.Size = new System.Drawing.Size(71, 13);
            this.lKgAmt.TabIndex = 24;
            this.lKgAmt.Text = "Unit Cost : ";
            // 
            // tbTpNo2
            // 
            this.tbTpNo2.Location = new System.Drawing.Point(799, 34);
            this.tbTpNo2.Name = "tbTpNo2";
            this.tbTpNo2.Size = new System.Drawing.Size(147, 20);
            this.tbTpNo2.TabIndex = 23;
            // 
            // tbTPNo1
            // 
            this.tbTPNo1.Location = new System.Drawing.Point(646, 35);
            this.tbTPNo1.Name = "tbTPNo1";
            this.tbTPNo1.Size = new System.Drawing.Size(147, 20);
            this.tbTPNo1.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(579, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "T.P No :";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(78, 34);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(495, 20);
            this.tbAddress.TabIndex = 20;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(733, 10);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(403, 20);
            this.tbName.TabIndex = 19;
            // 
            // tbSupNo
            // 
            this.tbSupNo.Location = new System.Drawing.Point(646, 9);
            this.tbSupNo.Name = "tbSupNo";
            this.tbSupNo.Size = new System.Drawing.Size(81, 20);
            this.tbSupNo.TabIndex = 18;
            // 
            // tbRoute
            // 
            this.tbRoute.Location = new System.Drawing.Point(349, 8);
            this.tbRoute.Name = "tbRoute";
            this.tbRoute.Size = new System.Drawing.Size(224, 20);
            this.tbRoute.TabIndex = 17;
            // 
            // lAddr
            // 
            this.lAddr.AutoSize = true;
            this.lAddr.Location = new System.Drawing.Point(21, 35);
            this.lAddr.Name = "lAddr";
            this.lAddr.Size = new System.Drawing.Size(60, 13);
            this.lAddr.TabIndex = 16;
            this.lAddr.Text = "Address :";
            // 
            // bClose
            // 
            this.bClose.Image = global::AuditReports.Properties.Resources.application_exit1;
            this.bClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bClose.Location = new System.Drawing.Point(1047, 50);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(89, 55);
            this.bClose.TabIndex = 15;
            this.bClose.Text = "Close";
            this.bClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // bPrint
            // 
            this.bPrint.Image = global::AuditReports.Properties.Resources.books;
            this.bPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bPrint.Location = new System.Drawing.Point(952, 53);
            this.bPrint.Name = "bPrint";
            this.bPrint.Size = new System.Drawing.Size(89, 52);
            this.bPrint.TabIndex = 14;
            this.bPrint.Text = "Enquirer";
            this.bPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bPrint.UseVisualStyleBackColor = true;
            this.bPrint.Click += new System.EventHandler(this.bPrint_Click);
            // 
            // nTotalAdvance
            // 
            this.nTotalAdvance.DecimalPlaces = 2;
            this.nTotalAdvance.Location = new System.Drawing.Point(122, 58);
            this.nTotalAdvance.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            131072});
            this.nTotalAdvance.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nTotalAdvance.Name = "nTotalAdvance";
            this.nTotalAdvance.Size = new System.Drawing.Size(162, 20);
            this.nTotalAdvance.TabIndex = 13;
            this.nTotalAdvance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nTotalAdvance.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lCycle
            // 
            this.lCycle.AutoSize = true;
            this.lCycle.Location = new System.Drawing.Point(21, 60);
            this.lCycle.Name = "lCycle";
            this.lCycle.Size = new System.Drawing.Size(102, 13);
            this.lCycle.TabIndex = 12;
            this.lCycle.Text = "Total Advance : ";
            // 
            // lSup
            // 
            this.lSup.AutoSize = true;
            this.lSup.Location = new System.Drawing.Point(579, 13);
            this.lSup.Name = "lSup";
            this.lSup.Size = new System.Drawing.Size(61, 13);
            this.lSup.TabIndex = 10;
            this.lSup.Text = "Supplier :";
            // 
            // lRoute
            // 
            this.lRoute.AutoSize = true;
            this.lRoute.Location = new System.Drawing.Point(294, 10);
            this.lRoute.Name = "lRoute";
            this.lRoute.Size = new System.Drawing.Size(49, 13);
            this.lRoute.TabIndex = 8;
            this.lRoute.Text = "Route :";
            // 
            // dtTo
            // 
            this.dtTo.CustomFormat = "dd/MM/yyyy";
            this.dtTo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTo.Location = new System.Drawing.Point(184, 7);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(100, 21);
            this.dtTo.TabIndex = 7;
            // 
            // dtFrom
            // 
            this.dtFrom.CustomFormat = "dd/MM/yyyy";
            this.dtFrom.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFrom.Location = new System.Drawing.Point(78, 7);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(100, 21);
            this.dtFrom.TabIndex = 6;
            this.dtFrom.ValueChanged += new System.EventHandler(this.dtFrom_ValueChanged);
            // 
            // lPer
            // 
            this.lPer.AutoSize = true;
            this.lPer.Location = new System.Drawing.Point(21, 10);
            this.lPer.Name = "lPer";
            this.lPer.Size = new System.Drawing.Size(51, 13);
            this.lPer.TabIndex = 5;
            this.lPer.Text = "Period :";
            // 
            // dgvAdvDetail
            // 
            this.dgvAdvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdvDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAdvDetail.Location = new System.Drawing.Point(3, 120);
            this.dgvAdvDetail.Name = "dgvAdvDetail";
            this.dgvAdvDetail.Size = new System.Drawing.Size(1143, 327);
            this.dgvAdvDetail.TabIndex = 1;
            // 
            // lPM
            // 
            this.lPM.AutoSize = true;
            this.lPM.Location = new System.Drawing.Point(21, 83);
            this.lPM.Name = "lPM";
            this.lPM.Size = new System.Drawing.Size(75, 13);
            this.lPM.TabIndex = 30;
            this.lPM.Text = "Pay Mode : ";
            // 
            // tbPayMode
            // 
            this.tbPayMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPayMode.Location = new System.Drawing.Point(122, 80);
            this.tbPayMode.Name = "tbPayMode";
            this.tbPayMode.Size = new System.Drawing.Size(162, 20);
            this.tbPayMode.TabIndex = 31;
            // 
            // FormAdvanceDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAdvanceDetails";
            this.Text = "Advance Details";
            this.Load += new System.EventHandler(this.FormAdvanceDetails_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPayAmt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTotalAdvance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdvDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvAdvDetail;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lAddr;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Button bPrint;
        private System.Windows.Forms.NumericUpDown nTotalAdvance;
        private System.Windows.Forms.Label lCycle;
        private System.Windows.Forms.Label lSup;
        private System.Windows.Forms.Label lRoute;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Label lPer;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbSupNo;
        private System.Windows.Forms.TextBox tbRoute;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbTPNo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nBalance;
        private System.Windows.Forms.NumericUpDown nPayAmt;
        private System.Windows.Forms.Label lKgs;
        private System.Windows.Forms.NumericUpDown nQty;
        private System.Windows.Forms.ComboBox cbUnitCost;
        private System.Windows.Forms.Label lKgAmt;
        private System.Windows.Forms.TextBox tbTpNo2;
        private System.Windows.Forms.TextBox tbPayMode;
        private System.Windows.Forms.Label lPM;
    }
}