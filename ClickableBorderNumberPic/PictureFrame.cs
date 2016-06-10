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
        public string imagePath = ""; // = @".\testing\gato.jpg";

        Label numberShown = new Label();
        Label lblImagePath = new Label();
        Color statusColor = new Color();
        PictureBox pictureBox = new PictureBox();
        Point pictureLocation = new Point();

        public PictureFrame()
        {
            InitializeComponent();
            this.MouseDown += OnClick;
        }

        public void Create()
        {
            statusColor = status ? Color.Green : Color.Red;
            this.BackColor = statusColor;

            // number.AutoSize = true;
            numberShown.Width = 28;
            numberShown.Height = 18;
            numberShown.BackColor = statusColor;
            numberShown.Text = id.ToString();
            numberShown.TextAlign = ContentAlignment.MiddleCenter;
            this.Controls.Add(numberShown);

            lblImagePath.Text = imagePath;
            lblImagePath.Top = numberShown.Top + numberShown.Bottom;
            this.Controls.Add(lblImagePath);

            pictureBox.ImageLocation = imagePath;
            pictureLocation.X = this.Location.X + borderSize;
            pictureLocation.Y = this.Location.Y + borderSize;
            pictureBox.Location = pictureLocation;
            pictureBox.Width = this.Width - (6 + (2 * borderSize));
            pictureBox.Height = this.Height - (6 + (2 * borderSize));
            // TODO: Change to "zoom". Stretch is just for showing but distorts image!!
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.MouseDown += OnClick;
            this.Controls.Add(pictureBox);
        }
    
        public void OnClick(object sender, EventArgs e)
        {
            Status(!status);
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
