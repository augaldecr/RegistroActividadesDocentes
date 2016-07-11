using SQLite.Net.Attributes;

namespace RegistroDocente.Models
{
    public class Institucion
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [NotNull]
        public string CodigoPresupuestario { get; set; }
        [NotNull]
        public string Nombre { get; set; }
        public string Direccion { get; set; }
    }
}
