//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LINQ_Exercise
{
    using System;
    using System.Collections.Generic;
    
    public partial class Movy
    {
        public short VideoCode { get; set; }
        public string MovieTitle { get; set; }
        public string MovieType { get; set; }
        public string Rating { get; set; }
        public Nullable<float> RentalPrice { get; set; }
        public string ProducerID { get; set; }
        public string Director { get; set; }
        public string Media { get; set; }
        public Nullable<short> TotalStock { get; set; }
        public Nullable<short> NumberRented { get; set; }
    
        public virtual Producer Producer { get; set; }
    }
}
