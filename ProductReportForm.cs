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
    public partial class ProductReportForm : Form
    {
        Context db = new Context();
        public ProductReportForm()
        {
            InitializeComponent();
        }

        private void ProductReportForm_Load(object sender, EventArgs e)
        {
            var products = from p in db.Products where p != null select p;
            foreach (var item in products)
            {
                productCx.Items.Add(item.Name);
            }
        }

        private void productCx_SelectedIndexChanged(object sender, EventArgs e)
        {
            storeCbx.Items.Clear();
            string productName = productCx.Text;
            var products = db.Products.Where(p => p.Name == productName);
            foreach (var prd in products)
            {
                var stores = db.Store.Where(s => s.ID == prd.StoreId);
                foreach (var item in stores)
                {
                    storeCbx.Items.Add(item.Name);
                }
            }

        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            report.Rows.Clear();
            DateTime startDate = startDateTime.Value;
            DateTime endDate = endDateTime.Value;
            string prdName = productCx.Text;

            List<int> storesId = new List<int>();
            foreach (var item in storeCbx.CheckedItems)
            {
                string storeName = item.ToString();
                Store store = db.Store.FirstOrDefault(s => s.Name == storeName);
                if (store != null)
                {
                    storesId.Add(store.ID);
                }
            }

            var products = db.Products
                          .Where(p => storesId.Contains(p.StoreId)
                              && (p.ImportPermitDetail.Any(ip => ip.ImportPermit.PermitDate >= startDate && ip.ImportPermit.PermitDate <= endDate)
                                  || p.ExchangePermitDetail.Any(ep => ep.ExchangePermit.PermitDate >= startDate && ep.ExchangePermit.PermitDate <= endDate)))
                          .ToList();


            var productsByStores = products.GroupBy(p => p.Store);
            report.Rows.Clear();

            foreach (var productsInStore in productsByStores)
            {
                Store store = productsInStore.Key;

                foreach (Product product in productsInStore)
                {
                    decimal totalQuantity = 0;
                    foreach (ImportPermitDetail importDetail in product.ImportPermitDetail)
                    {
                        if (importDetail.ImportPermit.PermitDate >= startDate && importDetail.ImportPermit.PermitDate <= endDate)
                        {
                            totalQuantity += importDetail.Quantity;
                        }
                    }
                    foreach (ExchangePermitDetail exchangeDetail in product.ExchangePermitDetail)
                    {
                        if (exchangeDetail.ExchangePermit.PermitDate >= startDate && exchangeDetail.ExchangePermit.PermitDate <= endDate)
                        {
                            totalQuantity -= exchangeDetail.Quantity;
                        }
                    }


                    var rowIndex = report.Rows.Add();
                    var row = report.Rows[rowIndex];
                    row.Cells[0].Value = store.Name;
                    row.Cells[1].Value = product.Name;
                    row.Cells[2].Value = product.Code;
                    row.Cells[3].Value = totalQuantity;
                    row.Cells[4].Value = product.UnitsOfMeasure;

                }
            }
        }
    }
}
