namespace Project
{
    partial class ProductReportForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ourProducts = new System.Windows.Forms.Label();
            this.productlabel = new System.Windows.Forms.Label();
            this.productCx = new System.Windows.Forms.ComboBox();
            this.endlabel = new System.Windows.Forms.Label();
            this.endDateTime = new System.Windows.Forms.DateTimePicker();
            this.startlabel = new System.Windows.Forms.Label();
            this.startDateTime = new System.Windows.Forms.DateTimePicker();
            this.report = new System.Windows.Forms.DataGridView();
            this.showBtn = new System.Windows.Forms.Button();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Store = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quentity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Units = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeCbx = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.report)).BeginInit();
            this.SuspendLayout();
            // 
            // ourProducts
            // 
            this.ourProducts.AutoSize = true;
            this.ourProducts.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ourProducts.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ourProducts.Location = new System.Drawing.Point(404, 27);
            this.ourProducts.Name = "ourProducts";
            this.ourProducts.Size = new System.Drawing.Size(449, 44);
            this.ourProducts.TabIndex = 17;
            this.ourProducts.Text = "Welcome to our Product Report";
            // 
            // productlabel
            // 
            this.productlabel.AutoSize = true;
            this.productlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productlabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.productlabel.Location = new System.Drawing.Point(63, 119);
            this.productlabel.Name = "productlabel";
            this.productlabel.Size = new System.Drawing.Size(122, 20);
            this.productlabel.TabIndex = 27;
            this.productlabel.Text = "Ptoduct Name";
            // 
            // productCx
            // 
            this.productCx.FormattingEnabled = true;
            this.productCx.Location = new System.Drawing.Point(200, 116);
            this.productCx.Name = "productCx";
            this.productCx.Size = new System.Drawing.Size(309, 28);
            this.productCx.TabIndex = 26;
            this.productCx.SelectedIndexChanged += new System.EventHandler(this.productCx_SelectedIndexChanged);
            // 
            // endlabel
            // 
            this.endlabel.AutoSize = true;
            this.endlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endlabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.endlabel.Location = new System.Drawing.Point(63, 249);
            this.endlabel.Name = "endlabel";
            this.endlabel.Size = new System.Drawing.Size(85, 20);
            this.endlabel.TabIndex = 25;
            this.endlabel.Text = "End Date";
            // 
            // endDateTime
            // 
            this.endDateTime.Location = new System.Drawing.Point(200, 249);
            this.endDateTime.Name = "endDateTime";
            this.endDateTime.Size = new System.Drawing.Size(309, 26);
            this.endDateTime.TabIndex = 24;
            // 
            // startlabel
            // 
            this.startlabel.AutoSize = true;
            this.startlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startlabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.startlabel.Location = new System.Drawing.Point(63, 190);
            this.startlabel.Name = "startlabel";
            this.startlabel.Size = new System.Drawing.Size(93, 20);
            this.startlabel.TabIndex = 23;
            this.startlabel.Text = "Start Date";
            // 
            // startDateTime
            // 
            this.startDateTime.Location = new System.Drawing.Point(200, 190);
            this.startDateTime.Name = "startDateTime";
            this.startDateTime.Size = new System.Drawing.Size(309, 26);
            this.startDateTime.TabIndex = 22;
            // 
            // report
            // 
            this.report.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.report.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.report.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.report.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product,
            this.Store,
            this.Code,
            this.Quentity,
            this.Units});
            this.report.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.report.Location = new System.Drawing.Point(556, 101);
            this.report.Name = "report";
            this.report.RowHeadersWidth = 62;
            this.report.RowTemplate.Height = 28;
            this.report.Size = new System.Drawing.Size(656, 229);
            this.report.TabIndex = 29;
            // 
            // showBtn
            // 
            this.showBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.showBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.showBtn.Location = new System.Drawing.Point(706, 373);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(177, 58);
            this.showBtn.TabIndex = 28;
            this.showBtn.Text = "Show Report";
            this.showBtn.UseVisualStyleBackColor = false;
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // Product
            // 
            this.Product.HeaderText = "Product";
            this.Product.MinimumWidth = 8;
            this.Product.Name = "Product";
            this.Product.Width = 150;
            // 
            // Store
            // 
            this.Store.HeaderText = "Store";
            this.Store.MinimumWidth = 8;
            this.Store.Name = "Store";
            this.Store.Width = 150;
            // 
            // Code
            // 
            this.Code.HeaderText = "Code";
            this.Code.MinimumWidth = 8;
            this.Code.Name = "Code";
            this.Code.Width = 150;
            // 
            // Quentity
            // 
            this.Quentity.HeaderText = "Quentity";
            this.Quentity.MinimumWidth = 8;
            this.Quentity.Name = "Quentity";
            this.Quentity.Width = 150;
            // 
            // Units
            // 
            this.Units.HeaderText = "Units";
            this.Units.MinimumWidth = 8;
            this.Units.Name = "Units";
            this.Units.Width = 150;
            // 
            // storeCbx
            // 
            this.storeCbx.FormattingEnabled = true;
            this.storeCbx.Location = new System.Drawing.Point(67, 293);
            this.storeCbx.Name = "storeCbx";
            this.storeCbx.Size = new System.Drawing.Size(442, 142);
            this.storeCbx.TabIndex = 30;
            // 
            // ProductReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 450);
            this.Controls.Add(this.storeCbx);
            this.Controls.Add(this.report);
            this.Controls.Add(this.showBtn);
            this.Controls.Add(this.productlabel);
            this.Controls.Add(this.productCx);
            this.Controls.Add(this.endlabel);
            this.Controls.Add(this.endDateTime);
            this.Controls.Add(this.startlabel);
            this.Controls.Add(this.startDateTime);
            this.Controls.Add(this.ourProducts);
            this.Name = "ProductReportForm";
            this.Text = "ProductReportForm";
            this.Load += new System.EventHandler(this.ProductReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.report)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ourProducts;
        private System.Windows.Forms.Label productlabel;
        private System.Windows.Forms.ComboBox productCx;
        private System.Windows.Forms.Label endlabel;
        private System.Windows.Forms.DateTimePicker endDateTime;
        private System.Windows.Forms.Label startlabel;
        private System.Windows.Forms.DateTimePicker startDateTime;
        private System.Windows.Forms.DataGridView report;
        private System.Windows.Forms.Button showBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Store;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quentity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Units;
        private System.Windows.Forms.CheckedListBox storeCbx;
    }
}