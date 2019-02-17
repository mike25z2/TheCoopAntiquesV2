using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheCoopAntiquesV2.Data;
using TheCoopAntiquesV2.Models;

namespace TheCoopAntiquesV2.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DealerController : Controller
    {
        private readonly ApplicationDbContext _db;

        public DealerController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View(_db.Dealer.ToList());
        }

        //GET CREATE
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Dealer dealer)
        {
            if (!ModelState.IsValid) return View();
            _db.Add(dealer);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}