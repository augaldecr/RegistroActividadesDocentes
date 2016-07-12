using SQLite.Net.Attributes;
using SQLiteNetExtensions.Attributes;

namespace RegistroActividadesDocentes.Models
{
    public class ComponentesPlanEval
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [NotNull, ForeignKey(typeof(PlanEvaluativo))]
        public int PlanEvaluativo { get; set; }
        [NotNull, ForeignKey(typeof(TipoEvaluacion))]
        public int TipoEvaluacion { get; set; }
        [NotNull]
        public int Cantidad { get; set; }
        [NotNull]
        public int PorcentajeAsignado { get; set; }
    }
}
