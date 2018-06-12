using AccessFacade.Business;
using AccessFacade.Configuration;
using AccessFacade.Dal.Repository.Abstraction;
using AccessFacade.Dal.Repository.Implementation;
using System;


namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServicesExtension
    {
        public static IServiceCollection AddModuleAccessFacade(this IServiceCollection services, Action<AccessFacadeOptions> setupAction)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }
            if (setupAction == null)
            {
                throw new ArgumentNullException(nameof(setupAction));
            }



            //string connectionString = @"Server=DESKTOP-LCV6O88\SQLEXPRESS;Database=AlzaLegoDatabase;User Id=sa;Password=master";
            //services.AddDbContext<EFLocalizationDbContext>(options => options.UseSqlServer(connectionString));




            //registruje nastaveni modulu
            services.Configure(setupAction);

            //connectionString si vezme sam DbContext z IOptions<>

            //REPOSITORY
            services.AddScoped<IDapperSyncRepository, DapperSyncRepository>();
            services.AddScoped<ITestRepository, TestRepository>();


            //SERVICES - zapouzdreni vsechn repositories pod jeden objekt
            //Tyto services pak budou pouzivat ostatni tridy/objetky
            services.AddScoped<AccessFacadeService, AccessFacadeService>();
            services.AddScoped<DapperService, DapperService>();


            return services;
        }
    }
}
