using Domain.Models.Enums;
using Domain.Models.Extensions;
using System;
using System.Linq;

namespace Domain.Models.Constants
{
    public static class FrameVariables
    {
        public static string[] FrameAppereances => Enum
            .GetValues(typeof(FrameAppereance))
            .Cast<FrameAppereance>()
            .AsEnumerable()
            .Select(property => property.GetDescription()).ToArray();

        public static string[] FrameResizeFromValues => Enum
            .GetValues(typeof(FrameResizeFrom))
            .Cast<FrameResizeFrom>()
            .AsEnumerable()
            .Select(property => property.GetDescription()).ToArray();
    }
}
