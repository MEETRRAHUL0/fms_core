using System;
using System.Collections.Generic;

namespace FMS_Core.Models.EFModels
{
    public partial class TblVendorType
    {
        public TblVendorType()
        {
            TblVendor = new HashSet<TblVendor>();
        }

        public int AutoId { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<TblVendor> TblVendor { get; set; }
    }
}
