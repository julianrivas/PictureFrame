using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace Presentation
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ServiceCollection services = new ServiceCollection();

            services.AddServices();

            using ServiceProvider serviceProvider = services.BuildServiceProvider();

            PictureFrame pictureFrame = serviceProvider.GetRequiredService<PictureFrame>();
            Application.Run(pictureFrame);
        }
    }
}
