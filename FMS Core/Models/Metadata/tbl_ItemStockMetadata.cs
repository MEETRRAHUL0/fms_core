using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FMS
{
    [ModelMetadataType(typeof(tbl_ItemStockMetadata))]
    public partial class TblItemStock
    {
    }

    public interface tbl_ItemStockMetadata
    {
        //[Display(Name = "No.")]
         //int AutoID  { get; set; }

        [Display(Name = "Stock Id")]
        [Required(ErrorMessage = "Stock Id is missing")]
         string ID  { get; set; }

        [Display(Name = "Purchase ID")]
         string PurchaseID  { get; set; }

        [Display(Name = "Sale ID")]
         string SaleID  { get; set; }

        [Display(Name = "Invoice Num")]
         string InvoiceNo  { get; set; }

        [Display(Name = "Item ID")]
         string ItemID  { get; set; }

        [Display(Name = "Quantity")]
        [Required(ErrorMessage = "Quantity is missing")]
         Nullable<int> Qty  { get; set; }

        [Display(Name = "Price Per Unit")]
         Nullable<decimal> PricePerUnit  { get; set; }

        [Display(Name = "Discount Per Unit")]
         Nullable<decimal> ItemwiseDiscount  { get; set; }

        [Display(Name = "Price Per Unit After Discount")]
         Nullable<decimal> PricePerUnitAfterDiscount  { get; set; }

        [Display(Name = "Total Price Before Tax")]
         Nullable<decimal> TotalPriceBeforeTax  { get; set; }

        [Display(Name = "SGST")]
         Nullable<decimal> SGST  { get; set; }

        [Display(Name = "CGST")]
         Nullable<decimal> CGST  { get; set; }

        [Display(Name = "IGST")]
         Nullable<decimal> IGST  { get; set; }

        [Display(Name = "GST")]
         Nullable<decimal> GST  { get; set; }

        [Display(Name = "Total Price After Tax")]
         Nullable<decimal> TotalPriceAfterTax  { get; set; }

        [Display(Name = "MRP")]
         Nullable<decimal> MRP  { get; set; }

        [Display(Name = "Manufacture Date")]
         Nullable<System.DateTime> ManufactureDate  { get; set; }

        [Display(Name = "Expiry Date")]
         Nullable<System.DateTime> Expirydate  { get; set; }

        [Display(Name = "Batch Num")]
         string BatchNo  { get; set; }

        [Display(Name = "Created On")]
         string CreatedDatetime  { get; set; }

        [Display(Name = "Stock Type")]
         string StockType  { get; set; }

    }
}