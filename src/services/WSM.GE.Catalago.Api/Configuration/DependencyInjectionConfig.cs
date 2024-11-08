using NSE.Catalogo.API.Models;
using WSM.GE.Catalago.Api.Data;
using WSM.GE.Catalago.Api.Data.Repository;

namespace WSM.GE.Catalago.Api.Configuration
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