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

            
            textBox1.Text = newPartID.ToString(); 
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
                    MessageBox.Show("Name field cannot be empty. Please enter a part name.");
                    return;
                }

                if (!int.TryParse(textBox3.Text, out int inStock))
                {
                    MessageBox.Show($"Inventory must be a whole number. You entered: '{textBox3.Text}'.");
                    return;
                }

                if (!double.TryParse(textBox14.Text, out double price))
                {
                    MessageBox.Show($"Price must be a decimal number (e.g., 12.99). You entered: '{textBox14.Text}'.");
                    return;
                }

                if (!int.TryParse(textBox5.Text, out int min))
                {
                    MessageBox.Show($"Min must be a whole number. You entered: '{textBox5.Text}'.");
                    return;
                }

                if (!int.TryParse(textBox4.Text, out int max))
                {
                    MessageBox.Show($"Max must be a whole number. You entered: '{textBox4.Text}'.");
                    return;
                }

                if (min > max)
                {
                    MessageBox.Show($"Min ({min}) cannot be greater than Max ({max}).");
                    return;
                }

                if (inStock < min || inStock > max)
                {
                    MessageBox.Show($"Inventory ({inStock}) must be between Min ({min}) and Max ({max}).");
                    return;
                }

                if (rbInHouse.Checked)
                {
                    if (!int.TryParse(textBox6.Text, out int machineID))
                    {
                        MessageBox.Show($"Machine ID must be a whole number. You entered: '{textBox6.Text}'.");
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
                        MessageBox.Show("Company Name cannot be empty. Please enter a company name.");
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
                MessageBox.Show("Unexpected error: " + ex.Message);
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
            
