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
    
    public partial class vw_StockAvailable
    {
        public Guid Guid { get; set; }
        public int StockIn { get; set; }
        public int StockOut { get; set; }
        public Nullable<int> StockAvailable { get; set; }
        public string ItemsID { get; set; }
        public string Name { get; set; }
        public string HSN_SAC_NO { get; set; }
    }
}