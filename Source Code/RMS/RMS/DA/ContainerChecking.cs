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
    
    public partial class ContainerChecking
    {
        public int ContainerCheckingID { get; set; }
        public int ContInOutID { get; set; }
        public string TemperatureShow { get; set; }
        public string TemperatureSetup { get; set; }
        public Nullable<bool> Running { get; set; }
        public Nullable<bool> Thawing { get; set; }
        public Nullable<bool> Stop { get; set; }
        public Nullable<bool> Error { get; set; }
        public Nullable<bool> ProductEmpty { get; set; }
        public Nullable<bool> Seal { get; set; }
        public Nullable<bool> Lock { get; set; }
        public string Remark { get; set; }
        public string UserCheck { get; set; }
        public Nullable<System.DateTime> Time { get; set; }
        public Nullable<bool> AttachmentFile { get; set; }
        public string LocationChecking { get; set; }
        public string DockNumber { get; set; }
        public Nullable<bool> NoOperation { get; set; }
        public Nullable<int> ContainerCheckingID_old { get; set; }
        public string ContainerCheckingNumber { get; set; }
    }
}
