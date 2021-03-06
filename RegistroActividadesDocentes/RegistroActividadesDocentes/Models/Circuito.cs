using SQLite.Net.Attributes;
using SQLiteNetExtensions.Attributes;

namespace RegistroActividadesDocentes.Models
{
    //Referente al circuito educativo, perteneciente a la dirección regional
    public class Circuito
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [NotNull]
        public string Nombre { get; set; }
        [NotNull, ForeignKey(typeof(Regional))]
        public int Regional { get; set; }
        public string supervisor { get; set; }
    }
}
