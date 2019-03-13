using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FMS_Core.Models.EFModels
{
    [ModelMetadataType(typeof(tbl_SupplierMetadata))]
    public partial class tbl_Supplier
    {
    }


    public interface tbl_SupplierMetadata
    {
        

         string ID   { get; set; }    

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Supplier Name is missing")]
         string Name   { get; set; }

        [Display(Name = "Contact Person")]
         string ContactPerson   { get; set; }

        [Display(Name = "Contact Number")]
         string ContactNumber   { get; set; }

        [Display(Name = "Type")]
         string Type   { get; set; }

        [Display(Name = "Place")]
         string Place   { get; set; }

        [Display(Name = "GST Num")]
         string GST_No   { get; set; }

        [Display(Name = "TIN Num")]
         string TIN_No   { get; set; }

        [Display(Name = "PAN Num")]
         string PAN_No   { get; set; }

        [Display(Name = "CIN Nu")]
         string CIN_No   { get; set; }

        [Display(Name = "Address Line 1")]
         string Address_Line1   { get; set; }

        [Display(Name = "Address Line 2")]
         string Address_Line2   { get; set; }

        [Display(Name = "City")]
         string City   { get; set; }

        [Display(Name = "State")]
         string State   { get; set; }

        [Display(Name = "Pin Code")]
         Nullable<int> Pin_Code   { get; set; }

        [Display(Name = "Phone Number")]
         string PhoneNumber   { get; set; }

        [Display(Name = "Email ID")]
         string Email   { get; set; }

        [Display(Name = "Opening Balance")]
         string OpeningBalance   { get; set; }

        [Display(Name = "opening Balance Date")]
         Nullable<System.DateTime> openingBalanceDate   { get; set; }

        [Display(Name = "Credit Limit")]
         Nullable<decimal> CreditLimit   { get; set; }

        [Display(Name = "Credit Period")]
         Nullable<int> CreditPeriod   { get; set; }

        [Display(Name = "Credit Intrest Rate")]
         Nullable<int> CreditIntrestRate   { get; set; }

        [Display(Name = "Remark")]
         string Remark   { get; set; }

        [Display(Name = "Photo")]
         string Photo   { get; set; }

        [Display(Name = "Created Date Time")]
         Nullable<System.DateTime> CreatedDateTime   { get; set; }

        
    }
}