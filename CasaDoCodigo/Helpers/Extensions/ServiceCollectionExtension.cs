using CasaDoCodigo.Data;
using CasaDoCodigo.Data.EfCore;
using CasaDoCodigo.Services.DataLoad;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace CasaDoCodigo.Helpers.Extensions
{
    public static class ServiceCollectionExtension
    {
        /// <summary>
        ///     Extension method responsible for grouping dependency injections.
        /// </summary>
        /// <param name="services">
        ///     Represents an instance of <see cref="IServiceCollection" />.
        /// </param>
        public static void InjectServices(this IServiceCollection services)
        {
            #region Data

            //DB Context 
            services.AddDbContext<ApplicationContext>();

            services.AddTransient<ICategoryDao, CategoryDao>();
            services.AddTransient<IProductDao, ProductDao>();

            #endregion

            #region Dependencies

            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            #endregion

            #region Services

            services.AddTransient<IDataLoadService, DataLoadService>();

            #endregion
        }
    }
}