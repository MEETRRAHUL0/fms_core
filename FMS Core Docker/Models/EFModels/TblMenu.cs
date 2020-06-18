using System;
using System.Collections.Generic;

namespace FMS_Core.Models.EFModels
{
    public partial class TblMenu
    {
        public int Id { get; set; }
        public string DisplayName { get; set; }
        public string Icon { get; set; }
        public string Type { get; set; }
        public int Ordinal { get; set; }
        public string Path { get; set; }
        public int ParentId { get; set; }
        public bool? IsEnable { get; set; }
    }
}
