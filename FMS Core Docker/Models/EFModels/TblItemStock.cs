using System;
using System.Collections.Generic;

namespace FMS_Core.Models.EFModels
{
    public partial class TblItemStock
    {
        public int AutoId { get; set; }
        public string Id { get; set; }
        public string StockType { get; set; }
        public string PurchaseId { get; set; }
        public string SaleId { get; set; }
        public string InvoiceNo { get; set; }
        public string ItemId { get; set; }
        public int? Qty { get; set; }
        public decimal? PricePerUnit { get; set; }
        public decimal? ItemwiseDiscount { get; set; }
        public decimal? PricePerUnitAfterDiscount { get; set; }
        public decimal? TotalPriceBeforeTax { get; set; }
        public decimal? Sgst { get; set; }
        public decimal? Cgst { get; set; }
        public decimal? Igst { get; set; }
        public decimal? Gst { get; set; }
        public decimal? TotalPriceAfterTax { get; set; }
        public decimal? Mrp { get; set; }
        public DateTime? ManufactureDate { get; set; }
        public DateTime? Expirydate { get; set; }
        public string BatchNo { get; set; }
        public string CreatedDatetime { get; set; }

        public virtual TblItems Item { get; set; }
        public virtual TblPurchase Purchase { get; set; }
        public virtual TblSale Sale { get; set; }
    }
}
