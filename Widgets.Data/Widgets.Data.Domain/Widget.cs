//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Widgets.Data.Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class Widget
    {
        public int widgetID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool Discount { get; set; }
        public int StateID { get; set; }
        public int TaxID { get; set; }
        public bool Active { get; set; }
    
        public virtual State State { get; set; }
        public virtual Tax Tax { get; set; }
    }
}
