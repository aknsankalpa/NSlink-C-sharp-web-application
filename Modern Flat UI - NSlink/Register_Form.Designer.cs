using System.Data.SqlClient;

namespace WinFormsApp1
{
    partial class Register_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register_Form));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            txtFirstName = new Guna.UI2.WinForms.Guna2TextBox();
            txtLastName = new Guna.UI2.WinForms.Guna2TextBox();
            label2 = new Label();
            label3 = new Label();
            txtPrivateEmail = new Guna.UI2.WinForms.Guna2TextBox();
            label4 = new Label();
            cboFaculty = new Guna.UI2.WinForms.Guna2ComboBox();
            label5 = new Label();
            txtStudentID = new Guna.UI2.WinForms.Guna2TextBox();
            pictureBox1 = new PictureBox();
            txtUserName = new Guna.UI2.WinForms.Guna2TextBox();
            label7 = new Label();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(664, 24);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(120, 117);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(69, 235);
            label1.Name = "label1";
            label1.Size = new Size(83, 18);
            label1.TabIndex = 2;
            label1.Text = "First Name";
            // 
            // txtFirstName
            // 
            txtFirstName.BorderRadius = 15;
            txtFirstName.CustomizableEdges = customizableEdges1;
            txtFirstName.DefaultText = "";
            txtFirstName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtFirstName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtFirstName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtFirstName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtFirstName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtFirstName.Font = new Font("Segoe UI", 9F);
            txtFirstName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtFirstName.Location = new Point(152, 221);
            txtFirstName.Margin = new Padding(3, 5, 3, 5);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PasswordChar = '\0';
            txtFirstName.PlaceholderText = "";
            txtFirstName.SelectedText = "";
            txtFirstName.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtFirstName.Size = new Size(229, 48);
            txtFirstName.TabIndex = 3;
            // 
            // txtLastName
            // 
            txtLastName.BorderRadius = 15;
            txtLastName.CustomizableEdges = customizableEdges3;
            txtLastName.DefaultText = "";
            txtLastName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtLastName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtLastName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtLastName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtLastName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtLastName.Font = new Font("Segoe UI", 9F);
            txtLastName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtLastName.Location = new Point(566, 221);
            txtLastName.Margin = new Padding(3, 5, 3, 5);
            txtLastName.Name = "txtLastName";
            txtLastName.PasswordChar = '\0';
            txtLastName.PlaceholderText = "";
            txtLastName.SelectedText = "";
            txtLastName.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtLastName.Size = new Size(229, 48);
            txtLastName.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(482, 235);
            label2.Name = "label2";
            label2.Size = new Size(84, 18);
            label2.TabIndex = 4;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(220, 310);
            label3.Name = "label3";
            label3.Size = new Size(50, 18);
            label3.TabIndex = 6;
            label3.Text = "Batch";
            // 
            // txtPrivateEmail
            // 
            txtPrivateEmail.BorderRadius = 15;
            txtPrivateEmail.CustomizableEdges = customizableEdges5;
            txtPrivateEmail.DefaultText = "";
            txtPrivateEmail.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPrivateEmail.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPrivateEmail.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPrivateEmail.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPrivateEmail.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPrivateEmail.Font = new Font("Segoe UI", 9F);
            txtPrivateEmail.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPrivateEmail.Location = new Point(152, 361);
            txtPrivateEmail.Margin = new Padding(3, 5, 3, 5);
            txtPrivateEmail.Name = "txtPrivateEmail";
            txtPrivateEmail.PasswordChar = '\0';
            txtPrivateEmail.PlaceholderText = "Enter your Personal e-mail address";
            txtPrivateEmail.SelectedText = "";
            txtPrivateEmail.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtPrivateEmail.Size = new Size(250, 48);
            txtPrivateEmail.TabIndex = 9;
            txtPrivateEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(45, 374);
            label4.Name = "label4";
            label4.Size = new Size(101, 18);
            label4.TabIndex = 8;
            label4.Text = "Private Email";
            // 
            // cboFaculty
            // 
            cboFaculty.BackColor = Color.Transparent;
            cboFaculty.BorderRadius = 15;
            cboFaculty.CustomizableEdges = customizableEdges7;
            cboFaculty.DrawMode = DrawMode.OwnerDrawFixed;
            cboFaculty.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFaculty.FocusedColor = Color.FromArgb(94, 148, 255);
            cboFaculty.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cboFaculty.Font = new Font("Segoe UI", 10F);
            cboFaculty.ForeColor = Color.FromArgb(68, 88, 112);
            cboFaculty.ItemHeight = 30;
            cboFaculty.Items.AddRange(new object[] { "24.1", "23.2", "23.1", "22.2", "22.1", "21.2", "21.1" });
            cboFaculty.Location = new Point(284, 292);
            cboFaculty.Margin = new Padding(3, 4, 3, 4);
            cboFaculty.Name = "cboFaculty";
            cboFaculty.ShadowDecoration.CustomizableEdges = customizableEdges8;
            cboFaculty.Size = new Size(83, 36);
            cboFaculty.TabIndex = 10;
            cboFaculty.SelectedIndexChanged += guna2ComboBox1_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(65, 461);
            label5.Name = "label5";
            label5.Size = new Size(81, 18);
            label5.TabIndex = 11;
            label5.Text = "Student ID";
            // 
            // txtStudentID
            // 
            txtStudentID.BorderRadius = 15;
            txtStudentID.CustomizableEdges = customizableEdges9;
            txtStudentID.DefaultText = "";
            txtStudentID.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtStudentID.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtStudentID.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtStudentID.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtStudentID.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtStudentID.Font = new Font("Segoe UI", 9F);
            txtStudentID.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtStudentID.Location = new Point(152, 442);
            txtStudentID.Margin = new Padding(3, 5, 3, 5);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.PasswordChar = '\0';
            txtStudentID.PlaceholderText = "Enter your student ID";
            txtStudentID.SelectedText = "";
            txtStudentID.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtStudentID.Size = new Size(176, 48);
            txtStudentID.TabIndex = 12;
            txtStudentID.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-54, -87);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(636, 520);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // txtUserName
            // 
            txtUserName.BorderRadius = 15;
            txtUserName.CustomizableEdges = customizableEdges11;
            txtUserName.DefaultText = "";
            txtUserName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtUserName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtUserName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtUserName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtUserName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUserName.Font = new Font("Segoe UI", 9F);
            txtUserName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUserName.Location = new Point(566, 292);
            txtUserName.Margin = new Padding(3, 5, 3, 5);
            txtUserName.Name = "txtUserName";
            txtUserName.PasswordChar = '\0';
            txtUserName.PlaceholderText = "Enter Nsbm Username";
            txtUserName.SelectedText = "";
            txtUserName.ShadowDecoration.CustomizableEdges = customizableEdges12;
            txtUserName.Size = new Size(229, 48);
            txtUserName.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(482, 310);
            label7.Name = "label7";
            label7.Size = new Size(88, 18);
            label7.TabIndex = 16;
            label7.Text = "User Name";
            // 
            // guna2Button1
            // 
            guna2Button1.BorderRadius = 20;
            guna2Button1.CustomizableEdges = customizableEdges13;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.Teal;
            guna2Button1.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(196, 527);
            guna2Button1.Margin = new Padding(3, 4, 3, 4);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges14;
            guna2Button1.Size = new Size(206, 60);
            guna2Button1.TabIndex = 18;
            guna2Button1.Text = "Register";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.ForeColor = SystemColors.ActiveCaptionText;
            guna2HtmlLabel1.Location = new Point(453, 548);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(167, 22);
            guna2HtmlLabel1.TabIndex = 19;
            guna2HtmlLabel1.Text = "If you already registered,";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Cursor = Cursors.Hand;
            linkLabel1.LinkColor = Color.Red;
            linkLabel1.Location = new Point(641, 548);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(50, 20);
            linkLabel1.TabIndex = 20;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Log In";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Register_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(linkLabel1);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(guna2Button1);
            Controls.Add(txtUserName);
            Controls.Add(label7);
            Controls.Add(txtStudentID);
            Controls.Add(label5);
            Controls.Add(cboFaculty);
            Controls.Add(txtPrivateEmail);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtLastName);
            Controls.Add(label2);
            Controls.Add(txtFirstName);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Register_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register_Form";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtFirstName;
        private Guna.UI2.WinForms.Guna2TextBox txtLastName;
        private Label label2;
        private Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtPrivateEmail;
        private Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox cboFaculty;
        private Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtStudentID;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtUserName;
        private Label label7;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private LinkLabel linkLabel1;
    }
}