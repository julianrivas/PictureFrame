using Domain.Services.Interfaces;
using Presentation.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Threading;
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
                contextMenuStrip1.Show(this, new Point(e.X, e.Y));
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

        private void backgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {   
            // Do not access the form's BackgroundWorker reference directly.
            // Instead, use the reference provided by the sender parameter.
            BackgroundWorker bw = sender as BackgroundWorker;

            // Extract the argument.
            int arg = (int)e.Argument;

            // Start the time-consuming operation.
            e.Result = TimeConsumingOperation(bw, arg);

            // If the operation was canceled by the user,
            // set the DoWorkEventArgs.Cancel property to true.
            if (bw.CancellationPending)
            {
                e.Cancel = true;
            }

        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                // The user canceled the operation.
                MessageBox.Show("Operation was canceled");
            }
            else if (e.Error != null)
            {
                // There was an error during the operation.
                string msg = String.Format("An error occurred: {0}", e.Error.Message);
                MessageBox.Show(msg);
            }
            else
            {
                // The operation completed normally.
                string msg = String.Format("Result = {0}", e.Result);
                MessageBox.Show(msg);
            }
        }

        // This method models an operation that may take a long time
        // to run. It can be cancelled, it can raise an exception,
        // or it can exit normally and return a result. These outcomes
        // are chosen randomly.
        private int TimeConsumingOperation(
            BackgroundWorker bw,
            int sleepPeriod)
        {
            int result = 0;

            Random rand = new Random();

            while (!bw.CancellationPending)
            {
                bool exit = false;

                switch (rand.Next(3))
                {
                    // Raise an exception.
                    case 0:
                        {
                            throw new Exception("An error condition occurred.");
                            break;
                        }

                    // Sleep for the number of milliseconds
                    // specified by the sleepPeriod parameter.
                    case 1:
                        {
                            Thread.Sleep(sleepPeriod);
                            break;
                        }

                    // Exit and return normally.
                    case 2:
                        {
                            result = 23;
                            exit = true;
                            break;
                        }

                    default:
                        {
                            break;
                        }
                }

                if (exit)
                {
                    break;
                }
            }

            return result;
        }

    }
}
