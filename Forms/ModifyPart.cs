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
using System.Xml.Linq;

namespace Inventory_Management_System.Forms
{
    public partial class ModifyPart : Form
    {
        private Part partToModify;
        internal ModifyPart(Part part)
        {
            InitializeComponent();

            partToModify = part;

            
            textBox1.Text = partToModify.PartID.ToString();
            textBox1.ReadOnly = true;
            textBox1.TabStop = false;

            
            textBox2.Text = partToModify.Name;
            textBox3.Text = partToModify.InStock.ToString();
            textBox14.Text = partToModify.Price.ToString();
            textBox5.Text = partToModify.Min.ToString();
            textBox4.Text = partToModify.Max.ToString();

            
            if (partToModify is Inhouse inhousePart)
            {
                rbInHouse.Checked = true;
                textBox6.Text = inhousePart.MachineID.ToString();
            }
            else if (partToModify is Outsourced outsourcedPart)
            {
                rbOutsourced.Checked = true;
                textBox6.Text = outsourcedPart.CompanyName;
            }
        }


        private void ModifyPart_Load(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
            textBox1.Enabled = false;
        }

        private void rbInHouse_CheckedChanged(object sender, EventArgs e)
        {
            if (rbInHouse.Checked == true)
            {
                label7.Text = "Machine ID";
                textBox6.Visible = true;
                label7.Visible = true;
            }
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

        private void Savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBox2.Text.Trim();
                if (string.IsNullOrEmpty(name))
                {
                    MessageBox.Show("Part name cannot be empty. Please enter a name.");
                    return;
                }

                if (!int.TryParse(textBox3.Text, out int inStock))
                {
                    MessageBox.Show($"Inventory must be a whole number. You entered: '{textBox3.Text}'.");
                    return;
                }

                if (!double.TryParse(textBox14.Text, out double price))
                {
                    MessageBox.Show($"Price must be a decimal number (e.g., 9.99). You entered: '{textBox14.Text}'.");
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
                    MessageBox.Show($"Min value ({min}) cannot be greater than Max value ({max}).");
                    return;
                }

                if (inStock < min || inStock > max)
                {
                    MessageBox.Show($"Inventory value ({inStock}) must be between Min ({min}) and Max ({max}).");
                    return;
                }

                int partID = partToModify.PartID;
                Part updatedPart;

                if (rbInHouse.Checked)
                {
                    if (!int.TryParse(textBox6.Text, out int machineID))
                    {
                        MessageBox.Show($"Machine ID must be a whole number. You entered: '{textBox6.Text}'.");
                        return;
                    }

                    updatedPart = new Inhouse(partID, name, price, inStock, min, max, machineID);
                }
                else if (rbOutsourced.Checked)
                {
                    string companyName = textBox6.Text.Trim();
                    if (string.IsNullOrEmpty(companyName))
                    {
                        MessageBox.Show("Company name cannot be empty. Please enter a company name.");
                        return;
                    }

                    updatedPart = new Outsourced(partID, name, price, inStock, min, max, companyName);
                }
                else
                {
                    MessageBox.Show("Please select either In-House or Outsourced.");
                    return;
                }

                Inventory.updatePart(partID, updatedPart);

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
    }
}