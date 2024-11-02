using WSM.GE.Catalago.API.Data;
using WSM.GE.Catalago.API.Data.Repository;
using WSM.GE.Catalago.API.Models;

namespace WSM.GE.Catalago.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<CatalogoContext>();
        }
    }
}