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
    
    public partial class SP_DSStockOnHandByLocationByBay_Result
    {
        public int DSROCartonID { get; set; }
        public int DSReceivingOrderID { get; set; }
        public string CartonDescription { get; set; }
        public int DSROID { get; set; }
        public Nullable<bool> Dispatched { get; set; }
        public int DSCustomerID { get; set; }
        public System.DateTime DSReceivingOrderDate { get; set; }
        public int CartonNewID { get; set; }
        public string CrowRefID { get; set; }
        public int LocationID { get; set; }
        public string LocationNumber { get; set; }
        public string DSReceivingOrderNumber { get; set; }
        public string DSCustomerNumber { get; set; }
        public string DSCustomerName { get; set; }
        public int DSCartonCategoryID { get; set; }
        public string CategoryDescription { get; set; }
        public float CartonSize { get; set; }
        public string DSSpecialRequirement { get; set; }
        public string RoomID { get; set; }
        public Nullable<short> Aisle { get; set; }
        public Nullable<short> High { get; set; }
        public bool Used { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string CartonNewIDBarcode { get; set; }
        public Nullable<short> Bay { get; set; }
    }
}