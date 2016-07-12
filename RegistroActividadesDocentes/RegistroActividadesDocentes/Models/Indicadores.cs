using SQLite.Net.Attributes;

namespace RegistroActividadesDocentes.Models
{
    public class Indicadores
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [NotNull]
        public string NombreIndicadores { get; set; }
    }
}
