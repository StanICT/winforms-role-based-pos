
namespace McDo.Setup
{
    partial class AdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            label2 = new Label();
            label1 = new Label();
            Configuration_Login = new Button();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            txtPassword = new TextBox();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Helvetica", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(45, 306);
            label2.Name = "label2";
            label2.Size = new Size(312, 17);
            label2.TabIndex = 9;
            label2.Text = "Log in to personalized or customized products.";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Helvetica Black", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(45, 258);
            label1.Name = "label1";
            label1.Size = new Size(261, 34);
            label1.TabIndex = 8;
            label1.Text = "Welcome Admin!";
            label1.Click += label1_Click;
            // 
            // Configuration_Login
            // 
            Configuration_Login.BackColor = Color.Gold;
            Configuration_Login.FlatStyle = FlatStyle.Flat;
            Configuration_Login.Font = new Font("Helvetica", 9F);
            Configuration_Login.Location = new Point(0, 688);
            Configuration_Login.Name = "Configuration_Login";
            Configuration_Login.Size = new Size(432, 65);
            Configuration_Login.TabIndex = 6;
            Configuration_Login.Text = "Log in";
            Configuration_Login.UseVisualStyleBackColor = false;
            Configuration_Login.Click += Configuration_Confirm_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(45, -68);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(347, 567);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Helvetica", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(45, 359);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "*Name";
            textBox1.Size = new Size(347, 27);
            textBox1.TabIndex = 11;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Helvetica", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(45, 416);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "*Password";
            txtPassword.Size = new Size(347, 27);
            txtPassword.TabIndex = 12;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Helvetica", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(255, 459);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(137, 21);
            checkBox1.TabIndex = 13;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // AdminLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(432, 753);
            Controls.Add(checkBox1);
            Controls.Add(txtPassword);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Configuration_Login);
            Controls.Add(pictureBox1);
            Name = "AdminLogin";
            Text = "AdminLogin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void Configuration_Confirm_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private Label label2;
        private Label label1;
        private Button Configuration_Login;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TextBox txtPassword;
        private CheckBox checkBox1;
    }
}