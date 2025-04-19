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
            try
            {
                int PartID = Inventory.GenerateNextID(); // or however you auto-generate IDs
                string PartName = textBox2.Text;
                int InStock = int.Parse(textBox3.Text);
                double Price = double.Parse(textBox14.Text);
                int Min = int.Parse(textBox5.Text);
                int Max = int.Parse(textBox4.Text);


                if (rbInHouse.Checked)
                {
                    int MachineID = int.Parse(textBox6.Text);
                    Inhouse newPart = new Inhouse(PartID, PartName, Price, InStock, Min, Max, MachineID);

                    Inventory.addPart(newPart);
                }

                else if (rbOutsourced.Checked)
                {
                    string CompanyName = textBox6.Text;

                    Outsourced newPart = new Outsourced(PartID, PartName, Price, InStock, Min, Max, CompanyName);

                    Inventory.addPart(newPart);


                }

                this.DialogResult = DialogResult.OK; // Let MainForm know we saved
                this.Close(); // Return back to MainForm



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
            
