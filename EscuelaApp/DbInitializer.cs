using EscuelaApp.Data;

namespace EscuelaApp
{
    public static class DbInitializer
    {
        public static void Initialize(EscuelaContext context)
        {
            context.Database.EnsureCreated();

            // Aquí puedes agregar código para inicializar datos, por ejemplo:
            if (!context.Estudiantes.Any())
            {
                // Agrega estudiantes de prueba aquí
            }
        }
    }
}
