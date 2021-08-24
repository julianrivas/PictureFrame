using Presentation.Handlers;
using Presentation.Main;
using Presentation.Properties;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Presentation
{
    public partial class PictureFrame : Form 
    {
        private PictureFrameRenderer _pictureFrameRenderer;

        private readonly List<Bitmap> images = new()
        {
            Resources.IMG_143949244608458,
            Resources.IMG_132060135311861,
            Resources.IMG_241369506629628,
            Resources.IMG_249997204594106,
            Resources.IMG_249595061164167,
            Resources.IMG_44353119378146,
            Resources.IMG_87564803925760,
            Resources.IMG_44243566241063
        };

        public PictureFrame()
        {
            InitializeComponent();
            _pictureFrameRenderer = new PictureFrameRenderer();
        }


        private void PictureFrame_MouseMove(object sender, MouseEventArgs e)
        {
            ClickAndDragHandler.MouseMove(sender, e);
            Left = ClickAndDragHandler.Left;
            Top = ClickAndDragHandler.Top;
        }

        private void PictureFrame_MouseDown(object sender, MouseEventArgs e)
        {
            ClickAndDragHandler.MouseDown(sender, e);
        }
    }
}
