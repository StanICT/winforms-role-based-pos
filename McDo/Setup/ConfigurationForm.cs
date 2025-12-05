using System.ComponentModel;

namespace McDo.Setup
{
    public partial class Configuration : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ConfigUserType UserType { get; set; }

        public Configuration()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            UserType_GroupBox = new GroupBox();
            UserType_Customer = new RadioButton();
            UserType_Admin = new RadioButton();
            Configuration_Confirm = new Button();
            UserType_GroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // UserType_GroupBox
            // 
            UserType_GroupBox.Controls.Add(UserType_Customer);
            UserType_GroupBox.Controls.Add(UserType_Admin);
            UserType_GroupBox.Location = new Point(12, 12);
            UserType_GroupBox.Name = "UserType_GroupBox";
            UserType_GroupBox.Size = new Size(263, 86);
            UserType_GroupBox.TabIndex = 0;
            UserType_GroupBox.TabStop = false;
            UserType_GroupBox.Text = "User Type";
            // 
            // UserType_Customer
            // 
            UserType_Customer.AutoSize = true;
            UserType_Customer.Location = new Point(13, 53);
            UserType_Customer.Name = "UserType_Customer";
            UserType_Customer.Size = new Size(82, 21);
            UserType_Customer.TabIndex = 1;
            UserType_Customer.TabStop = true;
            UserType_Customer.Text = "Customer";
            UserType_Customer.UseVisualStyleBackColor = true;
            // 
            // UserType_Admin
            // 
            UserType_Admin.AutoSize = true;
            UserType_Admin.Location = new Point(13, 26);
            UserType_Admin.Name = "UserType_Admin";
            UserType_Admin.Size = new Size(63, 21);
            UserType_Admin.TabIndex = 0;
            UserType_Admin.TabStop = true;
            UserType_Admin.Text = "Admin";
            UserType_Admin.UseVisualStyleBackColor = true;
            // 
            // Configuration_Confirm
            // 
            Configuration_Confirm.Location = new Point(12, 278);
            Configuration_Confirm.Name = "Configuration_Confirm";
            Configuration_Confirm.Size = new Size(109, 27);
            Configuration_Confirm.TabIndex = 1;
            Configuration_Confirm.Text = "Confirm";
            Configuration_Confirm.UseVisualStyleBackColor = true;
            Configuration_Confirm.Click += Configuration_Confirm_Click;
            // 
            // Configuration
            // 
            AcceptButton = Configuration_Confirm;
            ClientSize = new Size(287, 317);
            Controls.Add(Configuration_Confirm);
            Controls.Add(UserType_GroupBox);
            Name = "Configuration";
            Text = "Configuration";
            UserType_GroupBox.ResumeLayout(false);
            UserType_GroupBox.PerformLayout();
            ResumeLayout(false);

        }

        private void Configuration_Confirm_Click(object sender, EventArgs e)
        {
            if (UserType_Admin.Checked)
                UserType = ConfigUserType.Admin;
            else if (UserType_Customer.Checked)
                UserType = ConfigUserType.Customer;

            this.DialogResult = DialogResult.OK;
        }
    }
}
