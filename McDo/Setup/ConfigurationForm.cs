using McDo.Forms;
using System.ComponentModel;
using System.Text.Json;

namespace McDo.Setup
{
    public partial class Configuration : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ConfigUserType UserType { get; set; }

        public Configuration()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Configuration));
            UserType_GroupBox = new GroupBox();
            UserType_Customer = new RadioButton();
            UserType_Admin = new RadioButton();
            Configuration_Confirm = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            UserType_GroupBox.SuspendLayout();
            ((ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // UserType_GroupBox
            // 
            UserType_GroupBox.Controls.Add(UserType_Customer);
            UserType_GroupBox.Controls.Add(UserType_Admin);
            UserType_GroupBox.Font = new Font("Helvetica", 9F);
            UserType_GroupBox.Location = new Point(82, 360);
            UserType_GroupBox.Name = "UserType_GroupBox";
            UserType_GroupBox.Size = new Size(263, 88);
            UserType_GroupBox.TabIndex = 0;
            UserType_GroupBox.TabStop = false;
            UserType_GroupBox.Text = "User Type";
            UserType_GroupBox.Enter += UserType_GroupBox_Enter;
            // 
            // UserType_Customer
            // 
            UserType_Customer.AutoSize = true;
            UserType_Customer.Location = new Point(13, 53);
            UserType_Customer.Name = "UserType_Customer";
            UserType_Customer.Size = new Size(94, 21);
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
            UserType_Admin.Size = new Size(71, 21);
            UserType_Admin.TabIndex = 0;
            UserType_Admin.TabStop = true;
            UserType_Admin.Text = "Admin";
            UserType_Admin.UseVisualStyleBackColor = true;
            // 
            // Configuration_Confirm
            // 
            Configuration_Confirm.BackColor = Color.Gold;
            Configuration_Confirm.FlatStyle = FlatStyle.Flat;
            Configuration_Confirm.Font = new Font("Helvetica", 9F);
            Configuration_Confirm.Location = new Point(0, 688);
            Configuration_Confirm.Name = "Configuration_Confirm";
            Configuration_Confirm.Size = new Size(432, 65);
            Configuration_Confirm.TabIndex = 1;
            Configuration_Confirm.Text = "Confirm";
            Configuration_Confirm.UseVisualStyleBackColor = false;
            Configuration_Confirm.Click += Configuration_Confirm_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(45, -68);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(347, 567);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Helvetica Black", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(45, 258);
            label1.Name = "label1";
            label1.Size = new Size(167, 34);
            label1.TabIndex = 3;
            label1.Text = "Greetings!";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Helvetica", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(45, 306);
            label2.Name = "label2";
            label2.Size = new Size(325, 17);
            label2.TabIndex = 4;
            label2.Text = "Choose a user type between admin or customer.";
            // 
            // Configuration
            // 
            AcceptButton = Configuration_Confirm;
            BackColor = Color.White;
            ClientSize = new Size(432, 753);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Configuration_Confirm);
            Controls.Add(UserType_GroupBox);
            Controls.Add(pictureBox1);
            Name = "Configuration";
            Text = "`";
            UserType_GroupBox.ResumeLayout(false);
            UserType_GroupBox.PerformLayout();
            ((ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }
        public class UserSession
        {
            public string UserType { get; set; }
        }


        private void Configuration_Confirm_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedType = UserType_Admin.Checked ? "Admin" : "Customer";

                // Save session safely
                string folder = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                    "McDoPOS"
                );

                Directory.CreateDirectory(folder);

                string path = Path.Combine(folder, "session.json");

                var session = new UserSession { UserType = selectedType };
                string json = JsonSerializer.Serialize(session);

                File.WriteAllText(path, json);

                this.UserType = selectedType == "Admin" ? ConfigUserType.Admin : ConfigUserType.Customer;

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserType_GroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
