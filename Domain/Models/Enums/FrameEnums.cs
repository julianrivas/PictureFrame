using System.ComponentModel;

namespace Domain.Models.Enums
{
    public class FrameEnums { }

    public enum FrameAppereance : byte
    {
        [Description("Back Lacquer")]
        BackLacquer = 0,
        [Description("Light Wood")]
        LightWood = 1,
        [Description("Dark Wood")]
        DarkWood = 2,
        [Description("Simple Shadow")]
        SimpleShadow = 3,
        [Description("Inset")]
        Inset = 4,
        [Description("None")]
        None = 5,
    }

    public enum FrameResizeFrom : byte
    {
        [Description("Closest Corner")]
        ClosestCorner = 0,
        [Description("Top Left")]
        TopLeft = 1,
        [Description("Top Right")]
        TopRight = 2,
        [Description("Bottom Left")]
        BottomLeft = 3,
        [Description("Bottom Right")]
        BottomRight = 4
    }
}
