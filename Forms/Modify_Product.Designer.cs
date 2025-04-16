namespace Inventory_Management_System.Forms
{
    partial class Modify_Product
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
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            Column12 = new DataGridViewTextBoxColumn();
            dataGridView2 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column7, Column8, Column9, Column10, Column11, Column12 });
            dataGridView1.Location = new Point(371, 371);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(602, 150);
            dataGridView1.TabIndex = 0;
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
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridView2.Location = new Point(371, 73);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.Size = new Size(602, 150);
            dataGridView2.TabIndex = 1;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Part ID";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Name";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Inventory";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Price";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Min";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Max";
            Column6.Name = "Column6";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 19);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 2;
            label1.Text = "Modify Product";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(371, 45);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 3;
            label2.Text = "All candidate Parts";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(371, 346);
            label3.Name = "label3";
            label3.Size = new Size(186, 15);
            label3.TabIndex = 4;
            label3.Text = "Parts Associated with this Product";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 232);
            label4.Name = "label4";
            label4.Size = new Size(18, 15);
            label4.TabIndex = 5;
            label4.Text = "ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 273);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 6;
            label5.Text = "Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(44, 311);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 7;
            label6.Text = "Inventory";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(44, 349);
            label7.Name = "label7";
            label7.Size = new Size(33, 15);
            label7.TabIndex = 8;
            label7.Text = "Price";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(47, 387);
            label8.Name = "label8";
            label8.Size = new Size(30, 15);
            label8.TabIndex = 9;
            label8.Text = "Max";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(181, 392);
            label9.Name = "label9";
            label9.Size = new Size(28, 15);
            label9.TabIndex = 10;
            label9.Text = "Min";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(788, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(185, 23);
            textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(130, 346);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(120, 23);
            textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(130, 232);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(120, 23);
            textBox3.TabIndex = 13;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(130, 270);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(120, 23);
            textBox4.TabIndex = 14;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(130, 308);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(120, 23);
            textBox5.TabIndex = 15;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(89, 384);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(73, 23);
            textBox6.TabIndex = 16;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(226, 384);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(72, 23);
            textBox7.TabIndex = 17;
            // 
            // button1
            // 
            button1.Location = new Point(693, 28);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 18;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(909, 247);
            button2.Name = "button2";
            button2.Size = new Size(48, 30);
            button2.TabIndex = 19;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(904, 545);
            button3.Name = "button3";
            button3.Size = new Size(53, 34);
            button3.TabIndex = 20;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(834, 593);
            button4.Name = "button4";
            button4.Size = new Size(43, 35);
            button4.TabIndex = 21;
            button4.Text = "Save";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(904, 593);
            button5.Name = "button5";
            button5.Size = new Size(52, 35);
            button5.TabIndex = 22;
            button5.Text = "Cancel";
            button5.UseVisualStyleBackColor = true;
            // 
            // Modify_Product
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1214, 640);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Name = "Modify_Product";
            Text = "Modify_Product";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Button button1;
        private Button button2;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}