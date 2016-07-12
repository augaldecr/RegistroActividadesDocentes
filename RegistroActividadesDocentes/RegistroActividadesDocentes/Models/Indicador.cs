using SQLite.Net.Attributes;
using SQLiteNetExtensions.Attributes;

namespace RegistroActividadesDocentes.Models
{
    public class Indicador
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [NotNull]
        public string Nombre { get; set; }
        [NotNull, ForeignKey(typeof(Indicadores))]
        public int Indicadores { get; set; }
    }
}
