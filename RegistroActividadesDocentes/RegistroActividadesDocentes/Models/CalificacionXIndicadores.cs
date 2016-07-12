using SQLite.Net.Attributes;
using SQLiteNetExtensions.Attributes;

namespace RegistroActividadesDocentes.Models
{
    public class CalificacionXIndicadores
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [NotNull, ForeignKey(typeof(Evaluacion))]
        public int Evaluacion { get; set; }
        [NotNull, ForeignKey(typeof(Indicadores))]
        public int Indicadores { get; set; }
    }
}
