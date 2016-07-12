using SQLite.Net.Attributes;
using SQLiteNetExtensions.Attributes;

namespace RegistroActividadesDocentes.Models
{
    public class AdecuacionCurricular
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [NotNull, ForeignKey(typeof(Matricula))]
        public int Matricula { get; set; }
        [NotNull]
        public int IPeriodoFuncionamiento { get; set; }
        [NotNull]
        public int IIPeriodoFuncionamiento { get; set; }
        [NotNull]
        public int IIIPeriodoFuncionamiento { get; set; }

    }
}
 