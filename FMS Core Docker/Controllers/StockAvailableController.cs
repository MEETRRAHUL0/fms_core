using FMS_Core.Models.EFModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace FMS_Core.Controllers
{
    public class StockAvailableController : Controller
    {
        private readonly FMSExpContext _context ;

        public StockAvailableController(FMSExpContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.vw_StockAvailable.ToListAsync());
        }

      
    }
}