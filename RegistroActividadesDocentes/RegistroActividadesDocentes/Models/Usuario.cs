using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Attributes;
using SQLiteNetExtensions.Attributes;

namespace RegistroDocente.Models
{
    public class Usuario
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [NotNull]
        public string usuario { get; set; }
        [NotNull]
        public string password { get; set; }
        [NotNull, ForeignKey(typeof(Persona))]
        public int persona { get; set; }
        [NotNull, Default(value: false)]
        public bool defecto { get; set; }
    }
}
