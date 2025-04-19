using Inventory_Management_System.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System.Forms
{
    public partial class AddProductForm : Form
    {

        internal Product newProduct;
        public AddProductForm()
        {
            InitializeComponent();
            dataGridViewCandidateParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }


        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
        }

        private void button4_Click(object sender, EventArgs e)
        {


        }
        public void SetupDataGridView()
        {
            dataGridViewCandidateParts.AutoGenerateColumns = false;
            dataGridViewCandidateParts.Columns.Clear();

            dataGridViewCandidateParts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PartID",
                HeaderText = "ID"
            });

            dataGridViewCandidateParts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Name",
                HeaderText = "Name"
            });

            dataGridViewCandidateParts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Price",
                HeaderText = "Price"
            });

            dataGridViewCandidateParts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "InStock",
                HeaderText = "In Stock"
            });

            dataGridViewCandidateParts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Min",
                HeaderText = "Min"
            });

            dataGridViewCandidateParts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Max",
                HeaderText = "Max"
            });

            dataGridViewCandidateParts.DataSource = Inventory.Allparts;
            dataGridViewCandidateParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }




        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int productID = Inventory.generateProductID(); 
                string name = textBox3.Text;
                int instock = int.Parse(textBox4.Text);
                double price = double.Parse(textBox5.Text);
                int min = int.Parse(textBox7.Text);
                int max = int.Parse(textBox6.Text);

                newProduct = new Product(productID, name, price, instock, min, max);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
