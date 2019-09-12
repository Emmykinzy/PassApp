using PassApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PassApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            DBManager db = new DBManager();
            var records = db.GetAll();

            return View(records);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(PassWord p)
        {
            DBManager db = new DBManager();
            db.Add(p);

            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            DBManager db = new DBManager();
            var currRecord = db.Details(id);

            return View(currRecord);
        }

        public ActionResult Delete(int id)
        {
            DBManager db = new DBManager();
            db.Delete(id);

            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            DBManager db = new DBManager();
            var record = db.Details(id);

            return View(record);
        }

        [HttpPost]
        public ActionResult Edit(PassWord p)
        {
            DBManager db = new DBManager();
            db.Update(p);

            return RedirectToAction("Index");
        }




    }
}