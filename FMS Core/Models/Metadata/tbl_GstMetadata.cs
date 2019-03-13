using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FMS_Core.Models.EFModels
{
    [ModelMetadataType(typeof(tbl_GSTMetadata))]
    public partial class TblGst
    {
    }


    public interface tbl_GSTMetadata
    {
        

         //int AutoID { get; set; }
         string ID { get; set; }

        [Display(Name = "GST")]
        [Required(ErrorMessage = "GST is missing")]
         Nullable<decimal> GST { get; set; }

        [Display(Name = "SGST")]
        [Required(ErrorMessage = "SGST is missing")]
         Nullable<decimal> SGST { get; set; }

        [Display(Name = "CGST")]
        [Required(ErrorMessage = "CGST is missing")]
         Nullable<decimal> CGST { get; set; }
         Nullable<decimal> IGST { get; set; }
         string Comment { get; set; }

        [Display(Name = "Display Name")]
        [Required(ErrorMessage = "Display Name is missing")]
         string Name { get; set; }
         
    }
}