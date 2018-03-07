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
    
    public partial class Invoice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Invoice()
        {
            this.Invoice_Details = new HashSet<Invoice_Details>();
            this.Refunds = new HashSet<Refund>();
        }
    
        public int Invoice_ID { get; set; }
        public string Invoice_No { get; set; }
        public Nullable<int> Numeric_Invoice_No { get; set; }
        public Nullable<System.DateTime> Invoice_Date { get; set; }
        public Nullable<int> Management_Discount_ID { get; set; }
        public Nullable<decimal> Total_Sales { get; set; }
        public Nullable<decimal> Total_Tax { get; set; }
        public Nullable<decimal> Total_Products_Discount { get; set; }
        public Nullable<decimal> Total_Management_Discount { get; set; }
        public Nullable<decimal> Cash { get; set; }
        public Nullable<decimal> SPAN { get; set; }
        public Nullable<decimal> Credit_Card { get; set; }
        public Nullable<int> Branch_ID { get; set; }
        public Nullable<int> Cashier_ID { get; set; }
        public string QR_Code { get; set; }
        public Nullable<decimal> Net_Sales { get; set; }
        public Nullable<System.DateTime> Date_Created { get; set; }
    
        public virtual Branch Branch { get; set; }
        public virtual Cashier Cashier { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Invoice_Details> Invoice_Details { get; set; }
        public virtual Management_Discounts Management_Discounts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Refund> Refunds { get; set; }
    }
}
