namespace Project
{
    partial class CustomerForm
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
            this.IDlabel = new System.Windows.Forms.Label();
            this.idTx = new System.Windows.Forms.TextBox();
            this.nameTx = new System.Windows.Forms.TextBox();
            this.namelabel = new System.Windows.Forms.Label();
            this.telephoneTx = new System.Windows.Forms.TextBox();
            this.telephonelabel = new System.Windows.Forms.Label();
            this.faxTx = new System.Windows.Forms.TextBox();
            this.faxlabel = new System.Windows.Forms.Label();
            this.websiteTx = new System.Windows.Forms.TextBox();
            this.websitelabel = new System.Windows.Forms.Label();
            this.emailTx = new System.Windows.Forms.TextBox();
            this.emaillabel = new System.Windows.Forms.Label();
            this.mobileTx = new System.Windows.Forms.TextBox();
            this.Mobilelabel = new System.Windows.Forms.Label();
            this.CustomerList = new System.Windows.Forms.ListBox();
            this.showcustomers = new System.Windows.Forms.Button();
            this.addcustomer = new System.Windows.Forms.Button();
            this.updatecustomer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ourProducts
            // 
            this.ourProducts.AutoSize = true;
            this.ourProducts.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ourProducts.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ourProducts.Location = new System.Drawing.Point(487, 29);
            this.ourProducts.Name = "ourProducts";
            this.ourProducts.Size = new System.Drawing.Size(379, 44);
            this.ourProducts.TabIndex = 14;
            this.ourProducts.Text = "Welcome to our Customers";
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDlabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.IDlabel.Location = new System.Drawing.Point(24, 96);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(28, 20);
            this.IDlabel.TabIndex = 15;
            this.IDlabel.Text = "ID";
            // 
            // idTx
            // 
            this.idTx.Location = new System.Drawing.Point(161, 90);
            this.idTx.Name = "idTx";
            this.idTx.Size = new System.Drawing.Size(253, 26);
            this.idTx.TabIndex = 16;
            // 
            // nameTx
            // 
            this.nameTx.Location = new System.Drawing.Point(161, 144);
            this.nameTx.Name = "nameTx";
            this.nameTx.Size = new System.Drawing.Size(253, 26);
            this.nameTx.TabIndex = 18;
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.namelabel.Location = new System.Drawing.Point(24, 150);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(55, 20);
            this.namelabel.TabIndex = 17;
            this.namelabel.Text = "Name";
            // 
            // telephoneTx
            // 
            this.telephoneTx.Location = new System.Drawing.Point(161, 192);
            this.telephoneTx.Name = "telephoneTx";
            this.telephoneTx.Size = new System.Drawing.Size(253, 26);
            this.telephoneTx.TabIndex = 20;
            // 
            // telephonelabel
            // 
            this.telephonelabel.AutoSize = true;
            this.telephonelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telephonelabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.telephonelabel.Location = new System.Drawing.Point(24, 198);
            this.telephonelabel.Name = "telephonelabel";
            this.telephonelabel.Size = new System.Drawing.Size(93, 20);
            this.telephonelabel.TabIndex = 19;
            this.telephonelabel.Text = "Telephone";
            // 
            // faxTx
            // 
            this.faxTx.Location = new System.Drawing.Point(161, 298);
            this.faxTx.Name = "faxTx";
            this.faxTx.Size = new System.Drawing.Size(253, 26);
            this.faxTx.TabIndex = 22;
            // 
            // faxlabel
            // 
            this.faxlabel.AutoSize = true;
            this.faxlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.faxlabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.faxlabel.Location = new System.Drawing.Point(24, 304);
            this.faxlabel.Name = "faxlabel";
            this.faxlabel.Size = new System.Drawing.Size(38, 20);
            this.faxlabel.TabIndex = 21;
            this.faxlabel.Text = "Fax";
            // 
            // websiteTx
            // 
            this.websiteTx.Location = new System.Drawing.Point(161, 401);
            this.websiteTx.Name = "websiteTx";
            this.websiteTx.Size = new System.Drawing.Size(253, 26);
            this.websiteTx.TabIndex = 24;
            // 
            // websitelabel
            // 
            this.websitelabel.AutoSize = true;
            this.websitelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.websitelabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.websitelabel.Location = new System.Drawing.Point(24, 407);
            this.websitelabel.Name = "websitelabel";
            this.websitelabel.Size = new System.Drawing.Size(74, 20);
            this.websitelabel.TabIndex = 23;
            this.websitelabel.Text = "Website";
            // 
            // emailTx
            // 
            this.emailTx.Location = new System.Drawing.Point(161, 245);
            this.emailTx.Name = "emailTx";
            this.emailTx.Size = new System.Drawing.Size(253, 26);
            this.emailTx.TabIndex = 26;
            // 
            // emaillabel
            // 
            this.emaillabel.AutoSize = true;
            this.emaillabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emaillabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.emaillabel.Location = new System.Drawing.Point(24, 251);
            this.emaillabel.Name = "emaillabel";
            this.emaillabel.Size = new System.Drawing.Size(53, 20);
            this.emaillabel.TabIndex = 25;
            this.emaillabel.Text = "Email";
            // 
            // mobileTx
            // 
            this.mobileTx.Location = new System.Drawing.Point(161, 348);
            this.mobileTx.Name = "mobileTx";
            this.mobileTx.Size = new System.Drawing.Size(253, 26);
            this.mobileTx.TabIndex = 28;
            // 
            // Mobilelabel
            // 
            this.Mobilelabel.AutoSize = true;
            this.Mobilelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mobilelabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Mobilelabel.Location = new System.Drawing.Point(24, 354);
            this.Mobilelabel.Name = "Mobilelabel";
            this.Mobilelabel.Size = new System.Drawing.Size(61, 20);
            this.Mobilelabel.TabIndex = 27;
            this.Mobilelabel.Text = "Mobile";
            // 
            // CustomerList
            // 
            this.CustomerList.FormattingEnabled = true;
            this.CustomerList.ItemHeight = 20;
            this.CustomerList.Location = new System.Drawing.Point(595, 90);
            this.CustomerList.Name = "CustomerList";
            this.CustomerList.Size = new System.Drawing.Size(338, 264);
            this.CustomerList.TabIndex = 29;
            this.CustomerList.SelectedIndexChanged += new System.EventHandler(this.CustomerList_SelectedIndexChanged);
            // 
            // showcustomers
            // 
            this.showcustomers.BackColor = System.Drawing.SystemColors.Highlight;
            this.showcustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showcustomers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.showcustomers.Location = new System.Drawing.Point(662, 375);
            this.showcustomers.Name = "showcustomers";
            this.showcustomers.Size = new System.Drawing.Size(225, 52);
            this.showcustomers.TabIndex = 30;
            this.showcustomers.Text = "Show Customers";
            this.showcustomers.UseVisualStyleBackColor = false;
            this.showcustomers.Click += new System.EventHandler(this.showcustomers_Click);
            // 
            // addcustomer
            // 
            this.addcustomer.BackColor = System.Drawing.SystemColors.Highlight;
            this.addcustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addcustomer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addcustomer.Location = new System.Drawing.Point(1033, 129);
            this.addcustomer.Name = "addcustomer";
            this.addcustomer.Size = new System.Drawing.Size(184, 52);
            this.addcustomer.TabIndex = 31;
            this.addcustomer.Text = "Add Customer";
            this.addcustomer.UseVisualStyleBackColor = false;
            this.addcustomer.Click += new System.EventHandler(this.addcustomer_Click);
            // 
            // updatecustomer
            // 
            this.updatecustomer.BackColor = System.Drawing.SystemColors.Highlight;
            this.updatecustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatecustomer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updatecustomer.Location = new System.Drawing.Point(998, 272);
            this.updatecustomer.Name = "updatecustomer";
            this.updatecustomer.Size = new System.Drawing.Size(268, 52);
            this.updatecustomer.TabIndex = 32;
            this.updatecustomer.Text = "Update Customer";
            this.updatecustomer.UseVisualStyleBackColor = false;
            this.updatecustomer.Click += new System.EventHandler(this.updatecustomer_Click);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 450);
            this.Controls.Add(this.updatecustomer);
            this.Controls.Add(this.addcustomer);
            this.Controls.Add(this.showcustomers);
            this.Controls.Add(this.CustomerList);
            this.Controls.Add(this.mobileTx);
            this.Controls.Add(this.Mobilelabel);
            this.Controls.Add(this.emailTx);
            this.Controls.Add(this.emaillabel);
            this.Controls.Add(this.websiteTx);
            this.Controls.Add(this.websitelabel);
            this.Controls.Add(this.faxTx);
            this.Controls.Add(this.faxlabel);
            this.Controls.Add(this.telephoneTx);
            this.Controls.Add(this.telephonelabel);
            this.Controls.Add(this.nameTx);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.idTx);
            this.Controls.Add(this.IDlabel);
            this.Controls.Add(this.ourProducts);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ourProducts;
        private System.Windows.Forms.Label IDlabel;
        private System.Windows.Forms.TextBox idTx;
        private System.Windows.Forms.TextBox nameTx;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.TextBox telephoneTx;
        private System.Windows.Forms.Label telephonelabel;
        private System.Windows.Forms.TextBox faxTx;
        private System.Windows.Forms.Label faxlabel;
        private System.Windows.Forms.TextBox websiteTx;
        private System.Windows.Forms.Label websitelabel;
        private System.Windows.Forms.TextBox emailTx;
        private System.Windows.Forms.Label emaillabel;
        private System.Windows.Forms.TextBox mobileTx;
        private System.Windows.Forms.Label Mobilelabel;
        private System.Windows.Forms.ListBox CustomerList;
        private System.Windows.Forms.Button showcustomers;
        private System.Windows.Forms.Button addcustomer;
        private System.Windows.Forms.Button updatecustomer;
    }
}