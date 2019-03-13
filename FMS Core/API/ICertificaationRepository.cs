using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FMS_Core.Models.EFModels;

namespace FMS_Core.API
{
    public interface ICertificaationRepository
    {
        Task<List<Certification>> GetCertificationByEmployee(long EmployeeId);
    }
}
