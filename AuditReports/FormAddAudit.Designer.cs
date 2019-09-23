namespace AuditReports
{
    partial class FormAddAudit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddAudit));
            this.lVNo = new System.Windows.Forms.Label();
            this.tbVNo = new System.Windows.Forms.TextBox();
            this.lAmt = new System.Windows.Forms.Label();
            this.nAmt = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tbComment = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bPrint = new System.Windows.Forms.Button();
            this.bClose = new System.Windows.Forms.Button();
            this.bModify = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.lTip = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvAC = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nAmt)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAC)).BeginInit();
            this.SuspendLayout();
            // 
            // lVNo
            // 
            this.lVNo.AutoSize = true;
            this.lVNo.Location = new System.Drawing.Point(34, 6);
            this.lVNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lVNo.Name = "lVNo";
            this.lVNo.Size = new System.Drawing.Size(95, 18);
            this.lVNo.TabIndex = 0;
            this.lVNo.Text = "Voucher No :";
            // 
            // tbVNo
            // 
            this.tbVNo.Location = new System.Drawing.Point(155, 3);
            this.tbVNo.Name = "tbVNo";
            this.tbVNo.Size = new System.Drawing.Size(210, 24);
            this.tbVNo.TabIndex = 1;
            // 
            // lAmt
            // 
            this.lAmt.AutoSize = true;
            this.lAmt.Location = new System.Drawing.Point(493, 9);
            this.lAmt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lAmt.Name = "lAmt";
            this.lAmt.Size = new System.Drawing.Size(67, 18);
            this.lAmt.TabIndex = 2;
            this.lAmt.Text = "Amount :";
            // 
            // nAmt
            // 
            this.nAmt.DecimalPlaces = 2;
            this.nAmt.Location = new System.Drawing.Point(614, 6);
            this.nAmt.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            131072});
            this.nAmt.Name = "nAmt";
            this.nAmt.Size = new System.Drawing.Size(210, 24);
            this.nAmt.TabIndex = 3;
            this.nAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Audit Comment :";
            // 
            // tbComment
            // 
            this.tbComment.Location = new System.Drawing.Point(155, 36);
            this.tbComment.Multiline = true;
            this.tbComment.Name = "tbComment";
            this.tbComment.Size = new System.Drawing.Size(669, 166);
            this.tbComment.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bPrint);
            this.panel1.Controls.Add(this.bClose);
            this.panel1.Controls.Add(this.bModify);
            this.panel1.Controls.Add(this.bAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 451);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(852, 63);
            this.panel1.TabIndex = 6;
            // 
            // bPrint
            // 
            this.bPrint.Location = new System.Drawing.Point(483, 0);
            this.bPrint.Name = "bPrint";
            this.bPrint.Size = new System.Drawing.Size(127, 63);
            this.bPrint.TabIndex = 3;
            this.bPrint.Text = "Print Audit";
            this.bPrint.UseVisualStyleBackColor = true;
            // 
            // bClose
            // 
            this.bClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.bClose.Location = new System.Drawing.Point(725, 0);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(127, 63);
            this.bClose.TabIndex = 2;
            this.bClose.Text = "Close";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // bModify
            // 
            this.bModify.Location = new System.Drawing.Point(243, 0);
            this.bModify.Name = "bModify";
            this.bModify.Size = new System.Drawing.Size(127, 63);
            this.bModify.TabIndex = 1;
            this.bModify.Text = "Modify Comment";
            this.bModify.UseVisualStyleBackColor = true;
            this.bModify.Click += new System.EventHandler(this.bModify_Click);
            // 
            // bAdd
            // 
            this.bAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.bAdd.Location = new System.Drawing.Point(0, 0);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(127, 63);
            this.bAdd.TabIndex = 0;
            this.bAdd.Text = "Add Comment";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // lTip
            // 
            this.lTip.AutoSize = true;
            this.lTip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lTip.Location = new System.Drawing.Point(157, 205);
            this.lTip.Name = "lTip";
            this.lTip.Size = new System.Drawing.Size(339, 20);
            this.lTip.TabIndex = 7;
            this.lTip.Text = "මෙම කොටුව සඳහා සිංහල භාෂාව භාවිතා කළ හැක.";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbVNo);
            this.panel2.Controls.Add(this.lTip);
            this.panel2.Controls.Add(this.lVNo);
            this.panel2.Controls.Add(this.lAmt);
            this.panel2.Controls.Add(this.tbComment);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.nAmt);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(852, 231);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvAC);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 231);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(852, 220);
            this.panel3.TabIndex = 9;
            // 
            // dgvAC
            // 
            this.dgvAC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAC.Location = new System.Drawing.Point(0, 0);
            this.dgvAC.Name = "dgvAC";
            this.dgvAC.Size = new System.Drawing.Size(852, 220);
            this.dgvAC.TabIndex = 0;
            // 
            // FormAddAudit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 514);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAddAudit";
            this.Text = "Adding Audit Comments";
            this.Load += new System.EventHandler(this.FormAddAudit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nAmt)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lVNo;
        private System.Windows.Forms.TextBox tbVNo;
        private System.Windows.Forms.Label lAmt;
        private System.Windows.Forms.NumericUpDown nAmt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbComment;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Button bModify;
        private System.Windows.Forms.Label lTip;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bPrint;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvAC;
    }
}