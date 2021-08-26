using Domain.Frames;
using Domain.Services.Interfaces;
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

            Image ULCorner = darkFrame.CornerFrame.UpLeftImage;
            Image URCorner = darkFrame.CornerFrame.UpRightImage;
            Image DLCorner = darkFrame.CornerFrame.DownLeftImage;
            Image DRCorner = darkFrame.CornerFrame.DownRightImage;

            Image USide = darkFrame.BorderFrame.UpImage;
            Image DSide = darkFrame.BorderFrame.DownImage;
            Image LSide = darkFrame.BorderFrame.LeftImage;
            Image RSide = darkFrame.BorderFrame.RightImage;

            Graphics graphics = Graphics.FromImage(frame);

            graphics.DrawImage(image, 14, 14, imageWidth, imageHeight);

            graphics.DrawImage(ULCorner, 0, 0, 14, 14);
            graphics.DrawImage(URCorner, imageWidth + 14, 0, 14, 14);
            graphics.DrawImage(DLCorner, 0, imageHeight + 14, 14, 14);
            graphics.DrawImage(DRCorner, imageWidth + 14, imageHeight + 14, 14, 14);

            for (int i = 0; i < imageWidth; i++)
            {
                graphics.DrawImage(USide, 14 + i, 0);
                graphics.DrawImage(DSide, 14 + i, imageHeight + 14);
            }

            for (int i = 0; i < imageHeight; i++)
            {
                graphics.DrawImage(LSide, 0, 14 + i);
                graphics.DrawImage(RSide, imageWidth + 14, 14 + i);
            }
        }
    }
}
