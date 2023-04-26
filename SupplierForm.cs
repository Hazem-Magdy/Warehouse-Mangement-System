using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.Entities;

namespace Project
{
    public partial class SupplierForm : Form
    {
        Context db = new Context();
        public SupplierForm()
        {
            InitializeComponent();
        }

        private void SupplierForm_Load(object sender, EventArgs e)
        {
            idTx.Enabled = false;
            var suppliers = from s in db.Suppliers where s != null select s;
            foreach (var item in suppliers)
            {
                SupplierList.Items.Add(item.Name);
            }
        }

        private void showsuppliers_Click(object sender, EventArgs e)
        {
            SupplierList.Items.Clear();
            var Suppliers = from c in db.Suppliers where c != null select c;
            foreach (var item in Suppliers)
            {
                SupplierList.Items.Add(item.Name);
            }
        }

        private void addSupplier_Click(object sender, EventArgs e)
        {
            string name = nameTx.Text;
            string telephone = telephoneTx.Text;
            string mail = emailTx.Text;
            string fax = faxTx.Text;
            string mobile = mobileTx.Text;
            string website = websiteTx.Text;
            if (name != null && telephone != null && mail != null && fax != null && mobile != null && website != null && name != "" && telephone != "" && mail != "" && fax != "" && mobile != "" && website != "")
            {
                Supplier supplier = new Supplier();
                supplier.Name = name;
                supplier.Telephone = telephone;
                supplier.Email = mail;
                supplier.Fax = fax;
                supplier.Mobile = mobile;
                supplier.website = website;
                db.Suppliers.Add(supplier);
                db.SaveChanges();
                MessageBox.Show("Supplier has been added");
                nameTx.Text = telephoneTx.Text = emailTx.Text = faxTx.Text = mobileTx.Text = websiteTx.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Please enter all data, or vaild data");
            }
        }

        private void updateSupplier_Click(object sender, EventArgs e)
        {
            int id = int.Parse(idTx.Text);
            string name = nameTx.Text;
            string telephone = telephoneTx.Text;
            string mail = emailTx.Text;
            string fax = faxTx.Text;
            string mobile = mobileTx.Text;
            string website = websiteTx.Text;

            Supplier selectedSupplier = db.Suppliers.FirstOrDefault(c => c.ID == id);
            if (selectedSupplier != null)
            {
                selectedSupplier.Name = name;
                selectedSupplier.Telephone = telephone;
                selectedSupplier.Email = mail;
                selectedSupplier.Fax = fax;
                selectedSupplier.Mobile = mobile;
                selectedSupplier.website = website;
                db.Suppliers.AddOrUpdate(selectedSupplier);
                db.SaveChanges();
                MessageBox.Show("Supplier has been updated");
                idTx.Text = nameTx.Text = telephoneTx.Text = emailTx.Text = faxTx.Text = mobileTx.Text = websiteTx.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("No data found");
            }
        }

        private void SupplierList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SupplierList.SelectedItem != null)
            {
                string supplier = SupplierList.SelectedItem.ToString();
                var selectedSupplier= db.Suppliers.FirstOrDefault(c => c.Name == supplier);
                if (selectedSupplier!= null)
                {
                    idTx.Text = selectedSupplier.ID.ToString();
                    nameTx.Text = selectedSupplier.Name;
                    telephoneTx.Text = selectedSupplier.Telephone;
                    emailTx.Text = selectedSupplier.Email;
                    faxTx.Text = selectedSupplier.Fax;
                    mobileTx.Text = selectedSupplier.Mobile;
                    websiteTx.Text = selectedSupplier.website;
                }
                else
                {
                    MessageBox.Show("Not Found");
                }
            }
        }
    }
}
