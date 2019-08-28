namespace AuditReports
{
    partial class FormAdvAudit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdvAudit));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bClose = new System.Windows.Forms.Button();
            this.bPrint = new System.Windows.Forms.Button();
            this.cbReports = new System.Windows.Forms.ComboBox();
            this.lReport = new System.Windows.Forms.Label();
            this.cbSupplier = new System.Windows.Forms.ComboBox();
            this.lSup = new System.Windows.Forms.Label();
            this.cbRoute = new System.Windows.Forms.ComboBox();
            this.lRoute = new System.Windows.Forms.Label();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.lPer = new System.Windows.Forms.Label();
            this.crv = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.crv, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.70397F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.29603F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(852, 554);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bClose);
            this.panel1.Controls.Add(this.bPrint);
            this.panel1.Controls.Add(this.cbReports);
            this.panel1.Controls.Add(this.lReport);
            this.panel1.Controls.Add(this.cbSupplier);
            this.panel1.Controls.Add(this.lSup);
            this.panel1.Controls.Add(this.cbRoute);
            this.panel1.Controls.Add(this.lRoute);
            this.panel1.Controls.Add(this.dtTo);
            this.panel1.Controls.Add(this.dtFrom);
            this.panel1.Controls.Add(this.lPer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(846, 78);
            this.panel1.TabIndex = 0;
            // 
            // bClose
            // 
            this.bClose.Image = global::AuditReports.Properties.Resources.dialog_close1;
            this.bClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bClose.Location = new System.Drawing.Point(729, 36);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(89, 36);
            this.bClose.TabIndex = 10;
            this.bClose.Text = "Close";
            this.bClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // bPrint
            // 
            this.bPrint.Image = global::AuditReports.Properties.Resources.printer_6;
            this.bPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bPrint.Location = new System.Drawing.Point(634, 36);
            this.bPrint.Name = "bPrint";
            this.bPrint.Size = new System.Drawing.Size(89, 36);
            this.bPrint.TabIndex = 9;
            this.bPrint.Text = "Preview";
            this.bPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bPrint.UseVisualStyleBackColor = true;
            this.bPrint.Click += new System.EventHandler(this.bPrint_Click);
            // 
            // cbReports
            // 
            this.cbReports.FormattingEnabled = true;
            this.cbReports.Location = new System.Drawing.Point(364, 49);
            this.cbReports.Name = "cbReports";
            this.cbReports.Size = new System.Drawing.Size(264, 23);
            this.cbReports.TabIndex = 8;
            this.cbReports.SelectedIndexChanged += new System.EventHandler(this.cbReports_SelectedIndexChanged);
            // 
            // lReport
            // 
            this.lReport.AutoSize = true;
            this.lReport.Location = new System.Drawing.Point(306, 49);
            this.lReport.Name = "lReport";
            this.lReport.Size = new System.Drawing.Size(51, 15);
            this.lReport.TabIndex = 7;
            this.lReport.Text = "Report :";
            // 
            // cbSupplier
            // 
            this.cbSupplier.FormattingEnabled = true;
            this.cbSupplier.Location = new System.Drawing.Point(82, 49);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(206, 23);
            this.cbSupplier.TabIndex = 6;
            this.cbSupplier.SelectedIndexChanged += new System.EventHandler(this.cbSupplier_SelectedIndexChanged);
            // 
            // lSup
            // 
            this.lSup.AutoSize = true;
            this.lSup.Location = new System.Drawing.Point(9, 49);
            this.lSup.Name = "lSup";
            this.lSup.Size = new System.Drawing.Size(60, 15);
            this.lSup.TabIndex = 5;
            this.lSup.Text = "Supplier :";
            // 
            // cbRoute
            // 
            this.cbRoute.FormattingEnabled = true;
            this.cbRoute.Location = new System.Drawing.Point(362, 13);
            this.cbRoute.Name = "cbRoute";
            this.cbRoute.Size = new System.Drawing.Size(266, 23);
            this.cbRoute.TabIndex = 4;
            this.cbRoute.SelectedIndexChanged += new System.EventHandler(this.cbRoute_SelectedIndexChanged);
            // 
            // lRoute
            // 
            this.lRoute.AutoSize = true;
            this.lRoute.Location = new System.Drawing.Point(310, 16);
            this.lRoute.Name = "lRoute";
            this.lRoute.Size = new System.Drawing.Size(46, 15);
            this.lRoute.TabIndex = 3;
            this.lRoute.Text = "Route :";
            // 
            // dtTo
            // 
            this.dtTo.CustomFormat = "dd/MM/yyyy";
            this.dtTo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTo.Location = new System.Drawing.Point(188, 14);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(100, 21);
            this.dtTo.TabIndex = 2;
            // 
            // dtFrom
            // 
            this.dtFrom.CustomFormat = "dd/MM/yyyy";
            this.dtFrom.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFrom.Location = new System.Drawing.Point(82, 14);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(100, 21);
            this.dtFrom.TabIndex = 1;
            // 
            // lPer
            // 
            this.lPer.AutoSize = true;
            this.lPer.Location = new System.Drawing.Point(18, 15);
            this.lPer.Name = "lPer";
            this.lPer.Size = new System.Drawing.Size(50, 15);
            this.lPer.TabIndex = 0;
            this.lPer.Text = "Period :";
            // 
            // crv
            // 
            this.crv.ActiveViewIndex = -1;
            this.crv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crv.Location = new System.Drawing.Point(3, 90);
            this.crv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.crv.Name = "crv";
            this.crv.Size = new System.Drawing.Size(846, 460);
            this.crv.TabIndex = 1;
            // 
            // FormAdvAudit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 554);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormAdvAudit";
            this.Text = "Advance Audit";
            this.Load += new System.EventHandler(this.FormAdvAudit_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Label lPer;
        private System.Windows.Forms.Button bPrint;
        private System.Windows.Forms.ComboBox cbReports;
        private System.Windows.Forms.Label lReport;
        private System.Windows.Forms.ComboBox cbSupplier;
        private System.Windows.Forms.Label lSup;
        private System.Windows.Forms.ComboBox cbRoute;
        private System.Windows.Forms.Label lRoute;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Button bClose;
    }
}

