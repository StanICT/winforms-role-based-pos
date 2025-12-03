namespace McDo
{
    partial class LoginOrSignup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginOrSignup));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-10, -117);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(450, 663);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Helvetica Black", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 287);
            label1.Name = "label1";
            label1.Size = new Size(290, 34);
            label1.TabIndex = 1;
            label1.Text = "Good things ahead";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Location = new Point(32, 340);
            label2.Name = "label2";
            label2.Size = new Size(388, 58);
            label2.TabIndex = 2;
            label2.Text = "Become a member to order and pay in the app, receive tasty deals and collect points on your purchases.";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Helvetica", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(-10, 688);
            button1.Name = "button1";
            button1.Size = new Size(229, 67);
            button1.TabIndex = 3;
            button1.Text = "Log in";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Gold;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Helvetica", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(219, 688);
            button2.Name = "button2";
            button2.Size = new Size(221, 67);
            button2.TabIndex = 4;
            button2.Text = "Sign up";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.Font = new Font("Helvetica Black", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(12, 12);
            button3.Name = "button3";
            button3.Size = new Size(62, 48);
            button3.TabIndex = 7;
            button3.Text = "<";
            button3.TextAlign = ContentAlignment.TopCenter;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // LoginOrSignup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(432, 753);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "LoginOrSignup";
            Text = "LoginOrSignup";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}