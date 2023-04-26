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
    public partial class StoreReportForm : Form
    {
        Context db = new Context();
        public StoreReportForm()
        {
            InitializeComponent();
        }

        private void StoreReportForm_Load(object sender, EventArgs e)
        {
            var stores = from s in db.Store where s != null select s;
            foreach (var item in stores)
            {
                storeCx.Items.Add(item.Name);
            }
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            report.Rows.Clear();
            /*
            string storeName = storeCx.Text;
            DateTime startDate = startDateTime.Value;
            DateTime endDate = endDateTime.Value;

            var query = (from store in db.Store
            from product in db.Products
                         from import in db.ImportPermits
                         from importDetails in db.ImportPermitDetails
                         where store.Name == storeName && product.StoreId == store.ID
                               && import.PermitDate >= startDate && import.PermitDate <= endDate
                               && importDetails.ImportPermitId == import.ID && importDetails.ProductId == product.ID
                         select new
                         {
                             StoreName = storeName,
                             Address = store.Address,
                             Manager = store.ResponsiblePerson,
                             ProductName = product.Name,
                             Quantity = product.Quantity,
                             ImportDate = import.PermitDate
                         }).ToList();

            foreach (var item in query)
            {
                var rowIndex = report.Rows.Add();
                var row = report.Rows[rowIndex];
                row.Cells[0].Value = item.StoreName;
                row.Cells[1].Value = item.Address;
                row.Cells[2].Value = item.Manager;
                row.Cells[3].Value = item.ProductName;
                row.Cells[4].Value = item.Quantity;
                row.Cells[5].Value = item.ImportDate;
            }
            */
            
            string storeName = storeCx.Text;
            DateTime startTime = startDateTime.Value;
            DateTime endTime = endDateTime.Value;
            var storeReport = (from s in db.Store
                               from p in db.Products
                               from i in db.ImportPermits
                               from id in db.ImportPermitDetails
                               where s.Name == storeName &&
                                     p.StoreId == s.ID &&
                                     i.PermitDate >= startTime &&
                                     i.PermitDate <= endTime &&
                                     id.ImportPermitId == i.ID &&
                                     id.ProductId == p.ID
                               select new
                               {
                                   Store = storeName,
                                   Address = s.Address,
                                   Manager = s.ResponsiblePerson,
                                   Product = p.Name,
                                   Quentity = id.Quantity,
                                   ImportDate = i.PermitDate
                               }).ToList();
            if (storeReport.Count>0)
            {
                foreach (var item in storeReport)
                {
                    var index = report.Rows.Add();
                    var row = report.Rows[index];
                    row.Cells[0].Value = item.Store;
                    row.Cells[1].Value = item.Address;
                    row.Cells[2].Value = item.Manager;
                    row.Cells[3].Value = item.Product;
                    row.Cells[4].Value = item.Quentity;
                    row.Cells[5].Value = item.ImportDate;

                }
            }
            else
            {
                MessageBox.Show("There is no Data that matched the date u entered or not matched with the database");
            }
        }
    }
}
