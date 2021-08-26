using System.Drawing;

namespace Domain.Services.Interfaces
{
    public interface IPictureFrameRenderer
    {
        Image RenderImage(string filepath);
        Image RenderImage(Image image);
    }
}