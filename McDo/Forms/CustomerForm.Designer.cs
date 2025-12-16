namespace McDo.Forms
{
    partial class CustomerForm
    {

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            Category_DescriptionLabel = new Label();
            Category_NameLabel = new Label();
            McDo_Icon = new PictureBox();
            Category_SelectionSidebar = new FlowLayoutPanel();
            Category_ProductAdd = new Button();
            Category_Add = new Button();
            Customer_ProductList = new ListView();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)McDo_Icon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Category_DescriptionLabel
            // 
            Category_DescriptionLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Category_DescriptionLabel.Font = new Font("Helvetica", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Category_DescriptionLabel.Location = new Point(169, 98);
            Category_DescriptionLabel.Name = "Category_DescriptionLabel";
            Category_DescriptionLabel.Size = new Size(248, 53);
            Category_DescriptionLabel.TabIndex = 14;
            Category_DescriptionLabel.Text = "N/A";
            // 
            // Category_NameLabel
            // 
            Category_NameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Category_NameLabel.AutoSize = true;
            Category_NameLabel.Font = new Font("Coolvetica", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Category_NameLabel.Location = new Point(169, 39);
            Category_NameLabel.Name = "Category_NameLabel";
            Category_NameLabel.Size = new Size(68, 41);
            Category_NameLabel.TabIndex = 13;
            Category_NameLabel.Text = "N/A";
            // 
            // McDo_Icon
            // 
            McDo_Icon.BackColor = Color.WhiteSmoke;
            McDo_Icon.BackgroundImageLayout = ImageLayout.None;
            McDo_Icon.BorderStyle = BorderStyle.Fixed3D;
            McDo_Icon.Image = (Image)resources.GetObject("McDo_Icon.Image");
            McDo_Icon.Location = new Point(-2, -2);
            McDo_Icon.Margin = new Padding(3, 4, 3, 4);
            McDo_Icon.Name = "McDo_Icon";
            McDo_Icon.Size = new Size(146, 153);
            McDo_Icon.SizeMode = PictureBoxSizeMode.StretchImage;
            McDo_Icon.TabIndex = 12;
            McDo_Icon.TabStop = false;
            // 
            // Category_SelectionSidebar
            // 
            Category_SelectionSidebar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            Category_SelectionSidebar.AutoScroll = true;
            Category_SelectionSidebar.FlowDirection = FlowDirection.TopDown;
            Category_SelectionSidebar.Font = new Font("Helvetica", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Category_SelectionSidebar.Location = new Point(-2, 178);
            Category_SelectionSidebar.Margin = new Padding(3, 4, 3, 4);
            Category_SelectionSidebar.Name = "Category_SelectionSidebar";
            Category_SelectionSidebar.Size = new Size(146, 498);
            Category_SelectionSidebar.TabIndex = 17;
            Category_SelectionSidebar.WrapContents = false;
            // 
            // Category_ProductAdd
            // 
            Category_ProductAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Category_ProductAdd.BackColor = Color.Gold;
            Category_ProductAdd.FlatStyle = FlatStyle.Popup;
            Category_ProductAdd.Font = new Font("Helvetica", 9F);
            Category_ProductAdd.ImageAlign = ContentAlignment.TopRight;
            Category_ProductAdd.Location = new Point(271, 690);
            Category_ProductAdd.Margin = new Padding(3, 4, 3, 4);
            Category_ProductAdd.Name = "Category_ProductAdd";
            Category_ProductAdd.Size = new Size(147, 51);
            Category_ProductAdd.TabIndex = 15;
            Category_ProductAdd.Text = "Add Product";
            Category_ProductAdd.UseVisualStyleBackColor = false;
            // 
            // Category_Add
            // 
            Category_Add.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Category_Add.BackColor = Color.Gold;
            Category_Add.FlatStyle = FlatStyle.Popup;
            Category_Add.Font = new Font("Helvetica", 9F);
            Category_Add.Location = new Point(-2, 690);
            Category_Add.Margin = new Padding(3, 4, 3, 4);
            Category_Add.Name = "Category_Add";
            Category_Add.Size = new Size(146, 51);
            Category_Add.TabIndex = 16;
            Category_Add.Text = "Add Category";
            Category_Add.UseVisualStyleBackColor = false;
            // 
            // Customer_ProductList
            // 
            Customer_ProductList.Location = new Point(169, 178);
            Customer_ProductList.Name = "Customer_ProductList";
            Customer_ProductList.Size = new Size(249, 498);
            Customer_ProductList.TabIndex = 21;
            Customer_ProductList.UseCompatibleStateImageBehavior = false;
            Customer_ProductList.SelectedIndexChanged += Customer_ProductList_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.McDonald_s;
            pictureBox1.Location = new Point(176, 690);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(61, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(432, 753);
            Controls.Add(pictureBox1);
            Controls.Add(Category_Add);
            Controls.Add(Category_ProductAdd);
            Controls.Add(Category_DescriptionLabel);
            Controls.Add(Category_SelectionSidebar);
            Controls.Add(McDo_Icon);
            Controls.Add(Category_NameLabel);
            Controls.Add(Customer_ProductList);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CustomerForm";
            Text = "Customer Form";
            Load += CustomerForm_Load;
            ((System.ComponentModel.ISupportInitialize)McDo_Icon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
            this.Customer_ProductList.DoubleClick += new System.EventHandler(this.Customer_ProductList_DoubleClick);

        }

        #endregion

        private Label Category_DescriptionLabel;
        private Label Category_NameLabel;
        private PictureBox McDo_Icon;
        private FlowLayoutPanel Category_SelectionSidebar;
        private Button Category_ProductAdd;
        private Button Category_Add;
        private ListView Customer_ProductList;
        private PictureBox pictureBox1;
    }
}