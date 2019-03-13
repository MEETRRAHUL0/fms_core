using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FMS_Core.Models.EFModels
{
    [ModelMetadataType(typeof(TblVendorMetadata))]
    public partial class TblVendor
    {
    }


    public interface TblVendorMetadata
    {
        //[IgnoreDataMember]
        //int AutoId { get; set; }
        string Id { get; set; }

        [Display(Name = "Vendor Name")]
        [Required(ErrorMessage = "Vendor Name Required")]
        string Name { get; set; }
         string ContactPerson { get; set; }
         string ContactNo { get; set; }
         string PhoneNo { get; set; }
         string VendorType { get; set; }
         string Type { get; set; }
         string Place { get; set; }
         string Dob { get; set; }
         string Gstno { get; set; }
         string Tinno { get; set; }
         string Panno { get; set; }
         string Cinno { get; set; }
         string AdhaarNo { get; set; }
         decimal? OpeningBalance { get; set; }
         string OpeningBalanceType { get; set; }
         string OpeningBalanceDate { get; set; }
         decimal? CreditLimit { get; set; }
         int? CreditPeriod { get; set; }
         decimal? CreditInterestRate { get; set; }
         decimal? DebitInterestRate { get; set; }
         string CreatedDatetime { get; set; }
         string Photo { get; set; }
         string Remark { get; set; }
         string SuretyPerson { get; set; }
         string SuretyPersonContactNo { get; set; }
         string SuretyPersonAddress { get; set; }

          TblVendorType TypeNavigation { get; set; }
          ICollection<TblItems> TblItems { get; set; }
          ICollection<TblPayment> TblPayment { get; set; }
          ICollection<TblPurchase> TblPurchase { get; set; }
          ICollection<TblSale> TblSale { get; set; }
          ICollection<TblTransaction> TblTransaction { get; set; }
          ICollection<TblVendorAddress> TblVendorAddress { get; set; }
    }
}
