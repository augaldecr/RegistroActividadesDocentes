using SQLite.Net.Attributes;
using SQLiteNetExtensions.Attributes;
using System;

namespace RegistroActividadesDocentes.Models
{
    //Referente al período per se, por curso lectivo
    public class Periodo
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [NotNull]
        public string Nombre { get; set; }
        [NotNull, ForeignKey(typeof(CursoLectivo))]
        public int CursoLectivo { get; set; }
        [NotNull]
        public DateTime FechaInicio { get; set; }
        [NotNull]
        public DateTime FechaFin { get; set; }
    }
}
