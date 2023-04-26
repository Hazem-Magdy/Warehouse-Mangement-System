using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.Entities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Project
{
    public partial class TransferForm : Form
    {
        Context db = new Context();
        public TransferForm()
        {
            InitializeComponent();
            var allStores = from s in db.Store where s != null select s;
            foreach (var item in allStores)
            {
                storeToTx.Items.Add(item.Name);
                storeFromTx.Items.Add(item.Name);
            }
            idTx.Enabled = false;
        }

        private void TransferForm_Load(object sender, EventArgs e)
        {
            idTx.Enabled = false;
            transfer_items.Items.Clear();
        }
        private void FillListData()
        {
            var products = from p in db.Products where p != null select p;
            foreach (var item in products)
            {
                transfer_items.Items.Add(item.Name);
            }
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            transfer_items.Items.Clear();
            FillListData();
        }

        private void addPremitBtn_Click(object sender, EventArgs e)
        {
            DateTime transfer = transferDate.Value;
            var fromStore = db.Store.FirstOrDefault(s => s.Name == storeFromTx.SelectedItem.ToString());
            var toStore = db.Store.FirstOrDefault(s => s.Name == storeToTx.SelectedItem.ToString());
            int quentity = int.Parse(quentityTx.Text);
            DateTime pDate = productionDate.Value;
            DateTime eDate = expirationDate.Value;
            var product = db.Products.FirstOrDefault(p => p.Name == transfer_items.SelectedItem.ToString());
            ICollection<TransferItemDetails> transferItemDetails = new List<TransferItemDetails>();
            TransferItemDetails transferItem = new TransferItemDetails() 
            {
                Quantity = quentity,
                ProductionDate = pDate,
                ExpirationDate = eDate,
                ProductId = product.ID
            };
            transferItemDetails.Add(transferItem);
            Transfer transfer1 = new Transfer()
            {
                FromStoreId= fromStore.ID,
                ToStoreId = toStore.ID,
                TransferDate = transfer,
                TransferItem = transferItemDetails
            };
            db.TransferItems.Add(transferItem);
            MessageBox.Show("Succesfully addded");
            db.Transfers.Add(transfer1);
            db.SaveChanges();
            quentityTx.Text = storeToTx.Text = storeFromTx.Text = string.Empty;           
        }

        private void transfer_items_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (transfer_items !=null)
            {
                string productName = transfer_items.SelectedItem.ToString();
                var product = db.Products.FirstOrDefault(p => p.Name == productName);
                if(product != null)
                {
                    TransferItemDetails updateTransfer = db.TransferItems.FirstOrDefault(t => t.ProductId == product.ID);
                    if (updateTransfer != null)
                    {
                        var fromstore = db.Store.FirstOrDefault(s => s.ID == product.StoreId);
                        if (fromstore != null)
                            storeFromTx.Text = fromstore.Name;
                        quentityTx.Text = updateTransfer?.Quantity.ToString();
                        productionDate.Value = updateTransfer.ProductionDate;
                        expirationDate.Value = updateTransfer.ExpirationDate;
                        idTx.Text = updateTransfer.TransferId.ToString();
                        if(updateTransfer.TransferId != null)
                        {
                            var transferInfo = db.Transfers.FirstOrDefault(t => t.ID == updateTransfer.TransferId);
                            if(transferInfo != null)
                            {
                                transferDate.Value = transferInfo.TransferDate;
                                var store = db.Store.FirstOrDefault(s => s.ID == transferInfo.ToStoreId);
                                if (store != null)
                                {
                                    storeToTx.Text = store.Name; 
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Transfer is null");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No transfer found ");
                    }

                }
            }
        }

        private void updatePremitBtn_Click(object sender, EventArgs e)
        {
            DateTime transfer = transferDate.Value;
            var fromStore = db.Store.FirstOrDefault(s => s.Name == storeFromTx.SelectedItem.ToString());
            var toStore = db.Store.FirstOrDefault(s => s.Name == storeToTx.SelectedItem.ToString());
            int quentity = int.Parse(quentityTx.Text);
            DateTime pDate = productionDate.Value;
            DateTime eDate = expirationDate.Value;
            var product = db.Products.FirstOrDefault(p => p.Name == transfer_items.SelectedItem.ToString());
            ICollection<TransferItemDetails> transferItemDetails = new List<TransferItemDetails>();
            TransferItemDetails transferItem = new TransferItemDetails()
            {
                Quantity = quentity,
                ProductionDate = pDate,
                ExpirationDate = eDate,
                ProductId = product.ID
            };
            transferItemDetails.Add(transferItem);
            Transfer transfer1 = new Transfer()
            {
                FromStoreId = fromStore.ID,
                ToStoreId = toStore.ID,
                TransferDate = transfer,
                TransferItem = transferItemDetails
            };
            db.TransferItems.Add(transferItem);
            MessageBox.Show("Succesfully updated");
            db.Transfers.AddOrUpdate(transfer1);
            db.SaveChanges();
            quentityTx.Text = storeToTx.Text = storeFromTx.Text = string.Empty;
        }
    }
}
