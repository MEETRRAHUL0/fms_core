using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FMS_Core.Models.EFModels
{
    [ModelMetadataType(typeof(tbl_SalesMetadata))]
    public partial class TblSale
    {
        [NotMapped]
        public decimal Amount { get; set; }
    }

    public interface tbl_SalesMetadata
    {
        [Display(Name = "Invoice ID")]
        [Required(ErrorMessage = "Invoice ID is missing")]
          string InvoiceId { get; set; }

          [Display(Name = "Invoice Date")]
          [Required(ErrorMessage = "Invoice Date is missing")]
        DateTime? InvoiceDate { get; set; }

        [Display(Name = "Customer Id")]
        [Required(ErrorMessage = "Customer Id is missing")]
        string CustomerId { get; set; }
    }
}
