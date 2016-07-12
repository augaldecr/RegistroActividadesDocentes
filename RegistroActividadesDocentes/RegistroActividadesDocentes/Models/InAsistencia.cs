using System;
using SQLite.Net.Attributes;
using SQLiteNetExtensions.Attributes;

namespace RegistroActividadesDocentes.Models
{
    public class InAsistencia
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [NotNull, ForeignKey(typeof(Matricula))]
        public int Estudiante { get; set; }
        [NotNull]
        public DateTime Fecha { get; set; }
        [NotNull, ForeignKey(typeof(TipoInAsistencia))]
        public int Tipo { get; set; }
        [NotNull]
        public int Cantidad { get; set; }
    }
}
