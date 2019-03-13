using System;
using System.Collections.Generic;

namespace FMS_Core.Models.EFModels
{
    public partial class TblTransaction
    {
        public int AutoId { get; set; }
        public string Id { get; set; }
        public string VendorId { get; set; }
        public string PurchaseId { get; set; }
        public string SalesId { get; set; }
        public string EntryId { get; set; }
        public string EntryDate { get; set; }
        public string EntryType { get; set; }
        public decimal? Amount { get; set; }
        public string Status { get; set; }
        public string CreatedDatetime { get; set; }
        public string TransactionType { get; set; }
        public string TransactionRef { get; set; }
        public string PaymentId { get; set; }

        public virtual TblPayment Payment { get; set; }
        public virtual TblPurchase Purchase { get; set; }
        public virtual TblSale Sales { get; set; }
        public virtual TblVendor Vendor { get; set; }
    }
}
