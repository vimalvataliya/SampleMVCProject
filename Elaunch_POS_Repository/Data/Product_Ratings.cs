//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Elaunch_POS_Repository.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product_Ratings
    {
        public int Rating_ID { get; set; }
        public Nullable<int> Detail_ID { get; set; }
        public Nullable<int> Taste_Eval { get; set; }
        public Nullable<int> Shape_Eval { get; set; }
        public Nullable<int> Price_Eval { get; set; }
        public Nullable<System.DateTime> Rating_Datetime { get; set; }
    
        public virtual Invoice_Details Invoice_Details { get; set; }
    }
}
