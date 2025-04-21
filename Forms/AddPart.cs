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
            label7.Visible = false;
            textBox6.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox3.Text, out int inStock))
            {
                MessageBox.Show("Inventory must be a whole number.");
                return;
            }

            if (!double.TryParse(textBox14.Text, out double price))
            {
                MessageBox.Show("Price must be a number.");
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

            // Optional: Check name is not blank
            string partName = textBox2.Text.Trim();
            if (string.IsNullOrEmpty(partName))
            {
                MessageBox.Show("Part Name cannot be empty.");
                return;
            }

            int partID = Inventory.GenerateNextID();

            if (rbInHouse.Checked)
            {
                if (!int.TryParse(textBox6.Text, out int machineID))
                {
                    MessageBox.Show("Machine ID must be a whole number.");
                    return;
                }

                Inhouse newPart = new Inhouse(partID, partName, price, inStock, min, max, machineID);
                Inventory.addPart(newPart);
            }
            else if (rbOutsourced.Checked)
            {
                string companyName = textBox6.Text.Trim();
                if (string.IsNullOrEmpty(companyName))
                {
                    MessageBox.Show("Company Name cannot be empty.");
                    return;
                }

                Outsourced newPart = new Outsourced(partID, partName, price, inStock, min, max, companyName);
                Inventory.addPart(newPart);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();

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
            
