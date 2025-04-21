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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Inventory_Management_System.Forms
{
    public partial class ModifyProduct : Form
    {
        private Product product;
        internal ModifyProduct(Product selectedProduct)
        {
            InitializeComponent();
            product = selectedProduct;
            SetupAssociatedPartsGrid();
            // Pre-fill form controls
            textBox3.Text = product.ProductID.ToString();
            textBox4.Text = product.Name;
            textBox2.Text = product.Price.ToString();
            textBox5.Text = product.InStock.ToString();
            textBox7.Text = product.Min.ToString();
            textBox6.Text = product.Max.ToString();

            textBox3.ReadOnly = true; // ID is not editable

            dataGridViewModifyCandidateParts.DataSource = Inventory.Allparts;
            dataGridViewModifyAssociatedParts.DataSource = Product.AssociatedParts;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnRemoveAssociatedPart_Click(object sender, EventArgs e)
        {
            if (dataGridViewModifyAssociatedParts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an associated part to remove.");
                return;
            }

            Part selectedPart = dataGridViewModifyAssociatedParts.SelectedRows[0].DataBoundItem as Part;

            if (selectedPart != null)
            {
                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to remove '{selectedPart.Name}'?",
                    "Confirm Remove", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Product.AssociatedParts.Remove(selectedPart);
                    dataGridViewModifyAssociatedParts.Refresh();
                }
            }
        }


        private void Modify_Product_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
        }
        public void SetupDataGridView()
        {
            dataGridViewModifyCandidateParts.AutoGenerateColumns = false;
            dataGridViewModifyCandidateParts.Columns.Clear();

            dataGridViewModifyCandidateParts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PartID",
                HeaderText = "ID"
            });

            dataGridViewModifyCandidateParts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Name",
                HeaderText = "Name"
            });

            dataGridViewModifyCandidateParts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Price",
                HeaderText = "Price"
            });

            dataGridViewModifyCandidateParts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "InStock",
                HeaderText = "In Stock"
            });

            dataGridViewModifyCandidateParts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Min",
                HeaderText = "Min"
            });

            dataGridViewModifyCandidateParts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Max",
                HeaderText = "Max"
            });

            dataGridViewModifyCandidateParts.DataSource = Inventory.Allparts;
            dataGridViewModifyCandidateParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox2.Text, out double price))
            {
                MessageBox.Show("Price must be a valid number.");
                return;
            }

            if (!int.TryParse(textBox5.Text, out int inStock))
            {
                MessageBox.Show("Inventory must be a whole number.");
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

            string name = textBox4.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Product name cannot be empty.");
                return;
            }

            // All validation passed — now save changes to the product
            product.Name = name;
            product.Price = price;
            product.InStock = inStock;
            product.Min = min;
            product.Max = max;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (dataGridViewModifyCandidateParts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a part to associate.");
                return;
            }

            Part selectedPart = dataGridViewModifyCandidateParts.SelectedRows[0].DataBoundItem as Part;

            if (selectedPart != null)
            {
                if (!Product.AssociatedParts.Contains(selectedPart))
                {
                    Product.AssociatedParts.Add(selectedPart);
                    dataGridViewModifyAssociatedParts.Refresh(); // Refresh the view
                }
                else
                {
                    MessageBox.Show("This part is already associated with the product.");
                }
            }
        }
        private void SetupAssociatedPartsGrid()
        {
            dataGridViewModifyAssociatedParts.AutoGenerateColumns = false;
            dataGridViewModifyAssociatedParts.Columns.Clear();

            dataGridViewModifyAssociatedParts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PartID",
                HeaderText = "ID"
            });

            dataGridViewModifyAssociatedParts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Name",
                HeaderText = "Name"
            });

            dataGridViewModifyAssociatedParts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Price",
                HeaderText = "Price"
            });

            dataGridViewModifyAssociatedParts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "InStock",
                HeaderText = "In Stock"
            });

            dataGridViewModifyAssociatedParts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Min",
                HeaderText = "Min"
            });

            dataGridViewModifyAssociatedParts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Max",
                HeaderText = "Max"
            });
            dataGridViewModifyAssociatedParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridViewModifyAssociatedParts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a part to remove.");
                return;
            }

            Part selectedPart = dataGridViewModifyAssociatedParts.SelectedRows[0].DataBoundItem as Part;

            if (selectedPart != null)
            {
                DialogResult confirm = MessageBox.Show(
                    $"Are you sure you want to remove '{selectedPart.Name}' from this product?",
                    "Confirm Remove", MessageBoxButtons.YesNo);

                if (confirm == DialogResult.Yes)
                {
                    Product.AssociatedParts.Remove(selectedPart);
                    dataGridViewModifyAssociatedParts.Refresh();
                }
            }
        }
    }
}

