namespace Inventory_Management_System.Forms
{
    partial class Outsource
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
            button2 = new Button();
            button1 = new Button();
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
            label1 = new Label();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(318, 341);
            button2.Name = "button2";
            button2.Size = new Size(53, 30);
            button2.TabIndex = 66;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(242, 341);
            button1.Name = "button1";
            button1.Size = new Size(57, 30);
            button1.TabIndex = 65;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(62, 177);
            label14.Name = "label14";
            label14.Size = new Size(62, 15);
            label14.TabIndex = 64;
            label14.Text = "Price/Cost";
            // 
            // textBox14
            // 
            textBox14.Location = new Point(146, 174);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(112, 23);
            textBox14.TabIndex = 63;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(30, 291);
            label7.Name = "label7";
            label7.Size = new Size(94, 15);
            label7.TabIndex = 62;
            label7.Text = "Company Name";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(250, 238);
            label6.Name = "label6";
            label6.Size = new Size(28, 15);
            label6.TabIndex = 61;
            label6.Text = "Min";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(94, 238);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 60;
            label5.Text = "Max";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(67, 144);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 59;
            label4.Text = "Inventory";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(85, 101);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 58;
            label3.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(106, 63);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 57;
            label2.Text = "ID";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(146, 291);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(112, 23);
            textBox6.TabIndex = 56;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(293, 235);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(78, 23);
            textBox5.TabIndex = 55;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(146, 235);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(62, 23);
            textBox4.TabIndex = 54;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(146, 136);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(112, 23);
            textBox3.TabIndex = 53;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(146, 98);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(112, 23);
            textBox2.TabIndex = 52;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(146, 60);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(112, 23);
            textBox1.TabIndex = 51;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 50;
            label1.Text = "Add Part";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(212, 10);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(87, 19);
            radioButton2.TabIndex = 49;
            radioButton2.TabStop = true;
            radioButton2.Text = "Outsourced";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(111, 10);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(74, 19);
            radioButton1.TabIndex = 48;
            radioButton1.TabStop = true;
            radioButton1.Text = "In-House";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // Outsource
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 423);
            Controls.Add(button2);
            Controls.Add(button1);
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
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Name = "Outsource";
            Text = "sx";
            Load += Outsource_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
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
        private Label label1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
    }
}