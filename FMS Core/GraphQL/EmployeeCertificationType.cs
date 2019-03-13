using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FMS_Core.Models.EFModels;
using GraphQL.Types;

namespace FMS_Core.GraphQL
{
    public class EmployeeCertificationType : ObjectGraphType<Certification>
    {
        public EmployeeCertificationType()
        {
            Field(t => t.Id);
            Field(t => t.Title);
            Field(t => t.Month, nullable: true);
            Field(t => t.Year, nullable: true);
            Field(t => t.Provider);
        }
    }
}
