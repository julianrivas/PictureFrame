
namespace Presentation
{
    partial class PictureFrame
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.previousButton = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Label();
            this.playPauseButton = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.controlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(800, 450);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.Color.Transparent;
            this.controlPanel.Controls.Add(this.previousButton);
            this.controlPanel.Controls.Add(this.nextButton);
            this.controlPanel.Controls.Add(this.playPauseButton);
            this.controlPanel.Location = new System.Drawing.Point(32, 32);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(54, 20);
            this.controlPanel.TabIndex = 12;
            // 
            // previousButton
            // 
            this.previousButton.AutoSize = true;
            this.previousButton.BackColor = System.Drawing.Color.Transparent;
            this.previousButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.previousButton.Image = global::Presentation.Properties.Resources.previous_black;
            this.previousButton.Location = new System.Drawing.Point(2, 2);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(10, 15);
            this.previousButton.TabIndex = 8;
            this.previousButton.Text = " ";
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.AutoSize = true;
            this.nextButton.BackColor = System.Drawing.Color.Transparent;
            this.nextButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextButton.Image = global::Presentation.Properties.Resources.next_black;
            this.nextButton.Location = new System.Drawing.Point(42, 2);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(10, 15);
            this.nextButton.TabIndex = 10;
            this.nextButton.Text = " ";
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // playPauseButton
            // 
            this.playPauseButton.AutoSize = true;
            this.playPauseButton.BackColor = System.Drawing.Color.Transparent;
            this.playPauseButton.Image = global::Presentation.Properties.Resources.pause_black;
            this.playPauseButton.Location = new System.Drawing.Point(22, 2);
            this.playPauseButton.Name = "playPauseButton";
            this.playPauseButton.Size = new System.Drawing.Size(10, 15);
            this.playPauseButton.TabIndex = 9;
            this.playPauseButton.Text = " ";
            this.playPauseButton.Click += new System.EventHandler(this.playPauseButton_Click);
            // 
            // PictureFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PictureFrame";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Label previousButton;
        private System.Windows.Forms.Label nextButton;
        private System.Windows.Forms.Label playPauseButton;
    }
}

