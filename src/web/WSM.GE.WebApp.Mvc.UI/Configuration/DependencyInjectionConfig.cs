using WSM.GE.WebApp.Mvc.UI.Extensions;
using WSM.GE.WebApp.Mvc.UI.Services;

namespace WSM.GE.WebApp.Mvc.UI.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddHttpClient<IAutenticacaoService, AutenticacaoService>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IUser, AspNetUser>();
        }
    }
}