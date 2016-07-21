using SQLite.Net.Attributes;

namespace RegistroActividadesDocentes.Models
{
    class Especialidad
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [NotNull]
        public string Nombre { get; set; }
    }
}
