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

            textBox2.Text = part.Name;
            textBox3.Text = part.InStock.ToString();
            textBox14.Text = part.Price.ToString();
            textBox5.Text = part.Min.ToString();
            textBox4.Text = part.Max.ToString();

            if (part is Inhouse inhousePart)
            {
                rbInHouse.Checked = true;
                textBox6.Text = inhousePart.MachineID.ToString();
            }
            else if (part is Outsourced outsourcedPart)
            {
                rbOutsourced.Checked = true;
                textBox6.Text = outsourcedPart.CompanyName;
            }
        }


        private void ModifyPart_Load(object sender, EventArgs e)
        {

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
            if (!int.TryParse(textBox3.Text, out int inStock))
            {
                MessageBox.Show("Inventory must be a whole number.");
                return;
            }

            if (!double.TryParse(textBox14.Text, out double price))
            {
                MessageBox.Show("Price must be a valid number.");
                return;
            }

            if (!int.TryParse(textBox5.Text, out int min))
            {
                MessageBox.Show("Min must be a whole number.");
                return;
            }

            if (!int.TryParse(textBox4.Text, out int max))
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

            string partName = textBox2.Text.Trim();
            if (string.IsNullOrEmpty(partName))
            {
                MessageBox.Show("Name cannot be empty.");
                return;
            }

            // Now safe to modify the part
            partToModify.Name = partName;
            partToModify.InStock = inStock;
            partToModify.Price = price;
            partToModify.Min = min;
            partToModify.Max = max;

            if (rbInHouse.Checked && partToModify is Inhouse inhousePart)
            {
                if (!int.TryParse(textBox6.Text, out int machineID))
                {
                    MessageBox.Show("Machine ID must be a whole number.");
                    return;
                }

                inhousePart.MachineID = machineID;
            }
            else if (rbOutsourced.Checked && partToModify is Outsourced outsourcedPart)
            {
                string companyName = textBox6.Text.Trim();
                if (string.IsNullOrEmpty(companyName))
                {
                    MessageBox.Show("Company name cannot be empty.");
                    return;
                }

                outsourcedPart.CompanyName = companyName;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
