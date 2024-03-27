namespace PruebaTecnica.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombres { get; set; } = string.Empty;
        public string Apellidos { get; set; } = string.Empty;
        public DateTime? FechaNacimiento { get; set; } = null;
        public string CUIT { get; set; } = string.Empty;
        public string? Domicilio { get; set; }
        public string? TelefonoCelular { get; set; }
        public string Email { get; set; } = string.Empty;
    }
}
