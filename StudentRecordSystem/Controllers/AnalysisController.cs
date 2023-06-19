using Microsoft.AspNetCore.Mvc;
using StudentRecordSystem.Data;

namespace StudentRecordSystem.Controllers
{
    public class AnalysisController : Controller
    {
        private readonly ApplicationDbContext _context;
        public AnalysisController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var Analysis = new object[4];
            Analysis[0] = _context.Students.Count();
            Analysis[1]=_context.Universities.Count();
            Analysis[2]=_context.Faculties.Count();
            Analysis[3] = _context.Schools.Count();
            return View(Analysis);
        }
    }
}
