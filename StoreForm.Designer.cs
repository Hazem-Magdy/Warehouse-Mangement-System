namespace Project
{
    partial class StoreForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.showstores = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.namebx = new System.Windows.Forms.TextBox();
            this.addresslb = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mangercb = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ourstorre = new System.Windows.Forms.Label();
            this.updatebt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(41, 33);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(266, 224);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(420, 139);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(198, 26);
            this.ID.TabIndex = 1;
            this.ID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(426, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // showstores
            // 
            this.showstores.BackColor = System.Drawing.SystemColors.Highlight;
            this.showstores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showstores.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.showstores.Location = new System.Drawing.Point(72, 350);
            this.showstores.Name = "showstores";
            this.showstores.Size = new System.Drawing.Size(184, 52);
            this.showstores.TabIndex = 3;
            this.showstores.Text = "show Stores";
            this.showstores.UseVisualStyleBackColor = false;
            this.showstores.Click += new System.EventHandler(this.showstores_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(927, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // namebx
            // 
            this.namebx.Location = new System.Drawing.Point(921, 139);
            this.namebx.Name = "namebx";
            this.namebx.Size = new System.Drawing.Size(198, 26);
            this.namebx.TabIndex = 4;
            // 
            // addresslb
            // 
            this.addresslb.AutoSize = true;
            this.addresslb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addresslb.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.addresslb.Location = new System.Drawing.Point(426, 202);
            this.addresslb.Name = "addresslb";
            this.addresslb.Size = new System.Drawing.Size(75, 20);
            this.addresslb.TabIndex = 7;
            this.addresslb.Text = "Address";
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(420, 237);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(198, 26);
            this.address.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(927, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Manger";
            // 
            // mangercb
            // 
            this.mangercb.FormattingEnabled = true;
            this.mangercb.Location = new System.Drawing.Point(921, 235);
            this.mangercb.Name = "mangercb";
            this.mangercb.Size = new System.Drawing.Size(198, 28);
            this.mangercb.TabIndex = 10;
            this.mangercb.SelectedIndexChanged += new System.EventHandler(this.mangercb_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(566, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 50);
            this.button1.TabIndex = 11;
            this.button1.Text = "Add Store";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ourstorre
            // 
            this.ourstorre.AutoSize = true;
            this.ourstorre.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ourstorre.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ourstorre.Location = new System.Drawing.Point(580, 33);
            this.ourstorre.Name = "ourstorre";
            this.ourstorre.Size = new System.Drawing.Size(305, 44);
            this.ourstorre.TabIndex = 12;
            this.ourstorre.Text = "Welcome to our store";
            // 
            // updatebt
            // 
            this.updatebt.BackColor = System.Drawing.SystemColors.Highlight;
            this.updatebt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updatebt.Location = new System.Drawing.Point(804, 350);
            this.updatebt.Name = "updatebt";
            this.updatebt.Size = new System.Drawing.Size(174, 50);
            this.updatebt.TabIndex = 13;
            this.updatebt.Text = "Update Store";
            this.updatebt.UseVisualStyleBackColor = false;
            this.updatebt.Click += new System.EventHandler(this.updatebt_Click);
            // 
            // StoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 467);
            this.Controls.Add(this.updatebt);
            this.Controls.Add(this.ourstorre);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mangercb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addresslb);
            this.Controls.Add(this.address);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.namebx);
            this.Controls.Add(this.showstores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.listBox1);
            this.Name = "StoreForm";
            this.Text = "StoreForm";
            this.Load += new System.EventHandler(this.StoreForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button showstores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox namebx;
        private System.Windows.Forms.Label addresslb;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox mangercb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ourstorre;
        private System.Windows.Forms.Button updatebt;
    }
}