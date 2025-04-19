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
            try
            {
                product.Name = textBox4.Text;
                product.Price = double.Parse(textBox2.Text);
                product.InStock = int.Parse(textBox5.Text);
                product.Min = int.Parse(textBox7.Text);
                product.Max = int.Parse(textBox6.Text);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving product: " + ex.Message);
            }
        }
    }
}
