namespace Project
{
    partial class TransferItemReportForm
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
            this.ourProducts = new System.Windows.Forms.Label();
            this.productlabel = new System.Windows.Forms.Label();
            this.productCx = new System.Windows.Forms.ComboBox();
            this.info = new System.Windows.Forms.DataGridView();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransferDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FromStore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToStore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quentity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fromDatelabel = new System.Windows.Forms.Label();
            this.toDatelabel = new System.Windows.Forms.Label();
            this.fromDate = new System.Windows.Forms.DateTimePicker();
            this.ToDate = new System.Windows.Forms.DateTimePicker();
            this.showReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.info)).BeginInit();
            this.SuspendLayout();
            // 
            // ourProducts
            // 
            this.ourProducts.AutoSize = true;
            this.ourProducts.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ourProducts.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ourProducts.Location = new System.Drawing.Point(411, 31);
            this.ourProducts.Name = "ourProducts";
            this.ourProducts.Size = new System.Drawing.Size(476, 44);
            this.ourProducts.TabIndex = 18;
            this.ourProducts.Text = "Welcome to Transfer Item Report";
            // 
            // productlabel
            // 
            this.productlabel.AutoSize = true;
            this.productlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productlabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.productlabel.Location = new System.Drawing.Point(23, 136);
            this.productlabel.Name = "productlabel";
            this.productlabel.Size = new System.Drawing.Size(122, 20);
            this.productlabel.TabIndex = 29;
            this.productlabel.Text = "Ptoduct Name";
            // 
            // productCx
            // 
            this.productCx.FormattingEnabled = true;
            this.productCx.Location = new System.Drawing.Point(160, 133);
            this.productCx.Name = "productCx";
            this.productCx.Size = new System.Drawing.Size(309, 28);
            this.productCx.TabIndex = 28;
            // 
            // info
            // 
            this.info.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.info.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductName,
            this.TransferDate,
            this.FromStore,
            this.ToStore,
            this.Quentity});
            this.info.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.info.Location = new System.Drawing.Point(505, 133);
            this.info.Name = "info";
            this.info.RowHeadersWidth = 62;
            this.info.RowTemplate.Height = 28;
            this.info.Size = new System.Drawing.Size(668, 233);
            this.info.TabIndex = 30;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "ProductName";
            this.ProductName.MinimumWidth = 8;
            this.ProductName.Name = "ProductName";
            this.ProductName.Width = 150;
            // 
            // TransferDate
            // 
            this.TransferDate.HeaderText = "TransferDate";
            this.TransferDate.MinimumWidth = 8;
            this.TransferDate.Name = "TransferDate";
            this.TransferDate.Width = 150;
            // 
            // FromStore
            // 
            this.FromStore.HeaderText = "FromStore";
            this.FromStore.MinimumWidth = 8;
            this.FromStore.Name = "FromStore";
            this.FromStore.Width = 150;
            // 
            // ToStore
            // 
            this.ToStore.HeaderText = "ToStore";
            this.ToStore.MinimumWidth = 8;
            this.ToStore.Name = "ToStore";
            this.ToStore.Width = 150;
            // 
            // Quentity
            // 
            this.Quentity.HeaderText = "Quentity";
            this.Quentity.MinimumWidth = 8;
            this.Quentity.Name = "Quentity";
            this.Quentity.Width = 150;
            // 
            // fromDatelabel
            // 
            this.fromDatelabel.AutoSize = true;
            this.fromDatelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromDatelabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.fromDatelabel.Location = new System.Drawing.Point(32, 190);
            this.fromDatelabel.Name = "fromDatelabel";
            this.fromDatelabel.Size = new System.Drawing.Size(94, 20);
            this.fromDatelabel.TabIndex = 31;
            this.fromDatelabel.Text = "From Date";
            // 
            // toDatelabel
            // 
            this.toDatelabel.AutoSize = true;
            this.toDatelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDatelabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.toDatelabel.Location = new System.Drawing.Point(23, 245);
            this.toDatelabel.Name = "toDatelabel";
            this.toDatelabel.Size = new System.Drawing.Size(73, 20);
            this.toDatelabel.TabIndex = 32;
            this.toDatelabel.Text = "To Date";
            // 
            // fromDate
            // 
            this.fromDate.Location = new System.Drawing.Point(160, 190);
            this.fromDate.Name = "fromDate";
            this.fromDate.Size = new System.Drawing.Size(309, 26);
            this.fromDate.TabIndex = 33;
            // 
            // ToDate
            // 
            this.ToDate.Location = new System.Drawing.Point(160, 245);
            this.ToDate.Name = "ToDate";
            this.ToDate.Size = new System.Drawing.Size(309, 26);
            this.ToDate.TabIndex = 34;
            // 
            // showReport
            // 
            this.showReport.BackColor = System.Drawing.SystemColors.Highlight;
            this.showReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showReport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.showReport.Location = new System.Drawing.Point(160, 327);
            this.showReport.Name = "showReport";
            this.showReport.Size = new System.Drawing.Size(184, 52);
            this.showReport.TabIndex = 35;
            this.showReport.Text = "Show Report";
            this.showReport.UseVisualStyleBackColor = false;
            this.showReport.Click += new System.EventHandler(this.showReport_Click);
            // 
            // TransferItemReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 450);
            this.Controls.Add(this.showReport);
            this.Controls.Add(this.ToDate);
            this.Controls.Add(this.fromDate);
            this.Controls.Add(this.toDatelabel);
            this.Controls.Add(this.fromDatelabel);
            this.Controls.Add(this.info);
            this.Controls.Add(this.productlabel);
            this.Controls.Add(this.productCx);
            this.Controls.Add(this.ourProducts);
            this.Name = "TransferItemReportForm";
            this.Text = "TransferItemReportForm";
            this.Load += new System.EventHandler(this.TransferItemReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.info)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ourProducts;
        private System.Windows.Forms.Label productlabel;
        private System.Windows.Forms.ComboBox productCx;
        private System.Windows.Forms.DataGridView info;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransferDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn FromStore;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToStore;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quentity;
        private System.Windows.Forms.Label fromDatelabel;
        private System.Windows.Forms.Label toDatelabel;
        private System.Windows.Forms.DateTimePicker fromDate;
        private System.Windows.Forms.DateTimePicker ToDate;
        private System.Windows.Forms.Button showReport;
    }
}