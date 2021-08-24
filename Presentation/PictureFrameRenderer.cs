using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Presentation.Main
{
    public class PictureFrameRenderer
    {
        public PictureBox Render(string filepath)
        {
            Image image = Image.FromFile(filepath);

            return Render(image);
        }

        public PictureBox Render(Image image)
        {
            int imageWidth = image.Width;
            int imageHeight = image.Height;

            int frameWidth = imageWidth + 28;
            int frameHeight = imageHeight + 28;

            Bitmap frame = new Bitmap(frameWidth, frameHeight, PixelFormat.Format32bppArgb);

            RenderFrame(image, imageWidth, imageHeight, frame);
            return RenderImage(new Point(0, 0), new Size(frameWidth, frameHeight), frame);
        }

        private static void RenderFrame(Image image, int imageWidth, int imageHeight, Bitmap frame)
        {
            Image frame4 = Image.FromFile(@"res\frames\up-left.png");
            Image frame1 = Image.FromFile(@"res\frames\up-right.png");
            Image frame2 = Image.FromFile(@"res\frames\down-right.png");
            Image frame3 = Image.FromFile(@"res\frames\down-left.png");
            Image up = Image.FromFile(@"res\frames\up1.png");
            Image down = Image.FromFile(@"res\frames\down1.png");
            Image left = Image.FromFile(@"res\frames\left1.png");
            Image right = Image.FromFile(@"res\frames\right1.png");

            Graphics graphics = Graphics.FromImage(frame);

            graphics.DrawImage(image, 14, 14, imageWidth, imageHeight);

            graphics.DrawImage(frame4, 0, 0, 14, 14);
            graphics.DrawImage(frame1, imageWidth + 14, 0, 14, 14);
            graphics.DrawImage(frame2, imageWidth + 14, imageHeight + 14, 14, 14);
            graphics.DrawImage(frame3, 0, imageHeight + 14, 14, 14);

            for (int i = 0; i < imageWidth; i++)
            {
                graphics.DrawImage(up, 14 + i, 0);
                graphics.DrawImage(down, 14 + i, imageHeight + 14);
            }

            for (int i = 0; i < imageHeight; i++)
            {
                graphics.DrawImage(left, 0, 14 + i);
                graphics.DrawImage(right, imageWidth + 14, 14 + i);
            }
        }

        private PictureBox RenderImage(Point point, Size size, Image image)
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Location = point;
            pictureBox.Size = size;
            pictureBox.TabStop = false;
            pictureBox.SizeMode = PictureBoxSizeMode.Normal;
            pictureBox.Image = image;
            pictureBox.BorderStyle = BorderStyle.None;
            return pictureBox;
        }
    }
}
