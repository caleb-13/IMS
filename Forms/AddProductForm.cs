﻿using Inventory_Management_System.Models;
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
    public partial class AddProductForm : Form
    {
        private BindingList<Part> associatedParts = new BindingList<Part>();
        private int newProductID;
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
            newProductID = Inventory.generateProductID();
            textBox2.Text = newProductID.ToString();
            textBox2.ReadOnly = true;
            textBox2.TabStop = false;
            textBox2.BackColor = SystemColors.Window;
            textBox2.ForeColor = SystemColors.ControlText;

            dataGridViewCandidateParts.DataSource = Inventory.Allparts;
            dataGridViewAssociatedParts.DataSource = associatedParts;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridViewCandidateParts.SelectedRows.Count > 0)
            {
                Part selectedPart = dataGridViewCandidateParts.SelectedRows[0].DataBoundItem as Part;
                if (selectedPart != null && !associatedParts.Contains(selectedPart))
                {
                    associatedParts.Add(selectedPart); 
                }
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
            try
            {
                string name = textBox3.Text.Trim();
                if (string.IsNullOrEmpty(name))
                {
                    MessageBox.Show("Product name cannot be empty. Please enter a name.");
                    return;
                }

                if (!int.TryParse(textBox4.Text, out int inStock))
                {
                    MessageBox.Show($"Inventory must be a whole number. You entered: '{textBox4.Text}'.");
                    return;
                }

                if (!double.TryParse(textBox5.Text, out double price))
                {
                    MessageBox.Show($"Price must be a decimal number (e.g., 9.99). You entered: '{textBox5.Text}'.");
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

                newProduct = new Product(newProductID, name, price, inStock, min, max);

                foreach (Part part in associatedParts)
                {
                    newProduct.addAssociatedPart(part); 
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error: " + ex.Message);
            }

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
                    associatedParts.Remove(selectedPart);
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

        private void button5_Click(object sender, EventArgs e)
        {
            string searchTerm = textBox1.Text.Trim().ToLower();
            bool found = false;

            for (int i = 0; i < dataGridViewCandidateParts.Rows.Count; i++)
            {
                Part part = dataGridViewCandidateParts.Rows[i].DataBoundItem as Part;

                if (part != null &&
                    (part.PartID.ToString().Equals(searchTerm) ||
                     part.Name.ToLower().Contains(searchTerm)))
                {
                    dataGridViewCandidateParts.ClearSelection();
                    dataGridViewCandidateParts.Rows[i].Selected = true;
                    dataGridViewCandidateParts.FirstDisplayedScrollingRowIndex = i;
                    found = true;
                    break;
                }
            }

            

            if (string.IsNullOrEmpty(searchTerm))
            {
                dataGridViewCandidateParts.ClearSelection();
                MessageBox.Show("Please enter a Part ID or Name.");
                return;
            }

            if (!found)
            {
                MessageBox.Show("Part not found.");
            }
        }
    }
}

