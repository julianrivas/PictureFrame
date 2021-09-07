using Domain.Models.Enums;
using System.Configuration;

namespace Presentation.Settings
{
    public class GlobalSettings : ApplicationSettingsBase
    {
        [UserScopedSetting()]
        [DefaultSettingValue("0")]
        public PictureRepository Image_PictureRepository
        {
            get => (PictureRepository) this["Image_PictureRepository"];
            set => this["Image_PictureRepository"] = value;
        }

        [UserScopedSetting()]
        [DefaultSettingValue("0")]
        public PictureSort Image_PictureSort
        {
            get => (PictureSort) this["Image_PictureSort"];
            set => this["Image_PictureSort"] = value;
        }

        [UserScopedSetting()]
        [DefaultSettingValue("0")]
        public PictureChange Image_PictureChange
        {
            get => (PictureChange) this["Image_PictureChange"];
            set => this["Image_PictureChange"] = value;
        }

        [UserScopedSetting()]
        [DefaultSettingValue("")]
        public string Image_PictureFolder
        { 
            get => (string) this["Image_PictureFolder"];
            set => this["Image_PictureFolder"] = value;
        }

        [UserScopedSetting()]
        [DefaultSettingValue("false")]
        public bool Image_EnclosedFolders
        {
            get => (bool) this["Image_EnclosedFolders"];
            set => this["Image_EnclosedFolders"] = value;
        }

        [UserScopedSetting()]
        [DefaultSettingValue("100")]
        public int Frame_PictureSize
        {
            get => (int) this["Frame_PictureSize"];
            set => this["Frame_PictureSize"] = value;
        }

        [UserScopedSetting()]
        [DefaultSettingValue("0")]
        public FrameAppereance Frame_Appereance
        {
            get => (FrameAppereance) this["Frame_Appereance"];
            set => this["Frame_Appereance"] = value;
        }

        [UserScopedSetting()]
        [DefaultSettingValue("0")]
        public FrameResizeFrom Frame_ResizeFrom
        {
            get => (FrameResizeFrom) this["Frame_ResizeFrom"];
            set => this["Frame_ResizeFrom"] = value;
        }

        [UserScopedSetting()]
        [DefaultSettingValue("0")]
        public WindowLevel Window_Level
        {
            get => (WindowLevel)this["Window_Level"];
            set => this["Window_Level"] = value;
        }

        [UserScopedSetting()]
        [DefaultSettingValue("false")]
        public bool Window_IgnoreMouse
        {
            get => (bool) this["Window_IgnoreMouse"];
            set => this["Window_IgnoreMouse"] = value;
        }

        [UserScopedSetting()]
        [DefaultSettingValue("false")]
        public bool Window_PreventDragging
        {
            get => (bool) this["Window_PreventDragging"];
            set => this["Window_PreventDragging"] = value;
        }

        [UserScopedSetting()]
        [DefaultSettingValue("10")]
        public int Window_Opacity
        {
            get => (int) this["Window_Opacity"];
            set => this["Window_Opacity"] = value;
        }
    }
}
