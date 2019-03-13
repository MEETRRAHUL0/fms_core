using System;
using System.Collections.Generic;

namespace FMS_Core.Models.EFModels
{
    public partial class TblVendor
    {
        public TblVendor()
        {
            TblItems = new HashSet<TblItems>();
            TblPayment = new HashSet<TblPayment>();
            TblPurchase = new HashSet<TblPurchase>();
            TblSale = new HashSet<TblSale>();
            TblTransaction = new HashSet<TblTransaction>();
            TblVendorAddress = new HashSet<TblVendorAddress>();
        }

        public int AutoId { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string ContactPerson { get; set; }
        public string ContactNo { get; set; }
        public string PhoneNo { get; set; }
        public string VendorType { get; set; }
        public string Type { get; set; }
        public string Place { get; set; }
        public string Dob { get; set; }
        public string Gstno { get; set; }
        public string Tinno { get; set; }
        public string Panno { get; set; }
        public string Cinno { get; set; }
        public string AdhaarNo { get; set; }
        public decimal? OpeningBalance { get; set; }
        public string OpeningBalanceType { get; set; }
        public string OpeningBalanceDate { get; set; }
        public decimal? CreditLimit { get; set; }
        public int? CreditPeriod { get; set; }
        public decimal? CreditInterestRate { get; set; }
        public decimal? DebitInterestRate { get; set; }
        public string CreatedDatetime { get; set; }
        public string Photo { get; set; }
        public string Remark { get; set; }
        public string SuretyPerson { get; set; }
        public string SuretyPersonContactNo { get; set; }
        public string SuretyPersonAddress { get; set; }

        public virtual TblVendorType TypeNavigation { get; set; }
        public virtual ICollection<TblItems> TblItems { get; set; }
        public virtual ICollection<TblPayment> TblPayment { get; set; }
        public virtual ICollection<TblPurchase> TblPurchase { get; set; }
        public virtual ICollection<TblSale> TblSale { get; set; }
        public virtual ICollection<TblTransaction> TblTransaction { get; set; }
        public virtual ICollection<TblVendorAddress> TblVendorAddress { get; set; }
    }
}
