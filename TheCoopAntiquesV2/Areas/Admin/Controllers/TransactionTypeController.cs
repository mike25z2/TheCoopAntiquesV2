using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheCoopAntiquesV2.Data;

namespace TheCoopAntiquesV2.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TransactionTypeController : Controller
    {
        private readonly ApplicationDbContext _db;

        public TransactionTypeController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View(_db.TransactionType.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}