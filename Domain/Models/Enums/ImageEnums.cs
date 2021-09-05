using System.ComponentModel;

namespace Domain.Models.Enums
{
    public class ImageEnums { }

    public enum PictureRepository : byte
    {
        [Description("Local Folder")]
        LocalFolder = 0,
        [Description("Flickr")]
        Flickr = 1,
        [Description("Imgurl")]
        Imgurl = 2
    }

    public enum PictureSort : byte
    {
        [Description("Random")]
        Random = 0,
        [Description("In Order")]
        InOrder = 1
    }

    public enum PictureChange : byte
    {
        [Description("Every Minute")]
        EveryMinute = 0,
        [Description("Every Five Minutes")]
        EveryFiveMinutes = 1,
        [Description("Every Fifteen Minutes")]
        EveryFifteenMinutes = 2,
        [Description("Every Half Hour")]
        EveryHalfHour = 3,
        [Description("Every Hour")]
        EveryHour = 4
    }
}
