//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Web_TMDT.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TShirt
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MainImg { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public decimal OriginalPrice { get; set; }
        public string SecondaryImg { get; set; }
        public Nullable<decimal> DiscountedPrice { get; set; }
    }
}