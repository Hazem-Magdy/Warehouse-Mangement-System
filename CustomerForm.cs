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
    public partial class CustomerForm : Form
    {
        Context db = new Context();
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            idTx.Enabled = false;
            var customers = from c in db.Customers where c != null select c;
            foreach (var item in customers)
            {
                CustomerList.Items.Add(item.Name);
            }
        }

        private void showcustomers_Click(object sender, EventArgs e)
        {
            CustomerList.Items.Clear();
            var customers = from c in db.Customers where c != null select c;
            foreach (var item in customers)
            {
                CustomerList.Items.Add(item.Name);
            }
        }

        private void addcustomer_Click(object sender, EventArgs e)
        {
            string name = nameTx.Text;
            string telephone = telephoneTx.Text;
            string mail = emailTx.Text;
            string fax = faxTx.Text;
            string mobile = mobileTx.Text;
            string website = websiteTx.Text;
            if (name != null && telephone != null && mail !=null && fax !=null && mobile !=null && website!=null && name != "" && telephone != "" && mail != "" && fax != "" && mobile != "" && website != "")
            {
                Customer customer = new Customer();
                customer.Name = name;
                customer.Telephone = telephone;
                customer.Email = mail;
                customer.Fax = fax;
                customer.Mobile = mobile;
                customer.website = website;
                db.Customers.Add(customer);
                db.SaveChanges();
                MessageBox.Show("Customer has been added");
                nameTx.Text = telephoneTx.Text = emailTx.Text = faxTx.Text = mobileTx.Text = websiteTx.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Please enter all data, or vaild data");
            }

        }

        private void updatecustomer_Click(object sender, EventArgs e)
        {
            int id = int.Parse(idTx.Text);
            string name = nameTx.Text;
            string telephone = telephoneTx.Text;
            string mail = emailTx.Text;
            string fax = faxTx.Text;
            string mobile = mobileTx.Text;
            string website = websiteTx.Text;

            Customer selectedCustomer = db.Customers.FirstOrDefault(c => c.ID == id);
            if (selectedCustomer != null)
            {
                selectedCustomer.Name = name;
                selectedCustomer.Telephone = telephone;
                selectedCustomer.Email = mail;
                selectedCustomer.Fax = fax;
                selectedCustomer.Mobile = mobile;
                selectedCustomer.website = website;
                db.Customers.AddOrUpdate(selectedCustomer);
                db.SaveChanges();
                MessageBox.Show("Customer has been updated");
                idTx.Text = nameTx.Text = telephoneTx.Text= emailTx.Text = faxTx.Text = mobileTx.Text = websiteTx.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("No data found");
            }

        }

        private void CustomerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CustomerList.SelectedItem != null)
            {
                string customer = CustomerList.SelectedItem.ToString();
                var selectedCustomer = db.Customers.FirstOrDefault(c => c.Name == customer);
                if (selectedCustomer != null)
                {
                    idTx.Text = selectedCustomer.ID.ToString();
                    nameTx.Text = selectedCustomer.Name;
                    telephoneTx.Text = selectedCustomer.Telephone;
                    emailTx.Text = selectedCustomer.Email;
                    faxTx.Text = selectedCustomer.Fax;
                    mobileTx.Text = selectedCustomer.Mobile;
                    websiteTx.Text = selectedCustomer.website;
                }
                else
                {
                    MessageBox.Show("Not Found");
                }
            }
        }
    }
}
