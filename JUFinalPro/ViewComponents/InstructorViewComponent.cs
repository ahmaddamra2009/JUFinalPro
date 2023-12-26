using JUFinalPro.Data;
using Microsoft.AspNetCore.Mvc;

namespace JUFinalPro.ViewComponents
{
    public class InstructorViewComponent:ViewComponent
    {
        private ApplicationDbContext _context;

        public InstructorViewComponent(ApplicationDbContext _db)
        {
            _context = _db;
        }

        public IViewComponentResult Invoke()
        {
            var data = _context.Instructors.
                OrderByDescending(x => x.InstructorId).
                Take(10);
            return View(data);
        }
    }
}
