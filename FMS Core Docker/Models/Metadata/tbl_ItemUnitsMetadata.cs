using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FMS_Core.Models.EFModels
{

    [ModelMetadataType(typeof(tbl_ItemUnitsMetadata))]
    public partial class TblItemUnits
    {
    }

    public interface tbl_ItemUnitsMetadata
    {
        

          int MeasurintUnitID { get; set; }

        [Display(Name = "Measuring Units")]
        [Required(ErrorMessage = "MeasuringUnits is missing")]
          string MeasuringUnits { get; set; }

        
    }
}