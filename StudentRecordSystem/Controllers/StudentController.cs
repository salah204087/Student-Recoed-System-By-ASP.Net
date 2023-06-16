using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudentRecordSystem.Data;
using StudentRecordSystem.Models;
using StudentRecordSystem.Models.ViewModel;
using System.Data;

namespace StudentRecordSystem.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _context;
        public StudentController(ApplicationDbContext context)
        {
            _context = context;

        }
        [Authorize(Roles = Roles.Role_Admin)]
        public IActionResult Index()
        {
            var students=_context.Students.Include(n=>n.University).Include(n=>n.Faculty).Include(n=>n.School);
            if (students==null)
                return NotFound();
            return View(students);
        }
        [Authorize(Roles = Roles.Role_Admin)]
        public IActionResult Create()
        {
            StudentVM studentVM = new()
                {
                    UniversityList = _context.Universities
                    .Select(n => new SelectListItem { Text = n.Name, Value = n.Id.ToString() }),
                    FacultyList = _context.Faculties
                    .Select(n => new SelectListItem { Text = n.Name, Value = n.Id.ToString() }),
                    SchoolList = _context.Schools
                    .Select(n => new SelectListItem { Text = n.Name, Value = n.Id.ToString() }),
                    Student = new Student()
                };
                return View(studentVM);
            
            
        }
        [Authorize(Roles = Roles.Role_Admin)]
        [HttpPost]
        public IActionResult Create(StudentVM studentVM)
        {
            if (!ModelState.IsValid)
            {
                studentVM.UniversityList = _context.Universities.Select(n => new SelectListItem
                {
                    Text = n.Name,
                    Value=n.Id.ToString(),
                });
                studentVM.FacultyList = _context.Faculties.Select(n => new SelectListItem
                {
                    Text=n.Name,
                    Value=n.Id.ToString(),
                });
                studentVM.SchoolList = _context.Schools.Select(n => new SelectListItem
                {
                    Text=n.Name,
                    Value=n.Id.ToString(),
                });
                return View(studentVM);
            }
            else
            {
                _context.Students.Add(studentVM.Student);
                _context.SaveChanges();
                TempData["success"] = "Student added successfully";
                return RedirectToAction("Index");
            }
        }
        [Authorize(Roles = Roles.Role_Admin)]
        public IActionResult Edit(int? id)
        {
            StudentVM studentVM = new()
            {
                UniversityList = _context.Universities.Select(n => new SelectListItem { Text = n.Name, Value = n.Id.ToString() }),
                FacultyList = _context.Faculties.Select(n => new SelectListItem { Text = n.Name, Value = n.Id.ToString() }),
                SchoolList = _context.Schools.Select(n => new SelectListItem { Text = n.Name, Value = n.Id.ToString() }),
                Student = new Student()
            };
            if (id == null || id == 0)
                return View(studentVM);
             studentVM.Student = _context.Students.FirstOrDefault(x => x.Id == id);
            if (studentVM.Student == null)
                return NotFound();
            return View(studentVM);
        }
        [Authorize(Roles = Roles.Role_Admin)]
        [HttpPost]
        public IActionResult Edit(int? id, StudentVM studentVM)
        {
            if (!ModelState.IsValid)
            {
                // Model validation failed, return the view with the updated studentVM
                // and populate the select lists
                studentVM.UniversityList = _context.Universities.Select(n => new SelectListItem
                {
                    Text = n.Name,
                    Value = n.Id.ToString(),
                });
                studentVM.FacultyList = _context.Faculties.Select(n => new SelectListItem
                {
                    Text = n.Name,
                    Value = n.Id.ToString(),
                });
                studentVM.SchoolList = _context.Schools.Select(n => new SelectListItem
                {
                    Text = n.Name,
                    Value = n.Id.ToString(),
                });
                return View(studentVM);
            }
            else
            {
                // Model validation succeeded, update the existing student
                var existingStudent = _context.Students.FirstOrDefault(x => x.Id == id);
                if (existingStudent == null)
                    return NotFound();

                existingStudent.Name = studentVM.Student.Name;
                existingStudent.Age = studentVM.Student.Age;
                existingStudent.Email = studentVM.Student.Email;
                existingStudent.PhoneNumber = studentVM.Student.PhoneNumber;
                existingStudent.Gender = studentVM.Student.Gender;
                existingStudent.EducationType = studentVM.Student.EducationType;
                existingStudent.UniversityId = studentVM.Student.UniversityId;
                existingStudent.FacultyId = studentVM.Student.FacultyId;
                existingStudent.SchoolId = studentVM.Student.SchoolId;
                existingStudent.BirthDate = studentVM.Student.BirthDate;
                existingStudent.Address = studentVM.Student.Address;
                existingStudent.City = studentVM.Student.City;
                existingStudent.PostalCode = studentVM.Student.PostalCode;

                _context.SaveChanges();
                TempData["success"] = "Student updated successfully";
                return RedirectToAction("Index");
            }
        }
        [Authorize(Roles = Roles.Role_Admin)]
        public IActionResult Delete(int? id)
        {
            StudentVM studentVM = new()
            {
                UniversityList = _context.Universities.Select(n => new SelectListItem { Text = n.Name, Value = n.Id.ToString() }),
                FacultyList = _context.Faculties.Select(n => new SelectListItem { Text = n.Name, Value = n.Id.ToString() }),
                SchoolList = _context.Schools.Select(n => new SelectListItem { Text = n.Name, Value = n.Id.ToString() }),
                Student = new Student()
            };
            if (id== null||id==0)
                return NotFound();
            studentVM.Student=_context.Students.FirstOrDefault(x => x.Id==id);
            if (studentVM.Student == null)
                return NotFound();
            return View(studentVM);
        }
        [Authorize(Roles = Roles.Role_Admin)]
        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeletePost(int id) 
        {
            StudentVM studentVM = new()
            {
                UniversityList = _context.Universities.Select(n => new SelectListItem { Text = n.Name, Value = n.Id.ToString() }),
                FacultyList = _context.Faculties.Select(n => new SelectListItem { Text = n.Name, Value = n.Id.ToString() }),
                SchoolList = _context.Schools.Select(n => new SelectListItem { Text = n.Name, Value = n.Id.ToString() }),
                Student = new Student()
            };
            studentVM.Student=_context.Students.FirstOrDefault(n=>n.Id==id);
            if (studentVM.Student == null)
                return NotFound();
            else
            {
                _context.Students.Remove(studentVM.Student);
                _context.SaveChanges();
                TempData["success"] = "Student deleted successfully";
                return RedirectToAction("Index");
            }
        }

    }
}
