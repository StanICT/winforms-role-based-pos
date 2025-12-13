namespace McDo.Forms.AdminForms.Categories
{
    partial class CategoryAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryAdd));
            Category_NameInput = new TextBox();
            Category_NameLabel = new Label();
            Category_DescLabel = new Label();
            Category_DescInput = new McDo.Components.TextArea(components);
            Category_AddButton = new Button();
            McDo_Icon = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)McDo_Icon).BeginInit();
            SuspendLayout();
            // 
            // Category_NameInput
            // 
            Category_NameInput.Font = new Font("Helvetica", 9F);
            Category_NameInput.Location = new Point(139, 34);
            Category_NameInput.Margin = new Padding(3, 4, 3, 4);
            Category_NameInput.Name = "Category_NameInput";
            Category_NameInput.PlaceholderText = "Fries and Burgers, etc ...";
            Category_NameInput.Size = new Size(219, 25);
            Category_NameInput.TabIndex = 0;
            // 
            // Category_NameLabel
            // 
            Category_NameLabel.AutoSize = true;
            Category_NameLabel.Font = new Font("Helvetica", 9F);
            Category_NameLabel.Location = new Point(139, 11);
            Category_NameLabel.Name = "Category_NameLabel";
            Category_NameLabel.Size = new Size(148, 17);
            Category_NameLabel.TabIndex = 1;
            Category_NameLabel.Text = "Category Name";
            // 
            // Category_DescLabel
            // 
            Category_DescLabel.AutoSize = true;
            Category_DescLabel.Font = new Font("Helvetica", 9F);
            Category_DescLabel.Location = new Point(139, 95);
            Category_DescLabel.Name = "Category_DescLabel";
            Category_DescLabel.Size = new Size(146, 17);
            Category_DescLabel.TabIndex = 3;
            Category_DescLabel.Text = "Category Description";
            // 
            // Category_DescInput
            // 
            Category_DescInput.Font = new Font("Helvetica", 9F);
            Category_DescInput.Location = new Point(14, 122);
            Category_DescInput.Margin = new Padding(3, 4, 3, 4);
            Category_DescInput.Name = "Category_DescInput";
            Category_DescInput.Placeholder = "Fries and burgers you'll never forget, ...";
            Category_DescInput.Size = new Size(345, 202);
            Category_DescInput.TabIndex = 4;
            Category_DescInput.Text = "";
            // 
            // Category_AddButton
            // 
            Category_AddButton.Font = new Font("Helvetica", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Category_AddButton.Location = new Point(247, 407);
            Category_AddButton.Margin = new Padding(3, 4, 3, 4);
            Category_AddButton.Name = "Category_AddButton";
            Category_AddButton.Size = new Size(112, 33);
            Category_AddButton.TabIndex = 5;
            Category_AddButton.Text = "Add";
            Category_AddButton.UseVisualStyleBackColor = true;
            Category_AddButton.Click += Category_AddButton_Click;
            // 
            // McDo_Icon
            // 
            McDo_Icon.BackColor = Color.WhiteSmoke;
            McDo_Icon.BorderStyle = BorderStyle.Fixed3D;
            McDo_Icon.Image = (Image)resources.GetObject("McDo_Icon.Image");
            McDo_Icon.Location = new Point(0, -4);
            McDo_Icon.Margin = new Padding(3, 4, 3, 4);
            McDo_Icon.Name = "McDo_Icon";
            McDo_Icon.Size = new Size(138, 118);
            McDo_Icon.SizeMode = PictureBoxSizeMode.StretchImage;
            McDo_Icon.TabIndex = 6;
            McDo_Icon.TabStop = false;
            // 
            // CategoryAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(373, 454);
            Controls.Add(McDo_Icon);
            Controls.Add(Category_AddButton);
            Controls.Add(Category_DescInput);
            Controls.Add(Category_DescLabel);
            Controls.Add(Category_NameLabel);
            Controls.Add(Category_NameInput);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CategoryAdd";
            Text = "Add Category";
            ((System.ComponentModel.ISupportInitialize)McDo_Icon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Category_NameInput;
        private Label Category_NameLabel;
        private Label Category_DescLabel;
        private Components.TextArea Category_DescInput;
        private Button Category_AddButton;
        private PictureBox McDo_Icon;
    }
}