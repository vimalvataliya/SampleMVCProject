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
    
    public partial class Inventory_Out
    {
        public int Transaction_ID { get; set; }
        public string Barcode { get; set; }
        public Nullable<System.DateTime> Transaction_Date { get; set; }
        public Nullable<int> Sub_Product_ID { get; set; }
        public Nullable<int> Out_Quantity { get; set; }
        public Nullable<int> Out_Reason_ID { get; set; }
        public Nullable<int> Branch_ID { get; set; }
        public string User_Created { get; set; }
        public Nullable<System.DateTime> Date_Created { get; set; }
    
        public virtual Branch Branch { get; set; }
        public virtual Inventory_Out_Reasons Inventory_Out_Reasons { get; set; }
        public virtual Sub_Products Sub_Products { get; set; }
    }
}
