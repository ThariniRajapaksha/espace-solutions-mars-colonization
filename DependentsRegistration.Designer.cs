namespace Tharini_Rajapaksha_00238334_Database_Design
{
    partial class DependentsRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DependentsRegistration));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            label8 = new Label();
            textBox3 = new TextBox();
            richTextBox1 = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(794, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(112, 116);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(408, 38);
            label1.Name = "label1";
            label1.Size = new Size(380, 52);
            label1.TabIndex = 10;
            label1.Text = "E-Space Solutions";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tempus Sans ITC", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(12, 100);
            label2.Name = "label2";
            label2.Size = new Size(495, 39);
            label2.TabIndex = 11;
            label2.Text = "Colonists' Dependents Registration";
            // 
            // button2
            // 
            button2.BackColor = Color.MidnightBlue;
            button2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.Window;
            button2.Location = new Point(740, 493);
            button2.Name = "button2";
            button2.Size = new Size(167, 45);
            button2.TabIndex = 36;
            button2.Text = "Submit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.MidnightBlue;
            button1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Window;
            button1.Location = new Point(538, 493);
            button1.Name = "button1";
            button1.Size = new Size(167, 45);
            button1.TabIndex = 35;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 169);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 37;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 215);
            label4.Name = "label4";
            label4.Size = new Size(96, 20);
            label4.TabIndex = 38;
            label4.Text = "Date Of Birth";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 258);
            label5.Name = "label5";
            label5.Size = new Size(36, 20);
            label5.TabIndex = 39;
            label5.Text = "Age";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 299);
            label6.Name = "label6";
            label6.Size = new Size(57, 20);
            label6.TabIndex = 40;
            label6.Text = "Gender";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 344);
            label7.Name = "label7";
            label7.Size = new Size(190, 20);
            label7.TabIndex = 41;
            label7.Text = "Relationship With Colonists";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(213, 210);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(693, 27);
            dateTimePicker1.TabIndex = 42;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(213, 169);
            textBox1.MaxLength = 50;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(693, 27);
            textBox1.TabIndex = 43;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(213, 255);
            textBox2.MaxLength = 3;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(693, 27);
            textBox2.TabIndex = 44;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Female Gender", "Male Gender", "Neuter Gender" });
            comboBox1.Location = new Point(213, 296);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(693, 28);
            comboBox1.TabIndex = 45;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 427);
            label8.Name = "label8";
            label8.Size = new Size(114, 20);
            label8.TabIndex = 47;
            label8.Text = "Colonization_ID";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(213, 427);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(693, 27);
            textBox3.TabIndex = 48;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(213, 341);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(263, 77);
            richTextBox1.TabIndex = 49;
            richTextBox1.Text = "";
            // 
            // DependentsRegistration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(918, 550);
            Controls.Add(richTextBox1);
            Controls.Add(textBox3);
            Controls.Add(label8);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "DependentsRegistration";
            Text = "DependentsRegistration";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button button2;
        private Button button1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private Label label8;
        private TextBox textBox3;
        private RichTextBox richTextBox1;
    }
}