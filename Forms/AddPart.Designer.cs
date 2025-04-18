namespace Inventory_Management_System
{
    partial class AddForm
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
            rbInHouse = new RadioButton();
            rbOutsourced = new RadioButton();
            label1 = new Label();
            button2 = new Button();
            Savebtn = new Button();
            label14 = new Label();
            textBox14 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // rbInHouse
            // 
            rbInHouse.AutoSize = true;
            rbInHouse.Location = new Point(120, 12);
            rbInHouse.Name = "rbInHouse";
            rbInHouse.Size = new Size(74, 19);
            rbInHouse.TabIndex = 0;
            rbInHouse.TabStop = true;
            rbInHouse.Text = "In-House";
            rbInHouse.UseVisualStyleBackColor = true;
            rbInHouse.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // rbOutsourced
            // 
            rbOutsourced.AutoSize = true;
            rbOutsourced.Location = new Point(228, 12);
            rbOutsourced.Name = "rbOutsourced";
            rbOutsourced.Size = new Size(87, 19);
            rbOutsourced.TabIndex = 1;
            rbOutsourced.TabStop = true;
            rbOutsourced.Text = "Outsourced";
            rbOutsourced.UseVisualStyleBackColor = true;
            rbOutsourced.CheckedChanged += rbOutsourced_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 9);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 2;
            label1.Text = "Add Part";
            // 
            // button2
            // 
            button2.Location = new Point(317, 341);
            button2.Name = "button2";
            button2.Size = new Size(53, 30);
            button2.TabIndex = 47;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Savebtn
            // 
            Savebtn.Location = new Point(244, 341);
            Savebtn.Name = "Savebtn";
            Savebtn.Size = new Size(57, 30);
            Savebtn.TabIndex = 46;
            Savebtn.Text = "Save";
            Savebtn.UseVisualStyleBackColor = true;
            Savebtn.Click += button1_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(77, 177);
            label14.Name = "label14";
            label14.Size = new Size(62, 15);
            label14.TabIndex = 45;
            label14.Text = "Price/Cost";
            // 
            // textBox14
            // 
            textBox14.Location = new Point(161, 174);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(112, 23);
            textBox14.TabIndex = 44;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(72, 291);
            label7.Name = "label7";
            label7.Size = new Size(67, 15);
            label7.TabIndex = 43;
            label7.Text = "Machine ID";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(260, 243);
            label6.Name = "label6";
            label6.Size = new Size(28, 15);
            label6.TabIndex = 42;
            label6.Text = "Min";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(109, 243);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 41;
            label5.Text = "Max";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(82, 139);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 40;
            label4.Text = "Inventory";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(100, 101);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 39;
            label3.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(121, 63);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 38;
            label2.Text = "ID";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(176, 288);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(112, 23);
            textBox6.TabIndex = 37;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(308, 235);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(62, 23);
            textBox5.TabIndex = 36;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(161, 235);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(62, 23);
            textBox4.TabIndex = 35;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(161, 136);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(112, 23);
            textBox3.TabIndex = 34;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(161, 98);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(112, 23);
            textBox2.TabIndex = 33;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(161, 60);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(112, 23);
            textBox1.TabIndex = 32;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 383);
            Controls.Add(button2);
            Controls.Add(Savebtn);
            Controls.Add(label14);
            Controls.Add(textBox14);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(rbOutsourced);
            Controls.Add(rbInHouse);
            Name = "AddForm";
            Text = "AddForm";
            Load += AddForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rbInHouse;
        private RadioButton rbOutsourced;
        private Label label1;
        private Button button2;
        private Button Savebtn;
        private Label label14;
        private TextBox textBox14;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}