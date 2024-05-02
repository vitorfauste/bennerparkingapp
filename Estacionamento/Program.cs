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
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FormEntradaSaidaVeiculos());
        }

        //static IServiceProvider ConfigureServices()
        //{
        //    var services = new ServiceCollection();

        //    services.AddAutoMapper(typeof(RegistroProfile));
        //    services.AddMemoryCache();

        //    // Dependency Injection
        //    services.AddScoped(typeof(IUnitOfWork), typeof(UnitOfWork));
        //    services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        //    services.AddScoped(typeof(ICarroRepository), typeof(CarroRepository));
        //    services.AddScoped(typeof(IRegistroRepository), typeof(RegistroRepository));
        //    services.AddScoped(typeof(IVigenciaPrecoRepository), typeof(VigenciaPrecoRepository));
        //    services.AddScoped(typeof(IRegistroAppService), typeof(RegistroAppService));
        //    services.AddScoped(typeof(IVigenciaAppService), typeof(VigenciaAppService));

        //    services.AddDbContext<DataContext>(options =>
        //options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=msdb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"));


        //    // Construir o provedor de serviços
        //    return services.BuildServiceProvider();
        //}
    }
}