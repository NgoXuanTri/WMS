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
    
    public partial class SP_DSStockByLocationDetailsAllCustomer_Result
    {
        public string LocationNumber { get; set; }
        public string DSReceivingOrderNumber { get; set; }
        public string CustomerName { get; set; }
        public string CustomerNumber { get; set; }
        public System.DateTime DSReceivingOrderDate { get; set; }
        public string DSSpecialRequirement { get; set; }
        public string CrowRefID { get; set; }
        public int CartonNumber { get; set; }
        public string CartonDescription { get; set; }
        public int DSReceivingOrderID { get; set; }
        public int LocationID { get; set; }
        public Nullable<bool> Dispatched { get; set; }
        public string DSCustomerName { get; set; }
        public int CartonNewID { get; set; }
        public string DSCustomerNumber { get; set; }
        public string CartonNewIDBarcode { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
    }
}