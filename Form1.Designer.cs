namespace Project
{
	partial class Form1
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
            this.showStore = new System.Windows.Forms.Button();
            this.productBtn = new System.Windows.Forms.Button();
            this.customerBtn = new System.Windows.Forms.Button();
            this.showSupplier = new System.Windows.Forms.Button();
            this.exchangePremit = new System.Windows.Forms.Button();
            this.importPremit = new System.Windows.Forms.Button();
            this.ourProducts = new System.Windows.Forms.Label();
            this.showTransfer = new System.Windows.Forms.Button();
            this.storeReport = new System.Windows.Forms.Button();
            this.productReport = new System.Windows.Forms.Button();
            this.expireDate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showStore
            // 
            this.showStore.BackColor = System.Drawing.SystemColors.Highlight;
            this.showStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showStore.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.showStore.Location = new System.Drawing.Point(12, 126);
            this.showStore.Name = "showStore";
            this.showStore.Size = new System.Drawing.Size(177, 58);
            this.showStore.TabIndex = 0;
            this.showStore.Text = "Show Stores";
            this.showStore.UseVisualStyleBackColor = false;
            this.showStore.Click += new System.EventHandler(this.showStore_Click);
            // 
            // productBtn
            // 
            this.productBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.productBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.productBtn.Location = new System.Drawing.Point(232, 126);
            this.productBtn.Name = "productBtn";
            this.productBtn.Size = new System.Drawing.Size(177, 58);
            this.productBtn.TabIndex = 1;
            this.productBtn.Text = "Show Products";
            this.productBtn.UseVisualStyleBackColor = false;
            this.productBtn.Click += new System.EventHandler(this.productBtn_Click);
            // 
            // customerBtn
            // 
            this.customerBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.customerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.customerBtn.Location = new System.Drawing.Point(451, 126);
            this.customerBtn.Name = "customerBtn";
            this.customerBtn.Size = new System.Drawing.Size(203, 58);
            this.customerBtn.TabIndex = 2;
            this.customerBtn.Text = "Show Customers";
            this.customerBtn.UseVisualStyleBackColor = false;
            this.customerBtn.Click += new System.EventHandler(this.customerBtn_Click);
            // 
            // showSupplier
            // 
            this.showSupplier.BackColor = System.Drawing.SystemColors.Highlight;
            this.showSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showSupplier.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.showSupplier.Location = new System.Drawing.Point(709, 126);
            this.showSupplier.Name = "showSupplier";
            this.showSupplier.Size = new System.Drawing.Size(179, 58);
            this.showSupplier.TabIndex = 3;
            this.showSupplier.Text = "Show Supplier";
            this.showSupplier.UseVisualStyleBackColor = false;
            this.showSupplier.Click += new System.EventHandler(this.showSupplier_Click);
            // 
            // exchangePremit
            // 
            this.exchangePremit.BackColor = System.Drawing.SystemColors.Highlight;
            this.exchangePremit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exchangePremit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.exchangePremit.Location = new System.Drawing.Point(12, 226);
            this.exchangePremit.Name = "exchangePremit";
            this.exchangePremit.Size = new System.Drawing.Size(271, 58);
            this.exchangePremit.TabIndex = 4;
            this.exchangePremit.Text = "Show ExchangePermit";
            this.exchangePremit.UseVisualStyleBackColor = false;
            this.exchangePremit.Click += new System.EventHandler(this.exchangePremit_Click);
            // 
            // importPremit
            // 
            this.importPremit.BackColor = System.Drawing.SystemColors.Highlight;
            this.importPremit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importPremit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.importPremit.Location = new System.Drawing.Point(338, 226);
            this.importPremit.Name = "importPremit";
            this.importPremit.Size = new System.Drawing.Size(271, 58);
            this.importPremit.TabIndex = 5;
            this.importPremit.Text = "Show Import Permit";
            this.importPremit.UseVisualStyleBackColor = false;
            this.importPremit.Click += new System.EventHandler(this.importPremit_Click);
            // 
            // ourProducts
            // 
            this.ourProducts.AutoSize = true;
            this.ourProducts.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ourProducts.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ourProducts.Location = new System.Drawing.Point(454, 21);
            this.ourProducts.Name = "ourProducts";
            this.ourProducts.Size = new System.Drawing.Size(296, 44);
            this.ourProducts.TabIndex = 15;
            this.ourProducts.Text = "Welcome to our App";
            // 
            // showTransfer
            // 
            this.showTransfer.BackColor = System.Drawing.SystemColors.Highlight;
            this.showTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showTransfer.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.showTransfer.Location = new System.Drawing.Point(959, 126);
            this.showTransfer.Name = "showTransfer";
            this.showTransfer.Size = new System.Drawing.Size(198, 58);
            this.showTransfer.TabIndex = 16;
            this.showTransfer.Text = "Show Transfer";
            this.showTransfer.UseVisualStyleBackColor = false;
            this.showTransfer.Click += new System.EventHandler(this.showTransfer_Click);
            // 
            // storeReport
            // 
            this.storeReport.BackColor = System.Drawing.SystemColors.Highlight;
            this.storeReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeReport.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.storeReport.Location = new System.Drawing.Point(658, 226);
            this.storeReport.Name = "storeReport";
            this.storeReport.Size = new System.Drawing.Size(271, 58);
            this.storeReport.TabIndex = 17;
            this.storeReport.Text = "Show Store Report";
            this.storeReport.UseVisualStyleBackColor = false;
            this.storeReport.Click += new System.EventHandler(this.storeReport_Click);
            // 
            // productReport
            // 
            this.productReport.BackColor = System.Drawing.SystemColors.Highlight;
            this.productReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productReport.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.productReport.Location = new System.Drawing.Point(12, 331);
            this.productReport.Name = "productReport";
            this.productReport.Size = new System.Drawing.Size(271, 58);
            this.productReport.TabIndex = 18;
            this.productReport.Text = "Show Product Report";
            this.productReport.UseVisualStyleBackColor = false;
            this.productReport.Click += new System.EventHandler(this.productReport_Click);
            // 
            // expireDate
            // 
            this.expireDate.BackColor = System.Drawing.SystemColors.Highlight;
            this.expireDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expireDate.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.expireDate.Location = new System.Drawing.Point(338, 331);
            this.expireDate.Name = "expireDate";
            this.expireDate.Size = new System.Drawing.Size(383, 58);
            this.expireDate.TabIndex = 19;
            this.expireDate.Text = "Show Product ExpireDate Report";
            this.expireDate.UseVisualStyleBackColor = false;
            this.expireDate.Click += new System.EventHandler(this.expireDate_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(774, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(383, 58);
            this.button1.TabIndex = 20;
            this.button1.Text = "Show  Transfer Item Report";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.expireDate);
            this.Controls.Add(this.productReport);
            this.Controls.Add(this.storeReport);
            this.Controls.Add(this.showTransfer);
            this.Controls.Add(this.ourProducts);
            this.Controls.Add(this.importPremit);
            this.Controls.Add(this.exchangePremit);
            this.Controls.Add(this.showSupplier);
            this.Controls.Add(this.customerBtn);
            this.Controls.Add(this.productBtn);
            this.Controls.Add(this.showStore);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

		}


        #endregion

        private System.Windows.Forms.Button showStore;
        private System.Windows.Forms.Button productBtn;
        private System.Windows.Forms.Button customerBtn;
        private System.Windows.Forms.Button showSupplier;
        private System.Windows.Forms.Button exchangePremit;
        private System.Windows.Forms.Button importPremit;
        private System.Windows.Forms.Label ourProducts;
        private System.Windows.Forms.Button showTransfer;
        private System.Windows.Forms.Button storeReport;
        private System.Windows.Forms.Button productReport;
        private System.Windows.Forms.Button expireDate;
        private System.Windows.Forms.Button button1;
    }
}

