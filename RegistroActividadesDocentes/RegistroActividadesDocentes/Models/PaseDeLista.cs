using System;
using SQLite.Net.Attributes;
using SQLiteNetExtensions.Attributes;

namespace RegistroActividadesDocentes.Models
{
    public class PaseDeLista
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [NotNull]
        public DateTime Fecha { get; set; }
        [NotNull, ForeignKey(typeof(Matricula))]
        public int Estudiante { get; set; }
        public string Observacion { get; set; }
    }
}
