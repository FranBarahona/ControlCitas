//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Expendiente.conn
{
    using System;
    using System.Collections.Generic;
    
    public partial class detalle_cita
    {
        public int id { get; set; }
        public Nullable<int> id_cita { get; set; }
        public string peso { get; set; }
        public string temperatura { get; set; }
        public string diagnostico { get; set; }
        public string recetas { get; set; }
    
        public virtual citas citas { get; set; }
    }
}
