namespace AuditReports
{
    partial class FormLeafAnalysis
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bPreview = new System.Windows.Forms.Button();
            this.cboAnalysisMnth = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboAnalysisYr = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.crv = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bPreview);
            this.panel1.Controls.Add(this.cboAnalysisMnth);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cboAnalysisYr);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 106);
            this.panel1.TabIndex = 0;
            // 
            // bPreview
            // 
            this.bPreview.Location = new System.Drawing.Point(633, 32);
            this.bPreview.Name = "bPreview";
            this.bPreview.Size = new System.Drawing.Size(128, 40);
            this.bPreview.TabIndex = 4;
            this.bPreview.Text = "Preview";
            this.bPreview.UseVisualStyleBackColor = true;
            this.bPreview.Click += new System.EventHandler(this.bPreview_Click);
            // 
            // cboAnalysisMnth
            // 
            this.cboAnalysisMnth.FormattingEnabled = true;
            this.cboAnalysisMnth.Location = new System.Drawing.Point(151, 48);
            this.cboAnalysisMnth.Name = "cboAnalysisMnth";
            this.cboAnalysisMnth.Size = new System.Drawing.Size(386, 28);
            this.cboAnalysisMnth.TabIndex = 3;
            this.cboAnalysisMnth.SelectedIndexChanged += new System.EventHandler(this.cboAnalysisMnth_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Analysis Month :";
            // 
            // cboAnalysisYr
            // 
            this.cboAnalysisYr.FormattingEnabled = true;
            this.cboAnalysisYr.Location = new System.Drawing.Point(151, 5);
            this.cboAnalysisYr.Name = "cboAnalysisYr";
            this.cboAnalysisYr.Size = new System.Drawing.Size(386, 28);
            this.cboAnalysisYr.TabIndex = 1;
            this.cboAnalysisYr.SelectedIndexChanged += new System.EventHandler(this.cboAnalysisYr_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Analysis Years :";
            // 
            // crv
            // 
            this.crv.ActiveViewIndex = -1;
            this.crv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crv.Location = new System.Drawing.Point(0, 106);
            this.crv.Name = "crv";
            this.crv.Size = new System.Drawing.Size(1000, 456);
            this.crv.TabIndex = 1;
            // 
            // FormLeafAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.crv);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormLeafAnalysis";
            this.Text = "FormLeafAnalysis";
            this.Load += new System.EventHandler(this.FormLeafAnalysis_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboAnalysisYr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bPreview;
        private System.Windows.Forms.ComboBox cboAnalysisMnth;
        private System.Windows.Forms.Label label2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv;
    }
}