using System;
using SQLite.Net.Attributes;
using SQLiteNetExtensions.Attributes;

namespace RegistroActividadesDocentes.Models
{
    class AsignaturaEvaluada
    {
        [AutoIncrement, PrimaryKey]
        public int ID { get; set; }
        [NotNull, ForeignKey(typeof(Asignatura))]
        public int Asignatura { get; set; }
        [NotNull, ForeignKey(typeof(CursoLectivo))]
        public int CursoLectivo { get; set; }
    }
}
