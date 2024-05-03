using BusinessLogicalLayer.Interfaces;
using BusinessLogicalLayer.Services;
using DataAccessLayer.Context;
using DataAccessLayer.Interfaces.Repositories;
using DataAccessLayer.Repositories;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace WFPresentationLayer
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var serviceProvider = ConfigureServices();
            var dbContext = serviceProvider.GetService<EstacionamentoContext>();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FormEntradaSaidaVeiculos(serviceProvider));
        }

        static IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            services.AddAutoMapper(typeof(RegistroEstacionamentoMapper));
            services.AddMemoryCache();

            services.AddScoped(typeof(IUnitOfWork), typeof(UnitOfWork));
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped(typeof(IVeiculoRepository), typeof(VeiculoRepository));
            services.AddScoped(typeof(IRegistroEstacionamentoRepository), typeof(RegistroEstacionamentoRepository));
            services.AddScoped(typeof(IVigenciaPrecoRepository), typeof(VigenciaPrecoRepository));
            services.AddScoped(typeof(IRegistroEstacionamentoService), typeof(RegistroEstacionamentoService));
            services.AddScoped(typeof(IVigenciaPrecoService), typeof(VigenciaPrecoService));

            services.AddDbContext<EstacionamentoContext>(options => options.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\vtor_\OneDrive\Documentos\ParkingAppDatabase.mdf;Integrated Security=True;Connect Timeout=30"));

            return services.BuildServiceProvider();
        }
    }
}