﻿using System;
using System.Collections.Generic;

namespace FMS_Core.Models.EFModels
{
    public partial class Employee
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Company { get; set; }
        public string Address { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public List<Certification> certifications { get; set; }
    }
}