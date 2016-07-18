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
        [NotNull, MaxLength(2)]
        public string Grupo { get; set; }
        [MaxLength(1)]
        public string SubGrupo { get; set; }
        [ForeignKey(typeof(Funcionario))]
        public int ProfesorGuia { get; set; }
    }
}
