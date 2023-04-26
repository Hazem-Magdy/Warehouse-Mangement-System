namespace Project
{
    partial class TransferForm
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
            this.idlabel = new System.Windows.Forms.Label();
            this.transferDate = new System.Windows.Forms.DateTimePicker();
            this.premitlabel = new System.Windows.Forms.Label();
            this.storeFromTx = new System.Windows.Forms.ComboBox();
            this.storelabel = new System.Windows.Forms.Label();
            this.storeToTx = new System.Windows.Forms.ComboBox();
            this.storelabel1 = new System.Windows.Forms.Label();
            this.quentityTx = new System.Windows.Forms.TextBox();
            this.quentitylabel = new System.Windows.Forms.Label();
            this.productionDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.expirationDate = new System.Windows.Forms.DateTimePicker();
            this.ExpirationDatelabel = new System.Windows.Forms.Label();
            this.transfer_items = new System.Windows.Forms.ListBox();
            this.showBtn = new System.Windows.Forms.Button();
            this.addPremitBtn = new System.Windows.Forms.Button();
            this.updatePremitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ourProducts
            // 
            this.ourProducts.AutoSize = true;
            this.ourProducts.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ourProducts.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ourProducts.Location = new System.Drawing.Point(483, 25);
            this.ourProducts.Name = "ourProducts";
            this.ourProducts.Size = new System.Drawing.Size(368, 44);
            this.ourProducts.TabIndex = 16;
            this.ourProducts.Text = "Welcome to our Transfers";
            // 
            // idTx
            // 
            this.idTx.Location = new System.Drawing.Point(166, 132);
            this.idTx.Name = "idTx";
            this.idTx.Size = new System.Drawing.Size(239, 26);
            this.idTx.TabIndex = 22;
            // 
            // idlabel
            // 
            this.idlabel.AutoSize = true;
            this.idlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idlabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.idlabel.Location = new System.Drawing.Point(21, 135);
            this.idlabel.Name = "idlabel";
            this.idlabel.Size = new System.Drawing.Size(28, 20);
            this.idlabel.TabIndex = 21;
            this.idlabel.Text = "ID";
            // 
            // transferDate
            // 
            this.transferDate.Location = new System.Drawing.Point(166, 177);
            this.transferDate.Name = "transferDate";
            this.transferDate.Size = new System.Drawing.Size(239, 26);
            this.transferDate.TabIndex = 26;
            // 
            // premitlabel
            // 
            this.premitlabel.AutoSize = true;
            this.premitlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.premitlabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.premitlabel.Location = new System.Drawing.Point(21, 177);
            this.premitlabel.Name = "premitlabel";
            this.premitlabel.Size = new System.Drawing.Size(120, 20);
            this.premitlabel.TabIndex = 25;
            this.premitlabel.Text = "Transfer Date";
            // 
            // storeFromTx
            // 
            this.storeFromTx.FormattingEnabled = true;
            this.storeFromTx.Location = new System.Drawing.Point(166, 220);
            this.storeFromTx.Name = "storeFromTx";
            this.storeFromTx.Size = new System.Drawing.Size(239, 28);
            this.storeFromTx.TabIndex = 38;
            // 
            // storelabel
            // 
            this.storelabel.AutoSize = true;
            this.storelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storelabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.storelabel.Location = new System.Drawing.Point(21, 223);
            this.storelabel.Name = "storelabel";
            this.storelabel.Size = new System.Drawing.Size(99, 20);
            this.storelabel.TabIndex = 37;
            this.storelabel.Text = "From Store";
            // 
            // storeToTx
            // 
            this.storeToTx.FormattingEnabled = true;
            this.storeToTx.Location = new System.Drawing.Point(166, 269);
            this.storeToTx.Name = "storeToTx";
            this.storeToTx.Size = new System.Drawing.Size(239, 28);
            this.storeToTx.TabIndex = 40;
            // 
            // storelabel1
            // 
            this.storelabel1.AutoSize = true;
            this.storelabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storelabel1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.storelabel1.Location = new System.Drawing.Point(21, 272);
            this.storelabel1.Name = "storelabel1";
            this.storelabel1.Size = new System.Drawing.Size(78, 20);
            this.storelabel1.TabIndex = 39;
            this.storelabel1.Text = "To Store";
            // 
            // quentityTx
            // 
            this.quentityTx.Location = new System.Drawing.Point(166, 318);
            this.quentityTx.Name = "quentityTx";
            this.quentityTx.Size = new System.Drawing.Size(239, 26);
            this.quentityTx.TabIndex = 42;
            // 
            // quentitylabel
            // 
            this.quentitylabel.AutoSize = true;
            this.quentitylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quentitylabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.quentitylabel.Location = new System.Drawing.Point(21, 324);
            this.quentitylabel.Name = "quentitylabel";
            this.quentitylabel.Size = new System.Drawing.Size(76, 20);
            this.quentitylabel.TabIndex = 41;
            this.quentitylabel.Text = "Quantity";
            // 
            // productionDate
            // 
            this.productionDate.Location = new System.Drawing.Point(166, 363);
            this.productionDate.Name = "productionDate";
            this.productionDate.Size = new System.Drawing.Size(239, 26);
            this.productionDate.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(21, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 43;
            this.label1.Text = "Production Date";
            // 
            // expirationDate
            // 
            this.expirationDate.Location = new System.Drawing.Point(166, 409);
            this.expirationDate.Name = "expirationDate";
            this.expirationDate.Size = new System.Drawing.Size(239, 26);
            this.expirationDate.TabIndex = 46;
            // 
            // ExpirationDatelabel
            // 
            this.ExpirationDatelabel.AutoSize = true;
            this.ExpirationDatelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpirationDatelabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ExpirationDatelabel.Location = new System.Drawing.Point(21, 409);
            this.ExpirationDatelabel.Name = "ExpirationDatelabel";
            this.ExpirationDatelabel.Size = new System.Drawing.Size(133, 20);
            this.ExpirationDatelabel.TabIndex = 45;
            this.ExpirationDatelabel.Text = "Expiration Date";
            // 
            // transfer_items
            // 
            this.transfer_items.FormattingEnabled = true;
            this.transfer_items.ItemHeight = 20;
            this.transfer_items.Location = new System.Drawing.Point(585, 88);
            this.transfer_items.Name = "transfer_items";
            this.transfer_items.Size = new System.Drawing.Size(255, 224);
            this.transfer_items.TabIndex = 47;
            this.transfer_items.SelectedIndexChanged += new System.EventHandler(this.transfer_items_SelectedIndexChanged);
            // 
            // showBtn
            // 
            this.showBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.showBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.showBtn.Location = new System.Drawing.Point(612, 343);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(203, 58);
            this.showBtn.TabIndex = 48;
            this.showBtn.Text = "Show Items";
            this.showBtn.UseVisualStyleBackColor = false;
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // addPremitBtn
            // 
            this.addPremitBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.addPremitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPremitBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.addPremitBtn.Location = new System.Drawing.Point(1013, 115);
            this.addPremitBtn.Name = "addPremitBtn";
            this.addPremitBtn.Size = new System.Drawing.Size(203, 58);
            this.addPremitBtn.TabIndex = 49;
            this.addPremitBtn.Text = "Add Items";
            this.addPremitBtn.UseVisualStyleBackColor = false;
            this.addPremitBtn.Click += new System.EventHandler(this.addPremitBtn_Click);
            // 
            // updatePremitBtn
            // 
            this.updatePremitBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.updatePremitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatePremitBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.updatePremitBtn.Location = new System.Drawing.Point(1013, 223);
            this.updatePremitBtn.Name = "updatePremitBtn";
            this.updatePremitBtn.Size = new System.Drawing.Size(203, 58);
            this.updatePremitBtn.TabIndex = 50;
            this.updatePremitBtn.Text = "Update Items";
            this.updatePremitBtn.UseVisualStyleBackColor = false;
            this.updatePremitBtn.Click += new System.EventHandler(this.updatePremitBtn_Click);
            // 
            // TransferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 461);
            this.Controls.Add(this.updatePremitBtn);
            this.Controls.Add(this.addPremitBtn);
            this.Controls.Add(this.showBtn);
            this.Controls.Add(this.transfer_items);
            this.Controls.Add(this.expirationDate);
            this.Controls.Add(this.ExpirationDatelabel);
            this.Controls.Add(this.productionDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quentityTx);
            this.Controls.Add(this.quentitylabel);
            this.Controls.Add(this.storeToTx);
            this.Controls.Add(this.storelabel1);
            this.Controls.Add(this.storeFromTx);
            this.Controls.Add(this.storelabel);
            this.Controls.Add(this.transferDate);
            this.Controls.Add(this.premitlabel);
            this.Controls.Add(this.idTx);
            this.Controls.Add(this.idlabel);
            this.Controls.Add(this.ourProducts);
            this.Name = "TransferForm";
            this.Text = "TransferForm";
            this.Load += new System.EventHandler(this.TransferForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ourProducts;
        private System.Windows.Forms.TextBox idTx;
        private System.Windows.Forms.Label idlabel;
        private System.Windows.Forms.DateTimePicker transferDate;
        private System.Windows.Forms.Label premitlabel;
        private System.Windows.Forms.ComboBox storeFromTx;
        private System.Windows.Forms.Label storelabel;
        private System.Windows.Forms.ComboBox storeToTx;
        private System.Windows.Forms.Label storelabel1;
        private System.Windows.Forms.TextBox quentityTx;
        private System.Windows.Forms.Label quentitylabel;
        private System.Windows.Forms.DateTimePicker productionDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker expirationDate;
        private System.Windows.Forms.Label ExpirationDatelabel;
        private System.Windows.Forms.ListBox transfer_items;
        private System.Windows.Forms.Button showBtn;
        private System.Windows.Forms.Button addPremitBtn;
        private System.Windows.Forms.Button updatePremitBtn;
    }
}