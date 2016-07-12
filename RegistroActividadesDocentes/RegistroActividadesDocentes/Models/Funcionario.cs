using SQLite.Net.Attributes;
using SQLiteNetExtensions.Attributes;

namespace RegistroActividadesDocentes.Models
{
    //Referente al funcionario del MEP
    public class Funcionario
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [NotNull, ForeignKey(typeof(Persona))]
        public int Persona { get; set; }
        [NotNull, ForeignKey(typeof(Puesto))]
        public int Puesto { get; set; }
        [ForeignKey(typeof(CategoriaDocente))]
        public int CategoriaDocente { get; set; }
    }
}
