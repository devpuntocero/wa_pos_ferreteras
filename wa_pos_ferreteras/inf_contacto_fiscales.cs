//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace wa_pos_ferreteras
{
    using System;
    using System.Collections.Generic;
    
    public partial class inf_contacto_fiscales
    {
        public System.Guid id_contacto_fiscales { get; set; }
        public string nombres { get; set; }
        public string a_paterno { get; set; }
        public string a_materno { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
        public Nullable<int> id_estatus { get; set; }
        public Nullable<System.DateTime> fecha_registro { get; set; }
        public System.Guid id_fiscales { get; set; }
    }
}