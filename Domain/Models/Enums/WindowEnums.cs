using System.ComponentModel;

namespace Domain.Models.Enums
{
    public class WindowEnums { }

    public enum WindowLevel : byte
    {
        [Description("Normal")]
        Normal = 0,
        [Description("Keep on top of other windows")]
        KeepOnTopOfOtherWindows = 1,
        [Description("Keep bellow all other windows")]
        KeepBellowAllOtherWindows = 2
    }
}
