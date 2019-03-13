using System;
using System.Collections.Generic;

namespace FMS_Core.Models.EFModels
{
    public partial class TblGst
    {
        public TblGst()
        {
            TblItems = new HashSet<TblItems>();
        }

        public int Id { get; set; }
        public decimal? Gst { get; set; }
        public decimal? Sgst { get; set; }
        public decimal? Cgst { get; set; }
        public decimal? Igst { get; set; }
        public string Comment { get; set; }
        public string Name { get; set; }
        public int? Ordinal { get; set; }

        public virtual ICollection<TblItems> TblItems { get; set; }
    }
}
