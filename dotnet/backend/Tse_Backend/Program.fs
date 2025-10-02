open Microsoft.Extensions.DependencyInjection
open Tse_Backend.Application
open Tse_Backend.Application.Abstractions
open Tse_Backend.Infrastructure

// Helper to print results
let private printResult identifier result =
    match result with
    | Ok value -> printfn $"SUCCESS [%s{identifier}]: %A{value}"
    | Error msg -> printfn $"ERROR [%s{identifier}]: %s{msg}"

// --------------------------------------------------------------------------------------
// 2. CONFIGURE DEPENDENCY INJECTION
// --------------------------------------------------------------------------------------

let configureServices () =
    let services = ServiceCollection()
    // Register simple repositories using their static instance
    services.AddSingleton<ICourseRepository> CourseRepository.repository |> ignore

    services.AddSingleton<IPersonRepository> PersonRepository.repository |> ignore

    services.AddSingleton<ISchoolUnityRepository> SchoolUnityRepository.repository
    |> ignore

    services.AddSingleton<IUserRepository> UserRepository.repository |> ignore

    // Register the complex repository using a factory to inject its dependencies
    services.AddSingleton<IStudentRepository>(fun serviceProvider ->
        let personRepo = serviceProvider.GetRequiredService<IPersonRepository>()
        let courseRepo = serviceProvider.GetRequiredService<ICourseRepository>()
        let schoolUnityRepo = serviceProvider.GetRequiredService<ISchoolUnityRepository>()
        Tse_Backend.Infrastructure.StudentRepository.createRepository personRepo courseRepo schoolUnityRepo)
    |> ignore

    services.AddTransient<CourseService>() |> ignore
    services.AddTransient<PersonService>() |> ignore
    services.AddTransient<SchoolUnityService>() |> ignore
    services.AddTransient<StudentService>() |> ignore
    services.AddTransient<UserService>() |> ignore
    services.BuildServiceProvider()

// --------------------------------------------------------------------------------------
// 3. MAIN ENTRY POINT
// --------------------------------------------------------------------------------------

[<EntryPoint>]
let main argv =
    Database.load ()
    let serviceProvider = configureServices ()

    printfn "Application started. CLI argument parsing is currently disabled."
    // Add test code here to manually invoke services if needed, for example:
    let userService = serviceProvider.GetRequiredService<UserService>()
    printResult "User.GetAll" (userService.GetAll())

    0 // Success
