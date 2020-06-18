using System;
using System.Collections.Generic;

namespace FMS_Core.Models.EFModels
{
    public partial class TblPurchase
    {
        public TblPurchase()
        {
            TblItemStock = new HashSet<TblItemStock>();
            TblTransaction = new HashSet<TblTransaction>();
        }

        public int AutoId { get; set; }
        public string Id { get; set; }
        public DateTime? PartyInvoiceDate { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public string PartyInvoiceNo { get; set; }
        public string PartyName { get; set; }
        public string PaymentDueAfter { get; set; }
        public bool? ReverseCharge { get; set; }
        public string Remark { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal? OtherCharge { get; set; }
        public decimal? TotalAmountBeforeTax { get; set; }
        public decimal? TaxAmount { get; set; }
        public decimal? TotalAmountAfterTax { get; set; }
        public decimal? RoundOff { get; set; }
        public decimal? GrandTotal { get; set; }
        public int? PurchaseBook { get; set; }
        public int? PaymentMode { get; set; }
        public string ScanCopy { get; set; }
        public string CreatedDatetime { get; set; }

        public virtual TblVendor PartyNameNavigation { get; set; }
        public virtual TblPaymentMode PaymentModeNavigation { get; set; }
        public virtual ICollection<TblItemStock> TblItemStock { get; set; }
        public virtual ICollection<TblTransaction> TblTransaction { get; set; }
    }
}
