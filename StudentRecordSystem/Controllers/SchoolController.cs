using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudentRecordSystem.Data;
using StudentRecordSystem.Models;
using System.Data;

namespace StudentRecordSystem.Controllers
{
    public class SchoolController : Controller
    {
        private readonly ApplicationDbContext _context;
        public SchoolController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var schools=_context.Schools.ToList();
            if (schools==null)
                return NotFound();
            return View(schools);
        }
        [Authorize(Roles = Roles.Role_Admin)]
        public IActionResult Create()
        {
            return View();
        }
        [Authorize(Roles = Roles.Role_Admin)]
        [HttpPost]
        public IActionResult Create(School school) 
        {
            if (!ModelState.IsValid)
                return View();
            else
            {
                _context.Schools.Add(school);
                _context.SaveChanges();
                TempData["success"] = "School added successfully";
                return RedirectToAction("Index");
            }
        }
        [Authorize(Roles = Roles.Role_Admin)]
        public IActionResult Edit(int? id)
        {
            if (id == null||id==0)
                return NotFound();
            var schoolInDb=_context.Schools.FirstOrDefault(n=>n.Id==id);
            if (schoolInDb==null)
                return NotFound();
            return View(schoolInDb);
        }
        [Authorize(Roles = Roles.Role_Admin)]
        [HttpPost]
        public IActionResult Edit(School school)
        {
           if (!ModelState.IsValid)
                return View();
           else
            {
                _context.Schools.Update(school);
                _context.SaveChanges();
                TempData["success"] = "School Updated successfully";
                return RedirectToAction("Index");
            }
        }
        [Authorize(Roles = Roles.Role_Admin)]
        public IActionResult Delete(int? id)
        {
            if (id==null||id==0)
                return NotFound();
            var schoolInDb=_context.Schools.FirstOrDefault(n=>n.Id == id);
            if (schoolInDb==null)
                return NotFound();
            return View(schoolInDb);
        }
        [Authorize(Roles = Roles.Role_Admin)]
        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeletePost(int id)
        {
            var schoolInDb = _context.Schools.FirstOrDefault(n => n.Id == id);
            if (schoolInDb == null)
                return NotFound();
            else
            {
                _context.Schools.Remove(schoolInDb);
                _context.SaveChanges();
                TempData["success"] = "School Deleted successfully";
                return RedirectToAction("Index");
            }
        }
    }

}
