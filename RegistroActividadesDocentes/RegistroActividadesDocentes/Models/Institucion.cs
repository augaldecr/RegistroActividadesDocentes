using SQLite.Net.Attributes;
using SQLiteNetExtensions.Attributes;

namespace RegistroActividadesDocentes.Models
{
    //Referente a la institucion educativa
    public class Institucion
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [NotNull, ForeignKey(typeof(Circuito))]
        public int Circuito { get; set; }
        [NotNull]
        public string CodigoPresupuestario { get; set; }
        [NotNull]
        public string Nombre { get; set; }
        [NotNull, ForeignKey(typeof(ModalidadInstitucion))]
        public int Modalidad { get; set; }
        [NotNull, ForeignKey(typeof(Funcionario))]
        public int Director { get; set; }
        //[NotNull, ForeignKey(typeof(Distrito))]
        //public int Distrito { get; set; }
        public string Direccion { get; set; }
        public string EmailInstitucion { get; set; }
    }
}
