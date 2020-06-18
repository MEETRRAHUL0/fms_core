using System;
using System.Collections.Generic;

namespace FMS_Core.Models.EFModels
{
    public partial class TblItems
    {
        public TblItems()
        {
            TblItemStock = new HashSet<TblItemStock>();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string HsnSacNo { get; set; }
        public int? Type { get; set; }
        public int? MeasuringUnit { get; set; }
        public string Manufacture { get; set; }
        public string BarCode { get; set; }
        public string ItemUniqueDescription { get; set; }
        public string Supplier { get; set; }
        public string Photo { get; set; }
        public bool? UseBatchNo { get; set; }
        public bool? UseMfgDate { get; set; }
        public bool? UseExpiryDate { get; set; }
        public DateTime? CreatedDatetime { get; set; }
        public int? Gst { get; set; }

        public virtual TblGst GstNavigation { get; set; }
        public virtual TblItemUnits MeasuringUnitNavigation { get; set; }
        public virtual TblVendor SupplierNavigation { get; set; }
        public virtual TblItemType TypeNavigation { get; set; }
        public virtual ICollection<TblItemStock> TblItemStock { get; set; }
    }
}
