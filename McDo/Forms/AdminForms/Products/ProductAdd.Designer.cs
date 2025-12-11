namespace McDo.Forms.AdminForms.Products
{
    partial class ProductAdd
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductAdd));
            McDo_Icon = new PictureBox();
            Product_DescInput = new McDo.Components.TextArea(components);
            Product_DescLabel = new Label();
            Product_NameLabel = new Label();
            Product_NameInput = new TextBox();
            Product_PriceLabel = new Label();
            Product_PriceInput = new TextBox();
            Product_Icon = new PictureBox();
            Product_IconLabel = new Label();
            Product_AddButton = new Button();
            Product_IconFileInput = new OpenFileDialog();
            Product_PriceCurrencyDisplay = new Button();
            ((System.ComponentModel.ISupportInitialize)McDo_Icon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Product_Icon).BeginInit();
            SuspendLayout();
            // 
            // McDo_Icon
            // 
            McDo_Icon.BackColor = Color.WhiteSmoke;
            McDo_Icon.BorderStyle = BorderStyle.Fixed3D;
            McDo_Icon.Image = (Image)resources.GetObject("McDo_Icon.Image");
            McDo_Icon.Location = new Point(-10, -2);
            McDo_Icon.Margin = new Padding(3, 4, 3, 4);
            McDo_Icon.Name = "McDo_Icon";
            McDo_Icon.Size = new Size(159, 171);
            McDo_Icon.SizeMode = PictureBoxSizeMode.StretchImage;
            McDo_Icon.TabIndex = 2;
            McDo_Icon.TabStop = false;
            // 
            // Product_DescInput
            // 
            Product_DescInput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
<<<<<<< HEAD
            Product_DescInput.Font = new Font("Helvetica", 9F);
            Product_DescInput.Location = new Point(157, 91);
            Product_DescInput.Margin = new Padding(3, 4, 3, 4);
=======
            Product_DescInput.Location = new Point(137, 77);
>>>>>>> 782bbf2f60df7c7da6b3df2c01340e7adb97556b
            Product_DescInput.Name = "Product_DescInput";
            Product_DescInput.Placeholder = "Fries and burgers you'll never forget, ...";
            Product_DescInput.Size = new Size(402, 78);
            Product_DescInput.TabIndex = 8;
            Product_DescInput.Text = "";
            // 
            // Product_DescLabel
            // 
            Product_DescLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Product_DescLabel.AutoSize = true;
            Product_DescLabel.Font = new Font("Helvetica", 9F);
            Product_DescLabel.Location = new Point(157, 67);
            Product_DescLabel.Name = "Product_DescLabel";
            Product_DescLabel.Size = new Size(137, 17);
            Product_DescLabel.TabIndex = 7;
            Product_DescLabel.Text = "Product Description";
            // 
            // Product_NameLabel
            // 
            Product_NameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Product_NameLabel.AutoSize = true;
            Product_NameLabel.Font = new Font("Helvetica", 9F);
            Product_NameLabel.Location = new Point(157, 11);
            Product_NameLabel.Name = "Product_NameLabel";
            Product_NameLabel.Size = new Size(103, 17);
            Product_NameLabel.TabIndex = 6;
            Product_NameLabel.Text = "Product Name";
            // 
            // Product_NameInput
            // 
            Product_NameInput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
<<<<<<< HEAD
            Product_NameInput.Font = new Font("Helvetica", 9F);
            Product_NameInput.Location = new Point(157, 34);
            Product_NameInput.Margin = new Padding(3, 4, 3, 4);
=======
            Product_NameInput.Location = new Point(137, 29);
>>>>>>> 782bbf2f60df7c7da6b3df2c01340e7adb97556b
            Product_NameInput.Name = "Product_NameInput";
            Product_NameInput.PlaceholderText = "Fries and Burgers, etc ...";
            Product_NameInput.Size = new Size(402, 25);
            Product_NameInput.TabIndex = 5;
            // 
            // Product_PriceLabel
            // 
            Product_PriceLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            Product_PriceLabel.AutoSize = true;
<<<<<<< HEAD
            Product_PriceLabel.Font = new Font("Helvetica", 9F);
            Product_PriceLabel.Location = new Point(234, 192);
=======
            Product_PriceLabel.Location = new Point(205, 163);
>>>>>>> 782bbf2f60df7c7da6b3df2c01340e7adb97556b
            Product_PriceLabel.Name = "Product_PriceLabel";
            Product_PriceLabel.Size = new Size(176, 17);
            Product_PriceLabel.TabIndex = 9;
            Product_PriceLabel.Text = "Product Price (Per Order)";
            // 
            // Product_PriceInput
            // 
            Product_PriceInput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
<<<<<<< HEAD
            Product_PriceInput.Font = new Font("Helvetica", 9F);
            Product_PriceInput.Location = new Point(291, 215);
            Product_PriceInput.Margin = new Padding(3, 4, 3, 4);
            Product_PriceInput.Name = "Product_PriceInput";
            Product_PriceInput.PlaceholderText = "Php35.00, Php75.50, Php129.99, ...";
            Product_PriceInput.Size = new Size(267, 25);
=======
            Product_PriceInput.Location = new Point(255, 183);
            Product_PriceInput.Name = "Product_PriceInput";
            Product_PriceInput.PlaceholderText = "Php35.00, Php75.50, Php129.99, ...";
            Product_PriceInput.Size = new Size(234, 25);
>>>>>>> 782bbf2f60df7c7da6b3df2c01340e7adb97556b
            Product_PriceInput.TabIndex = 10;
            // 
            // Product_Icon
            // 
            Product_Icon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Product_Icon.BackColor = SystemColors.ControlLight;
            Product_Icon.Location = new Point(14, 215);
            Product_Icon.Margin = new Padding(3, 4, 3, 4);
            Product_Icon.Name = "Product_Icon";
            Product_Icon.Size = new Size(214, 198);
            Product_Icon.TabIndex = 13;
            Product_Icon.TabStop = false;
            Product_Icon.Click += Product_Icon_Click;
            // 
            // Product_IconLabel
            // 
            Product_IconLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            Product_IconLabel.AutoSize = true;
            Product_IconLabel.Font = new Font("Helvetica", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Product_IconLabel.Location = new Point(14, 192);
            Product_IconLabel.Name = "Product_IconLabel";
            Product_IconLabel.Size = new Size(91, 17);
            Product_IconLabel.TabIndex = 14;
            Product_IconLabel.Text = "Product Icon";
            // 
            // Product_AddButton
            // 
            Product_AddButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
<<<<<<< HEAD
            Product_AddButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Product_AddButton.Location = new Point(431, 380);
            Product_AddButton.Margin = new Padding(3, 4, 3, 4);
=======
            Product_AddButton.Location = new Point(377, 323);
>>>>>>> 782bbf2f60df7c7da6b3df2c01340e7adb97556b
            Product_AddButton.Name = "Product_AddButton";
            Product_AddButton.Size = new Size(128, 33);
            Product_AddButton.TabIndex = 15;
            Product_AddButton.Text = "Add";
            Product_AddButton.UseVisualStyleBackColor = true;
            Product_AddButton.Click += Product_AddButton_Click;
            // 
            // Product_IconFileInput
            // 
            Product_IconFileInput.FileName = "ProductIcon";
            // 
            // Product_PriceCurrencyDisplay
            // 
            Product_PriceCurrencyDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Right;
<<<<<<< HEAD
            Product_PriceCurrencyDisplay.Font = new Font("Helvetica", 9F);
            Product_PriceCurrencyDisplay.Location = new Point(234, 215);
            Product_PriceCurrencyDisplay.Margin = new Padding(3, 4, 3, 4);
            Product_PriceCurrencyDisplay.Name = "Product_PriceCurrencyDisplay";
            Product_PriceCurrencyDisplay.Size = new Size(53, 29);
=======
            Product_PriceCurrencyDisplay.Location = new Point(205, 183);
            Product_PriceCurrencyDisplay.Name = "Product_PriceCurrencyDisplay";
            Product_PriceCurrencyDisplay.Size = new Size(46, 25);
>>>>>>> 782bbf2f60df7c7da6b3df2c01340e7adb97556b
            Product_PriceCurrencyDisplay.TabIndex = 16;
            Product_PriceCurrencyDisplay.Text = "PHP";
            Product_PriceCurrencyDisplay.UseVisualStyleBackColor = true;
            // 
            // ProductAdd
            // 
            AcceptButton = Product_AddButton;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
<<<<<<< HEAD
            ClientSize = new Size(587, 441);
=======
            ClientSize = new Size(514, 375);
>>>>>>> 782bbf2f60df7c7da6b3df2c01340e7adb97556b
            Controls.Add(Product_PriceCurrencyDisplay);
            Controls.Add(Product_AddButton);
            Controls.Add(Product_IconLabel);
            Controls.Add(Product_Icon);
            Controls.Add(Product_PriceInput);
            Controls.Add(Product_PriceLabel);
            Controls.Add(Product_DescInput);
            Controls.Add(Product_DescLabel);
            Controls.Add(Product_NameLabel);
            Controls.Add(Product_NameInput);
            Controls.Add(McDo_Icon);
<<<<<<< HEAD
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(603, 481);
=======
            MinimumSize = new Size(530, 416);
>>>>>>> 782bbf2f60df7c7da6b3df2c01340e7adb97556b
            Name = "ProductAdd";
            Text = "Product Add";
            Load += ProductAdd_Load;
            ((System.ComponentModel.ISupportInitialize)McDo_Icon).EndInit();
            ((System.ComponentModel.ISupportInitialize)Product_Icon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox McDo_Icon;
        private Components.TextArea Product_DescInput;
        private Label Product_DescLabel;
        private Label Product_NameLabel;
        private TextBox Product_NameInput;
        private Label Product_PriceLabel;
        private TextBox Product_PriceInput;
        private PictureBox Product_Icon;
        private Label Product_IconLabel;
        private Button Product_AddButton;
        private OpenFileDialog Product_IconFileInput;
        private Button Product_PriceCurrencyDisplay;
    }
}