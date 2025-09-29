using Tse_Forms.forms;
using static Tse_Backend.Infrastructure.Database;

namespace Tse_Forms;

internal static class Program
{
    /// <summary>
    ///     The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        load(); // Load the backend database at application startup
        Application.Run(new StartMenu());
    }
}