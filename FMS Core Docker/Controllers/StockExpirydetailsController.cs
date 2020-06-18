using FMS_Core.Models.EFModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace FMS_Core.Controllers
{
    public class StockExpirydetailsController : Controller
    {
        private readonly FMSExpContext _context;
        public StockExpirydetailsController(FMSExpContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.vw_StockExpirydetails.ToListAsync());
        }

        
    }
}