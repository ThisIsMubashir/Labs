//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EDM_CRUD
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProducerWebSite
    {
        public string ProducerID { get; set; }
        public string Website { get; set; }
    
        public virtual Producer Producer { get; set; }
    }
}
