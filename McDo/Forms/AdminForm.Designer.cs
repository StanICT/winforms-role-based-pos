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
            Category_SelectionSidebar = new FlowLayoutPanel();
            McDo_Icon = new PictureBox();
            Category_DescriptionLabel = new Label();
            Category_ProductAdd = new Button();
            Category_NameLabel = new Label();
            Category_Add = new Button();
            Category_ProductList = new ListView();
            Category_DeleteButton = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)McDo_Icon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Category_SelectionSidebar
            // 
            Category_SelectionSidebar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            Category_SelectionSidebar.AutoScroll = true;
            Category_SelectionSidebar.FlowDirection = FlowDirection.TopDown;
            Category_SelectionSidebar.Font = new Font("Helvetica", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Category_SelectionSidebar.Location = new Point(1, 162);
            Category_SelectionSidebar.Margin = new Padding(3, 4, 3, 4);
            Category_SelectionSidebar.Name = "Category_SelectionSidebar";
            Category_SelectionSidebar.Size = new Size(145, 498);
            Category_SelectionSidebar.TabIndex = 6;
            Category_SelectionSidebar.WrapContents = false;
            // 
            // McDo_Icon
            // 
            McDo_Icon.BackColor = Color.WhiteSmoke;
            McDo_Icon.Image = (Image)resources.GetObject("McDo_Icon.Image");
            McDo_Icon.Location = new Point(0, -28);
            McDo_Icon.Margin = new Padding(3, 4, 3, 4);
            McDo_Icon.Name = "McDo_Icon";
            McDo_Icon.Size = new Size(145, 200);
            McDo_Icon.SizeMode = PictureBoxSizeMode.StretchImage;
            McDo_Icon.TabIndex = 1;
            McDo_Icon.TabStop = false;
            // 
            // Category_DescriptionLabel
            // 
            Category_DescriptionLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Category_DescriptionLabel.Font = new Font("Helvetica", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Category_DescriptionLabel.Location = new Point(169, 82);
            Category_DescriptionLabel.Name = "Category_DescriptionLabel";
            Category_DescriptionLabel.Size = new Size(248, 53);
            Category_DescriptionLabel.TabIndex = 4;
            Category_DescriptionLabel.Text = "N/A";
            // 
            // Category_ProductAdd
            // 
            Category_ProductAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Category_ProductAdd.BackColor = Color.Gold;
            Category_ProductAdd.FlatStyle = FlatStyle.Popup;
            Category_ProductAdd.Font = new Font("Helvetica", 9F);
            Category_ProductAdd.ImageAlign = ContentAlignment.TopRight;
            Category_ProductAdd.Location = new Point(271, 689);
            Category_ProductAdd.Margin = new Padding(3, 4, 3, 4);
            Category_ProductAdd.Name = "Category_ProductAdd";
            Category_ProductAdd.Size = new Size(147, 51);
            Category_ProductAdd.TabIndex = 5;
            Category_ProductAdd.Text = "Add Product";
            Category_ProductAdd.UseVisualStyleBackColor = false;
            Category_ProductAdd.Click += Category_ProductAdd_Click;
            // 
            // Category_NameLabel
            // 
            Category_NameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Category_NameLabel.AutoSize = true;
            Category_NameLabel.Font = new Font("Coolvetica", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Category_NameLabel.Location = new Point(169, 23);
            Category_NameLabel.Name = "Category_NameLabel";
            Category_NameLabel.Size = new Size(68, 41);
            Category_NameLabel.TabIndex = 3;
            Category_NameLabel.Text = "N/A";
            // 
            // Category_Add
            // 
            Category_Add.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Category_Add.BackColor = Color.Gold;
            Category_Add.FlatStyle = FlatStyle.Popup;
            Category_Add.Font = new Font("Helvetica", 9F);
            Category_Add.Location = new Point(0, 689);
            Category_Add.Margin = new Padding(3, 4, 3, 4);
            Category_Add.Name = "Category_Add";
            Category_Add.Size = new Size(146, 51);
            Category_Add.TabIndex = 6;
            Category_Add.Text = "Add Category";
            Category_Add.UseVisualStyleBackColor = false;
            Category_Add.Click += Category_Add_Click;
            // 
            // Category_ProductList
            // 
            Category_ProductList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Category_ProductList.Location = new Point(169, 166);
            Category_ProductList.Margin = new Padding(3, 4, 3, 4);
            Category_ProductList.Name = "Category_ProductList";
            Category_ProductList.Size = new Size(248, 494);
            Category_ProductList.TabIndex = 8;
            Category_ProductList.UseCompatibleStateImageBehavior = false;
            Category_ProductList.MouseClick += Category_ProductList_MouseClick;
            // 
            // Category_DeleteButton
            // 
            Category_DeleteButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Category_DeleteButton.BackColor = Color.Gold;
            Category_DeleteButton.FlatStyle = FlatStyle.Popup;
            Category_DeleteButton.Font = new Font("Helvetica", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Category_DeleteButton.Location = new Point(328, 25);
            Category_DeleteButton.Margin = new Padding(3, 4, 3, 4);
            Category_DeleteButton.Name = "Category_DeleteButton";
            Category_DeleteButton.Size = new Size(89, 39);
            Category_DeleteButton.TabIndex = 10;
            Category_DeleteButton.Text = "Delete";
            Category_DeleteButton.UseVisualStyleBackColor = false;
            Category_DeleteButton.Click += Category_DeleteButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.McDonald_s;
            pictureBox1.Location = new Point(195, 689);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(61, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(432, 753);
            Controls.Add(pictureBox1);
            Controls.Add(Category_DeleteButton);
            Controls.Add(Category_ProductList);
            Controls.Add(Category_Add);
            Controls.Add(Category_ProductAdd);
            Controls.Add(Category_DescriptionLabel);
            Controls.Add(Category_SelectionSidebar);
            Controls.Add(McDo_Icon);
            Controls.Add(Category_NameLabel);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(450, 636);
            Name = "AdminForm";
            Text = "Admin Form";
            Load += AdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)McDo_Icon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox McDo_Icon;
        private Label Category_DescriptionLabel;
        private Button Category_ProductAdd;
        private Label Category_NameLabel;
        private FlowLayoutPanel Category_SelectionSidebar;
        private Button Category_Add;
        private ListView Category_ProductList;
        private Button Category_DeleteButton;
        private PictureBox pictureBox1;
    }
}