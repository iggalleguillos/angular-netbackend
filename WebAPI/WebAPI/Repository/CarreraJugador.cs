//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAPI.Repository
{
    using System;
    using System.Collections.Generic;
    
    public partial class CarreraJugador
    {
        public int Id { get; set; }
        public int Jugador { get; set; }
        public int Carrera { get; set; }
        public int CaballoApostado { get; set; }
        public decimal CantidadApostada { get; set; }
    
        public virtual Caballos Caballos { get; set; }
        public virtual Carreras Carreras { get; set; }
        public virtual Jugadores Jugadores { get; set; }
    }
}