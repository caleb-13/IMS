using Inventory_Management_System.Forms;
using Inventory_Management_System.Models;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Inventory_Management_System
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            SetupDataGridView();

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
            AddForm addForm = new AddForm(this);
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                // Rebind or refresh to reflect new data
                dataGridViewParts.DataSource = null;
                dataGridViewParts.DataSource = Inventory.Allparts;
            }
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

        }

        private void btn_search_2(object sender, EventArgs e)
        {

        }

        private void btn_modify(object sender, EventArgs e)
        {
            ModifyPart modifyPart = new ModifyPart(this);
            modifyPart.ShowDialog();
            
        }

        private void btn_delete(object sender, EventArgs e)
        {
            //    if (dataGridView1.Rows.Count > 0)
            //        dataGridView1.Rows.RemoveAt(e.GetHashCode());
            //    else
            //        MessageBox.Show("You can't remove an empty row"); ---- this may be need to go under the datagridview button.
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
