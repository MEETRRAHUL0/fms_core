using System;
using System.Collections.Generic;

namespace FMS_Core.Models.EFModels
{
    public partial class TblPaymentMode
    {
        public TblPaymentMode()
        {
            TblPurchase = new HashSet<TblPurchase>();
            TblSale = new HashSet<TblSale>();
        }

        public int Id { get; set; }
        public string Mode { get; set; }
        public string Type { get; set; }
        public bool? IsVisible { get; set; }

        public virtual ICollection<TblPurchase> TblPurchase { get; set; }
        public virtual ICollection<TblSale> TblSale { get; set; }
    }
}
