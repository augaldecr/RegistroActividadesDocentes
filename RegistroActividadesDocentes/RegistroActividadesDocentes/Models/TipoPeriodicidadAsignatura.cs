﻿using SQLite.Net.Attributes;
namespace RegistroActividadesDocentes.Models
{
    //Referente a la cantidad de periodos en los que se imparte una asignatura
    // (Semestral, Unisemestral, Trimestral, etc.)
    public class TipoPeriodicidadAsignatura
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [NotNull]
        public string Nombre { get; set; }
    }
}
