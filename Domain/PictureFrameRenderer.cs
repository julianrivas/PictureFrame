using Domain.Frames;
using System.Drawing;
using System.Drawing.Imaging;

namespace Domain
{
    public class PictureFrameRenderer : IPictureFrameRenderer
    {
        public Image RenderImage(string filepath)
        {
            Image image = Image.FromFile(filepath);

            return RenderImage(image);
        }

        public Image RenderImage(Image image)
        {
            int imageWidth = image.Width;
            int imageHeight = image.Height;

            int frameWidth = imageWidth + 28;
            int frameHeight = imageHeight + 28;

            Bitmap frame = new Bitmap(frameWidth, frameHeight, PixelFormat.Format32bppArgb);

            RenderFrame(image, imageWidth, imageHeight, frame);
            return frame;
        }

        private static void RenderFrame(Image image, int imageWidth, int imageHeight, Bitmap frame)
        {
            DarkFrame darkFrame = new DarkFrame();

            Image frame4 = darkFrame.CornerFrame.UpLeftImage;
            Image frame1 = darkFrame.CornerFrame.UpRightImage;
            Image frame2 = darkFrame.CornerFrame.DownRightImage;
            Image frame3 = darkFrame.CornerFrame.DownLeftImage;
            Image up = darkFrame.BorderFrame.UpImage;
            Image down = darkFrame.BorderFrame.DownImage;
            Image left = darkFrame.BorderFrame.LeftImage;
            Image right = darkFrame.BorderFrame.RightImage;

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
    }
}
