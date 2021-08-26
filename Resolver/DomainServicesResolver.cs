using Domain;
using Domain.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Presentation
{
    public static class DomainServicesResolver
    {
        public static void AddDomainServices(this ServiceCollection services)
        {
            services.AddScoped<IPictureFrameRenderer, PictureFrameRenderer>();
        }
    }
}
