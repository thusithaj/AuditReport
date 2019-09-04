namespace AuditReports
{
    partial class FormInquiry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInquiry));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbAcc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bClose = new System.Windows.Forms.Button();
            this.bPrint = new System.Windows.Forms.Button();
            this.nCycle = new System.Windows.Forms.NumericUpDown();
            this.lCycle = new System.Windows.Forms.Label();
            this.cbSupplier = new System.Windows.Forms.ComboBox();
            this.lSup = new System.Windows.Forms.Label();
            this.cbRoute = new System.Windows.Forms.ComboBox();
            this.lRoute = new System.Windows.Forms.Label();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.lPer = new System.Windows.Forms.Label();
            this.dgvAdvSumm = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nTotalAdvance = new System.Windows.Forms.NumericUpDown();
            this.ltotAdv = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nCycle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdvSumm)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nTotalAdvance)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvAdvSumm, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.77778F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.22222F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(940, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbAcc);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bClose);
            this.panel1.Controls.Add(this.bPrint);
            this.panel1.Controls.Add(this.nCycle);
            this.panel1.Controls.Add(this.lCycle);
            this.panel1.Controls.Add(this.cbSupplier);
            this.panel1.Controls.Add(this.lSup);
            this.panel1.Controls.Add(this.cbRoute);
            this.panel1.Controls.Add(this.lRoute);
            this.panel1.Controls.Add(this.dtTo);
            this.panel1.Controls.Add(this.dtFrom);
            this.panel1.Controls.Add(this.lPer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 73);
            this.panel1.TabIndex = 0;
            // 
            // cbAcc
            // 
            this.cbAcc.FormattingEnabled = true;
            this.cbAcc.Location = new System.Drawing.Point(79, 34);
            this.cbAcc.Name = "cbAcc";
            this.cbAcc.Size = new System.Drawing.Size(205, 21);
            this.cbAcc.TabIndex = 17;
            this.cbAcc.SelectedIndexChanged += new System.EventHandler(this.cbAcc_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Account :";
            // 
            // bClose
            // 
            this.bClose.Image = global::AuditReports.Properties.Resources.application_exit1;
            this.bClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bClose.Location = new System.Drawing.Point(808, 34);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(89, 47);
            this.bClose.TabIndex = 15;
            this.bClose.Text = "Close";
            this.bClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // bPrint
            // 
            this.bPrint.Image = global::AuditReports.Properties.Resources.appointment_recurring;
            this.bPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bPrint.Location = new System.Drawing.Point(691, 34);
            this.bPrint.Name = "bPrint";
            this.bPrint.Size = new System.Drawing.Size(89, 47);
            this.bPrint.TabIndex = 14;
            this.bPrint.Text = "Enquirer";
            this.bPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bPrint.UseVisualStyleBackColor = true;
            this.bPrint.Click += new System.EventHandler(this.bPrint_Click);
            // 
            // nCycle
            // 
            this.nCycle.Location = new System.Drawing.Point(346, 34);
            this.nCycle.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nCycle.Name = "nCycle";
            this.nCycle.Size = new System.Drawing.Size(99, 20);
            this.nCycle.TabIndex = 13;
            this.nCycle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nCycle.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lCycle
            // 
            this.lCycle.AutoSize = true;
            this.lCycle.Location = new System.Drawing.Point(294, 36);
            this.lCycle.Name = "lCycle";
            this.lCycle.Size = new System.Drawing.Size(46, 13);
            this.lCycle.TabIndex = 12;
            this.lCycle.Text = "Cycle :";
            // 
            // cbSupplier
            // 
            this.cbSupplier.FormattingEnabled = true;
            this.cbSupplier.Location = new System.Drawing.Point(691, 7);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(206, 21);
            this.cbSupplier.TabIndex = 11;
            // 
            // lSup
            // 
            this.lSup.AutoSize = true;
            this.lSup.Location = new System.Drawing.Point(626, 10);
            this.lSup.Name = "lSup";
            this.lSup.Size = new System.Drawing.Size(61, 13);
            this.lSup.TabIndex = 10;
            this.lSup.Text = "Supplier :";
            // 
            // cbRoute
            // 
            this.cbRoute.FormattingEnabled = true;
            this.cbRoute.Location = new System.Drawing.Point(346, 7);
            this.cbRoute.Name = "cbRoute";
            this.cbRoute.Size = new System.Drawing.Size(266, 21);
            this.cbRoute.TabIndex = 9;
            this.cbRoute.SelectedIndexChanged += new System.EventHandler(this.cbRoute_SelectedIndexChanged);
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
            // 
            // lPer
            // 
            this.lPer.AutoSize = true;
            this.lPer.Location = new System.Drawing.Point(22, 10);
            this.lPer.Name = "lPer";
            this.lPer.Size = new System.Drawing.Size(51, 13);
            this.lPer.TabIndex = 5;
            this.lPer.Text = "Period :";
            // 
            // dgvAdvSumm
            // 
            this.dgvAdvSumm.AllowUserToAddRows = false;
            this.dgvAdvSumm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdvSumm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAdvSumm.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAdvSumm.Location = new System.Drawing.Point(3, 82);
            this.dgvAdvSumm.Name = "dgvAdvSumm";
            this.dgvAdvSumm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdvSumm.Size = new System.Drawing.Size(934, 314);
            this.dgvAdvSumm.TabIndex = 1;
            this.dgvAdvSumm.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdvSumm_CellDoubleClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ltotAdv);
            this.panel2.Controls.Add(this.nTotalAdvance);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(3, 408);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(934, 39);
            this.panel2.TabIndex = 2;
            // 
            // nTotalAdvance
            // 
            this.nTotalAdvance.DecimalPlaces = 2;
            this.nTotalAdvance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nTotalAdvance.Location = new System.Drawing.Point(656, 10);
            this.nTotalAdvance.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            131072});
            this.nTotalAdvance.Name = "nTotalAdvance";
            this.nTotalAdvance.Size = new System.Drawing.Size(196, 24);
            this.nTotalAdvance.TabIndex = 0;
            this.nTotalAdvance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nTotalAdvance.ThousandsSeparator = true;
            // 
            // ltotAdv
            // 
            this.ltotAdv.AutoSize = true;
            this.ltotAdv.Location = new System.Drawing.Point(526, 12);
            this.ltotAdv.Name = "ltotAdv";
            this.ltotAdv.Size = new System.Drawing.Size(124, 18);
            this.ltotAdv.TabIndex = 1;
            this.ltotAdv.Text = "Total Advance :";
            // 
            // FormInquiry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormInquiry";
            this.Text = "Inquiry Audit";
            this.Load += new System.EventHandler(this.FormInquiry_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nCycle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdvSumm)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nTotalAdvance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvAdvSumm;
        private System.Windows.Forms.ComboBox cbRoute;
        private System.Windows.Forms.Label lRoute;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Label lPer;
        private System.Windows.Forms.ComboBox cbSupplier;
        private System.Windows.Forms.Label lSup;
        private System.Windows.Forms.NumericUpDown nCycle;
        private System.Windows.Forms.Label lCycle;
        private System.Windows.Forms.Button bPrint;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.ComboBox cbAcc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label ltotAdv;
        private System.Windows.Forms.NumericUpDown nTotalAdvance;
    }
}