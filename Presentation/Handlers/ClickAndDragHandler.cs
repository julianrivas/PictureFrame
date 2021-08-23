using System.Drawing;
using System.Windows.Forms;

namespace Presentation.Handlers
{
    public static class ClickAndDragHandler
    {
        private static Point _lastPoint;
        public static int Left { get; private set; }
        public static int Top { get; private set; }

        public static void MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - _lastPoint.X;
                Top += e.Y - _lastPoint.Y;
            }
        }

        public static void MouseDown(object sender, MouseEventArgs e)
        {
            _lastPoint = new Point(e.X, e.Y);
        }
    }
}
