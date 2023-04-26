using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Project.Entities;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace Project
{
    public partial class StoreForm : Form
    {
        Context db = new Context();
        public StoreForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void showstores_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var stores = from s in db.Store where s != null select s;
            foreach (var item in stores)
            {
                listBox1.Items.Add(item.Name);
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void mangercb_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void StoreForm_Load(object sender, EventArgs e)
        {
            ID.Enabled = false;
            var mangers = from m in db.Store where m != null select m;
            foreach (var item in mangers)
            {
                mangercb.Items.Add(item.ManagerId);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem != null)
            {
                string store = (listBox1.SelectedItem).ToString();
                var selectesStore = db.Store.Include(a=> a.ResponsiblePerson).FirstOrDefault(s=>s.Name==store);
                if(selectesStore != null)
                {
                    ID.Text = selectesStore.ID.ToString();
                    namebx.Text = selectesStore.Name;
                    address.Text = selectesStore.Address;
                    mangercb.Text = selectesStore.ManagerId.ToString();
                    ID.Enabled = false;
                }
                else
                {
                    MessageBox.Show("No data found");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = namebx.Text;
            string addressc = address.Text;
            int manager = int.Parse(mangercb.SelectedItem.ToString());
            Store newStore = new Store();
            newStore.Name = name;
            newStore.Address = addressc;
            newStore.ManagerId = manager;
            db.Store.Add(newStore);
            db.SaveChanges();
            MessageBox.Show("The store has been added");
            namebx.Text = address.Text = string.Empty;
        }

        private void updatebt_Click(object sender, EventArgs e)
        {
            int id = int.Parse(ID.Text);
            string name = namebx.Text;
            string add = address.Text;
            int manager = int.Parse(mangercb.Text);

            Store selectedStore = db.Store.FirstOrDefault(s => s.ID == id);
            Manager selectedmanager = db.Managers.FirstOrDefault(m => m.ID == manager);
            if(selectedStore!=null && selectedmanager != null)
            {
                selectedStore.Name = name;
                selectedStore.Address = add;
                selectedStore.ManagerId = selectedmanager.ID;
                selectedStore.ResponsiblePerson = selectedmanager;
                db.Store.AddOrUpdate(selectedStore);
                MessageBox.Show("Store has been updated");
                db.SaveChanges();
                namebx.Text = address.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Data not found");
            }

        }
    }
}
