using System;
using System.Collections.Generic;

namespace FMS_Core.Models.EFModels
{
    public partial class TblVendorAddress
    {
        public int AutoId { get; set; }
        public string Id { get; set; }
        public string VendorId { get; set; }
        public string AddressType { get; set; }
        public string AddLine1 { get; set; }
        public string AddLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PinCode { get; set; }
        public int? ContactNo { get; set; }
        public string Email { get; set; }

        public virtual TblVendor Vendor { get; set; }
    }
}
