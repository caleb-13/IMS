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
            dataGridViewAssociatedParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SetupAssociatedPartsGrid();
        }
        private void SetupAssociatedPartsGrid()
        {
            dataGridViewAssociatedParts.AutoGenerateColumns = false;
            dataGridViewAssociatedParts.Columns.Clear();

            dataGridViewAssociatedParts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PartID",
                HeaderText = "Part ID"
            });

            dataGridViewAssociatedParts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Name",
                HeaderText = "Name"
            });

            dataGridViewAssociatedParts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Price",
                HeaderText = "Price"
            });

            dataGridViewAssociatedParts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "InStock",
                HeaderText = "Inventory"
            });

            dataGridViewAssociatedParts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Min",
                HeaderText = "Min"
            });

            dataGridViewAssociatedParts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Max",
                HeaderText = "Max"
            });
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
            dataGridViewCandidateParts.DataSource = Inventory.Allparts;
            dataGridViewAssociatedParts.DataSource = Product.AssociatedParts;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridViewCandidateParts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a part to associate.");
                return;
            }

            Part selectedPart = dataGridViewCandidateParts.SelectedRows[0].DataBoundItem as Part;

            if (selectedPart != null && !Product.AssociatedParts.Contains(selectedPart))
            {
                Product.AssociatedParts.Add(selectedPart);
                dataGridViewAssociatedParts.Refresh();
            }

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
            if (!int.TryParse(textBox4.Text, out int inStock))
            {
                MessageBox.Show("Inventory must be a whole number.");
                return;
            }

            if (!double.TryParse(textBox5.Text, out double price))
            {
                MessageBox.Show("Price must be a valid number.");
                return;
            }

            if (!int.TryParse(textBox7.Text, out int min))
            {
                MessageBox.Show("Min must be a whole number.");
                return;
            }

            if (!int.TryParse(textBox6.Text, out int max))
            {
                MessageBox.Show("Max must be a whole number.");
                return;
            }

            if (min > max)
            {
                MessageBox.Show("Min cannot be greater than Max.");
                return;
            }

            if (inStock < min || inStock > max)
            {
                MessageBox.Show("Inventory must be between Min and Max.");
                return;
            }

            string name = textBox3.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Product name cannot be empty.");
                return;
            }

            // All validation passed — create the product
            int productID = Inventory.generateProductID();
            newProduct = new Product(productID, name, price, inStock, min, max);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridViewAssociatedParts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a part to remove.");
                return;
            }

            Part selectedPart = dataGridViewAssociatedParts.SelectedRows[0].DataBoundItem as Part;

            if (selectedPart != null)
            {
                DialogResult confirm = MessageBox.Show(
                    $"Remove '{selectedPart.Name}' from associated parts?",
                    "Confirm Remove", MessageBoxButtons.YesNo);

                if (confirm == DialogResult.Yes)
                {
                    Product.AssociatedParts.Remove(selectedPart);
                    dataGridViewAssociatedParts.Refresh();
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewAssociatedParts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

