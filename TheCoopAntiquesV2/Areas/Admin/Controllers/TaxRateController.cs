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
    public class TaxRateController : Controller
    {
        private readonly ApplicationDbContext _db;

        public TaxRateController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View(_db.TaxRate.ToList());
        }

        #region Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TaxRate taxRate)
        {
            if (!ModelState.IsValid) return View();
            taxRate.Amount /= 100;
            _db.Add(taxRate);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        #endregion
    }
}