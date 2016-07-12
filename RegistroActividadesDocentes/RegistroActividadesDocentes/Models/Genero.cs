using SQLite.Net.Attributes;

namespace RegistroActividadesDocentes.Models
{
    public class Genero
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [NotNull]
        public string Nombre { get; set; }
    }
}
