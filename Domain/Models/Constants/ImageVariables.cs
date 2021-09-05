using Domain.Models.Enums;
using Domain.Models.Extensions;
using System;
using System.Linq;

namespace Domain.Models.Constants
{
    public static class ImageVariables
    {
        public static string[] PictureRepositories => Enum
            .GetValues(typeof(PictureRepository))
            .Cast<PictureRepository>()
            .AsEnumerable()
            .Select(property => property.GetDescription()).ToArray();

        public static string[] PictureSorts => Enum
            .GetValues(typeof(PictureSort))
            .Cast<PictureSort>()
            .AsEnumerable()
            .Select(property => property.GetDescription()).ToArray();

        public static string[] PictureChanges => Enum
            .GetValues(typeof(PictureChange))
            .Cast<PictureChange>()
            .AsEnumerable()
            .Select(property => property.GetDescription()).ToArray();
    }
}
