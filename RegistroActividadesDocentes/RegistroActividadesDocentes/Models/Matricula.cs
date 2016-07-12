using SQLite.Net.Attributes;
using SQLiteNetExtensions.Attributes;
using System;

namespace RegistroActividadesDocentes.Models
{
    public class Matricula
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [NotNull, ForeignKey(typeof(CursoLectivo))]
        public string CursoLectivo { get; set; }
        [NotNull, ForeignKey(typeof(Persona))]
        public int Estudiante { get; set; }
        [NotNull, ForeignKey(typeof(Asignatura))]
        public int Asignatura { get; set; }
        [NotNull, ForeignKey(typeof(Seccion))]
        public int Seccion { get; set; }
        [NotNull, ForeignKey(typeof(TipoMatricula))]
        public int TipoMatricula { get; set; }
        public int TipoSalida { get; set; }
        [NotNull]
        public DateTime modificado { get; set; }
    }
}
