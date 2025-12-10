using BL.Mappings;
using BL.Services;
using BL.Services.PatientsService;
using BL.Services.ReportService;
using BL.Services.TestsService;
using DAL;
using DAL.Seeds;
using DAL.Repositories;
using DAL.Repositories.PatientsRepository;
using DAL.Repositories.ReportsRepository;
using DAL.Repositories.TestsRepository;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.Configuration;

namespace iMDSoft
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            ServiceProvider = ConfigureServices();

            using (var scope = ServiceProvider.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<DatabaseContext>();
                var created = db.Database.EnsureCreated();
                if (created)
                {
                    db.SeedDatabase();
                }
            }

            var mainForm = ServiceProvider.GetRequiredService<MainForm>();
            Application.Run(mainForm);
        }

        private static IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            services.AddDbContext<DatabaseContext>(options =>
                options.UseSqlServer(ConfigurationManager.ConnectionStrings["Imdsoft"].ConnectionString));

            services.AddAutoMapper(cfg =>
            {
                cfg.AddProfile<PatientProfile>();
                cfg.AddProfile<TestProfile>();
                cfg.AddProfile<ReportProfile>();
            });

            services.AddLogging(builder => builder.AddConsole());

            services.AddScoped<IValidator<BL.Models.Patient>, BL.Validators.PatientValidator>();
            services.AddScoped<IValidator<BL.Models.Test>, BL.Validators.TestValidator>();
            services.AddScoped<IValidator<BL.Models.ReportPeriod>, BL.Validators.ReportPeriodValidator>();

            services.AddScoped<IRepository<DAL.Entities.Patient>, PatientsRepository>();
            services.AddScoped<IRepository<DAL.Entities.Test>, TestsRepository>();
            services.AddScoped<IReportsRepository, ReportsRepository>();

            services.AddScoped<IBaseService<DAL.Entities.Patient, BL.Models.Patient, PatientsService>, PatientsService>();
            services.AddScoped<IBaseService<DAL.Entities.Test, BL.Models.Test, TestsService>, TestsService>();
            services.AddScoped<IReportsService, ReportsService>();

            services.AddTransient<MainForm>();
            services.AddTransient<PatientForm>();
            services.AddTransient<TestForm>();
            services.AddTransient<ReportDialog>();
            services.AddTransient<ReportForm>();

            return services.BuildServiceProvider();
        }
    }
}