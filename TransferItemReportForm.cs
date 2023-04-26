using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.Entities;


namespace Project
{
    public partial class TransferItemReportForm : Form
    {
        Context db = new Context();
        public TransferItemReportForm()
        {
            InitializeComponent();
        }

        private void TransferItemReportForm_Load(object sender, EventArgs e)
        {
            var products = (from s in db.Products
                            where s != null
                            select s.Name).Distinct();
            foreach (var store in products)
            {
                productCx.Items.Add(store);
            }
        }

        private void showReport_Click(object sender, EventArgs e)
        {
            if (productCx.SelectedItem != null)
            {
                info.Rows.Clear();
                string productName = productCx.SelectedItem.ToString();
                List<TransferItemDetails> transferedItems = db.TransferItems.Include(x => x.Product).Where(p => p.Product.Name == productName).ToList();
                var from = fromDate.Value;
                var to = ToDate.Value;
                if (transferedItems != null)
                {
                    foreach (var product in transferedItems)
                    {
                        var transfered = db.Transfers.Include(x => x.FromStore).Include(x => x.ToStore).FirstOrDefault(s => s.ID == product.TransferId && s.TransferDate >= from && s.TransferDate <= to);

                        if (transfered != null)
                        {
                            DataGridViewRow row = new DataGridViewRow();
                            DataGridViewCell cell1 = new DataGridViewTextBoxCell();
                            DataGridViewCell cell2 = new DataGridViewTextBoxCell();
                            DataGridViewCell cell3 = new DataGridViewTextBoxCell();
                            DataGridViewCell cell4 = new DataGridViewTextBoxCell();
                            DataGridViewCell cell5 = new DataGridViewTextBoxCell();
                            cell1.Value = productName;
                            cell2.Value = transfered.TransferDate;
                            cell3.Value = transfered.FromStore.Name;
                            cell4.Value = transfered.ToStore.Name;
                            cell5.Value = product.Quantity;

                            row.Cells.Add(cell1);
                            row.Cells.Add(cell2);
                            row.Cells.Add(cell3);
                            row.Cells.Add(cell4);
                            row.Cells.Add(cell5);
                            info.Rows.Add(row);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("The product you choosed doesn't has any transform from one store to another");
                }
            }
            else
            {
                MessageBox.Show("Please, select product to get the report");
            }
        }
    }
}
