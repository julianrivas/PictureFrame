using System;

namespace Presentation
{
    public static class DefaultDirectory
    {
        public static string CommonPictures => Environment.GetFolderPath(Environment.SpecialFolder.CommonPictures);
    }
}
