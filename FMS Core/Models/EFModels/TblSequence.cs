using System;
using System.Collections.Generic;

namespace FMS_Core.Models.EFModels
{
    public partial class TblSequence
    {
        public int Id { get; set; }
        public string TableName { get; set; }
        public string PreFix { get; set; }
        public int RecordCount { get; set; }
    }
}
