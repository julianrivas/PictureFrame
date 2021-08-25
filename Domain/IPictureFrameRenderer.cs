using System.Drawing;

namespace Domain
{
    public interface IPictureFrameRenderer
    {
        Image RenderImage(string filepath);
        Image RenderImage(Image image);
    }
}