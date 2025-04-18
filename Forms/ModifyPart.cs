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
            try
            {
                partToModify.Name = textBox2.Text;
                partToModify.InStock = int.Parse(textBox3.Text);
                partToModify.Price = double.Parse(textBox14.Text);
                partToModify.Min = int.Parse(textBox5.Text);
                partToModify.Max = int.Parse(textBox4.Text);

                if (rbInHouse.Checked && partToModify is Inhouse inhousePart)
                {
                    inhousePart.MachineID = int.Parse(textBox6.Text);
                }
                else if (rbOutsourced.Checked && partToModify is Outsourced outsourcedPart)
                {
                    outsourcedPart.CompanyName = textBox6.Text;
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
