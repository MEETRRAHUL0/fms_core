//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FMS_Core.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class vw_StockExpirydetails
    {
        public Guid Guid { get; set; }
        public string ID { get; set; }
        public string Name { get; set; }
        public string HSN_SAC_NO { get; set; }
        public string ItemType { get; set; }
        public string MeasuringUnits { get; set; }
        public string Supplier { get; set; }
        public Nullable<int> MeasuringUnit { get; set; }
        public Nullable<System.DateTime> Expirydate { get; set; }
        public string BatchNo { get; set; }
        public string StockType { get; set; }
        public string PurchaseID { get; set; }
        public string SaleID { get; set; }
        public string InvoiceNo { get; set; }
        public Nullable<int> Qty { get; set; }
    }
}