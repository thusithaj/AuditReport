namespace AuditReports
{
    partial class FormAdvance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdvance));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.nAcBalance = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bPrint = new System.Windows.Forms.Button();
            this.bClose = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.bEdit = new System.Windows.Forms.Button();
            this.badd = new System.Windows.Forms.Button();
            this.tbVoucherNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbChqNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nAmt = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lCrAc = new System.Windows.Forms.Label();
            this.cbDebitAc = new System.Windows.Forms.ComboBox();
            this.cbCreditAc = new System.Windows.Forms.ComboBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.cbRoute = new System.Windows.Forms.ComboBox();
            this.lRt = new System.Windows.Forms.Label();
            this.lSupNo = new System.Windows.Forms.Label();
            this.nSupNo = new System.Windows.Forms.NumericUpDown();
            this.cbAdvType = new System.Windows.Forms.ComboBox();
            this.lAdvType = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvPmt = new System.Windows.Forms.DataGridView();
            this.lAdvDate = new System.Windows.Forms.Label();
            this.dtAdvDate = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nAcBalance)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nAmt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSupNo)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPmt)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtAdvDate);
            this.panel1.Controls.Add(this.lAdvDate);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.nAcBalance);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.tbVoucherNo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbChqNo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.nAmt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lCrAc);
            this.panel1.Controls.Add(this.cbDebitAc);
            this.panel1.Controls.Add(this.cbCreditAc);
            this.panel1.Controls.Add(this.tbName);
            this.panel1.Controls.Add(this.cbRoute);
            this.panel1.Controls.Add(this.lRt);
            this.panel1.Controls.Add(this.lSupNo);
            this.panel1.Controls.Add(this.nSupNo);
            this.panel1.Controls.Add(this.cbAdvType);
            this.panel1.Controls.Add(this.lAdvType);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(845, 193);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(618, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Balance :";
            // 
            // nAcBalance
            // 
            this.nAcBalance.DecimalPlaces = 2;
            this.nAcBalance.Enabled = false;
            this.nAcBalance.Location = new System.Drawing.Point(681, 120);
            this.nAcBalance.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            131072});
            this.nAcBalance.Name = "nAcBalance";
            this.nAcBalance.Size = new System.Drawing.Size(139, 21);
            this.nAcBalance.TabIndex = 18;
            this.nAcBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nAcBalance.ThousandsSeparator = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bPrint);
            this.panel2.Controls.Add(this.bClose);
            this.panel2.Controls.Add(this.bDelete);
            this.panel2.Controls.Add(this.bSave);
            this.panel2.Controls.Add(this.bEdit);
            this.panel2.Controls.Add(this.badd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 147);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(845, 46);
            this.panel2.TabIndex = 17;
            // 
            // bPrint
            // 
            this.bPrint.Image = global::AuditReports.Properties.Resources.printer_2;
            this.bPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bPrint.Location = new System.Drawing.Point(241, 3);
            this.bPrint.Name = "bPrint";
            this.bPrint.Size = new System.Drawing.Size(75, 41);
            this.bPrint.TabIndex = 3;
            this.bPrint.Text = "Print";
            this.bPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bPrint.UseVisualStyleBackColor = true;
            // 
            // bClose
            // 
            this.bClose.Image = global::AuditReports.Properties.Resources.dialog_close;
            this.bClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bClose.Location = new System.Drawing.Point(399, 4);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(75, 41);
            this.bClose.TabIndex = 5;
            this.bClose.Text = "Close";
            this.bClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bClose.UseVisualStyleBackColor = true;
            // 
            // bDelete
            // 
            this.bDelete.Image = global::AuditReports.Properties.Resources.document_close_4;
            this.bDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bDelete.Location = new System.Drawing.Point(162, 3);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(75, 41);
            this.bDelete.TabIndex = 2;
            this.bDelete.Text = "Delete";
            this.bDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bDelete.UseVisualStyleBackColor = true;
            // 
            // bSave
            // 
            this.bSave.Image = ((System.Drawing.Image)(resources.GetObject("bSave.Image")));
            this.bSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bSave.Location = new System.Drawing.Point(320, 4);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(75, 41);
            this.bSave.TabIndex = 4;
            this.bSave.Text = "Save";
            this.bSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bEdit
            // 
            this.bEdit.Image = ((System.Drawing.Image)(resources.GetObject("bEdit.Image")));
            this.bEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bEdit.Location = new System.Drawing.Point(83, 3);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(75, 41);
            this.bEdit.TabIndex = 1;
            this.bEdit.Text = "Edit";
            this.bEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bEdit.UseVisualStyleBackColor = true;
            // 
            // badd
            // 
            this.badd.Image = ((System.Drawing.Image)(resources.GetObject("badd.Image")));
            this.badd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.badd.Location = new System.Drawing.Point(4, 3);
            this.badd.Name = "badd";
            this.badd.Size = new System.Drawing.Size(75, 41);
            this.badd.TabIndex = 0;
            this.badd.Text = "Add";
            this.badd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.badd.UseVisualStyleBackColor = true;
            this.badd.Click += new System.EventHandler(this.badd_Click);
            // 
            // tbVoucherNo
            // 
            this.tbVoucherNo.Enabled = false;
            this.tbVoucherNo.Location = new System.Drawing.Point(612, 34);
            this.tbVoucherNo.Name = "tbVoucherNo";
            this.tbVoucherNo.Size = new System.Drawing.Size(208, 21);
            this.tbVoucherNo.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(530, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Voucher No :";
            // 
            // tbChqNo
            // 
            this.tbChqNo.Location = new System.Drawing.Point(106, 118);
            this.tbChqNo.Name = "tbChqNo";
            this.tbChqNo.Size = new System.Drawing.Size(305, 21);
            this.tbChqNo.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Cheque No  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(417, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Amount :";
            // 
            // nAmt
            // 
            this.nAmt.DecimalPlaces = 2;
            this.nAmt.Location = new System.Drawing.Point(473, 118);
            this.nAmt.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            131072});
            this.nAmt.Name = "nAmt";
            this.nAmt.Size = new System.Drawing.Size(139, 21);
            this.nAmt.TabIndex = 11;
            this.nAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nAmt.ThousandsSeparator = true;
            this.nAmt.Enter += new System.EventHandler(this.nAmt_Enter);
            this.nAmt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nAmt_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(451, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Debit Ac :";
            // 
            // lCrAc
            // 
            this.lCrAc.AutoSize = true;
            this.lCrAc.Location = new System.Drawing.Point(38, 92);
            this.lCrAc.Name = "lCrAc";
            this.lCrAc.Size = new System.Drawing.Size(61, 15);
            this.lCrAc.TabIndex = 9;
            this.lCrAc.Text = "Credit Ac :";
            // 
            // cbDebitAc
            // 
            this.cbDebitAc.FormattingEnabled = true;
            this.cbDebitAc.Location = new System.Drawing.Point(514, 89);
            this.cbDebitAc.Name = "cbDebitAc";
            this.cbDebitAc.Size = new System.Drawing.Size(306, 23);
            this.cbDebitAc.TabIndex = 8;
            this.cbDebitAc.SelectedIndexChanged += new System.EventHandler(this.cbDebitAc_SelectedIndexChanged);
            // 
            // cbCreditAc
            // 
            this.cbCreditAc.FormattingEnabled = true;
            this.cbCreditAc.Location = new System.Drawing.Point(105, 89);
            this.cbCreditAc.Name = "cbCreditAc";
            this.cbCreditAc.Size = new System.Drawing.Size(306, 23);
            this.cbCreditAc.TabIndex = 7;
            this.cbCreditAc.SelectedIndexChanged += new System.EventHandler(this.cbCreditAc_SelectedIndexChanged);
            // 
            // tbName
            // 
            this.tbName.Enabled = false;
            this.tbName.Location = new System.Drawing.Point(300, 63);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(520, 21);
            this.tbName.TabIndex = 6;
            // 
            // cbRoute
            // 
            this.cbRoute.FormattingEnabled = true;
            this.cbRoute.Location = new System.Drawing.Point(300, 33);
            this.cbRoute.Name = "cbRoute";
            this.cbRoute.Size = new System.Drawing.Size(224, 23);
            this.cbRoute.TabIndex = 5;
            this.cbRoute.SelectedIndexChanged += new System.EventHandler(this.cbRoute_SelectedIndexChanged);
            this.cbRoute.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbRoute_KeyDown);
            // 
            // lRt
            // 
            this.lRt.AutoSize = true;
            this.lRt.Location = new System.Drawing.Point(248, 36);
            this.lRt.Name = "lRt";
            this.lRt.Size = new System.Drawing.Size(46, 15);
            this.lRt.TabIndex = 4;
            this.lRt.Text = "Route :";
            // 
            // lSupNo
            // 
            this.lSupNo.AutoSize = true;
            this.lSupNo.Location = new System.Drawing.Point(21, 63);
            this.lSupNo.Name = "lSupNo";
            this.lSupNo.Size = new System.Drawing.Size(78, 15);
            this.lSupNo.TabIndex = 3;
            this.lSupNo.Text = "Supplier No :";
            // 
            // nSupNo
            // 
            this.nSupNo.AutoSize = true;
            this.nSupNo.Location = new System.Drawing.Point(105, 62);
            this.nSupNo.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nSupNo.Name = "nSupNo";
            this.nSupNo.Size = new System.Drawing.Size(139, 21);
            this.nSupNo.TabIndex = 2;
            this.nSupNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nSupNo.Enter += new System.EventHandler(this.nSupNo_Enter);
            this.nSupNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nSupNo_KeyDown);
            // 
            // cbAdvType
            // 
            this.cbAdvType.FormattingEnabled = true;
            this.cbAdvType.Location = new System.Drawing.Point(105, 33);
            this.cbAdvType.Name = "cbAdvType";
            this.cbAdvType.Size = new System.Drawing.Size(139, 23);
            this.cbAdvType.TabIndex = 1;
            this.cbAdvType.SelectedIndexChanged += new System.EventHandler(this.cbAdvType_SelectedIndexChanged);
            this.cbAdvType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbAdvType_KeyDown);
            // 
            // lAdvType
            // 
            this.lAdvType.AutoSize = true;
            this.lAdvType.Location = new System.Drawing.Point(12, 36);
            this.lAdvType.Name = "lAdvType";
            this.lAdvType.Size = new System.Drawing.Size(87, 15);
            this.lAdvType.TabIndex = 0;
            this.lAdvType.Text = "Advance Type :";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvPmt);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 193);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(845, 326);
            this.panel3.TabIndex = 1;
            // 
            // dgvPmt
            // 
            this.dgvPmt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPmt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPmt.Location = new System.Drawing.Point(0, 0);
            this.dgvPmt.Name = "dgvPmt";
            this.dgvPmt.Size = new System.Drawing.Size(845, 326);
            this.dgvPmt.TabIndex = 2;
            // 
            // lAdvDate
            // 
            this.lAdvDate.AutoSize = true;
            this.lAdvDate.Location = new System.Drawing.Point(12, 9);
            this.lAdvDate.Name = "lAdvDate";
            this.lAdvDate.Size = new System.Drawing.Size(88, 15);
            this.lAdvDate.TabIndex = 20;
            this.lAdvDate.Text = "Advance Date :";
            // 
            // dtAdvDate
            // 
            this.dtAdvDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtAdvDate.Location = new System.Drawing.Point(107, 9);
            this.dtAdvDate.Name = "dtAdvDate";
            this.dtAdvDate.Size = new System.Drawing.Size(137, 21);
            this.dtAdvDate.TabIndex = 21;
            this.dtAdvDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtAdvDate_KeyDown);
            // 
            // FormAdvance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 519);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAdvance";
            this.Text = "Form Advance";
            this.Load += new System.EventHandler(this.FormAdvance_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nAcBalance)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nAmt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSupNo)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPmt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lAdvType;
        private System.Windows.Forms.ComboBox cbAdvType;
        private System.Windows.Forms.Label lSupNo;
        private System.Windows.Forms.NumericUpDown nSupNo;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.ComboBox cbRoute;
        private System.Windows.Forms.Label lRt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lCrAc;
        private System.Windows.Forms.ComboBox cbDebitAc;
        private System.Windows.Forms.ComboBox cbCreditAc;
        private System.Windows.Forms.NumericUpDown nAmt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbChqNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbVoucherNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bPrint;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.Button badd;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvPmt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nAcBalance;
        private System.Windows.Forms.DateTimePicker dtAdvDate;
        private System.Windows.Forms.Label lAdvDate;
    }
}