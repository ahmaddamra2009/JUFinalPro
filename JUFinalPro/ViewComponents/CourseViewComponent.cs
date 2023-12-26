using JUFinalPro.Data;
using Microsoft.AspNetCore.Mvc;

namespace JUFinalPro.ViewComponents
{
    public class CourseViewComponent : ViewComponent
    {
        private ApplicationDbContext db;

        public CourseViewComponent(ApplicationDbContext _db)
        {
            db = _db;
        }

        public IViewComponentResult Invoke()
        {
            var data = db.Courses.
                OrderByDescending(x=>x.CourseId).
                Take(6);
            return View(data);
        }
    }
}
