using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyBlog.Controllers
{
    public class NewPageController : Controller
    {
        // GET: NewPage
        public ActionResult Index()
        {
            return View();
        }

        // GET: NewPage/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: NewPage/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NewPage/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: NewPage/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: NewPage/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: NewPage/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NewPage/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
