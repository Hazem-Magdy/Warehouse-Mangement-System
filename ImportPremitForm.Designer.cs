namespace Project
{
    partial class ImportPremitForm
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
            this.idlabel = new System.Windows.Forms.Label();
            this.idTx = new System.Windows.Forms.TextBox();
            this.premitTx = new System.Windows.Forms.TextBox();
            this.premitNumberlabel = new System.Windows.Forms.Label();
            this.premitlabel = new System.Windows.Forms.Label();
            this.premitDate = new System.Windows.Forms.DateTimePicker();
            this.productionDate = new System.Windows.Forms.DateTimePicker();
            this.productionlabel = new System.Windows.Forms.Label();
            this.expiryDate = new System.Windows.Forms.DateTimePicker();
            this.expirylabel = new System.Windows.Forms.Label();
            this.productsTx = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quentity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Itemlabel = new System.Windows.Forms.Label();
            this.addPremitBtn = new System.Windows.Forms.Button();
            this.updatePremitBtn = new System.Windows.Forms.Button();
            this.Show_Import_Premits = new System.Windows.Forms.ListBox();
            this.showBtn = new System.Windows.Forms.Button();
            this.storelabel = new System.Windows.Forms.Label();
            this.storeTx = new System.Windows.Forms.ComboBox();
            this.supplierTx = new System.Windows.Forms.ComboBox();
            this.supplierlabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productsTx)).BeginInit();
            this.SuspendLayout();
            // 
            // ourProducts
            // 
            this.ourProducts.AutoSize = true;
            this.ourProducts.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ourProducts.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ourProducts.Location = new System.Drawing.Point(440, 27);
            this.ourProducts.Name = "ourProducts";
            this.ourProducts.Size = new System.Drawing.Size(434, 44);
            this.ourProducts.TabIndex = 15;
            this.ourProducts.Text = "Welcome to our Import Premit";
            // 
            // idlabel
            // 
            this.idlabel.AutoSize = true;
            this.idlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idlabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.idlabel.Location = new System.Drawing.Point(23, 73);
            this.idlabel.Name = "idlabel";
            this.idlabel.Size = new System.Drawing.Size(28, 20);
            this.idlabel.TabIndex = 16;
            this.idlabel.Text = "ID";
            // 
            // idTx
            // 
            this.idTx.Location = new System.Drawing.Point(168, 70);
            this.idTx.Name = "idTx";
            this.idTx.Size = new System.Drawing.Size(239, 26);
            this.idTx.TabIndex = 20;
            // 
            // premitTx
            // 
            this.premitTx.Location = new System.Drawing.Point(168, 123);
            this.premitTx.Name = "premitTx";
            this.premitTx.Size = new System.Drawing.Size(239, 26);
            this.premitTx.TabIndex = 19;
            // 
            // premitNumberlabel
            // 
            this.premitNumberlabel.AutoSize = true;
            this.premitNumberlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.premitNumberlabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.premitNumberlabel.Location = new System.Drawing.Point(23, 129);
            this.premitNumberlabel.Name = "premitNumberlabel";
            this.premitNumberlabel.Size = new System.Drawing.Size(127, 20);
            this.premitNumberlabel.TabIndex = 18;
            this.premitNumberlabel.Text = "Premit Number";
            // 
            // premitlabel
            // 
            this.premitlabel.AutoSize = true;
            this.premitlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.premitlabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.premitlabel.Location = new System.Drawing.Point(23, 178);
            this.premitlabel.Name = "premitlabel";
            this.premitlabel.Size = new System.Drawing.Size(104, 20);
            this.premitlabel.TabIndex = 21;
            this.premitlabel.Text = "Premit Date";
            // 
            // premitDate
            // 
            this.premitDate.Location = new System.Drawing.Point(168, 178);
            this.premitDate.Name = "premitDate";
            this.premitDate.Size = new System.Drawing.Size(239, 26);
            this.premitDate.TabIndex = 22;
            // 
            // productionDate
            // 
            this.productionDate.Location = new System.Drawing.Point(168, 228);
            this.productionDate.Name = "productionDate";
            this.productionDate.Size = new System.Drawing.Size(239, 26);
            this.productionDate.TabIndex = 24;
            // 
            // productionlabel
            // 
            this.productionlabel.AutoSize = true;
            this.productionlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productionlabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.productionlabel.Location = new System.Drawing.Point(23, 228);
            this.productionlabel.Name = "productionlabel";
            this.productionlabel.Size = new System.Drawing.Size(139, 20);
            this.productionlabel.TabIndex = 23;
            this.productionlabel.Text = "Production Date";
            // 
            // expiryDate
            // 
            this.expiryDate.Location = new System.Drawing.Point(168, 274);
            this.expiryDate.Name = "expiryDate";
            this.expiryDate.Size = new System.Drawing.Size(239, 26);
            this.expiryDate.TabIndex = 26;
            // 
            // expirylabel
            // 
            this.expirylabel.AutoSize = true;
            this.expirylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expirylabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.expirylabel.Location = new System.Drawing.Point(23, 274);
            this.expirylabel.Name = "expirylabel";
            this.expirylabel.Size = new System.Drawing.Size(101, 20);
            this.expirylabel.TabIndex = 25;
            this.expirylabel.Text = "Expiry Date";
            // 
            // productsTx
            // 
            this.productsTx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsTx.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.Quentity});
            this.productsTx.Location = new System.Drawing.Point(168, 402);
            this.productsTx.Name = "productsTx";
            this.productsTx.RowHeadersWidth = 62;
            this.productsTx.RowTemplate.Height = 28;
            this.productsTx.Size = new System.Drawing.Size(349, 150);
            this.productsTx.TabIndex = 28;
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
            // Itemlabel
            // 
            this.Itemlabel.AutoSize = true;
            this.Itemlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Itemlabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Itemlabel.Location = new System.Drawing.Point(26, 471);
            this.Itemlabel.Name = "Itemlabel";
            this.Itemlabel.Size = new System.Drawing.Size(54, 20);
            this.Itemlabel.TabIndex = 30;
            this.Itemlabel.Text = "Items";
            // 
            // addPremitBtn
            // 
            this.addPremitBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.addPremitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPremitBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.addPremitBtn.Location = new System.Drawing.Point(529, 123);
            this.addPremitBtn.Name = "addPremitBtn";
            this.addPremitBtn.Size = new System.Drawing.Size(203, 58);
            this.addPremitBtn.TabIndex = 31;
            this.addPremitBtn.Text = "Add Premit";
            this.addPremitBtn.UseVisualStyleBackColor = false;
            this.addPremitBtn.Click += new System.EventHandler(this.addPremitBtn_Click);
            // 
            // updatePremitBtn
            // 
            this.updatePremitBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.updatePremitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatePremitBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.updatePremitBtn.Location = new System.Drawing.Point(529, 208);
            this.updatePremitBtn.Name = "updatePremitBtn";
            this.updatePremitBtn.Size = new System.Drawing.Size(203, 58);
            this.updatePremitBtn.TabIndex = 32;
            this.updatePremitBtn.Text = "Update Premit";
            this.updatePremitBtn.UseVisualStyleBackColor = false;
            this.updatePremitBtn.Click += new System.EventHandler(this.updatePremitBtn_Click);
            // 
            // Show_Import_Premits
            // 
            this.Show_Import_Premits.FormattingEnabled = true;
            this.Show_Import_Premits.ItemHeight = 20;
            this.Show_Import_Premits.Location = new System.Drawing.Point(958, 91);
            this.Show_Import_Premits.Name = "Show_Import_Premits";
            this.Show_Import_Premits.Size = new System.Drawing.Size(255, 224);
            this.Show_Import_Premits.TabIndex = 33;
            this.Show_Import_Premits.SelectedIndexChanged += new System.EventHandler(this.Show_Import_Premits_SelectedIndexChanged);
            // 
            // showBtn
            // 
            this.showBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.showBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.showBtn.Location = new System.Drawing.Point(994, 348);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(203, 58);
            this.showBtn.TabIndex = 34;
            this.showBtn.Text = "Show Premits";
            this.showBtn.UseVisualStyleBackColor = false;
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // storelabel
            // 
            this.storelabel.AutoSize = true;
            this.storelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storelabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.storelabel.Location = new System.Drawing.Point(23, 318);
            this.storelabel.Name = "storelabel";
            this.storelabel.Size = new System.Drawing.Size(62, 20);
            this.storelabel.TabIndex = 35;
            this.storelabel.Text = "Stores";
            // 
            // storeTx
            // 
            this.storeTx.FormattingEnabled = true;
            this.storeTx.Location = new System.Drawing.Point(168, 315);
            this.storeTx.Name = "storeTx";
            this.storeTx.Size = new System.Drawing.Size(239, 28);
            this.storeTx.TabIndex = 36;
            // 
            // supplierTx
            // 
            this.supplierTx.FormattingEnabled = true;
            this.supplierTx.Location = new System.Drawing.Point(168, 361);
            this.supplierTx.Name = "supplierTx";
            this.supplierTx.Size = new System.Drawing.Size(239, 28);
            this.supplierTx.TabIndex = 38;
            // 
            // supplierlabel
            // 
            this.supplierlabel.AutoSize = true;
            this.supplierlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierlabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.supplierlabel.Location = new System.Drawing.Point(23, 364);
            this.supplierlabel.Name = "supplierlabel";
            this.supplierlabel.Size = new System.Drawing.Size(84, 20);
            this.supplierlabel.TabIndex = 37;
            this.supplierlabel.Text = "Suppliers";
            // 
            // ImportPremitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 564);
            this.Controls.Add(this.supplierTx);
            this.Controls.Add(this.supplierlabel);
            this.Controls.Add(this.storeTx);
            this.Controls.Add(this.storelabel);
            this.Controls.Add(this.showBtn);
            this.Controls.Add(this.Show_Import_Premits);
            this.Controls.Add(this.updatePremitBtn);
            this.Controls.Add(this.addPremitBtn);
            this.Controls.Add(this.Itemlabel);
            this.Controls.Add(this.productsTx);
            this.Controls.Add(this.expiryDate);
            this.Controls.Add(this.expirylabel);
            this.Controls.Add(this.productionDate);
            this.Controls.Add(this.productionlabel);
            this.Controls.Add(this.premitDate);
            this.Controls.Add(this.premitlabel);
            this.Controls.Add(this.premitTx);
            this.Controls.Add(this.premitNumberlabel);
            this.Controls.Add(this.idTx);
            this.Controls.Add(this.idlabel);
            this.Controls.Add(this.ourProducts);
            this.Name = "ImportPremitForm";
            this.Text = "ImportPremitForm";
            this.Load += new System.EventHandler(this.ImportPremitForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsTx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ourProducts;
        private System.Windows.Forms.Label idlabel;
        private System.Windows.Forms.TextBox idTx;
        private System.Windows.Forms.TextBox premitTx;
        private System.Windows.Forms.Label premitNumberlabel;
        private System.Windows.Forms.Label premitlabel;
        private System.Windows.Forms.DateTimePicker premitDate;
        private System.Windows.Forms.DateTimePicker productionDate;
        private System.Windows.Forms.Label productionlabel;
        private System.Windows.Forms.DateTimePicker expiryDate;
        private System.Windows.Forms.Label expirylabel;
        private System.Windows.Forms.DataGridView productsTx;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quentity;
        private System.Windows.Forms.Label Itemlabel;
        private System.Windows.Forms.Button addPremitBtn;
        private System.Windows.Forms.Button updatePremitBtn;
        private System.Windows.Forms.ListBox Show_Import_Premits;
        private System.Windows.Forms.Button showBtn;
        private System.Windows.Forms.Label storelabel;
        private System.Windows.Forms.ComboBox storeTx;
        private System.Windows.Forms.ComboBox supplierTx;
        private System.Windows.Forms.Label supplierlabel;
    }
}