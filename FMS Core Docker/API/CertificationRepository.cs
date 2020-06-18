using FMS_Core.Models.EFModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace FMS_Core.API
{
    public class CertificationRepository : ICertificaationRepository
    {
        private readonly FMSExpContext _context;
        public CertificationRepository(FMSExpContext context)
        {
            _context = context;
        }

        public Task<List<Certification>> GetCertificationByEmployee(long EmployeeId)
        {
            return _context.Certification.Where(a => a.EmployeeId == EmployeeId).ToListAsync();
        }
        public async Task<ILookup<long, Certification>> GetCertificationByEmployee(IEnumerable<long> employeeIds)
        {
            var reviews = await _context.Certification.Where(a => employeeIds.Contains(a.EmployeeId)).ToListAsync();
            return reviews.ToLookup(r => r.EmployeeId);
        }
    }
}
