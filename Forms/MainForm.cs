using Inventory_Management_System.Forms;
using Inventory_Management_System.Models;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Inventory_Management_System
{
    public partial class MainForm : Form
    {
       
        public MainForm()
        {
            InitializeComponent();
            SetupDataGridView();
            ;
        }
       
        public void SetupDataGridView()
        {
            dataGridViewParts.AutoGenerateColumns = false;
            dataGridViewParts.Columns.Clear();

            dataGridViewParts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PartID",
                HeaderText = "ID"
            });

            dataGridViewParts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Name",
                HeaderText = "Name"
            });

            dataGridViewParts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Price",
                HeaderText = "Price"
            });

            dataGridViewParts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "InStock",
                HeaderText = "In Stock"
            });

            dataGridViewParts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Min",
                HeaderText = "Min"
            });

            dataGridViewParts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Max",
                HeaderText = "Max"
            });

            dataGridViewParts.DataSource = Inventory.Allparts;
            dataGridViewParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }





        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_add(object sender, EventArgs e)
        {
            
        }
        private void AddForm_MouseClick(object? sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void MyNewButton_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btn_search_1(object sender, EventArgs e)
        {
            string searchTerm = textBoxSearch.Text.Trim();
            bool found = false;

            // If the user typed a number, try to search by ID
            if (int.TryParse(searchTerm, out int partIDToFind))
            {
                for (int i = 0; i < dataGridViewParts.Rows.Count; i++)
                {
                    Part part = dataGridViewParts.Rows[i].DataBoundItem as Part;

                    if (part != null && part.PartID == partIDToFind)
                    {
                        dataGridViewParts.ClearSelection();
                        dataGridViewParts.Rows[i].Selected = true;
                        dataGridViewParts.FirstDisplayedScrollingRowIndex = i;
                        found = true;
                        break;
                    }
                }
            }
            else
            {
                // Otherwise, search by name (case-insensitive)
                for (int i = 0; i < dataGridViewParts.Rows.Count; i++)
                {
                    Part part = dataGridViewParts.Rows[i].DataBoundItem as Part;

                    if (part != null && part.Name.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        dataGridViewParts.ClearSelection();
                        dataGridViewParts.Rows[i].Selected = true;
                        dataGridViewParts.FirstDisplayedScrollingRowIndex = i;
                        found = true;
                        break;
                    }
                }
            }

            if (!found)
            {
                MessageBox.Show("Part not found.");
            }
        }

        private void btn_search_2(object sender, EventArgs e)
        {

        }

        private void btn_modify(object sender, EventArgs e)
        {


            if (dataGridViewParts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a part to modify.");
                return;
            }

            Part selectedPart = dataGridViewParts.SelectedRows[0].DataBoundItem as Part;

            if (selectedPart != null)
            {
                ModifyPart modifyPart = new ModifyPart(selectedPart);

                if (modifyPart.ShowDialog() == DialogResult.OK)
                {
                    dataGridViewParts.Refresh(); // Update the grid with modified values
                }
            }
        }
            

        private void btn_delete(object sender, EventArgs e)
        {
            if (dataGridViewParts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a part to delete.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this part?", "Confirm Delete", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Part selectedPart = dataGridViewParts.SelectedRows[0].DataBoundItem as Part;

                if (selectedPart != null)
                {
                    Inventory.Allparts.Remove(selectedPart);
                }
            }
        }
        private void btn_exit_click(object sender, EventArgs e)
        {
            this.Close(); // Closes the form
        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            
            AddProductForm addProductForm = new();
            addProductForm.ShowDialog();
            SetupDataGridView();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Modify_Product modify_Product = new Modify_Product();
            modify_Product.ShowDialog();
        }

        private void dataGridViewParts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataGridViewProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
