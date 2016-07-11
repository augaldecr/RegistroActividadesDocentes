using SQLite.Net.Attributes;
using SQLiteNetExtensions.Attributes;

namespace RegistroDocente.Models
{
    public class Circuito
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [NotNull]
        public string Nombre { get; set; }
        [NotNull, ForeignKey(typeof(Regional))]
        public int Regional { get; set; }
    }
}
