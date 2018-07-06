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
    
    public partial class Gate_ContInOut
    {
        public int ContInOutID { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string ContainerNum { get; set; }
        public string ContainerType { get; set; }
        public string Reason { get; set; }
        public string ProductQty { get; set; }
        public Nullable<System.DateTime> TimeIn { get; set; }
        public Nullable<System.DateTime> TimeOut { get; set; }
        public Nullable<System.DateTime> StartTime { get; set; }
        public Nullable<System.DateTime> EndTime { get; set; }
        public string UserOut { get; set; }
        public Nullable<System.DateTime> RunningHour { get; set; }
        public Nullable<double> RunningFloat { get; set; }
        public Nullable<double> PowerQuantity { get; set; }
        public Nullable<bool> CheckOut { get; set; }
        public Nullable<bool> Via { get; set; }
        public Nullable<int> OtherServiceID { get; set; }
        public string TruckIn { get; set; }
        public string TruckOut { get; set; }
        public Nullable<bool> UserCheckOut { get; set; }
        public Nullable<bool> TruckCheckOut { get; set; }
        public string UserTruckOut { get; set; }
        public Nullable<byte> Gate { get; set; }
        public Nullable<float> EstimateHour { get; set; }
        public string OrderNumber { get; set; }
        public string Remarks { get; set; }
        public Nullable<System.DateTime> StartWorkingTime { get; set; }
        public Nullable<System.DateTime> EndWorkingTime { get; set; }
    }
}
