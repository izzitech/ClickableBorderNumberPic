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
        public int value = 13;
        public bool status = false;
        public int borderSize = 4;

        public ClickableBorderNumberPic()
        {
            InitializeComponent();

            Color statusColor = new Color();
            if (status)
            {
                statusColor = Color.Green;
            }
            else
            {
                statusColor = Color.Red;
            }

            this.BackColor = statusColor;

            Label number = new Label();
            // number.AutoSize = true;
            number.Width = 28;
            number.Height = 18;
            number.BackColor = statusColor;
            number.Text = value.ToString();
            number.TextAlign = ContentAlignment.MiddleCenter;
            this.Controls.Add(number);

            PictureBox picture = new PictureBox();
            picture.ImageLocation = @"D:\oto.jpg";
            
            Point pictureLocation = new Point();
            pictureLocation.X = this.Location.X + borderSize;
            pictureLocation.Y= this.Location.Y + borderSize;

            picture.Location = pictureLocation;
            picture.Width = this.Width - (2*borderSize);
            picture.Height = this.Height - (2*borderSize); 
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(picture);
            
        }
    }
}
