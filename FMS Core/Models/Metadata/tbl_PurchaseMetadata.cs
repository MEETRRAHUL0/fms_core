using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FMS_Core.Models.EFModels
{
    [ModelMetadataType(typeof(tbl_PurchaseMetadata))]
    public partial class TblPurchase
    {
        [NotMapped]
        public decimal Amount { get; set; }
    }

    public interface tbl_PurchaseMetadata
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[Key, Column(Order = 0)]
        //[Display(Name = "Sl.No")]
        //int AutoId { get; set; }

        //[Display(Name = "Quantity")]
        //public string ID ;   [Display(Name = "Quantity")]

        [Display(Name = "Party Invoice Date")]
        [Required(ErrorMessage = "Party Invoice Date is missing")]
         Nullable<System.DateTime> PartyInvoiceDate  { get; set; }

        [Display(Name = "Purchase Date")]
        [Required(ErrorMessage = "Purchase Date is missing")]
         Nullable<System.DateTime> PurchaseDate  { get; set; }

        [Display(Name = "Party Invoice No")]
        [Required(ErrorMessage = "Party Invoice No is missing")]
         string PartyInvoiceNo  { get; set; }

        [Display(Name = "Party Name")]
         string PartyName  { get; set; }

        [Display(Name = "Payment Due After")]
         string PaymentDueAfter  { get; set; }

        [Display(Name = "Reverse Charge")]
         Nullable<bool> ReverseCharge  { get; set; }

        [Display(Name = "Remark")]
         string Remark  { get; set; }

        [Display(Name = "Discount Amount")]
         Nullable<decimal> DiscountAmount  { get; set; }

        [Display(Name = "Other Charge")]
         Nullable<decimal> OtherCharge  { get; set; }

        [Display(Name = "Total Amount Before Tax")]
         Nullable<decimal> TotalAmountBeforeTax  { get; set; }

        [Display(Name = "Tax Amount")]
         Nullable<decimal> TaxAmount  { get; set; }

        [Display(Name = "Total Amount After Tax")]
         Nullable<decimal> TotalAmountAfterTax  { get; set; }

        [Display(Name = "Round Off Amount")]
         Nullable<decimal> RoundOff  { get; set; }

        [Display(Name = "Grand Total")]
         Nullable<decimal> GrandTotal  { get; set; }

        [Display(Name = "Purchase Book")]
         Nullable<int> PurchaseBook  { get; set; }

        [Display(Name = "Payment Mode")]
        [Required(ErrorMessage = "Please select Payment option")]
         Nullable<int> PaymentMode  { get; set; }

        [Display(Name = "Scan Copy")]
         string ScanCopy  { get; set; }

        [Display(Name = "Created On")]
         string CreatedDatetime  { get; set; }
    }
}