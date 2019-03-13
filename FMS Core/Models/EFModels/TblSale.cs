using System;
using System.Collections.Generic;

namespace FMS_Core.Models.EFModels
{
    public partial class TblSale
    {
        public TblSale()
        {
            TblItemStock = new HashSet<TblItemStock>();
            TblTransaction = new HashSet<TblTransaction>();
        }

        public int AutoId { get; set; }
        public string SaleId { get; set; }
        public string InvoiceId { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string CustomerId { get; set; }
        public decimal? DiscountAfterTax { get; set; }
        public decimal? OtherChargeAfterTax { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? Tax { get; set; }
        public decimal? TotalValueafterTax { get; set; }
        public decimal? RoundOff { get; set; }
        public decimal? GrandTotal { get; set; }
        public string CreatedDatetime { get; set; }
        public bool? ReverseCharge { get; set; }
        public string Remark { get; set; }
        public int? PaymentMode { get; set; }
        public string ScanCopy { get; set; }

        public virtual TblVendor Customer { get; set; }
        public virtual TblPaymentMode PaymentModeNavigation { get; set; }
        public virtual ICollection<TblItemStock> TblItemStock { get; set; }
        public virtual ICollection<TblTransaction> TblTransaction { get; set; }
    }
}
