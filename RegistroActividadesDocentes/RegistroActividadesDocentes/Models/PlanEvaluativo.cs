using SQLite.Net.Attributes;
using SQLiteNetExtensions.Attributes;

namespace RegistroActividadesDocentes.Models
{
    public class PlanEvaluativo
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [NotNull, ForeignKey(typeof(Periodo))]
        public int Periodo { get; set; }
        [NotNull, ForeignKey(typeof(Seccion))]
        public int Seccion { get; set; }
        [NotNull, ForeignKey(typeof(TipoPeriodicidadAsignatura))]
        public int TipoPeriodicidadAsignatura { get; set; }
        [NotNull]
        public int CantidadLecciones { get; set; }
    }
}
