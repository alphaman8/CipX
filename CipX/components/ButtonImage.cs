using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace CipX.components
{
    public partial class ButtonImage : System.Windows.Forms.Control
    {
        private Image image;
        //flag to indicate the pressed state
        private bool bPushed;
        private Bitmap m_bmpOffscreen;

        public Image Image
        {
            get { return image; }
            set { image = value; }
        }

        public ButtonImage(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            //Do nothing
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics gxOff;      //Offscreen graphics
            Rectangle imgRect; //image rectangle
            Brush backBrush;   //brush for filling a backcolor

            if (m_bmpOffscreen == null) //Bitmap for doublebuffering
            {
                m_bmpOffscreen = new Bitmap(ClientSize.Width, ClientSize.Height);
            }

            gxOff = Graphics.FromImage(m_bmpOffscreen);

            gxOff.Clear(this.BackColor);

            if (!bPushed)
                backBrush = new SolidBrush(Parent.BackColor);
            else //change the background when it's pressed
                backBrush = new SolidBrush(Color.LightGray);

            gxOff.FillRectangle(backBrush, this.ClientRectangle);

            if (image != null)
            {
                //Center the image relativelly to the control
                //int imageLeft = (this.Width - image.Width) / 2;
                int imageLeft = 0;
                int imageTop = (this.Height - image.Height) / 2;

                if (!bPushed)
                {
                    imgRect = new Rectangle(imageLeft, imageTop, image.Width,
            image.Height);
                }
                else //The button was pressed
                {
                    //Shift the image by one pixel
                    imgRect = new Rectangle(imageLeft + 1, imageTop + 1, image.Width,
                                                                     image.Height);
                }
                //Set transparent key
                ImageAttributes imageAttr = new ImageAttributes();
                imageAttr.SetColorKey(BackgroundImageColor(image),
                                                      BackgroundImageColor(image));
                //Draw image
                gxOff.DrawImage(image, imgRect, 0, 0, image.Width, image.Height,
                                                    GraphicsUnit.Pixel, imageAttr);
                //gxOff.DrawRectangle(new Pen(Color.Black), this.ClientRectangle);
                if (this.Text.Length > 0)
                {
                    gxOff.DrawString(this.Text,
                        new Font(FontFamily.GenericSansSerif, 7f, FontStyle.Bold),
                        new SolidBrush(Color.Black),
                        new Rectangle(this.Image.Width + 5, this.Image.Height / 2, this.Width - this.Image.Width, this.Height));
                }

            }

            if (bPushed) //The button was pressed
            {
                //Prepare rectangle
                Rectangle rc = this.ClientRectangle;
                rc.Width--;
                rc.Height--;
                //Draw rectangle
                gxOff.DrawRectangle(new Pen(Color.Black), rc);
            }

            //Draw from the memory bitmap
            e.Graphics.DrawImage(m_bmpOffscreen, 0, 0);
            base.OnPaint(e);
        }

        private Color BackgroundImageColor(Image image)
        {
            Bitmap bmp = new Bitmap(image);
            return bmp.GetPixel(0, 0);
        }


        protected override void OnMouseDown(System.Windows.Forms.MouseEventArgs e)
        {
            bPushed = true;
            this.Invalidate();
        }

        protected override void OnMouseUp(System.Windows.Forms.MouseEventArgs e)
        {
            bPushed = false;
            this.Invalidate();
        }
    }
}
