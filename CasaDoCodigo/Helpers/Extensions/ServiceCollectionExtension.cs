using CasaDoCodigo.Data.EfCore;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace CasaDoCodigo.Helpers.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void InjectServices(this IServiceCollection services)
        {
            #region DBCONTEXT

            //DB Context 
            services.AddDbContext<ApplicationDbContext>();

            #endregion

            #region Dependencies

            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            #endregion
        }
    }
}