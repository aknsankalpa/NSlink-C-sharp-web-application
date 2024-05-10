namespace Modern_Flat_UI___NSlink
{
    partial class AppointmentForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label7 = new Label();
            textBox4 = new TextBox();
            button2 = new Button();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans", 10.2F);
            label1.Location = new Point(40, 88);
            label1.Name = "label1";
            label1.Size = new Size(124, 19);
            label1.TabIndex = 0;
            label1.Text = "Student Name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans", 10.2F);
            label2.Location = new Point(40, 125);
            label2.Name = "label2";
            label2.Size = new Size(96, 19);
            label2.TabIndex = 1;
            label2.Text = "Student ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Sans", 10.2F);
            label3.Location = new Point(40, 173);
            label3.Name = "label3";
            label3.Size = new Size(0, 19);
            label3.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Lucida Sans", 10.2F);
            textBox1.Location = new Point(170, 85);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(284, 28);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Lucida Sans", 10.2F);
            textBox2.Location = new Point(170, 125);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 28);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Lucida Sans", 10.2F);
            textBox3.Location = new Point(170, 164);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(284, 28);
            textBox3.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Sans", 10.2F);
            label4.Location = new Point(40, 173);
            label4.Name = "label4";
            label4.Size = new Size(55, 19);
            label4.TabIndex = 6;
            label4.Text = "Email";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Sans", 10.2F);
            label5.Location = new Point(46, 223);
            label5.Name = "label5";
            label5.Size = new Size(0, 19);
            label5.TabIndex = 7;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Navy;
            button1.Location = new Point(360, 388);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 8;
            button1.Text = "submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lucida Sans", 10.2F);
            label6.Location = new Point(40, 223);
            label6.Name = "label6";
            label6.Size = new Size(46, 19);
            label6.TabIndex = 9;
            label6.Text = "Date";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Lucida Sans", 10.2F);
            dateTimePicker1.Location = new Point(170, 216);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 28);
            dateTimePicker1.TabIndex = 13;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Lucida Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(40, 275);
            label7.Name = "label7";
            label7.Size = new Size(99, 19);
            label7.TabIndex = 14;
            label7.Text = "Comments";
            label7.Click += label7_Click;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Lucida Sans", 10.2F);
            textBox4.Location = new Point(170, 275);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(284, 86);
            textBox4.TabIndex = 15;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Navy;
            button2.Location = new Point(40, 388);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 16;
            button2.Text = "Go Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Navy;
            label8.Location = new Point(40, 19);
            label8.Name = "label8";
            label8.Size = new Size(406, 35);
            label8.TabIndex = 17;
            label8.Text = "REQUEST AN APPOINTMENT";
            // 
            // AppointmentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(508, 459);
            Controls.Add(label8);
            Controls.Add(button2);
            Controls.Add(textBox4);
            Controls.Add(label7);
            Controls.Add(dateTimePicker1);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AppointmentForm";
            RightToLeftLayout = true;
            Text = "AppointmentForm";
            Load += AppointmentForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label4;
        private Label label5;
        private Button button1;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private Label label7;
        private TextBox textBox4;
        private Button button2;
        private Label label8;
    }
}