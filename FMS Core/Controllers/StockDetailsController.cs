using FMS_Core.Models.EFModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace FMS_Core.Controllers
{
    public class StockDetailsController : Controller
    {
        private readonly FMSExpContext _context;

        public StockDetailsController(FMSExpContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.vw_StockDetails.ToListAsync());
        }

      
    }
}