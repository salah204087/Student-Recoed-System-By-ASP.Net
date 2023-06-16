using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudentRecordSystem.Data;
using StudentRecordSystem.Models;

namespace StudentRecordSystem.Controllers
{
    public class UniversityController : Controller
    {
        private readonly ApplicationDbContext _context;
        public UniversityController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var universities=_context.Universities.ToList();
            if (universities == null)
                return NotFound();
            return View(universities);
        }
        [Authorize(Roles =Roles.Role_Admin)]
        public IActionResult Create()
        {
            return View();
        }
        [Authorize(Roles = Roles.Role_Admin)]
        [HttpPost]
        public IActionResult Create(University university)
        {
            if (!ModelState.IsValid)
                return View();
            else
            {
                _context.Universities.Add(university);
                _context.SaveChanges();
                TempData["success"] = "University added successfully";
                return RedirectToAction("Index");
            }
        }
        [Authorize(Roles = Roles.Role_Admin)]
        public IActionResult Edit(int? id)
        {
            if(id==null || id==0)
                return NotFound();
            var universityInDb = _context.Universities.FirstOrDefault(n => n.Id == id);
            if(universityInDb == null)
                return NotFound();
            return View(universityInDb);
        }
        [Authorize(Roles = Roles.Role_Admin)]
        [HttpPost]
        public IActionResult Edit(University university)
        {
            if(!ModelState.IsValid)
                return View();
            else
            {
                _context.Universities.Update(university);
                _context.SaveChanges();
                TempData["success"] = "University updated successfully";
                return RedirectToAction("Index");
            }
        }
        [Authorize(Roles = Roles.Role_Admin)]
        public IActionResult Delete(int? id)
        {
            if (id==null || id==0)
                return NotFound();
            var universityInDb = _context.Universities.FirstOrDefault(n => n.Id == id);
            if (universityInDb == null)
                return NotFound();
            return View(universityInDb);
        }
        [Authorize(Roles = Roles.Role_Admin)]
        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeletePost(int? id)
        {
            var universityInDb = _context.Universities.FirstOrDefault(n => n.Id == id);
            if (universityInDb == null)
                return NotFound();
            _context.Universities.Remove(universityInDb);
            _context.SaveChanges();
            TempData["success"] = "University deleted successfully";
            return RedirectToAction("Index");
        }
    }
}
