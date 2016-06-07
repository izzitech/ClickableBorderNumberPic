using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickableBorderNumberPic
{
    public partial class ClickableBorderNumberPic : UserControl
    {
        public int value = 1;
        public bool status = false;
        public int borderSize = 0;

        Label number = new Label();
        Random ran = new Random();
        Color statusColor = new Color();
        PictureBox picture = new PictureBox();
        Point pictureLocation = new Point();
        Rectangle formSize = new Rectangle();

        public ClickableBorderNumberPic()
        {
            InitializeComponent();
            formSize = this.ClientRectangle;
        }

        public void Create(int formWidth, int formHeight)
        {
            this.Width = formWidth;
            this.Height = formHeight;

            if (status)
            {
                statusColor = Color.Green;
            }
            else
            {
                statusColor = Color.Red;
            }

            this.BackColor = statusColor;

            // number.AutoSize = true;
            number.Width = 28;
            number.Height = 18;
            number.BackColor = statusColor;
            number.Text = value.ToString();
            number.TextAlign = ContentAlignment.MiddleCenter;
            this.Controls.Add(number);

            picture.ImageLocation = @"D:\oto.jpg";
            pictureLocation.X = this.Location.X + borderSize;
            pictureLocation.Y= this.Location.Y + borderSize;
            picture.Location = pictureLocation;
            picture.Width = this.Width - (6 + (2*borderSize));
            picture.Height = this.Height - (6 + (2*borderSize));
            // TODO: Change to "zoom". Stretch is just for showing but distorts image!!
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(picture);
        }

        public void changeValue(int _value)
        {
            value = _value;
            number.Text = _value.ToString();
        }
    }
}
