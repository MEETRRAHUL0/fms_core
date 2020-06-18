using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FMS_Core.Models.EFModels
{
    [ModelMetadataType(typeof(tbl_ItemsMetadata))]
    public partial class TblItems
    {
        [NotMapped]
        [Display(Name = "Opening Stock")]
        [Required(ErrorMessage = "Opening Stock Required")]
        public decimal OpeningStock { get; set; }
    }

    public interface tbl_ItemsMetadata
    {
        [Display(Name = "Item Id")]
        string Id { get; set; }

        [Display(Name = "Item Name")]
        [Required(ErrorMessage = "Item ID Required")]
        string Name { get; set; }

        [Display(Name = "HSN SAC Number")]
        [Required(ErrorMessage = "HSN SAC Number Required")]
        string HsnSacNo { get; set; }

        [Display(Name = "Type")]
        [Required(ErrorMessage = "Type Required")]
        int? Type { get; set; }

        [Display(Name = "Measuring Unit")]
        [Required(ErrorMessage = "Measuring Unit Required")]
        int? MeasuringUnit { get; set; }

        [Display(Name = "Manufacture")]
        string Manufacture { get; set; }

        [Display(Name = "Bar Code")]
        string BarCode { get; set; }

        [Display(Name = "Item Unique Description")]
        string ItemUniqueDescription { get; set; }

        [Display(Name = "Supplier")]
        [Required(ErrorMessage = "Supplier Required")]
        string Supplier { get; set; }

        [Display(Name = "Photo")]
        string Photo { get; set; }

        [Display(Name = "Use Batch No")]
        Nullable<bool> UseBatchNo { get; set; }

        [Display(Name = "Use Mfg Date")]
        Nullable<bool> UseMfgDate { get; set; }

        [Display(Name = "Use Expiry Date")]
        Nullable<bool> UseExpiryDate { get; set; }

        [Display(Name = "Created On")]
        Nullable<System.DateTime> CreatedDatetime { get; set; }

        [Required(ErrorMessage = "GST Required")]
        string Gst { get; set; }

        //[Display(Name = "OpeningStock")]
        //[Required(ErrorMessage = "Opening Stock Required")]
        //public string OpeningStock { get; set; }
    }
}