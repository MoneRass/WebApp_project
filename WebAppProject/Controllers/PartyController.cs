using Microsoft.AspNetCore.Mvc;
using WebAppProject.Data;
using WebAppProject.Models;

namespace WebAppProject.Controllers
{
    public class PartyController : Controller
    {
        private readonly ApplicationDBContext _db;
        public PartyController(ApplicationDBContext db) {  _db = db; }
        public IActionResult Index()
        {
            /*Party p1 = new Party();
            p1.Name = "First Drink";
            p1.location = "Room A";
            p1.Time = DateTime.;
            p1.Description = "Welcome to NulNul";
            p1.img = "https://engineer.kmitl.ac.th/wp-content/uploads/2022/07/1-4-1024x859.jpg";

            var p2 = new Party();
            p2.Name = "First Drink";
            p2.location = "Room B";
            p2.Time = DateTime.Now;
            p2.Description = "Welcome to NulNul";
            p2.img = "https://engineer.kmitl.ac.th/wp-content/uploads/2022/07/1-4-1024x859.jpg";

            Party p3 = new();
            p3.Name = "First Drink";
            p3.location = "Room C";
            p3.Time = DateTime.Now;
            p3.Description = "Welcome to NulNul";
            p3.img = "https://engineer.kmitl.ac.th/wp-content/uploads/2022/07/1-4-1024x859.jpg";

            List<Party> allParty = new List<Party>();
            allParty.Add(p1);
            allParty.Add(p2);
            allParty.Add(p3);*/
            IEnumerable<Party> allParty = _db.Partys;

            return View(allParty);
        }
        // GET Method
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Party obj)
        {
            if (ModelState.IsValid)
            {
                _db.Partys.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        public IActionResult Edit()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Party obj)
        {
            if (ModelState.IsValid)
            {
                _db.Partys.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
    }
}
