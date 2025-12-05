using System.ComponentModel;

namespace McDo.Components
{
    public partial class TextArea : RichTextBox
    {
        private string placeholder = "";

        [Browsable(true)]
        [Category("Appearance")]
        [Description("The placeholder text displayed when the TextArea is empty.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Placeholder
        {
            get => placeholder;
            set
            {
                placeholder = value;
                Invalidate();
            }
        }

        public TextArea()
        {
            InitializeComponent();

            SetStyle(ControlStyles.UserPaint, true);
        }

        public TextArea(IContainer container)
        {
            container.Add(this);
            InitializeComponent();

            SetStyle(ControlStyles.UserPaint, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (string.IsNullOrEmpty(Text))
                e.Graphics.DrawString(Placeholder, Font, Brushes.Gray, new PointF(0, 0));
            else
                e.Graphics.DrawString(Text, Font, Brushes.Black, new PointF(0, 0));
        }
    }
}
