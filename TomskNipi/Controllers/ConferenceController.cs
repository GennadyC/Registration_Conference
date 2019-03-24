using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TomskNipi.Models; // пространство имен моделей и контекста данных
using System;

namespace TomskNipi.Controllers
{
    public class ConferenceController : Controller
    {
        private ApplicationContext db1;
        public ConferenceController(ApplicationContext context)
        {
            db1 = context;
        }

        public async Task<IActionResult> Spisok()
        {
            return View(await db1.Sectionss.ToListAsync());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Sections section)
        {
            db1.Sectionss.Add(section);
            await db1.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}