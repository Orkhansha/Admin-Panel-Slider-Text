using EntityFrameworkProject.Data;
using EntityFrameworkProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkProject.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    public class SliderDetailController : Controller
    {
        private readonly AppDbContext _context;
        public SliderDetailController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<SliderDetail> sliderDetails = await _context.SliderDetails.Where(m => !m.IsDeleted).ToListAsync();
            return View(sliderDetails);
        }
    }
}
