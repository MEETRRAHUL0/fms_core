using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FMS_Core.Models.EFModels
{
    [ModelMetadataType(typeof(tbl_PaymentModeMetadata))]
    public partial class TblPaymentMode
    {
    }


    public interface tbl_PaymentModeMetadata
    {       

        //public int ID { get; set; }

        [Display(Name = "Mode")]
        [Required(ErrorMessage = "Mode is missing")]
          string Mode { get; set; }
 
    }
}