using SQLite.Net.Attributes;
using SQLiteNetExtensions.Attributes;

namespace RegistroActividadesDocentes.Models
{
    public class IndicadorAplicado
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [NotNull, ForeignKey(typeof(CalificacionXIndicadores))]
        public int CalificacionAplicada { get; set; }
        [NotNull, ForeignKey(typeof(Indicador))]
        public int Indicador { get; set; }
        [NotNull]
        public int PuntajeAsignado { get; set; }
        [NotNull]
        public int PuntajeObtenido { get; set; }
    }
}
