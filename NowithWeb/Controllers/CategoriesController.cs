using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NowithWeb.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly NorthwindContext _db;

        public CategoriesController(NorthwindContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<Category> obj = _db.Categories.ToList();
            return View(obj);
        }
    }
}
