
namespace McDo
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            pictureBox1 = new PictureBox();
            button3 = new Button();
            txtUsername = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtPassword = new TextBox();
            button1 = new Button();
            checkBox1 = new CheckBox();
            rdoAdmin = new RadioButton();
            rdoCustomer = new RadioButton();
            label3 = new Label();
            linkLabel2 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(231, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(209, 314);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.Font = new Font("Helvetica Black", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(10, 12);
            button3.Name = "button3";
            button3.Size = new Size(62, 48);
            button3.TabIndex = 19;
            button3.Text = "<";
            button3.TextAlign = ContentAlignment.TopCenter;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtUsername.BackColor = Color.White;
            txtUsername.Font = new Font("Helvetica", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(33, 361);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "*Username";
            txtUsername.Size = new Size(362, 25);
            txtUsername.TabIndex = 20;
            // 
            // label1
            // 
            label1.Font = new Font("Helvetica Black", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 136);
            label1.Name = "label1";
            label1.Size = new Size(249, 71);
            label1.TabIndex = 21;
            label1.Text = "Log in to the good stuff";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Helvetica", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(33, 254);
            label2.Name = "label2";
            label2.Size = new Size(203, 17);
            label2.TabIndex = 22;
            label2.Text = "Please fill in your login details.";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.Font = new Font("Helvetica", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(33, 437);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "*Password";
            txtPassword.Size = new Size(362, 25);
            txtPassword.TabIndex = 23;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Gold;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Helvetica", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(-10, 682);
            button1.Name = "button1";
            button1.Size = new Size(450, 71);
            button1.TabIndex = 26;
            button1.Text = "Log in";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.FlatStyle = FlatStyle.System;
            checkBox1.Font = new Font("Helvetica", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(261, 505);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(146, 22);
            checkBox1.TabIndex = 28;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // rdoAdmin
            // 
            rdoAdmin.AutoSize = true;
            rdoAdmin.Font = new Font("Helvetica", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdoAdmin.Location = new Point(93, 302);
            rdoAdmin.Name = "rdoAdmin";
            rdoAdmin.Size = new Size(82, 25);
            rdoAdmin.TabIndex = 29;
            rdoAdmin.TabStop = true;
            rdoAdmin.Text = "Admin";
            rdoAdmin.UseVisualStyleBackColor = true;
            // 
            // rdoCustomer
            // 
            rdoCustomer.AutoSize = true;
            rdoCustomer.Font = new Font("Helvetica", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdoCustomer.Location = new Point(231, 302);
            rdoCustomer.Name = "rdoCustomer";
            rdoCustomer.Size = new Size(109, 25);
            rdoCustomer.TabIndex = 30;
            rdoCustomer.TabStop = true;
            rdoCustomer.Text = "Customer";
            rdoCustomer.UseVisualStyleBackColor = true;
            rdoCustomer.CheckedChanged += rdoCustomer_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Helvetica", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(33, 505);
            label3.Name = "label3";
            label3.Size = new Size(134, 17);
            label3.TabIndex = 32;
            label3.Text = "Not a member yet?";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Helvetica", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel2.Location = new Point(168, 505);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(57, 17);
            linkLabel2.TabIndex = 33;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Sign up";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(432, 753);
            Controls.Add(linkLabel2);
            Controls.Add(label3);
            Controls.Add(rdoCustomer);
            Controls.Add(rdoAdmin);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtUsername);
            Controls.Add(button3);
            Controls.Add(pictureBox1);
            Name = "LogIn";
            Text = "Log In";
            Load += LogIn_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide(); // hides current form
            new LoginOrSignup().Show();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button3;
        private TextBox txtUsername;
        private Label label1;
        private Label label2;
        private TextBox txtPassword;
        private Button button1;
        private CheckBox checkBox1;
        private RadioButton rdoAdmin;
        private RadioButton rdoCustomer;
        private Label label3;
        private LinkLabel linkLabel2;
    }
}