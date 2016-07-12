using SQLite.Net.Attributes;

namespace RegistroActividadesDocentes.Models
{
    //Referente a los diferentes años calendario
    public class Anho
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [NotNull]
        public string Nombre { get; set; } 
    }
}
