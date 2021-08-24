using Presentation.Handlers;
using System.Drawing;
using System.Windows.Forms;

namespace Presentation
{
    public partial class PictureFrame : Form 
    {
        private Point _lastPoint;

        public PictureFrame()
        {
            InitializeComponent();
        }

        private void PictureFrame_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - _lastPoint.X;
                Top += e.Y - _lastPoint.Y;
            }
        }

        private void PictureFrame_MouseDown(object sender, MouseEventArgs e)
        {
            _lastPoint = new Point(e.X, e.Y);
        }
    }
}
