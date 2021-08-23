using Presentation.Handlers;
using System.Windows.Forms;

namespace Presentation
{
    public partial class PictureFrame : Form 
    {
        public PictureFrame()
        {
            InitializeComponent();
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
