﻿using SQLite.Net.Attributes;

namespace RegistroActividadesDocentes.Models
{
    public class TipoPeriodo
    { 
        //Referente al nombre de los diferentes períodos (Primer período, Segundo período, etc.)
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [NotNull]
        public string Nombre { get; set; }
    }
}
