namespace AuditReports
{
    partial class formAuditPrint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAuditPrint));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lTrnDate = new System.Windows.Forms.Label();
            this.dtFromDate = new System.Windows.Forms.DateTimePicker();
            this.dtToDate = new System.Windows.Forms.DateTimePicker();
            this.lSup = new System.Windows.Forms.Label();
            this.cbSupplier = new System.Windows.Forms.ComboBox();
            this.crv = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.bPrint = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bPrint);
            this.panel1.Controls.Add(this.cbSupplier);
            this.panel1.Controls.Add(this.lSup);
            this.panel1.Controls.Add(this.dtToDate);
            this.panel1.Controls.Add(this.dtFromDate);
            this.panel1.Controls.Add(this.lTrnDate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 69);
            this.panel1.TabIndex = 0;
            // 
            // lTrnDate
            // 
            this.lTrnDate.AutoSize = true;
            this.lTrnDate.Location = new System.Drawing.Point(30, 19);
            this.lTrnDate.Name = "lTrnDate";
            this.lTrnDate.Size = new System.Drawing.Size(69, 16);
            this.lTrnDate.TabIndex = 0;
            this.lTrnDate.Text = "Trn. Date :";
            // 
            // dtFromDate
            // 
            this.dtFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFromDate.Location = new System.Drawing.Point(106, 19);
            this.dtFromDate.Name = "dtFromDate";
            this.dtFromDate.Size = new System.Drawing.Size(101, 22);
            this.dtFromDate.TabIndex = 1;
            // 
            // dtToDate
            // 
            this.dtToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtToDate.Location = new System.Drawing.Point(213, 19);
            this.dtToDate.Name = "dtToDate";
            this.dtToDate.Size = new System.Drawing.Size(101, 22);
            this.dtToDate.TabIndex = 2;
            // 
            // lSup
            // 
            this.lSup.AutoSize = true;
            this.lSup.Location = new System.Drawing.Point(332, 21);
            this.lSup.Name = "lSup";
            this.lSup.Size = new System.Drawing.Size(64, 16);
            this.lSup.TabIndex = 3;
            this.lSup.Text = "Supplier :";
            // 
            // cbSupplier
            // 
            this.cbSupplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbSupplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSupplier.FormattingEnabled = true;
            this.cbSupplier.Location = new System.Drawing.Point(402, 16);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(295, 24);
            this.cbSupplier.TabIndex = 4;
            // 
            // crv
            // 
            this.crv.ActiveViewIndex = -1;
            this.crv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crv.Location = new System.Drawing.Point(0, 69);
            this.crv.Name = "crv";
            this.crv.Size = new System.Drawing.Size(883, 373);
            this.crv.TabIndex = 1;
            // 
            // bPrint
            // 
            this.bPrint.Location = new System.Drawing.Point(717, 17);
            this.bPrint.Name = "bPrint";
            this.bPrint.Size = new System.Drawing.Size(75, 23);
            this.bPrint.TabIndex = 5;
            this.bPrint.Text = "Preview";
            this.bPrint.UseVisualStyleBackColor = true;
            this.bPrint.Click += new System.EventHandler(this.bPrint_Click);
            // 
            // formAuditPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 442);
            this.Controls.Add(this.crv);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "formAuditPrint";
            this.Text = "Audit Print ";
            this.Load += new System.EventHandler(this.formAuditPrint_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbSupplier;
        private System.Windows.Forms.Label lSup;
        private System.Windows.Forms.DateTimePicker dtToDate;
        private System.Windows.Forms.DateTimePicker dtFromDate;
        private System.Windows.Forms.Label lTrnDate;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv;
        private System.Windows.Forms.Button bPrint;
    }
}