namespace Project
{
    partial class StoreReportForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.startDateTime = new System.Windows.Forms.DateTimePicker();
            this.ourProducts = new System.Windows.Forms.Label();
            this.startlabel = new System.Windows.Forms.Label();
            this.endlabel = new System.Windows.Forms.Label();
            this.endDateTime = new System.Windows.Forms.DateTimePicker();
            this.storeCx = new System.Windows.Forms.ComboBox();
            this.storelabel = new System.Windows.Forms.Label();
            this.showBtn = new System.Windows.Forms.Button();
            this.report = new System.Windows.Forms.DataGridView();
            this.Store = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quentity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImportDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.report)).BeginInit();
            this.SuspendLayout();
            // 
            // startDateTime
            // 
            this.startDateTime.Location = new System.Drawing.Point(174, 207);
            this.startDateTime.Name = "startDateTime";
            this.startDateTime.Size = new System.Drawing.Size(309, 26);
            this.startDateTime.TabIndex = 0;
            // 
            // ourProducts
            // 
            this.ourProducts.AutoSize = true;
            this.ourProducts.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ourProducts.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ourProducts.Location = new System.Drawing.Point(468, 31);
            this.ourProducts.Name = "ourProducts";
            this.ourProducts.Size = new System.Drawing.Size(412, 44);
            this.ourProducts.TabIndex = 16;
            this.ourProducts.Text = "Welcome to our Report Store";
            // 
            // startlabel
            // 
            this.startlabel.AutoSize = true;
            this.startlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startlabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.startlabel.Location = new System.Drawing.Point(37, 207);
            this.startlabel.Name = "startlabel";
            this.startlabel.Size = new System.Drawing.Size(93, 20);
            this.startlabel.TabIndex = 17;
            this.startlabel.Text = "Start Date";
            // 
            // endlabel
            // 
            this.endlabel.AutoSize = true;
            this.endlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endlabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.endlabel.Location = new System.Drawing.Point(37, 266);
            this.endlabel.Name = "endlabel";
            this.endlabel.Size = new System.Drawing.Size(85, 20);
            this.endlabel.TabIndex = 19;
            this.endlabel.Text = "End Date";
            // 
            // endDateTime
            // 
            this.endDateTime.Location = new System.Drawing.Point(174, 266);
            this.endDateTime.Name = "endDateTime";
            this.endDateTime.Size = new System.Drawing.Size(309, 26);
            this.endDateTime.TabIndex = 18;
            // 
            // storeCx
            // 
            this.storeCx.FormattingEnabled = true;
            this.storeCx.Location = new System.Drawing.Point(174, 133);
            this.storeCx.Name = "storeCx";
            this.storeCx.Size = new System.Drawing.Size(309, 28);
            this.storeCx.TabIndex = 20;
            // 
            // storelabel
            // 
            this.storelabel.AutoSize = true;
            this.storelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storelabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.storelabel.Location = new System.Drawing.Point(37, 136);
            this.storelabel.Name = "storelabel";
            this.storelabel.Size = new System.Drawing.Size(104, 20);
            this.storelabel.TabIndex = 21;
            this.storelabel.Text = "Store Name";
            // 
            // showBtn
            // 
            this.showBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.showBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.showBtn.Location = new System.Drawing.Point(153, 346);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(177, 58);
            this.showBtn.TabIndex = 22;
            this.showBtn.Text = "Show Report";
            this.showBtn.UseVisualStyleBackColor = false;
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // report
            // 
            this.report.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.report.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.report.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.report.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Store,
            this.Address,
            this.Manager,
            this.Product,
            this.Quentity,
            this.ImportDate});
            this.report.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.report.Location = new System.Drawing.Point(534, 133);
            this.report.Name = "report";
            this.report.RowHeadersWidth = 62;
            this.report.RowTemplate.Height = 28;
            this.report.Size = new System.Drawing.Size(656, 229);
            this.report.TabIndex = 23;
            // 
            // Store
            // 
            this.Store.HeaderText = "Store";
            this.Store.MinimumWidth = 8;
            this.Store.Name = "Store";
            this.Store.Width = 150;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.MinimumWidth = 8;
            this.Address.Name = "Address";
            this.Address.Width = 150;
            // 
            // Manager
            // 
            this.Manager.HeaderText = "Manager";
            this.Manager.MinimumWidth = 8;
            this.Manager.Name = "Manager";
            this.Manager.Width = 150;
            // 
            // Product
            // 
            this.Product.HeaderText = "Product";
            this.Product.MinimumWidth = 8;
            this.Product.Name = "Product";
            this.Product.Width = 150;
            // 
            // Quentity
            // 
            this.Quentity.HeaderText = "Quentity";
            this.Quentity.MinimumWidth = 8;
            this.Quentity.Name = "Quentity";
            this.Quentity.Width = 150;
            // 
            // ImportDate
            // 
            this.ImportDate.HeaderText = "ImportDate";
            this.ImportDate.MinimumWidth = 8;
            this.ImportDate.Name = "ImportDate";
            this.ImportDate.Width = 150;
            // 
            // StoreReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 450);
            this.Controls.Add(this.report);
            this.Controls.Add(this.showBtn);
            this.Controls.Add(this.storelabel);
            this.Controls.Add(this.storeCx);
            this.Controls.Add(this.endlabel);
            this.Controls.Add(this.endDateTime);
            this.Controls.Add(this.startlabel);
            this.Controls.Add(this.ourProducts);
            this.Controls.Add(this.startDateTime);
            this.Name = "StoreReportForm";
            this.Text = "StoreReportForm";
            this.Load += new System.EventHandler(this.StoreReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.report)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker startDateTime;
        private System.Windows.Forms.Label ourProducts;
        private System.Windows.Forms.Label startlabel;
        private System.Windows.Forms.Label endlabel;
        private System.Windows.Forms.DateTimePicker endDateTime;
        private System.Windows.Forms.ComboBox storeCx;
        private System.Windows.Forms.Label storelabel;
        private System.Windows.Forms.Button showBtn;
        private System.Windows.Forms.DataGridView report;
        private System.Windows.Forms.DataGridViewTextBoxColumn Store;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manager;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quentity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImportDate;
    }
}