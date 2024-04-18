using Microsoft.AspNetCore.Mvc;
using WebAppProject.Data;
using WebAppProject.Models;

namespace WebAppProject.Controllers
{
    public class ProfileController : Controller
    {
        private readonly ApplicationDBContext _db;
        public ProfileController(ApplicationDBContext db) { _db = db; }

        public IActionResult Index(string email = "ping@gmail")
        {
            if (email == null)
            {
                return BadRequest();
            }
            var obj = _db.UsersData.Find(email);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        public IActionResult Edit(string Email="Gay@g")
        {
            
            if(Email==null)
            {
                return BadRequest();
            }
            var obj = _db.UsersData.Find(Email);
            if(obj==null)
            {
                return NotFound();
            }
            return View(obj);
            
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(UserData obj)
        {
            //if (ModelState.IsValid)
            //{
            //    _db.UsersData.Update(obj);
            //    _db.SaveChanges();
            //    return RedirectToAction("Index", "Party");
            //}
            //return BadRequest();
            _db.UsersData.Update(obj);
            _db.SaveChanges();
            return RedirectToAction("Index", "Party");
        }
    }
}
