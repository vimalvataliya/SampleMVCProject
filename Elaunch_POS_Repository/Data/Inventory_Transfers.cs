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
    
    public partial class Inventory_Transfers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Inventory_Transfers()
        {
            this.Inventory_Transfer_Items = new HashSet<Inventory_Transfer_Items>();
        }
    
        public int Transafer_ID { get; set; }
        public Nullable<int> From_Branch_ID { get; set; }
        public Nullable<int> To_Branch_ID { get; set; }
        public Nullable<System.DateTime> Transfer_Date { get; set; }
        public string Remarks { get; set; }
        public string User_Created { get; set; }
        public Nullable<System.DateTime> Date_Created { get; set; }
        public string Transfer_No { get; set; }
    
        public virtual Branch Branch { get; set; }
        public virtual Branch Branch1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Inventory_Transfer_Items> Inventory_Transfer_Items { get; set; }
    }
}
