using HealthManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;
using System.Configuration;
using HealthManagementSystem;


namespace HealthManagementSystem.Controllers
{

    public class AccountController : Controller
    {
        HealthcareDBEntities db = new HealthcareDBEntities();

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string Username, string Password)
        {
            var user = db.Users.FirstOrDefault(u => u.Username == Username && u.Password == Password);
            if (user != null)
            {
                Session["UserID"] = user.UserID;
                Session["Username"] = user.Username;
                return RedirectToAction("Index");
            }


            ViewBag.Error = "Invalid Username or Password";
            return View();
        }
        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Login");
        }

        public ActionResult Index(string searchQuery)
        {
            var patients = db.Patients.AsQueryable();
            if (!string.IsNullOrEmpty(searchQuery))
            {
                patients = patients.Where
                    (p => p.FullName.ToLower().Contains(searchQuery.ToLower()) || p.Address.ToLower().Contains(searchQuery.ToLower()));

            }
            return View(patients.ToList());


        }
        public ActionResult Details(int id)
        {
            var patient = db.Patients.Find(id);
            if(patient == null)
            {
                return HttpNotFound();
            }
            return View(patient);

        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Patient patient)
        {
            if (ModelState.IsValid)
            {
                db.Patients.Add(patient);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(patient);
        }

        // GET: Account/Edit/5
        [HttpGet]
public ActionResult Edit(int id)
{
    var patient = db.Patients.Find(id);
    if (patient == null)
    {
        return HttpNotFound();
    }
    return View(patient);
}

// POST: Account/Edit/5
[HttpPost] [ValidateAntiForgeryToken]
public ActionResult Edit(Patient patient)
{
    if (ModelState.IsValid)
    {
        db.Entry(patient).State = System.Data.Entity.EntityState.Modified;
        db.SaveChanges();
        TempData["Message"] = "Patient details updated successfully!";
        return RedirectToAction("Index");
    }
    return View(patient);
}
       
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var patient = db.Patients.Find(id);
            if (patient == null)
            {
                return HttpNotFound();
            }
            return View(patient);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var patient = db.Patients.Find(id);
            db.Patients.Remove(patient);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
