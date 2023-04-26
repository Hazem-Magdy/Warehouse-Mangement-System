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
    public partial class ExchangePremitForm : Form
    {
        Context db = new Context();
        public ExchangePremitForm()
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
                if (item != null)
                {
                    productsTx.Rows.Add(item.Name);
                }
            }
            idTx.Enabled = false;
        }

        private void ExchangePremitForm_Load(object sender, EventArgs e)
        {
            idTx.Enabled = false;
            Show_Exchange_Premits.Items.Clear();
        }

        private void Show_Exchange_Premits_SelectedIndexChanged(object sender, EventArgs e)
        {
            RemoveGridViewCell();
            var selectedExcangePremit = Show_Exchange_Premits.SelectedItem.ToString();
            var exchangePremit = db.ExchangePermits
                                 .Include(i => i.ExchangePermitDetail)
                                 .Include(s => s.Store)
                                 .Include(sp => sp.Supplier)
                                 .FirstOrDefault(p => p.PermitNumber == selectedExcangePremit);
            if (exchangePremit != null)
            {
                idTx.Text = exchangePremit.ID.ToString();
                storeTx.SelectedItem = exchangePremit.Store.Name;
                premitdateTime.Value = exchangePremit.PermitDate;
                supplierTx.SelectedItem = exchangePremit.Supplier.Name;
                premitNum.Text = exchangePremit.PermitNumber;
                foreach (var item in exchangePremit.ExchangePermitDetail)
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
            else
            {
                MessageBox.Show("No exchange data for this item");
            }
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

        private void showBtn_Click(object sender, EventArgs e)
        {
            Show_Exchange_Premits.Items.Clear();
            importPremits();
        }
        private void importPremits()
        {
            Show_Exchange_Premits.Items.Clear();
            var allPremits = from premit in db.ExchangePermits where premit != null select premit;
            foreach (var item in allPremits)
            {
                Show_Exchange_Premits.Items.Add(item.PermitNumber);
            }
        }

        private void addPremitBtn_Click(object sender, EventArgs e)
        {
            string number = premitNum.Text;
            DateTime pDate = premitdateTime.Value;
            string store = storeTx.SelectedItem.ToString();
            string supplier = supplierTx.SelectedItem.ToString();
            var selectedStore = db.Store.FirstOrDefault(s => s.Name == store);
            var selectedSupplier = db.Suppliers.FirstOrDefault(sp => sp.Name == supplier);
            List<ExchangePermitDetail> exchangeDetails = new List<ExchangePermitDetail>();
            List<Transfer> transfers = db.Transfers.ToList();
            foreach (DataGridViewRow row in productsTx.Rows)
            {
                if (row.Cells[1].Value != null)
                {
                    var productName = row.Cells[0].Value.ToString();
                    var transfer = db.Products.FirstOrDefault(p => p.Name == productName);
                    if (transfer != null)
                    {
                        ExchangePermitDetail exDetail = new ExchangePermitDetail()
                        {
                            Product = transfer,
                            ProductId = transfer.ID,
                            Quantity = int.Parse(row.Cells[1].Value.ToString())
                        };
                        exchangeDetails.Add(exDetail);
                    }
                }
            }
            ExchangePermit exchangePermit = new ExchangePermit()
            {
                PermitDate = pDate,
                PermitNumber = number,
                Store = selectedStore,
                StoreId = selectedStore.ID,
                Supplier = selectedSupplier,
                SupplierId = selectedSupplier.ID
            };
            db.ExchangePermits.Add(exchangePermit);
            db.SaveChanges();
            MessageBox.Show("Exchange Premit has been added");
            importPremits();
            premitdateTime.Text = storeTx.Text  = string.Empty;
            RemoveGridViewCell();
            
        }

        private void updatePremitBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(idTx.Text);
            string pNumber = premitNum.Text;
            DateTime pDate = premitdateTime.Value;
            string store = storeTx.SelectedItem.ToString();
            string supplier = supplierTx.SelectedItem.ToString();

            ExchangePermit exchangePermitOld = db.ExchangePermits.FirstOrDefault(p => p.ID == id);
            Supplier selectedSupplier = db.Suppliers.FirstOrDefault(s => s.Name == supplier);
            Store selectedStore = db.Store.FirstOrDefault(s => s.Name == store);

            List<ExchangePermitDetail> importPermits = new List<ExchangePermitDetail>();
            List<Product> products = db.Products.ToList();

            foreach (DataGridViewRow row in productsTx.Rows)
            {
                if (row.Cells[1].Value != null)
                {
                    var productName = row.Cells[0].Value.ToString();
                    ExchangePermitDetail product = exchangePermitOld.ExchangePermitDetail.FirstOrDefault(p => p.Product.Name == productName);
                    if (product != null)
                    {
                        product.Quantity = int.Parse(row.Cells[1].Value.ToString());
                        importPermits.Add(product);
                    }
                    else
                    {
                        ExchangePermitDetail newProduct = new ExchangePermitDetail()
                        {
                            Product = db.Products.FirstOrDefault(x => x.Name == productName),
                            ProductId = db.Products.FirstOrDefault(x => x.Name == productName).ID,
                            Quantity = int.Parse(row.Cells[1].Value.ToString()),
                            ExchangePermitId = exchangePermitOld.ID,
                            ExchangePermit = exchangePermitOld
                        };
                        importPermits.Add(newProduct);
                    }
                }
            }

            exchangePermitOld.PermitNumber = pNumber;
            exchangePermitOld.PermitDate = pDate;
            exchangePermitOld.ExchangePermitDetail = importPermits;
            exchangePermitOld.Store = selectedStore;
            exchangePermitOld.StoreId = selectedStore.ID;
            exchangePermitOld.Supplier = selectedSupplier;
            exchangePermitOld.SupplierId = selectedSupplier.ID;
            db.ExchangePermits.AddOrUpdate(exchangePermitOld);
            db.SaveChanges();
            MessageBox.Show("export premit has been updated");
            idTx.Text = premitNum.Text = storeTx.Text = supplierTx.Text = string.Empty;
            RemoveGridViewCell();
            importPremits();
        }
    }
}
