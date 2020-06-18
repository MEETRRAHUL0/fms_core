using System;
using System.Collections.Generic;

namespace FMS_Core.Models.EFModels
{
    public partial class TblItemType
    {
        public TblItemType()
        {
            TblItems = new HashSet<TblItems>();
        }

        public int ItemTypeId { get; set; }
        public string ItemType { get; set; }

        public virtual ICollection<TblItems> TblItems { get; set; }
    }
}
