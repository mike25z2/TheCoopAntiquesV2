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

        #region Create
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
        #endregion

        #region Edit
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            var dealer = await _db.Dealer.FindAsync(id);
            if (dealer == null) return NotFound();
            return View(dealer);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Dealer dealer)
        {
            if (id != dealer.Id) return NotFound();
            if (!ModelState.IsValid) return View();
            _db.Update(dealer);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        #endregion

        #region Details
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();
            var dealer = await _db.Dealer.FindAsync(id);
            if (dealer == null) return NotFound();
            return View(dealer);
        }

        #endregion
    }
}