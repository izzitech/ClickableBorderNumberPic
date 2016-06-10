using System;
using System.Drawing;
using System.Windows.Forms;

namespace PictureFrameControl
{
    public partial class PictureFrame : UserControl
    {
        public int id = 1;
        public bool status = false;
        public int borderSize = 2;

        public Label numberShown = new Label();
        public Color statusColor = new Color();
        public PictureBox pictureBox = new PictureBox();
        public Point pictureLocation = new Point();
        public Panel panelTouch = new Panel();

        public PictureFrame()
        {
            InitializeComponent();
        }

        public void Create()
        {
            statusColor = status ? Color.Green : Color.Red;
            this.BackColor = statusColor;
            this.MouseDown += MouseDownEvent;

            numberShown.Width = 28;
            numberShown.Height = 18;
            numberShown.BackColor = statusColor;
            numberShown.Text = id.ToString();
            numberShown.TextAlign = ContentAlignment.MiddleCenter;
            numberShown.MouseDown += MouseDownEvent;
            this.Controls.Add(numberShown);

            pictureLocation.X = this.Location.X + borderSize;
            pictureLocation.Y = this.Location.Y + borderSize;
            pictureBox.Location = pictureLocation;
            pictureBox.Width = this.Width - (2 * borderSize);
            pictureBox.Height = this.Height - (2 * borderSize);
            // TODO: Change to "zoom". Stretch is just for showing but distorts image!!
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.MouseDown += MouseDownEvent;
            this.Controls.Add(pictureBox);
        }
    
        public void MouseDownEvent(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Status(!status);
            }
        }

        public void ChangeId(int _id)
        {
            id = _id;
            numberShown.Text = _id.ToString();
        }

        public void Status(bool value)
        {
            status = value;
            statusColor = status ? Color.Green : Color.Red;
            this.BackColor = statusColor;
            numberShown.BackColor = statusColor;
        }
    }
}
