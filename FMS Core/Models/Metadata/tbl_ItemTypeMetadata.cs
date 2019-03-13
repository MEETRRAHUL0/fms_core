using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FMS_Core.Models.EFModels
{

    [ModelMetadataType(typeof(tbl_ItemTypeMetadata))]
    public partial class TblItemType
    {
    }


    public interface tbl_ItemTypeMetadata
    {
         

          int ItemTypeId { get; set; }

        [Display(Name = "Item Type")]
        [Required(ErrorMessage = "Item Type is missing")]
          string ItemType { get; set; }

         
    }
}