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

        private BindingList<Part> associatedParts = new BindingList<Part>();
        internal ModifyProduct(Product selectedProduct)
        {
            InitializeComponent();
            product = selectedProduct;
            SetupAssociatedPartsGrid();

            textBox3.Text = product.ProductID.ToString();
            textBox4.Text = product.Name;
            textBox2.Text = product.Price.ToString();
            textBox5.Text = product.InStock.ToString();
            textBox7.Text = product.Min.ToString();
            textBox6.Text = product.Max.ToString();

            textBox3.ReadOnly = true;

            dataGridViewModifyCandidateParts.DataSource = Inventory.Allparts;

            associatedParts = new BindingList<Part>(Product.AssociatedParts.ToList());
            dataGridViewModifyAssociatedParts.DataSource = associatedParts;
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
            try
            {
                string name = textBox4.Text.Trim();
                if (string.IsNullOrEmpty(name))
                {
                    MessageBox.Show("Product name cannot be empty. Please enter a name.");
                    return;
                }

                if (!int.TryParse(textBox5.Text, out int inStock))
                {
                    MessageBox.Show($"Inventory must be a whole number. You entered: '{textBox5.Text}'.");
                    return;
                }

                if (!double.TryParse(textBox2.Text, out double price))
                {
                    MessageBox.Show($"Price must be a decimal number (e.g., 9.99). You entered: '{textBox2.Text}'.");
                    return;
                }

                if (!int.TryParse(textBox7.Text, out int min))
                {
                    MessageBox.Show($"Min must be a whole number. You entered: '{textBox7.Text}'.");
                    return;
                }

                if (!int.TryParse(textBox6.Text, out int max))
                {
                    MessageBox.Show($"Max must be a whole number. You entered: '{textBox6.Text}'.");
                    return;
                }

                if (min > max)
                {
                    MessageBox.Show($"Min value ({min}) cannot be greater than Max value ({max}).");
                    return;
                }

                if (inStock < min || inStock > max)
                {
                    MessageBox.Show($"Inventory value ({inStock}) must be between Min ({min}) and Max ({max}).");
                    return;
                }

               
                product.Name = name;
                product.Price = price;
                product.InStock = inStock;
                product.Min = min;
                product.Max = max;

            
                Product.AssociatedParts.Clear();
                foreach (Part part in associatedParts)
                {
                    product.addAssociatedPart(part);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error while saving product: " + ex.Message);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridViewModifyCandidateParts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a part to add.");
                return;
            }

            Part selectedPart = dataGridViewModifyCandidateParts.SelectedRows[0].DataBoundItem as Part;

            if (selectedPart == null)
            {
                MessageBox.Show("Selected part is invalid.");
                return;
            }

           
            bool alreadyAssociated = associatedParts.Any(p => p.PartID == selectedPart.PartID);


            associatedParts.Add(selectedPart);
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
                    $"Are you sure you want to remove '{selectedPart.Name}' from the associated parts?",
                    "Confirm Remove", MessageBoxButtons.YesNo);

                if (confirm == DialogResult.Yes)
                {
                    associatedParts.Remove(selectedPart); 
                }
                
            }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            string searchTerm = textBox1.Text.Trim().ToLower();

            
            if (string.IsNullOrEmpty(searchTerm))
            {
                dataGridViewModifyCandidateParts.ClearSelection();
                MessageBox.Show("Please enter a Part ID or Name.");
                return;
            }

            bool found = false;

            for (int i = 0; i < dataGridViewModifyCandidateParts.Rows.Count; i++)
            {
                Part part = dataGridViewModifyCandidateParts.Rows[i].DataBoundItem as Part;

                if (part != null &&
                    (part.PartID.ToString() == searchTerm || part.Name.ToLower().Contains(searchTerm)))
                {
                    dataGridViewModifyCandidateParts.ClearSelection();
                    dataGridViewModifyCandidateParts.Rows[i].Selected = true;
                    dataGridViewModifyCandidateParts.FirstDisplayedScrollingRowIndex = i;
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                MessageBox.Show("Part not found.");
            }
        }
    }
}

