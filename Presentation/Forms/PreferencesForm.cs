using Domain.Models.Constants;
using Domain.Models.Enums;
using Presentation.Settings;
using System;
using System.Windows.Forms;

namespace Presentation.Forms
{
    public partial class PreferencesForm : Form
    {
        private GlobalSettings _settings = new GlobalSettings();

        public PreferencesForm()
        {
            InitializeComponent();
            LoadGlobalSettings();
        }

        private void LoadGlobalSettings()
        {
            LoadImageSettings();
            LoadFrameSettings();
            LoadWindowsSettings();
        }

        private void LoadFrameSettings()
        {
            TextBox_Frame_PictureSize.Text = _settings.Frame_PictureSize.ToString();

            ComboBox_Frame_Appereance.Items.AddRange(FrameVariables.FrameAppereances);
            ComboBox_Frame_Appereance.SelectedIndex = (int)_settings.Frame_Appereance;

            ComboBox_Frame_ResizeFrom.Items.AddRange(FrameVariables.FrameResizeFromValues);
            ComboBox_Frame_ResizeFrom.SelectedIndex = (int)_settings.Frame_ResizeFrom;
        }

        private void TextBox_Frame_PictureSize_TextChanged(object sender, EventArgs e)
        {
            int pictureSize = string.IsNullOrEmpty(TextBox_Frame_PictureSize.Text) ? 0 : Int32.Parse(TextBox_Frame_PictureSize.Text);
            _settings.Frame_PictureSize = pictureSize;
        }

        private void ComboBox_Frame_Appereance_SelectedIndexChanged(object sender, EventArgs e)
        {
            _settings.Frame_Appereance = (FrameAppereance)ComboBox_Frame_Appereance.SelectedIndex;
        }

        private void ComboBox_Frame_ResizeFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            _settings.Frame_ResizeFrom = (FrameResizeFrom)ComboBox_Frame_ResizeFrom.SelectedIndex;
        }

        private void LoadImageSettings()
        {
            ComboBox_Image_PictureRepository.Items.AddRange(ImageVariables.PictureRepositories);
            ComboBox_Image_PictureRepository.SelectedIndex = (int)_settings.Image_PictureRepository;

            ComboBox_Image_PictureSort.Items.AddRange(ImageVariables.PictureSorts);
            ComboBox_Image_PictureSort.SelectedIndex = (int)_settings.Image_PictureSort;

            ComboBox_Image_PictureChange.Items.AddRange(ImageVariables.PictureChanges);
            ComboBox_Image_PictureChange.SelectedIndex = (int)_settings.Image_PictureChange;

            TextBox_Image_PictureFolder.Text = _settings.Image_PictureFolder;
            CheckBox_Image_EnclosedFolders.Checked = _settings.Image_EnclosedFolders;
        }

        private void ComboBox_Image_PictureRepository_SelectedIndexChanged(object sender, EventArgs e)
        {
            _settings.Image_PictureRepository = (PictureRepository)ComboBox_Image_PictureRepository.SelectedIndex;
        }

        private void ComboBox_Image_PictureSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            _settings.Image_PictureSort = (PictureSort)ComboBox_Image_PictureSort.SelectedIndex;
        }

        private void ComboBox_Image_PictureChange_SelectedIndexChanged(object sender, EventArgs e)
        {
            _settings.Image_PictureChange = (PictureChange)ComboBox_Image_PictureChange.SelectedIndex;
        }

        private void TextBox_Image_PictureFolder_TextChanged(object sender, EventArgs e)
        {
            _settings.Image_PictureFolder = TextBox_Image_PictureFolder.Text;
        }

        private void CheckBox_Image_EnclosedFolders_CheckedChanged(object sender, EventArgs e)
        {
            _settings.Image_EnclosedFolders = CheckBox_Image_EnclosedFolders.Checked;
        }

        private void LoadWindowsSettings()
        {
            ComboBox_Window_Level.Items.AddRange(WindowVariables.WindowLevels);
            ComboBox_Window_Level.SelectedIndex = (int)_settings.Window_Level;

            CheckBox_Window_IgnoreMouse.Checked = _settings.Window_IgnoreMouse;
            CheckBox_Window_PreventDragging.Checked = _settings.Window_PreventDragging;

            TrackBar_Window_Opacity.Value = _settings.Window_Opacity;
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            _settings.Save();
            Close();
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ComboBox_Window_Level_SelectedIndexChanged(object sender, EventArgs e)
        {
            _settings.Window_Level = (WindowLevel) ComboBox_Window_Level.SelectedIndex;
        }

        private void CheckBox_Window_IgnoreMouse_CheckedChanged(object sender, EventArgs e)
        {
            _settings.Window_IgnoreMouse = CheckBox_Window_IgnoreMouse.Checked;
        }

        private void CheckBox_Window_PreventDragging_CheckedChanged(object sender, EventArgs e)
        {
            _settings.Window_PreventDragging = CheckBox_Window_PreventDragging.Checked;
        }

        private void TrackBar_Window_Opacity_Scroll(object sender, EventArgs e)
        {
            _settings.Window_Opacity = TrackBar_Window_Opacity.Value;
        }

        private void Button_Image_SelectFolder_Click(object sender, EventArgs e)
        {
            if (FolderBrowserDialog_Image.ShowDialog() == DialogResult.OK)
                TextBox_Image_PictureFolder.Text = FolderBrowserDialog_Image.SelectedPath;
        }
    }


}
