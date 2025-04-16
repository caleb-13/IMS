
namespace Inventory_Management_System.Forms
{
    partial class AddProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            dataGridView2 = new DataGridView();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            Column12 = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridView1.Location = new Point(439, 87);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(601, 150);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Part ID";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Name";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Inventory";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Price";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Min";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "Max";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column7, Column8, Column9, Column10, Column11, Column12 });
            dataGridView2.Location = new Point(439, 296);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.Size = new Size(603, 150);
            dataGridView2.TabIndex = 1;
            // 
            // Column7
            // 
            Column7.HeaderText = "Part ID";
            Column7.Name = "Column7";
            // 
            // Column8
            // 
            Column8.HeaderText = "Name";
            Column8.Name = "Column8";
            // 
            // Column9
            // 
            Column9.HeaderText = "Inventory";
            Column9.Name = "Column9";
            // 
            // Column10
            // 
            Column10.HeaderText = "Price";
            Column10.Name = "Column10";
            // 
            // Column11
            // 
            Column11.HeaderText = "Min";
            Column11.Name = "Column11";
            // 
            // Column12
            // 
            Column12.HeaderText = "Max";
            Column12.Name = "Column12";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(640, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(439, 69);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 4;
            label2.Text = "All candidate Parts";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(439, 278);
            label3.Name = "label3";
            label3.Size = new Size(186, 15);
            label3.TabIndex = 5;
            label3.Text = "Parts Associated with this Product";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 27);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 6;
            label4.Text = "Add Product";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 143);
            label5.Name = "label5";
            label5.Size = new Size(18, 15);
            label5.TabIndex = 7;
            label5.Text = "ID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 183);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 8;
            label6.Text = "Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 217);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 9;
            label7.Text = "Inventory";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(23, 247);
            label8.Name = "label8";
            label8.Size = new Size(33, 15);
            label8.TabIndex = 10;
            label8.Text = "Price";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(156, 299);
            label9.Name = "label9";
            label9.Size = new Size(28, 15);
            label9.TabIndex = 11;
            label9.Text = "Min";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(23, 299);
            label10.Name = "label10";
            label10.Size = new Size(30, 15);
            label10.TabIndex = 12;
            label10.Text = "Max";
            // 
            // button1
            // 
            button1.Location = new Point(969, 465);
            button1.Name = "button1";
            button1.Size = new Size(59, 29);
            button1.TabIndex = 13;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(884, 510);
            button2.Name = "button2";
            button2.Size = new Size(56, 30);
            button2.TabIndex = 14;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(969, 510);
            button3.Name = "button3";
            button3.Size = new Size(60, 30);
            button3.TabIndex = 15;
            button3.Text = "Cancel";
            button3.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(94, 143);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 16;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(94, 183);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 17;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(94, 214);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 18;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(94, 251);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 19;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(59, 296);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(72, 23);
            textBox6.TabIndex = 20;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(199, 296);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(72, 23);
            textBox7.TabIndex = 21;
            // 
            // button4
            // 
            button4.Location = new Point(980, 243);
            button4.Name = "button4";
            button4.Size = new Size(48, 39);
            button4.TabIndex = 22;
            button4.Text = "Add";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(572, 27);
            button5.Name = "button5";
            button5.Size = new Size(53, 23);
            button5.TabIndex = 23;
            button5.Text = "Search";
            button5.UseVisualStyleBackColor = true;
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1185, 560);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Name = "AddProductForm";
            Text = "AddProductForm";
            Load += AddProductForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
        private Button button4;
        private Button button5;
    }
}