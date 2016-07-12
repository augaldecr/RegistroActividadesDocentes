using SQLite.Net.Attributes;

namespace RegistroActividadesDocentes.Models
{
    public class Pais
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [NotNull]
        public string Nombre { get; set; }
    }
}
