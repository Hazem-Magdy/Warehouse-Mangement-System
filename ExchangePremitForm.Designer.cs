namespace Project
{
    partial class ExchangePremitForm
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
            this.idTx = new System.Windows.Forms.TextBox();
            this.IDlabel = new System.Windows.Forms.Label();
            this.premitNum = new System.Windows.Forms.TextBox();
            this.premitNumber = new System.Windows.Forms.Label();
            this.premitdateTime = new System.Windows.Forms.DateTimePicker();
            this.premitDate = new System.Windows.Forms.Label();
            this.storeTx = new System.Windows.Forms.ComboBox();
            this.storelabel = new System.Windows.Forms.Label();
            this.supplierlabel = new System.Windows.Forms.Label();
            this.supplierTx = new System.Windows.Forms.ComboBox();
            this.Itemlabel = new System.Windows.Forms.Label();
            this.productsTx = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quentity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addPremitBtn = new System.Windows.Forms.Button();
            this.updatePremitBtn = new System.Windows.Forms.Button();
            this.Show_Exchange_Premits = new System.Windows.Forms.ListBox();
            this.showBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productsTx)).BeginInit();
            this.SuspendLayout();
            // 
            // ourProducts
            // 
            this.ourProducts.AutoSize = true;
            this.ourProducts.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ourProducts.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ourProducts.Location = new System.Drawing.Point(424, 9);
            this.ourProducts.Name = "ourProducts";
            this.ourProducts.Size = new System.Drawing.Size(470, 44);
            this.ourProducts.TabIndex = 15;
            this.ourProducts.Text = "Welcome to our Exchange Premit";
            // 
            // idTx
            // 
            this.idTx.Location = new System.Drawing.Point(156, 75);
            this.idTx.Name = "idTx";
            this.idTx.Size = new System.Drawing.Size(275, 26);
            this.idTx.TabIndex = 18;
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDlabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.IDlabel.Location = new System.Drawing.Point(19, 81);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(28, 20);
            this.IDlabel.TabIndex = 17;
            this.IDlabel.Text = "ID";
            // 
            // premitNum
            // 
            this.premitNum.Location = new System.Drawing.Point(156, 123);
            this.premitNum.Name = "premitNum";
            this.premitNum.Size = new System.Drawing.Size(275, 26);
            this.premitNum.TabIndex = 20;
            // 
            // premitNumber
            // 
            this.premitNumber.AutoSize = true;
            this.premitNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.premitNumber.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.premitNumber.Location = new System.Drawing.Point(19, 130);
            this.premitNumber.Name = "premitNumber";
            this.premitNumber.Size = new System.Drawing.Size(127, 20);
            this.premitNumber.TabIndex = 19;
            this.premitNumber.Text = "Premit Number";
            // 
            // premitdateTime
            // 
            this.premitdateTime.Location = new System.Drawing.Point(156, 174);
            this.premitdateTime.Name = "premitdateTime";
            this.premitdateTime.Size = new System.Drawing.Size(275, 26);
            this.premitdateTime.TabIndex = 21;
            // 
            // premitDate
            // 
            this.premitDate.AutoSize = true;
            this.premitDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.premitDate.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.premitDate.Location = new System.Drawing.Point(19, 177);
            this.premitDate.Name = "premitDate";
            this.premitDate.Size = new System.Drawing.Size(104, 20);
            this.premitDate.TabIndex = 22;
            this.premitDate.Text = "Premit Date";
            // 
            // storeTx
            // 
            this.storeTx.FormattingEnabled = true;
            this.storeTx.Location = new System.Drawing.Point(156, 222);
            this.storeTx.Name = "storeTx";
            this.storeTx.Size = new System.Drawing.Size(275, 28);
            this.storeTx.TabIndex = 23;
            // 
            // storelabel
            // 
            this.storelabel.AutoSize = true;
            this.storelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storelabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.storelabel.Location = new System.Drawing.Point(12, 226);
            this.storelabel.Name = "storelabel";
            this.storelabel.Size = new System.Drawing.Size(53, 20);
            this.storelabel.TabIndex = 24;
            this.storelabel.Text = "Store";
            // 
            // supplierlabel
            // 
            this.supplierlabel.AutoSize = true;
            this.supplierlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierlabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.supplierlabel.Location = new System.Drawing.Point(12, 277);
            this.supplierlabel.Name = "supplierlabel";
            this.supplierlabel.Size = new System.Drawing.Size(75, 20);
            this.supplierlabel.TabIndex = 26;
            this.supplierlabel.Text = "Supplier";
            // 
            // supplierTx
            // 
            this.supplierTx.FormattingEnabled = true;
            this.supplierTx.Location = new System.Drawing.Point(156, 273);
            this.supplierTx.Name = "supplierTx";
            this.supplierTx.Size = new System.Drawing.Size(275, 28);
            this.supplierTx.TabIndex = 25;
            // 
            // Itemlabel
            // 
            this.Itemlabel.AutoSize = true;
            this.Itemlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Itemlabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Itemlabel.Location = new System.Drawing.Point(14, 384);
            this.Itemlabel.Name = "Itemlabel";
            this.Itemlabel.Size = new System.Drawing.Size(54, 20);
            this.Itemlabel.TabIndex = 32;
            this.Itemlabel.Text = "Items";
            // 
            // productsTx
            // 
            this.productsTx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsTx.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.Quentity});
            this.productsTx.Location = new System.Drawing.Point(156, 315);
            this.productsTx.Name = "productsTx";
            this.productsTx.RowHeadersWidth = 62;
            this.productsTx.RowTemplate.Height = 28;
            this.productsTx.Size = new System.Drawing.Size(349, 150);
            this.productsTx.TabIndex = 31;
            // 
            // Item
            // 
            this.Item.HeaderText = "Item";
            this.Item.MinimumWidth = 8;
            this.Item.Name = "Item";
            this.Item.Width = 150;
            // 
            // Quentity
            // 
            this.Quentity.HeaderText = "Quentity";
            this.Quentity.MinimumWidth = 8;
            this.Quentity.Name = "Quentity";
            this.Quentity.Width = 150;
            // 
            // addPremitBtn
            // 
            this.addPremitBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.addPremitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPremitBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.addPremitBtn.Location = new System.Drawing.Point(566, 106);
            this.addPremitBtn.Name = "addPremitBtn";
            this.addPremitBtn.Size = new System.Drawing.Size(203, 58);
            this.addPremitBtn.TabIndex = 33;
            this.addPremitBtn.Text = "Add Exchange";
            this.addPremitBtn.UseVisualStyleBackColor = false;
            this.addPremitBtn.Click += new System.EventHandler(this.addPremitBtn_Click);
            // 
            // updatePremitBtn
            // 
            this.updatePremitBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.updatePremitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatePremitBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.updatePremitBtn.Location = new System.Drawing.Point(566, 205);
            this.updatePremitBtn.Name = "updatePremitBtn";
            this.updatePremitBtn.Size = new System.Drawing.Size(203, 58);
            this.updatePremitBtn.TabIndex = 34;
            this.updatePremitBtn.Text = "Update Exchange";
            this.updatePremitBtn.UseVisualStyleBackColor = false;
            this.updatePremitBtn.Click += new System.EventHandler(this.updatePremitBtn_Click);
            // 
            // Show_Exchange_Premits
            // 
            this.Show_Exchange_Premits.FormattingEnabled = true;
            this.Show_Exchange_Premits.ItemHeight = 20;
            this.Show_Exchange_Premits.Location = new System.Drawing.Point(972, 77);
            this.Show_Exchange_Premits.Name = "Show_Exchange_Premits";
            this.Show_Exchange_Premits.Size = new System.Drawing.Size(255, 224);
            this.Show_Exchange_Premits.TabIndex = 35;
            this.Show_Exchange_Premits.SelectedIndexChanged += new System.EventHandler(this.Show_Exchange_Premits_SelectedIndexChanged);
            // 
            // showBtn
            // 
            this.showBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.showBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.showBtn.Location = new System.Drawing.Point(972, 346);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(255, 58);
            this.showBtn.TabIndex = 36;
            this.showBtn.Text = "Show Exchange Premits";
            this.showBtn.UseVisualStyleBackColor = false;
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // ExchangePremitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 477);
            this.Controls.Add(this.showBtn);
            this.Controls.Add(this.Show_Exchange_Premits);
            this.Controls.Add(this.updatePremitBtn);
            this.Controls.Add(this.addPremitBtn);
            this.Controls.Add(this.Itemlabel);
            this.Controls.Add(this.productsTx);
            this.Controls.Add(this.supplierlabel);
            this.Controls.Add(this.supplierTx);
            this.Controls.Add(this.storelabel);
            this.Controls.Add(this.storeTx);
            this.Controls.Add(this.premitDate);
            this.Controls.Add(this.premitdateTime);
            this.Controls.Add(this.premitNum);
            this.Controls.Add(this.premitNumber);
            this.Controls.Add(this.idTx);
            this.Controls.Add(this.IDlabel);
            this.Controls.Add(this.ourProducts);
            this.Name = "ExchangePremitForm";
            this.Text = "ExchangePremitForm";
            this.Load += new System.EventHandler(this.ExchangePremitForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsTx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ourProducts;
        private System.Windows.Forms.TextBox idTx;
        private System.Windows.Forms.Label IDlabel;
        private System.Windows.Forms.TextBox premitNum;
        private System.Windows.Forms.Label premitNumber;
        private System.Windows.Forms.DateTimePicker premitdateTime;
        private System.Windows.Forms.Label premitDate;
        private System.Windows.Forms.ComboBox storeTx;
        private System.Windows.Forms.Label storelabel;
        private System.Windows.Forms.Label supplierlabel;
        private System.Windows.Forms.ComboBox supplierTx;
        private System.Windows.Forms.Label Itemlabel;
        private System.Windows.Forms.DataGridView productsTx;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quentity;
        private System.Windows.Forms.Button addPremitBtn;
        private System.Windows.Forms.Button updatePremitBtn;
        private System.Windows.Forms.ListBox Show_Exchange_Premits;
        private System.Windows.Forms.Button showBtn;
    }
}