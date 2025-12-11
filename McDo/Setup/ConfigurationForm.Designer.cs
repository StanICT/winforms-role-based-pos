namespace McDo.Setup
{
    partial class Configuration
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
        private GroupBox UserType_GroupBox;
        private RadioButton UserType_Customer;
        private RadioButton UserType_Admin;
        private Button Configuration_Confirm;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
    }
}