using Domain;
using Presentation.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Presentation
{
    public partial class PictureFrame : Form
    {
        private readonly IPictureFrameRenderer _pictureFrameRenderer;

        private int _indice;
        private bool _IsPlaying;
        private Point _lastPoint;

        public PictureFrame(IPictureFrameRenderer pictureFrameRenderer)
        {
            _pictureFrameRenderer = pictureFrameRenderer;
            InitializeComponent();
            EnableControlPanel();
            DrawImage(GenerateRandomImage());
        }

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

        private Bitmap GenerateRandomImage()
        {
            Random random = new Random();

            _indice = random.Next(0, 7);

            Bitmap image = images[_indice];
            return image;
        }

        private void EnableControlPanel()
        {
            controlPanel.Location = new Point(20, 20);
            //controlPanel.BackColor = Color.Transparent;
            controlPanel.Visible = true;
            _IsPlaying = true;
        }

        private void DrawImage(Bitmap bitmap)
        {
            Image image = _pictureFrameRenderer.RenderImage(bitmap);

            pictureBox.Controls.Clear();
            pictureBox.Image = image;
            Size = pictureBox.Size = image.Size;
        }

        private Bitmap GetNextImage()
        {
            _indice++;

            if (_indice >= images.Count)
                _indice = 0;

            return images[_indice];
        }

        private Bitmap GetPreviousImage()
        {
            _indice--;

            if (_indice < 0)
                _indice = images.Count - 1;

            return images[_indice];
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - _lastPoint.X;
                Top += e.Y - _lastPoint.Y;
            }
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            _lastPoint = new Point(e.X, e.Y);
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            Bitmap image = GetPreviousImage();
            DrawImage(image);
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            Bitmap image = GetNextImage();
            DrawImage(image);
        }

        private void playPauseButton_Click(object sender, EventArgs e)
        {
            if (_IsPlaying)
                playPauseButton.Image = Resources.pause_black;
            else
                playPauseButton.Image = Resources.play_black;

            _IsPlaying = !_IsPlaying;
        }
    }
}
