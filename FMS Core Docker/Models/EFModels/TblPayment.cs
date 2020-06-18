using System;
using System.Collections.Generic;

namespace FMS_Core.Models.EFModels
{
    public partial class TblPayment
    {
        public TblPayment()
        {
            TblTransaction = new HashSet<TblTransaction>();
        }

        public int AutoId { get; set; }
        public string Id { get; set; }
        public string PaymentDate { get; set; }
        public string PartyName { get; set; }
        public decimal? Amount { get; set; }
        public string PaymentMode { get; set; }
        public string Remark { get; set; }
        public string CreatedDatetime { get; set; }

        public virtual TblVendor PartyNameNavigation { get; set; }
        public virtual ICollection<TblTransaction> TblTransaction { get; set; }
    }
}
