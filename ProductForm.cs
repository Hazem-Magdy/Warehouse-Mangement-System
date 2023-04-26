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
    public partial class ProductForm : Form
    {
        Context db = new Context();
        public ProductForm()
        {
            InitializeComponent();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            idTx.Enabled = false;
            var stores = from s in db.Store where s != null select s;
            foreach (var item in stores)
            {
                storeTx.Items.Add(item.ID);
            }
        }

        private void showproducts_Click(object sender, EventArgs e)
        {
            productList.Items.Clear();
            var products = from p in db.Products where p != null select p;
            foreach (var item in products)
            {
                productList.Items.Add(item.Name);
            }
        }

        private void addproducts_Click(object sender, EventArgs e)
        {
            string name = nameTx.Text;
            string code = codeTx.Text;
            string units = unitTx.Text;
            int store = int.Parse(storeTx.SelectedItem.ToString());
            Product newProduct = new Product();
            newProduct.Name = name;
            newProduct.Code = code;
            newProduct.UnitsOfMeasure = units;
            newProduct.StoreId = store;
            db.Products.Add(newProduct);
            db.SaveChanges();
            MessageBox.Show("Product has been updated");
            nameTx.Text = codeTx.Text = unitTx.Text = string.Empty;
            
        }

        private void updateproducts_Click(object sender, EventArgs e)
        {
            int id = int.Parse(idTx.Text);
            string name = nameTx.Text;
            string code = codeTx.Text;
            string unit = unitTx.Text;
            int store = int.Parse(storeTx.Text);
            Product selectedProduct = db.Products.FirstOrDefault(p => p.ID == id);
            Store selectesStore = db.Store.FirstOrDefault(s => s.ID == store);
            if (selectedProduct != null && selectesStore != null)
            {
                selectedProduct.Name = name;
                selectedProduct.Code = code;
                selectedProduct.UnitsOfMeasure = unit;
                selectedProduct.Store = selectesStore;
                db.Products.AddOrUpdate(selectedProduct);
                db.SaveChanges();
                MessageBox.Show("The product has been updated");
                nameTx.Text = codeTx.Text = unitTx.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Data not found");
            }
        }

        private void productList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(productList.SelectedItem != null)
            {
                string product = productList.SelectedItem.ToString();
                var selectedProduct = db.Products.FirstOrDefault(p => p.Name == product);
                if(selectedProduct != null)
                {
                    idTx.Text = selectedProduct.ID.ToString();
                    nameTx.Text = selectedProduct.Name;
                    codeTx.Text = selectedProduct.Code;
                    unitTx.Text = selectedProduct.UnitsOfMeasure;
                    productList.Text = selectedProduct.StoreId.ToString();
                    idTx.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Not found");
                }
            }
        }
    }
}
