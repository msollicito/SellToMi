using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using SellToMi.Models;

namespace SellToMi.Controllers
{
    public class SubCategoriesController : Controller
    {
        //
        // GET: /SubCategories/
        private DB_77381_txttoadEntities db = new DB_77381_txttoadEntities();

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /SubCategories/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /SubCategories/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /SubCategories/Create

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

        //
        // GET: /SubCategories/Edit/5

       
        public ActionResult GetSubcategories(int id)
        {
            IEnumerable<SellToMi.Models.GetSubCategories_Result> subcats = db.GetSubCategories(id);
            if (subcats.Count() == 0)
            {
                return HttpNotFound();
            }
            return View(subcats);
        }
        //
        // POST: /SubCategories/Edit/5

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

        //
        // GET: /SubCategories/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /SubCategories/Delete/5

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
