using Domain.Services.Interfaces;
using Presentation.Properties;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Presentation.Forms
{
    public partial class PictureFrame : Form
    {
        private readonly IPictureFrameRenderer _pictureFrameRenderer;

        private int _indice;
        private bool _IsPlaying;
        private Point _lastPoint;
        private string[] _images;

        public PictureFrame(IPictureFrameRenderer pictureFrameRenderer)
        {
            _pictureFrameRenderer = pictureFrameRenderer;
            InitializeComponent();
            EnableControlPanel();
            GetDirectoryFilesPath();
            DrawImage(GenerateRandomImage());
        }


        private Bitmap GenerateRandomImage()
        {
            _indice = new Random().Next(0, _images.Length);

            return (Bitmap)Image.FromFile(_images[_indice]);
        }

        private void GetDirectoryFilesPath()
        {
            _images = Directory.GetFiles(@"C:\Images", "*.*", SearchOption.AllDirectories);
        }

        private void EnableControlPanel()
        {
            controlPanel.Location = new Point(20, 20);
            controlPanel.Visible = false;
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

            if (_indice >= _images.Length)
                _indice = 0;

            return (Bitmap)Image.FromFile(_images[_indice]);
        }

        private Bitmap GetPreviousImage()
        {
            _indice--;

            if (_indice < 0)
                _indice = _images.Length - 1;

            return (Bitmap)Image.FromFile(_images[_indice]);
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

        private void PictureFrame_Activated(object sender, EventArgs e)
        {
            controlPanel.Visible = true;
        }

        private void PictureFrame_Deactivate(object sender, EventArgs e)
        {
            controlPanel.Visible = false;
        }
        private void PictureFrame_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                ContextMenuStrip.Show(this, new Point(e.X, e.Y));
        }

        private void ToolStripMenuItem_Preferences_Click(object sender, EventArgs e)
        {
            PreferencesForm preferences = new();
            preferences.Show();
        }

        private void ToolStripMenuItem_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
