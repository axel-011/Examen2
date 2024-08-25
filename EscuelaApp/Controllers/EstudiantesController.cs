using Microsoft.AspNetCore.Mvc;
using EscuelaApp.Data;
using EscuelaApp.Models;
using System.Linq;

namespace EscuelaApp.Controllers
{
    public class EstudiantesController : Controller
    {
        private readonly EscuelaContext _context;

        public EstudiantesController(EscuelaContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Estudiantes.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Estudiante estudiante)
        {
            if (ModelState.IsValid)
            {
                _context.Estudiantes.Add(estudiante);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(estudiante);
        }
    }
}
