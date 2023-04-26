namespace Project
{
    partial class ProductForm
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
            this.idLabel = new System.Windows.Forms.Label();
            this.idTx = new System.Windows.Forms.TextBox();
            this.nameTx = new System.Windows.Forms.TextBox();
            this.namelabel = new System.Windows.Forms.Label();
            this.codeTx = new System.Windows.Forms.TextBox();
            this.codelabel = new System.Windows.Forms.Label();
            this.unitTx = new System.Windows.Forms.TextBox();
            this.unitlabel = new System.Windows.Forms.Label();
            this.storelabel = new System.Windows.Forms.Label();
            this.productList = new System.Windows.Forms.ListBox();
            this.showproducts = new System.Windows.Forms.Button();
            this.updateproducts = new System.Windows.Forms.Button();
            this.addproducts = new System.Windows.Forms.Button();
            this.storeTx = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ourProducts
            // 
            this.ourProducts.AutoSize = true;
            this.ourProducts.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ourProducts.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ourProducts.Location = new System.Drawing.Point(491, 25);
            this.ourProducts.Name = "ourProducts";
            this.ourProducts.Size = new System.Drawing.Size(360, 44);
            this.ourProducts.TabIndex = 13;
            this.ourProducts.Text = "Welcome to our Products";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.idLabel.Location = new System.Drawing.Point(38, 95);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(28, 20);
            this.idLabel.TabIndex = 14;
            this.idLabel.Text = "ID";
            // 
            // idTx
            // 
            this.idTx.Location = new System.Drawing.Point(182, 95);
            this.idTx.Name = "idTx";
            this.idTx.Size = new System.Drawing.Size(258, 26);
            this.idTx.TabIndex = 15;
            // 
            // nameTx
            // 
            this.nameTx.Location = new System.Drawing.Point(182, 175);
            this.nameTx.Name = "nameTx";
            this.nameTx.Size = new System.Drawing.Size(258, 26);
            this.nameTx.TabIndex = 17;
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.namelabel.Location = new System.Drawing.Point(38, 181);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(55, 20);
            this.namelabel.TabIndex = 16;
            this.namelabel.Text = "Name";
            // 
            // codeTx
            // 
            this.codeTx.Location = new System.Drawing.Point(182, 265);
            this.codeTx.Name = "codeTx";
            this.codeTx.Size = new System.Drawing.Size(258, 26);
            this.codeTx.TabIndex = 19;
            // 
            // codelabel
            // 
            this.codelabel.AutoSize = true;
            this.codelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codelabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.codelabel.Location = new System.Drawing.Point(38, 265);
            this.codelabel.Name = "codelabel";
            this.codelabel.Size = new System.Drawing.Size(51, 20);
            this.codelabel.TabIndex = 18;
            this.codelabel.Text = "Code";
            // 
            // unitTx
            // 
            this.unitTx.Location = new System.Drawing.Point(182, 346);
            this.unitTx.Name = "unitTx";
            this.unitTx.Size = new System.Drawing.Size(258, 26);
            this.unitTx.TabIndex = 21;
            // 
            // unitlabel
            // 
            this.unitlabel.AutoSize = true;
            this.unitlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitlabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.unitlabel.Location = new System.Drawing.Point(21, 349);
            this.unitlabel.Name = "unitlabel";
            this.unitlabel.Size = new System.Drawing.Size(155, 20);
            this.unitlabel.TabIndex = 20;
            this.unitlabel.Text = "Units of Measures";
            // 
            // storelabel
            // 
            this.storelabel.AutoSize = true;
            this.storelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storelabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.storelabel.Location = new System.Drawing.Point(38, 433);
            this.storelabel.Name = "storelabel";
            this.storelabel.Size = new System.Drawing.Size(53, 20);
            this.storelabel.TabIndex = 22;
            this.storelabel.Text = "Store";
            // 
            // productList
            // 
            this.productList.FormattingEnabled = true;
            this.productList.ItemHeight = 20;
            this.productList.Location = new System.Drawing.Point(611, 95);
            this.productList.Name = "productList";
            this.productList.Size = new System.Drawing.Size(354, 284);
            this.productList.TabIndex = 24;
            this.productList.SelectedIndexChanged += new System.EventHandler(this.productList_SelectedIndexChanged);
            // 
            // showproducts
            // 
            this.showproducts.BackColor = System.Drawing.SystemColors.Highlight;
            this.showproducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showproducts.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.showproducts.Location = new System.Drawing.Point(690, 415);
            this.showproducts.Name = "showproducts";
            this.showproducts.Size = new System.Drawing.Size(209, 52);
            this.showproducts.TabIndex = 25;
            this.showproducts.Text = "Show Products";
            this.showproducts.UseVisualStyleBackColor = false;
            this.showproducts.Click += new System.EventHandler(this.showproducts_Click);
            // 
            // updateproducts
            // 
            this.updateproducts.BackColor = System.Drawing.SystemColors.Highlight;
            this.updateproducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateproducts.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updateproducts.Location = new System.Drawing.Point(1079, 275);
            this.updateproducts.Name = "updateproducts";
            this.updateproducts.Size = new System.Drawing.Size(184, 52);
            this.updateproducts.TabIndex = 26;
            this.updateproducts.Text = "Update Products";
            this.updateproducts.UseVisualStyleBackColor = false;
            this.updateproducts.Click += new System.EventHandler(this.updateproducts_Click);
            // 
            // addproducts
            // 
            this.addproducts.BackColor = System.Drawing.SystemColors.Highlight;
            this.addproducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addproducts.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addproducts.Location = new System.Drawing.Point(1079, 138);
            this.addproducts.Name = "addproducts";
            this.addproducts.Size = new System.Drawing.Size(184, 52);
            this.addproducts.TabIndex = 27;
            this.addproducts.Text = "Add Products";
            this.addproducts.UseVisualStyleBackColor = false;
            this.addproducts.Click += new System.EventHandler(this.addproducts_Click);
            // 
            // storeTx
            // 
            this.storeTx.FormattingEnabled = true;
            this.storeTx.Location = new System.Drawing.Point(182, 415);
            this.storeTx.Name = "storeTx";
            this.storeTx.Size = new System.Drawing.Size(258, 28);
            this.storeTx.TabIndex = 28;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 513);
            this.Controls.Add(this.storeTx);
            this.Controls.Add(this.addproducts);
            this.Controls.Add(this.updateproducts);
            this.Controls.Add(this.showproducts);
            this.Controls.Add(this.productList);
            this.Controls.Add(this.storelabel);
            this.Controls.Add(this.unitTx);
            this.Controls.Add(this.unitlabel);
            this.Controls.Add(this.codeTx);
            this.Controls.Add(this.codelabel);
            this.Controls.Add(this.nameTx);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.idTx);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.ourProducts);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ourProducts;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox idTx;
        private System.Windows.Forms.TextBox nameTx;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.TextBox codeTx;
        private System.Windows.Forms.Label codelabel;
        private System.Windows.Forms.TextBox unitTx;
        private System.Windows.Forms.Label unitlabel;
        private System.Windows.Forms.Label storelabel;
        private System.Windows.Forms.ListBox productList;
        private System.Windows.Forms.Button showproducts;
        private System.Windows.Forms.Button updateproducts;
        private System.Windows.Forms.Button addproducts;
        private System.Windows.Forms.ComboBox storeTx;
    }
}