using GestionDeEmpleados;

namespace LaBaratosa;

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
<<<<<<< HEAD
        Application.Run(new Login());
=======
        Application.Run(new ManageEmployees());
>>>>>>> 291a4ecacc3b08a5ae16a2e9a37bb8a33eb58b0a
    }
}