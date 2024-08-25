namespace EscuelaApp.Models
{
    public class Estudiante
    {
        public int ID { get; set; }
        public string Nombre { get; set; }  = string.Empty;
        public string Apellido { get; set; }  = string.Empty;
        public int Edad { get; set; }
        public string Correo { get; set; }  = string.Empty;
    }
}
