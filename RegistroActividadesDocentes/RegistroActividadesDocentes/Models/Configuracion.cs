using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Attributes;

namespace RegistroActividadesDocentes.Models
{
    public class Configuracion
    {
        [NotNull, Default(value:false)]
        public bool Listo { get; set; }
        [NotNull,Default(value:false)]
        public bool DatosBasicos { get; set; }
    }
}
