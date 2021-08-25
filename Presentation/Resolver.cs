using Domain;
using Microsoft.Extensions.DependencyInjection;

namespace Presentation
{
    public static class Resolver
    {
        public static void AddServices(this ServiceCollection services)
        {
            services.AddScoped<PictureFrame>();
            services.AddScoped<IPictureFrameRenderer, PictureFrameRenderer>();
        }
    }
}
