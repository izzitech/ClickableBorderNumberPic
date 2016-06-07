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
        public int id = 1;
        public bool status = false;
        public int borderSize = 2;
        public string imagePath = @".\testing\gato.jpg";
        public int formWidth = 200;
        public int formHeight = 130;

        Label numberShown = new Label();
        Color statusColor = new Color();
        PictureBox picture = new PictureBox();
        Point pictureLocation = new Point();

        public ClickableBorderNumberPic()
        {
            InitializeComponent();
            formWidth = this.Width;
            formHeight = this.Height;
            this.Click += picOnClick;
        }

        public void Create()
        {
            statusColor = status ? Color.Green : Color.Red;
            this.BackColor = statusColor;

            if (this.Width != formWidth) this.Width = formWidth;
            if (this.Height != formHeight) this.Height = formHeight;

            // number.AutoSize = true;
            numberShown.Width = 28;
            numberShown.Height = 18;
            numberShown.BackColor = statusColor;
            numberShown.Text = id.ToString();
            numberShown.TextAlign = ContentAlignment.MiddleCenter;
            this.Controls.Add(numberShown);

            picture.ImageLocation = imagePath;
            pictureLocation.X = this.Location.X + borderSize;
            pictureLocation.Y = this.Location.Y + borderSize;
            picture.Location = pictureLocation;
            picture.Width = this.Width - (6 + (2 * borderSize));
            picture.Height = this.Height - (6 + (2 * borderSize));
            // TODO: Change to "zoom". Stretch is just for showing but distorts image!!
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
            picture.MouseDown += picOnClick;
            this.Controls.Add(picture);
        }
    
        public void picOnClick(object sender, EventArgs e)
        {
            changeStatus(!status);
        }

        public void changeID(int _ID)
        {
            id = _ID;
            numberShown.Text = _ID.ToString();
        }

        public void changeStatus(bool _status)
        {
            status = _status;
            statusColor = status ? Color.Green : Color.Red;
            this.BackColor = statusColor;
            numberShown.BackColor = statusColor;
        }
    }
}
