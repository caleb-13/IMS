namespace Inventory_Management_System
{
    partial class MainForm
    {
        private const string V = "Form1";

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bthProductSearch = new Button();
            btn_Add = new Button();
            btn_Modify = new Button();
            button4 = new Button();
            textBox1 = new TextBox();
            btnSearch = new Button();
            textBoxSearch = new TextBox();
            label1 = new Label();
            label2 = new Label();
            dataGridViewParts = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            ColumnName = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            label3 = new Label();
            DataGridViewProducts = new DataGridView();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            Column12 = new DataGridViewTextBoxColumn();
            button2 = new Button();
            button3 = new Button();
            button5 = new Button();
            button6 = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewParts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewProducts).BeginInit();
            SuspendLayout();
            // 
            // bthProductSearch
            // 
            bthProductSearch.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bthProductSearch.Location = new Point(990, 55);
            bthProductSearch.Name = "bthProductSearch";
            bthProductSearch.Size = new Size(50, 23);
            bthProductSearch.TabIndex = 0;
            bthProductSearch.Text = "Search";
            bthProductSearch.UseVisualStyleBackColor = true;
            bthProductSearch.Click += bthProductSearch_Click;
            // 
            // btn_Add
            // 
            btn_Add.Location = new Point(360, 312);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(75, 33);
            btn_Add.TabIndex = 1;
            btn_Add.Text = "Add";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_add;
            // 
            // btn_Modify
            // 
            btn_Modify.Location = new Point(441, 312);
            btn_Modify.Name = "btn_Modify";
            btn_Modify.Size = new Size(75, 33);
            btn_Modify.TabIndex = 2;
            btn_Modify.Text = "Modify";
            btn_Modify.UseVisualStyleBackColor = true;
            btn_Modify.Click += btn_modify;
            // 
            // button4
            // 
            button4.Location = new Point(532, 312);
            button4.Name = "button4";
            button4.Size = new Size(75, 33);
            button4.TabIndex = 3;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btn_delete;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1056, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(195, 23);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // btnSearch
            // 
            btnSearch.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSearch.Location = new Point(303, 61);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(50, 23);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btn_search_1;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(372, 61);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(183, 23);
            textBoxSearch.TabIndex = 7;
            textBoxSearch.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(48, 27);
            label2.Name = "label2";
            label2.Size = new Size(227, 21);
            label2.TabIndex = 8;
            label2.Text = "Inventory Management System";
            label2.Click += label2_Click;
            // 
            // dataGridViewParts
            // 
            dataGridViewParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewParts.Columns.AddRange(new DataGridViewColumn[] { Column1, ColumnName, Column2, Column3, Column4, Column5, Column6 });
            dataGridViewParts.Location = new Point(78, 101);
            dataGridViewParts.Name = "dataGridViewParts";
            dataGridViewParts.RowHeadersVisible = false;
            dataGridViewParts.Size = new Size(601, 200);
            dataGridViewParts.TabIndex = 9;
            dataGridViewParts.CellContentClick += dataGridViewParts_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Part ID";
            Column1.Name = "Column1";
            // 
            // ColumnName
            // 
            ColumnName.HeaderText = "Name";
            ColumnName.Name = "ColumnName";
            // 
            // Column2
            // 
            Column2.HeaderText = "Name";
            Column2.Name = "Column2";
            Column2.Visible = false;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(28, 69);
            label3.MinimumSize = new Size(1, 1);
            label3.Name = "label3";
            label3.Size = new Size(44, 21);
            label3.TabIndex = 10;
            label3.Text = "Parts\r\n";
            // 
            // DataGridViewProducts
            // 
            DataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewProducts.Columns.AddRange(new DataGridViewColumn[] { Column7, Column8, Column9, Column10, Column11, Column12 });
            DataGridViewProducts.Location = new Point(762, 101);
            DataGridViewProducts.Name = "DataGridViewProducts";
            DataGridViewProducts.RowHeadersVisible = false;
            DataGridViewProducts.Size = new Size(601, 200);
            DataGridViewProducts.TabIndex = 11;
            DataGridViewProducts.CellContentClick += DataGridViewProducts_CellContentClick;
            // 
            // Column7
            // 
            Column7.HeaderText = "Product ID";
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
            // button2
            // 
            button2.Location = new Point(1110, 312);
            button2.Name = "button2";
            button2.Size = new Size(75, 33);
            button2.TabIndex = 12;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_2;
            // 
            // button3
            // 
            button3.Location = new Point(1191, 312);
            button3.Name = "button3";
            button3.Size = new Size(75, 33);
            button3.TabIndex = 13;
            button3.Text = "Modify";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.Location = new Point(1272, 312);
            button5.Name = "button5";
            button5.Size = new Size(75, 33);
            button5.TabIndex = 14;
            button5.Text = "Delete";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click_1;
            // 
            // button6
            // 
            button6.Location = new Point(1272, 395);
            button6.Name = "button6";
            button6.Size = new Size(75, 29);
            button6.TabIndex = 15;
            button6.Text = "Exit";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(762, 75);
            label4.Name = "label4";
            label4.Size = new Size(71, 21);
            label4.TabIndex = 16;
            label4.Text = "Products";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1375, 454);
            Controls.Add(label4);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(DataGridViewProducts);
            Controls.Add(label3);
            Controls.Add(dataGridViewParts);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxSearch);
            Controls.Add(btnSearch);
            Controls.Add(textBox1);
            Controls.Add(button4);
            Controls.Add(btn_Modify);
            Controls.Add(btn_Add);
            Controls.Add(bthProductSearch);
            Name = "MainForm";
            Text = "Main";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewParts).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearch;
        private Button btn_Add;
        private Button btn_Modify;
        private Button button4;
        private TextBox textBox1;
        private Button bthProductSearch;
        private TextBox textBoxSearch;
        private Label label1;
        private Label label2;
        private DataGridView dataGridViewParts;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridView DataGridViewProducts;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
        private Button button2;
        private Button button3;
        private Button button5;
        private Button button6;
        public Label label3;
        private Label label4;
    }
}
