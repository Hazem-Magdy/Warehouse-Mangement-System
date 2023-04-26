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
    public partial class ImportPremitForm : Form
    {
        Context db = new Context();
        public ImportPremitForm()
        {
            InitializeComponent();
            var allStores = from s in db.Store where s != null select s;
            foreach (var item in allStores)
            {
                storeTx.Items.Add(item.Name);
            }
            var allSuppliers = from sp in db.Suppliers where sp != null select sp;
            foreach (var item in allSuppliers)
            {
                supplierTx.Items.Add(item.Name);
            }
            var allProducts = from p in db.Products where p != null select p;
            foreach (var item in allProducts)
            {
                if(item != null)
                {
                    productsTx.Rows.Add(item.Name);
                }
            }
            idTx.Enabled = false;

        }

        private void Show_Import_Premits_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            RemoveGridViewCell();
            var selectedImportPremit = Show_Import_Premits.SelectedItem.ToString();
            var importPremit = db.ImportPermits
                                 .Include(i => i.ImportPermitDetails)
                                 .Include(s => s.Store)
                                 .Include(sp => sp.Supplier)
                                 .FirstOrDefault(p => p.PermitNumber == selectedImportPremit);
            if(importPremit != null)
            {
                idTx.Text = importPremit.ID.ToString();
                storeTx.SelectedItem = importPremit.Store.Name;
                premitDate.Value = importPremit.PermitDate;
                productionDate.Value = importPremit.ProductionDate;
                expiryDate.Value = importPremit.ExpiryDate;
                supplierTx.SelectedItem = importPremit.Supplier.Name;
                premitTx.Text = importPremit.PermitNumber;
                foreach (var item in importPremit.ImportPermitDetails)
                {
                    foreach (DataGridViewRow row in productsTx.Rows)
                    {
                        if (row.Cells[0].Value != null && row.Cells[0].Value == item.Product.Name)
                        {
                            row.Cells[1].Value = item.Quantity;
                        }
                    }
                }

            }

        }

        private void ImportPremitForm_Load(object sender, EventArgs e)
        {
            idTx.Enabled = false;
            Show_Import_Premits.Items.Clear();
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            Show_Import_Premits.Items.Clear();
            importPremits();
        }
        private void importPremits()
        {
            Show_Import_Premits.Items.Clear();
            var allPremits = from premit in db.ImportPermits where premit != null select premit;
            foreach (var item in allPremits)
            {
                Show_Import_Premits.Items.Add(item.PermitNumber);
            }
        }

        private void addPremitBtn_Click(object sender, EventArgs e)
        {
            string number = premitTx.Text;
            DateTime pDate = premitDate.Value;
            DateTime production = productionDate.Value;
            DateTime expiry = expiryDate.Value;
            string store = storeTx.SelectedItem.ToString();
            string supplier = supplierTx.SelectedItem.ToString();
            var selectedStore = db.Store.FirstOrDefault(s => s.Name == store);
            var selectedSupplier = db.Suppliers.FirstOrDefault(sp => sp.Name == supplier);
            List<ImportPermitDetail> premitDetails = new List<ImportPermitDetail>();
            List<Product> products = db.Products.ToList();
            foreach (DataGridViewRow row in productsTx.Rows)
            {
                if (row.Cells[1].Value != null)
                {
                    var productName = row.Cells[0].Value.ToString();
                    var product = db.Products.FirstOrDefault(p => p.Name == productName);
                    if(product != null)
                    {
                        ImportPermitDetail permitDetail = new ImportPermitDetail()
                        {
                            Product = product,
                            ProductId = product.ID,
                            Quantity = int.Parse(row.Cells[1].Value.ToString())
                        };
                        premitDetails.Add(permitDetail);
                    }
                }
            }
            ImportPermit importPermit = new ImportPermit()
            {
                ExpiryDate = expiry,
                ProductionDate = production,
                PermitDate = pDate,
                PermitNumber = number,
                Store = selectedStore,
                StoreId = selectedStore.ID,
                Supplier = selectedSupplier,
                SupplierId = selectedSupplier.ID
            };
            db.ImportPermits.Add(importPermit);
            db.SaveChanges();
            MessageBox.Show("Premit production has been added");
            importPremits();
            premitTx.Text = storeTx.Text= premitTx.Text = string.Empty;
            RemoveGridViewCell();
        }
        private void RemoveGridViewCell()
        {
            foreach (DataGridViewRow row in productsTx.Rows)
            {
                if (row.Cells[1].Value != null)
                {
                    row.Cells[1].Value = null;
                }
            }
        }

        private void updatePremitBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(idTx.Text);
            string pNumber = premitTx.Text;
            DateTime pDate = premitDate.Value;
            DateTime proDate = productionDate.Value;
            DateTime expDate = expiryDate.Value;
            string store = storeTx.SelectedItem.ToString();
            string supplier = supplierTx.SelectedItem.ToString();

            ImportPermit importPermitOld = db.ImportPermits.FirstOrDefault(p => p.ID == id);
            Supplier selectedSupplier = db.Suppliers.FirstOrDefault(s => s.Name == supplier);
            Store selectedStore = db.Store.FirstOrDefault(s => s.Name == store);

            List<ImportPermitDetail> importPermits = new List<ImportPermitDetail>();
            List<Product> products = db.Products.ToList();

            foreach (DataGridViewRow row in productsTx.Rows)
            {
                if (row.Cells[1].Value != null)
                {
                    var productName = row.Cells[0].Value.ToString();
                    ImportPermitDetail product = importPermitOld.ImportPermitDetails.FirstOrDefault(p => p.Product.Name == productName);
                    if(product != null)
                    {
                        product.Quantity = int.Parse(row.Cells[1].Value.ToString());
                        importPermits.Add(product);
                    }
                    else
                    {
                        ImportPermitDetail newProduct = new ImportPermitDetail()
                        {
                            Product = db.Products.FirstOrDefault(x => x.Name == productName),
                            ProductId = db.Products.FirstOrDefault(x => x.Name == productName).ID,
                            Quantity = int.Parse(row.Cells[1].Value.ToString()),
                            ImportPermitId = importPermitOld.ID,
                            ImportPermit = importPermitOld
                        };
                        importPermits.Add(newProduct);
                    }
                }
            }

            importPermitOld.PermitNumber = pNumber;
            importPermitOld.PermitDate = pDate;
            importPermitOld.ProductionDate = proDate;
            importPermitOld.ExpiryDate = expDate;
            importPermitOld.ImportPermitDetails = importPermits;
            importPermitOld.Store = selectedStore;
            importPermitOld.StoreId = selectedStore.ID;
            importPermitOld.Supplier = selectedSupplier;
            importPermitOld.SupplierId = selectedSupplier.ID;
            db.ImportPermits.AddOrUpdate(importPermitOld);
            db.SaveChanges();
            MessageBox.Show("Import premit has been updated");
            idTx.Text = premitTx.Text = storeTx.Text = supplierTx.Text = string.Empty;
            RemoveGridViewCell();
            importPremits();
        }
    }
}
