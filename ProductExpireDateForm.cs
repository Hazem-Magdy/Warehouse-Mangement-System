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
using System.Runtime.InteropServices.ComTypes;

namespace Project
{
    public partial class ProductExpireDateForm : Form
    {
        Context db = new Context();
        public ProductExpireDateForm()
        {
            InitializeComponent();
        }

        private void ProductExpireDateForm_Load(object sender, EventArgs e)
        {
            var stores = from s in db.Store where s != null select s;
            foreach (var item in stores)
            {
                storeCx.Items.Add(item.Name);
            }
        }

        private void productReport_Click(object sender, EventArgs e)
        {
            string storeName = storeCx.SelectedItem.ToString();
            DateTime startDate = fromDate.Value;
            DateTime endDate = ToDate.Value;
            var products = db.ImportPermitDetails
                             .Where(ipd => ipd.ImportPermit.PermitDate >= startDate && 
                                    ipd.ImportPermit.PermitDate <= endDate)
                             .Where(ipd => ipd.ImportPermit.Store.Name == storeName)
                             .Select(ipd => new {
                                    ProductName = ipd.Product.Name,
                                    Code = ipd.Product.Code,
                                    ImportDate = ipd.ImportPermit.PermitDate
                             })
                             .Distinct()
                             .ToList();
            if (products.Count > 0)
            {
                foreach (var item in products)
                {
                    report.Rows.Add(item.ProductName, item.Code, item.ImportDate);
                }
            }
            else
            {
                MessageBox.Show("No Products found the choosen dates");
            }
        }
    }
}
