//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data.Taller
{
    using System;
    using System.Collections.Generic;
    
    public partial class AUTO
    {
        public int id { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public string patente { get; set; }
        public Nullable<int> año { get; set; }
        public string color { get; set; }
        public string nChasis { get; set; }
        public string titularNombre { get; set; }
        public string titularApellido { get; set; }
        public string celular { get; set; }
        public Nullable<int> km { get; set; }
        public string problema { get; set; }
        public string solucion { get; set; }
        public Nullable<int> idTecnico { get; set; }
        public Nullable<int> idEstado { get; set; }
    
        public virtual ESTADO ESTADO { get; set; }
        public virtual TECNICO TECNICO { get; set; }
    }
}
