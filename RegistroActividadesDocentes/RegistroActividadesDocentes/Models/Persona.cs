using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Attributes;

namespace RegistroDocente.Models
{
    public class Persona
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [Unique, NotNull]
        public string Cedula { get; set; }
        [NotNull]
        public string Nombre { get; set; }
        [NotNull]
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        [NotNull]
        public DateTime FechaNacimiento { get; set; }
        [NotNull]
        public string Email { get; set; }
        public string Celular { get; set; }
        public string Telefono { get; set; }
    }
}
