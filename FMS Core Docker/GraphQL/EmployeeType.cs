using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FMS_Core.API;
using FMS_Core.Models.EFModels;
using GraphQL.DataLoader;
using GraphQL.Types;

namespace FMS_Core.GraphQL
{
    public class EmployeeType : ObjectGraphType<Employee>
    {
        public EmployeeType(ICertificaationRepository certificationRepository, IDataLoaderContextAccessor dataLoaderContextAccessor)
        {
            Field(a => a.Id);
            Field(a => a.Name);
            Field(a => a.Email);
            Field(a => a.Mobile);
            Field(a => a.Company).Description("Company Name"); ;
            Field(a => a.Address);
            Field(a => a.ShortDescription);
            Field(a => a.LongDescription);
            Field<ListGraphType<EmployeeCertificationType>>(
                "certifications",
                resolve: context =>
                {
                    //return certificationRepository.GetCertificationByEmployee(context.Source.Id);

                    var loader = dataLoaderContextAccessor.Context.GetOrAddCollectionBatchLoader<long, Certification>(
                        "GetCertificationByEmployee", certificationRepository.GetCertificationByEmployee);

                    return loader.LoadAsync(context.Source.Id);
                });
        }
    }
}
