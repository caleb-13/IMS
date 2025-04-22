using Inventory_Management_System.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Inventory_Management_System
{

    public partial class AddForm : Form
    {


        private int newPartID;

        private MainForm mainForm;
        public AddForm(MainForm form)
        {
            InitializeComponent();
            mainForm = form;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbInHouse.Checked == true)
            {
                label7.Text = "Machine ID";
                textBox6.Visible = true;
                label7.Visible = true;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void AddForm_Load(object sender, EventArgs e)
        {

            newPartID = Inventory.GenerateNextID();

            // Set textbox to show the ID and make it non-editable
            textBox1.Text = newPartID.ToString(); // Replace textBox1 with your ID textbox name
            textBox1.ReadOnly = true;
            textBox1.Enabled = false;
            textBox1.TabStop = false;
            label7.Visible = false;
            textBox6.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBox2.Text.Trim();
                if (string.IsNullOrEmpty(name))
                {
                    MessageBox.Show("Name cannot be empty.");
                    return;
                }

                if (!int.TryParse(textBox3.Text, out int inStock) ||
                    !double.TryParse(textBox14.Text, out double price) ||
                    !int.TryParse(textBox5.Text, out int min) ||
                    !int.TryParse(textBox4.Text, out int max))
                {
                    MessageBox.Show("Please enter valid numeric values.");
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

                if (rbInHouse.Checked)
                {
                    if (!int.TryParse(textBox6.Text, out int machineID))
                    {
                        MessageBox.Show("Machine ID must be a number.");
                        return;
                    }

                    Inhouse newPart = new Inhouse(newPartID, name, price, inStock, min, max, machineID);
                    Inventory.addPart(newPart);
                }
                else if (rbOutsourced.Checked)
                {
                    string companyName = textBox6.Text.Trim();
                    if (string.IsNullOrEmpty(companyName))
                    {
                        MessageBox.Show("Company name cannot be empty.");
                        return;
                    }

                    Outsourced newPart = new Outsourced(newPartID, name, price, inStock, min, max, companyName);
                    Inventory.addPart(newPart);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }











        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOutsourced.Checked)
            {
                label7.Text = "Company Name";
                textBox6.Visible = true;
                label7.Visible = true;
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
            
