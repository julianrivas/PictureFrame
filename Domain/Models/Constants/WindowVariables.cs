using Domain.Models.Enums;
using Domain.Models.Extensions;
using System;
using System.Linq;

namespace Domain.Models.Constants
{
    public static class WindowVariables
    {
        public static string[] WindowLevels => Enum
            .GetValues(typeof(WindowLevel))
            .Cast<WindowLevel>()
            .AsEnumerable()
            .Select(property => property.GetDescription()).ToArray();

    }
}
