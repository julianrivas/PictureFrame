using Microsoft.Extensions.DependencyInjection;
using Presentation.Forms;

namespace Presentation
{
    public static class FormsResolver
    {
        public static void AddResolverServices(this ServiceCollection services)
        {
            services.AddScoped<PictureFrame>();
        }
    }
}
