using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Font = System.Drawing.Font;
using Image = System.Drawing.Image;

namespace McDo.Forms
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            flowSidebar = new FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button5 = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            button4 = new Button();
            label1 = new Label();
            btnAddCategory = new Button();
            pictureBox2 = new PictureBox();
            flowSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // flowSidebar
            // 
            flowSidebar.AutoScroll = true;
            flowSidebar.Controls.Add(button1);
            flowSidebar.Controls.Add(button2);
            flowSidebar.Controls.Add(button3);
            flowSidebar.Controls.Add(button5);
            flowSidebar.FlowDirection = FlowDirection.TopDown;
            flowSidebar.Location = new Point(-2, 162);
            flowSidebar.Name = "flowSidebar";
            flowSidebar.Size = new Size(132, 467);
            flowSidebar.TabIndex = 6;
            flowSidebar.WrapContents = false;
            // 
            // button1
            // 
            button1.Font = new Font("Helvetica", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(129, 39);
            button1.TabIndex = 8;
            button1.Text = "Chicken";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Helvetica", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(3, 48);
            button2.Name = "button2";
            button2.Size = new Size(129, 39);
            button2.TabIndex = 9;
            button2.Text = "Burgers";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Helvetica", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(3, 93);
            button3.Name = "button3";
            button3.Size = new Size(129, 39);
            button3.TabIndex = 10;
            button3.Text = "Fries";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Helvetica", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(3, 138);
            button5.Name = "button5";
            button5.Size = new Size(129, 39);
            button5.TabIndex = 11;
            button5.Text = "Drinks";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.WhiteSmoke;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-2, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(132, 137);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Helvetica", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(169, 99);
            label2.Name = "label2";
            label2.Size = new Size(231, 17);
            label2.TabIndex = 4;
            label2.Text = "Browse between categories below";
            // 
            // button4
            // 
            button4.BackColor = Color.Gold;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Helvetica", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ImageAlign = ContentAlignment.TopRight;
            button4.Location = new Point(273, 669);
            button4.Name = "button4";
            button4.Size = new Size(147, 85);
            button4.TabIndex = 5;
            button4.Text = "Add Product";
            button4.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Helvetica Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(211, 40);
            label1.Name = "label1";
            label1.Size = new Size(150, 37);
            label1.TabIndex = 3;
            label1.Text = "Chicken";
            // 
            // btnAddCategory
            // 
            btnAddCategory.BackColor = Color.Gold;
            btnAddCategory.FlatStyle = FlatStyle.Popup;
            btnAddCategory.Font = new Font("Helvetica", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddCategory.Location = new Point(12, 669);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(132, 39);
            btnAddCategory.TabIndex = 6;
            btnAddCategory.Text = "Add Category";
            btnAddCategory.UseVisualStyleBackColor = false;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(169, 669);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(83, 85);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(432, 753);
            Controls.Add(pictureBox2);
            Controls.Add(btnAddCategory);
            Controls.Add(button4);
            Controls.Add(label2);
            Controls.Add(flowSidebar);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "AdminForm";
            Text = "Admin Form";
            flowSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label2;
        private Button button4;
        private Label label1;
        private FlowLayoutPanel flowSidebar;
        private Button btnAddCategory;
        private PictureBox pictureBox2;
        private Button button1;
        private Button button3;
        private Button button2;
        private Button button5;
    }
}