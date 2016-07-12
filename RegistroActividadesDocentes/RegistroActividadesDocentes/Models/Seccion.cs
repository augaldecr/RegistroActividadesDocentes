using SQLite.Net.Attributes;
using SQLiteNetExtensions.Attributes;

namespace RegistroActividadesDocentes.Models
{
    public class Seccion
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [NotNull, ForeignKey(typeof(Nivel))]
        public int Nivel { get; set; }
        [NotNull]
        public string Grupo { get; set; }
        public char SubGrupo { get; set; }
        [ForeignKey(typeof(Funcionario))]
        public int ProfesorGuia { get; set; }
    }
}
