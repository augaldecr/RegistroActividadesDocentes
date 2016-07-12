using SQLite.Net.Attributes;
using SQLiteNetExtensions.Attributes;
using System;

namespace RegistroActividadesDocentes.Models
{
    public class Evaluacion
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [NotNull]
        public string Nombre { get; set; }
        [NotNull, ForeignKey(typeof(Periodo))]
        public int Periodo { get; set; }
        [NotNull, ForeignKey(typeof(TipoEvaluacion))]
        public int TipoEvaluacion { get; set; }
        [NotNull, ForeignKey(typeof(Matricula))]
        public int Estudiante { get; set; }
        [NotNull, ForeignKey(typeof(Seccion))]
        public int Seccion { get; set; }
        [NotNull]
        public DateTime FechaAplicacion { get; set; } 
        [NotNull]
        public decimal Porcentaje { get; set; }
        [NotNull]
        public decimal Puntos { get; set; }
        public decimal PuntajeObtenido { get; set; }
        public decimal Calificacion { get; set; }
        public string Observacion { get; set; }
    }
}
