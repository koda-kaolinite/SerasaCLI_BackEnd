using Microsoft.Extensions.DependencyInjection;
using Tse_Backend.Application;
using Tse_Backend.Infrastructure;

namespace Tse_Forms;

public static class DI
{
    static DI()
    {
        var services = new ServiceCollection();
        ConfigureServices(services);
        ServiceProvider = services.BuildServiceProvider();
    }

    public static IServiceProvider ServiceProvider { get; private set; }

    private static void ConfigureServices(IServiceCollection services)
    {
        // Register simple repositories using their static instance
        services.AddSingleton<Abstractions.ICourseRepository>(CourseRepository.repository);
        services.AddSingleton<Abstractions.IPersonRepository>(PersonRepository.repository);
        services.AddSingleton<Abstractions.ISchoolUnityRepository>(SchoolUnityRepository.repository);

        // Register the complex repository using a factory to inject its dependencies
        services.AddSingleton<Abstractions.IStudentRepository>(serviceProvider =>
        {
            var personRepo =
                serviceProvider.GetRequiredService<Abstractions.IPersonRepository>();
            var courseRepo =
                serviceProvider.GetRequiredService<Abstractions.ICourseRepository>();
            var schoolUnityRepo = serviceProvider
                .GetRequiredService<Abstractions.ISchoolUnityRepository>();
            return StudentRepository.createRepository(personRepo, courseRepo,
                schoolUnityRepo);
        });

        // Register application services
        services.AddTransient<PersonService>();
        services.AddTransient<SchoolUnityService>();
        services.AddTransient<StudentService>();

        // Register FontService as a singleton
        services.AddSingleton<FontService>();
    }
}