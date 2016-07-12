using SQLite.Net.Attributes;
using SQLiteNetExtensions.Attributes;

namespace RegistroActividadesDocentes.Models
{
    public class HorarioDocente
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [NotNull, ForeignKey(typeof(Asignatura))]
        public int Asignatura { get; set; }
        [NotNull, ForeignKey(typeof(Seccion))]
        public int Seccion { get; set; }
        [NotNull, ForeignKey(typeof(Dia))]
        public int Dia { get; set; }
        [NotNull]
        public int CantidadLecciones { get; set; }
    }
}
