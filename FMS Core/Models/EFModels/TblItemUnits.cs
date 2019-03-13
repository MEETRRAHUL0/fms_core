using System;
using System.Collections.Generic;

namespace FMS_Core.Models.EFModels
{
    public partial class TblItemUnits
    {
        public TblItemUnits()
        {
            TblItems = new HashSet<TblItems>();
        }

        public int MeasurintUnitId { get; set; }
        public string MeasuringUnits { get; set; }

        public virtual ICollection<TblItems> TblItems { get; set; }
    }
}
