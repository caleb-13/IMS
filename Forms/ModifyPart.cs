using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System.Forms
{
    public partial class ModifyPart : Form
    {
        public ModifyPart()
        {

        }
        private MainForm mainForm;
        public ModifyPart(MainForm form)
        {
            InitializeComponent();
            mainForm = form;
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
    }
}
