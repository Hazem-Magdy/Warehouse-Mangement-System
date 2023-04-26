using Project.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

        private void showStore_Click(object sender, EventArgs e)
        {
			StoreForm stores = new StoreForm();
			stores.Show();
        }

        private void productBtn_Click(object sender, EventArgs e)
        {
			ProductForm product = new ProductForm();
			product.Show();
        }

        private void customerBtn_Click(object sender, EventArgs e)
        {
            CustomerForm customer = new CustomerForm();
            customer.Show();
        }

        private void showSupplier_Click(object sender, EventArgs e)
        {
            SupplierForm supplier = new SupplierForm();
            supplier.Show();
        }

        private void exchangePremit_Click(object sender, EventArgs e)
        {
            ExchangePremitForm exchangePremit = new ExchangePremitForm();
            exchangePremit.Show();
        }

        private void importPremit_Click(object sender, EventArgs e)
        {
            ImportPremitForm importPremit = new ImportPremitForm();
            importPremit.Show();
        }

        private void showTransfer_Click(object sender, EventArgs e)
        {
            TransferForm transfer = new TransferForm();
            transfer.Show();
        }

        private void storeReport_Click(object sender, EventArgs e)
        {
            StoreReportForm storeReport = new StoreReportForm();
            storeReport.Show();
        }


        private void productReport_Click(object sender, EventArgs e)
        {
            ProductReportForm productReport = new ProductReportForm();
            productReport.Show();
        }

        private void expireDate_Click(object sender, EventArgs e)
        {
            ProductExpireDateForm productExpireDate = new ProductExpireDateForm();
            productExpireDate.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TransferItemReportForm transferItemReport = new TransferItemReportForm();
            transferItemReport.Show();
        }
    }
}
