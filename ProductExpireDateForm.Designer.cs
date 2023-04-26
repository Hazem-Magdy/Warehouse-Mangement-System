namespace Project
{
    partial class ProductExpireDateForm
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
            this.storeCx = new System.Windows.Forms.ComboBox();
            this.ourstorre = new System.Windows.Forms.Label();
            this.storelabel = new System.Windows.Forms.Label();
            this.Fromlabel = new System.Windows.Forms.Label();
            this.fromDate = new System.Windows.Forms.DateTimePicker();
            this.ToDate = new System.Windows.Forms.DateTimePicker();
            this.Tolabel = new System.Windows.Forms.Label();
            this.productReport = new System.Windows.Forms.Button();
            this.report = new System.Windows.Forms.DataGridView();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImportDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.report)).BeginInit();
            this.SuspendLayout();
            // 
            // storeCx
            // 
            this.storeCx.FormattingEnabled = true;
            this.storeCx.Location = new System.Drawing.Point(214, 129);
            this.storeCx.Name = "storeCx";
            this.storeCx.Size = new System.Drawing.Size(269, 28);
            this.storeCx.TabIndex = 0;
            // 
            // ourstorre
            // 
            this.ourstorre.AutoSize = true;
            this.ourstorre.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ourstorre.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ourstorre.Location = new System.Drawing.Point(431, 22);
            this.ourstorre.Name = "ourstorre";
            this.ourstorre.Size = new System.Drawing.Size(462, 44);
            this.ourstorre.TabIndex = 13;
            this.ourstorre.Text = "Welcome to our Products Report";
            // 
            // storelabel
            // 
            this.storelabel.AutoSize = true;
            this.storelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storelabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.storelabel.Location = new System.Drawing.Point(45, 129);
            this.storelabel.Name = "storelabel";
            this.storelabel.Size = new System.Drawing.Size(119, 20);
            this.storelabel.TabIndex = 14;
            this.storelabel.Text = "Choose Store";
            // 
            // Fromlabel
            // 
            this.Fromlabel.AutoSize = true;
            this.Fromlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fromlabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Fromlabel.Location = new System.Drawing.Point(45, 202);
            this.Fromlabel.Name = "Fromlabel";
            this.Fromlabel.Size = new System.Drawing.Size(50, 20);
            this.Fromlabel.TabIndex = 15;
            this.Fromlabel.Text = "From";
            // 
            // fromDate
            // 
            this.fromDate.Location = new System.Drawing.Point(214, 202);
            this.fromDate.Name = "fromDate";
            this.fromDate.Size = new System.Drawing.Size(269, 26);
            this.fromDate.TabIndex = 16;
            // 
            // ToDate
            // 
            this.ToDate.Location = new System.Drawing.Point(214, 269);
            this.ToDate.Name = "ToDate";
            this.ToDate.Size = new System.Drawing.Size(269, 26);
            this.ToDate.TabIndex = 18;
            // 
            // Tolabel
            // 
            this.Tolabel.AutoSize = true;
            this.Tolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tolabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Tolabel.Location = new System.Drawing.Point(45, 269);
            this.Tolabel.Name = "Tolabel";
            this.Tolabel.Size = new System.Drawing.Size(29, 20);
            this.Tolabel.TabIndex = 17;
            this.Tolabel.Text = "To";
            // 
            // productReport
            // 
            this.productReport.BackColor = System.Drawing.SystemColors.Highlight;
            this.productReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productReport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.productReport.Location = new System.Drawing.Point(121, 372);
            this.productReport.Name = "productReport";
            this.productReport.Size = new System.Drawing.Size(225, 52);
            this.productReport.TabIndex = 37;
            this.productReport.Text = "Show Report";
            this.productReport.UseVisualStyleBackColor = false;
            this.productReport.Click += new System.EventHandler(this.productReport_Click);
            // 
            // report
            // 
            this.report.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.report.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.report.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductName,
            this.Code,
            this.ImportDate});
            this.report.Location = new System.Drawing.Point(517, 127);
            this.report.Name = "report";
            this.report.RowHeadersWidth = 62;
            this.report.RowTemplate.Height = 28;
            this.report.Size = new System.Drawing.Size(513, 249);
            this.report.TabIndex = 38;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "ProductName";
            this.ProductName.MinimumWidth = 8;
            this.ProductName.Name = "ProductName";
            this.ProductName.Width = 150;
            // 
            // Code
            // 
            this.Code.HeaderText = "Code";
            this.Code.MinimumWidth = 8;
            this.Code.Name = "Code";
            this.Code.Width = 150;
            // 
            // ImportDate
            // 
            this.ImportDate.HeaderText = "ImportDate";
            this.ImportDate.MinimumWidth = 8;
            this.ImportDate.Name = "ImportDate";
            this.ImportDate.Width = 150;
            // 
            // ProductExpireDateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 450);
            this.Controls.Add(this.report);
            this.Controls.Add(this.productReport);
            this.Controls.Add(this.ToDate);
            this.Controls.Add(this.Tolabel);
            this.Controls.Add(this.fromDate);
            this.Controls.Add(this.Fromlabel);
            this.Controls.Add(this.storelabel);
            this.Controls.Add(this.ourstorre);
            this.Controls.Add(this.storeCx);
            this.Name = "ProductExpireDateForm";
            this.Text = "ProductExpireDateForm";
            this.Load += new System.EventHandler(this.ProductExpireDateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.report)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox storeCx;
        private System.Windows.Forms.Label ourstorre;
        private System.Windows.Forms.Label storelabel;
        private System.Windows.Forms.Label Fromlabel;
        private System.Windows.Forms.DateTimePicker fromDate;
        private System.Windows.Forms.DateTimePicker ToDate;
        private System.Windows.Forms.Label Tolabel;
        private System.Windows.Forms.Button productReport;
        private System.Windows.Forms.DataGridView report;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImportDate;
    }
}