using Microsoft.AspNetCore.Mvc;
using WebAppProject.Data;
using WebAppProject.Models;

namespace WebAppProject.Controllers
{
    public class LoginController : Controller
    {
        private readonly ApplicationDBContext _db;
        public LoginController(ApplicationDBContext db) { _db = db; }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SignUp(UserData obj)
        {
            IEnumerable<UserData> allUser = _db.UsersData;
            foreach (var user in allUser)
            {
                if (obj.Email == user.Email && obj.Password == user.Password)
                {
                    return RedirectToAction("Index", "Party");
                }
                ViewBag.Notification = "Wrong";
                return RedirectToAction("Index");
            }
            if (ModelState.IsValid)
            {
                _db.UsersData.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index","Party");
            }
            return View(obj);
        }
    }
}
