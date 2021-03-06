//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RMS.DA
{
    using System;
    using System.Collections.Generic;
    
    public partial class DSDispatchingOrder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DSDispatchingOrder()
        {
            this.DSDOCartons = new HashSet<DSDOCarton>();
        }
    
        public int DSDispatchingOrderID { get; set; }
        public string DSDispatchingOrderNumber { get; set; }
        public string DSCustomerName { get; set; }
        public string DSCustomerNumber { get; set; }
        public int DSCustomerID { get; set; }
        public System.DateTime DSDispatchingOrderDate { get; set; }
        public string DSSpecialRequirement { get; set; }
        public bool DSStatus { get; set; }
        public Nullable<System.DateTime> DSDispatchingCreatedTime { get; set; }
        public string DSOwner { get; set; }
        public string DSDispatchingType { get; set; }
        public int ServiceID { get; set; }
        public Nullable<System.DateTime> StartTime { get; set; }
        public Nullable<System.DateTime> EndTime { get; set; }
        public byte[] ts { get; set; }
        public string ContactEmail { get; set; }
        public byte DSOrderStatus { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DSDOCarton> DSDOCartons { get; set; }
    }
}
