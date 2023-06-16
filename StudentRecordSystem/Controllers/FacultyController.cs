using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using StudentRecordSystem.Data;
using StudentRecordSystem.Models;
using System.Data;

namespace StudentRecordSystem.Controllers
{
    public class FacultyController : Controller
    {
        private readonly ApplicationDbContext _context;
        public FacultyController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var facutiles = _context.Faculties.ToList();
            if (facutiles==null)
                return NotFound();
            return View(facutiles);
        }
        [Authorize(Roles = Roles.Role_Admin)]
        public IActionResult Create()
        {
            return View();
        }
        [Authorize(Roles = Roles.Role_Admin)]
        [HttpPost]
        public IActionResult Create(Faculty faculty)
        {
            if (!ModelState.IsValid)
                return View();
            else
            {
                _context.Faculties.Add(faculty);
                _context.SaveChanges();
                TempData["success"] = "Faculty added successfully";
                return RedirectToAction("Index");
            }
        }
        [Authorize(Roles = Roles.Role_Admin)]
        public IActionResult Edit(int? id) 
        {
            if (id == null||id==0)
                return NotFound();
            var facultyInDb=_context.Faculties.FirstOrDefault(n=> n.Id == id);
            if (facultyInDb==null)
                return NotFound();
            return View(facultyInDb);
        }
        [Authorize(Roles = Roles.Role_Admin)]
        [HttpPost]
        public IActionResult Edit(Faculty faculty)
        {
            if (!ModelState.IsValid)
                return View();
            else
            {
                _context.Faculties.Update(faculty);
                _context.SaveChanges();
                TempData["success"] = "Faculty updated sucessfully";
                return RedirectToAction("Index");
            }
        }
        [Authorize(Roles = Roles.Role_Admin)]
        public IActionResult Delete(int? id)
        {
            if (id==null || id==0)
                return NotFound();
            var facultyInDb=_context.Faculties.FirstOrDefault(n=>n.Id == id);
            if (facultyInDb==null)
                return NotFound();
            return View(facultyInDb);
        }
        [Authorize(Roles = Roles.Role_Admin)]
        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeletePost(int id)
        {
            var facultyInDb=_context.Faculties.FirstOrDefault(n=>n.Id==id);
            if (facultyInDb==null)
                return NotFound();
            else
            {
                _context.Faculties.Remove(facultyInDb);
                _context.SaveChanges();
                TempData["success"] = "Faculty deleted successfully";
                return RedirectToAction("Index");
            }
        }
    }
}
